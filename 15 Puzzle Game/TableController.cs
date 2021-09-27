using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Puzzle_Game
{
    class TableController
    {
        Tablero table;

        enum Moves{ MOVE_UP = 1, MOVE_DOWN = 2, MOVE_LEFT = 3, MOVE_RIGHT = 4, END_GAME = 5, UNDEFINED = 0};

        public TableController(Tablero table)
        {
            this.table = table;
        }

        

        public bool CheckIfValidMove(Moves)
        {
            int[] pos = table.RetornarPosVacio();
            int i = pos[0], j = pos[1];

            switch (move)
            {
                case MOVE_UP:
                    i--;
                    if (i < 0)
                    {
                        return fak;
                    }
                    else
                    {
                        return 1;
                    }
                    break;
                case MOVE_DOWN:
                    i++;
                    if (i >= table.row_count)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                    break;
                case MOVE_LEFT:
                    j--;
                    if (j < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                    break;
                case MOVE_RIGHT:
                    j++;
                    if (j >= table.col_count)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1true;
                    }
                    break;
                case END_GAME:
                    return -100;
                default:
                    return 0;
                    break;
            }

            return -1;
        }

        public void DoTheMove(MOVES move)
        {
            switch (move)
            {

                case MOVE_UP:
                    {
                        int i = retornarIDeVacio(), j = retornarJDeVacio();
                        int tmp = 0;
                        tmp = table.tablero[i - 1][j];
                        table.tablero[i - 1][j] = table.tablero[i][j];
                        table.tablero[i][j] = tmp;
                        break;
                    }
                case MOVE_DOWN:
                    {
                        int i = retornarIDeVacio(), j = retornarJDeVacio();
                        int tmp = 0;
                        tmp = table.tablero[i + 1][j];
                        table.tablero[i + 1][j] = table.tablero[i][j];
                        table.tablero[i][j] = tmp;
                        break;
                    }
                case MOVE_LEFT:
                    {
                        int i = retornarIDeVacio(), j = retornarJDeVacio();
                        int tmp = 0;
                        tmp = table.tablero[i][j - 1];
                        table.tablero[i][j - 1] = table.tablero[i][j];
                        table.tablero[i][j] = tmp;
                    }
                    break;

                case MOVE_RIGHT:
                    {
                        int i = retornarIDeVacio(), j = retornarJDeVacio();
                        int tmp = 0;
                        tmp = table.tablero[i][j + 1];
                        table.tablero[i][j + 1] = table.tablero[i][j];
                        table.tablero[i][j] = tmp;
                        break;
                    }
                case END_GAME:

                    break;
                default:

                    break;
            }
        }

        public int CheckIfWon()
        {
            return 1;
        }

            ~TableController()
        {

        }
    }
}
