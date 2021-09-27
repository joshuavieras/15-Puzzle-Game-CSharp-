using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Puzzle_Game
{
    class TableController
    {
        public readonly Tablero table;

        public enum Moves{ MOVE_UP = 1, MOVE_DOWN = 2, MOVE_LEFT = 3, MOVE_RIGHT = 4, END_GAME = 5, UNDEFINED = 0};

        public TableController(Tablero table)
        {
            this.table = table;
        }

        public int CheckIfValidMove(Moves move)
        {
            int[] pos = table.RetornarPosVacio();
            int i = pos[0], j = pos[1];

            switch (move)
            {
                case Moves.MOVE_UP:

                    i--;
                    if (i < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case Moves.MOVE_DOWN:
                    i++;
                    if (i >= table.Row_Count)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case Moves.MOVE_LEFT:
                    j--;
                    if (j < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case Moves.MOVE_RIGHT:
                    j++;
                    if (j >= table.Col_Count)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case Moves.END_GAME:
                    return -100;
                case Moves.UNDEFINED:
                    return -69;
                default:
                    return 69;
            }
        }

        public void DoTheMove(Moves move)
        {
            switch (move)
            {

                case Moves.MOVE_UP:
                    {
                        int[] pos = table.RetornarPosVacio();
                        int i = pos[0], j = pos[1];

                        table.Swap(i, j, move);
                        break;
                    }
                case Moves.MOVE_DOWN:
                    {
                        int[] pos = table.RetornarPosVacio();
                        int i = pos[0], j = pos[1];

                        table.Swap(i, j, move);
                        break;
                    }
                case Moves.MOVE_LEFT:
                    {
                        int[] pos = table.RetornarPosVacio();
                        int i = pos[0], j = pos[1];

                        table.Swap(i, j, move);
                    }
                    break;

                case Moves.MOVE_RIGHT:
                    {
                        int[] pos = table.RetornarPosVacio();
                        int i = pos[0], j = pos[1];

                        table.Swap(i, j, move);
                        break;
                    }
                case Moves.END_GAME:

                    break;
                default:

                    break;
            }
        }

        public bool CheckIfWon()
        {
            int contador = 1;
            for (int i = 0; i < table.Row_Count; i++)
            {
                for (int j = 0; j < table.Col_Count; j++)
                {
                    if (table.Compare(i, j, contador))
                    {
                        contador++;

                        if (contador == 15 && table.Compare(i, j, 0))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        ~TableController()
        {

        }
    }
}
