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

                    j--;
                    if (j < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case Moves.MOVE_DOWN:
                    j++;
                    if (j >= table.Row_Count)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case Moves.MOVE_LEFT:
                    i--;
                    if (i < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case Moves.MOVE_RIGHT:
                    i++;
                    if (i >= table.Col_Count)
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
            if(move!=Moves.UNDEFINED || move != Moves.END_GAME)
            {
                table.Swap(move);
            }
        }

        public Jugador DefinirJugador(string nombreJugador)
        {
            Jugador nuevo=new Jugador(nombreJugador);

            return nuevo;
        }

        public bool CheckIfWon()
        {
            int contador = 1;
            for (int i = 0; i < table.Row_Count; i++)
            {
                for (int j = 0; j < table.Col_Count; j++)
                {
                    if (table.Compare(j, i, contador))
                    {
                        contador++;
                        if (contador == 16)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
            
        }

        public int ObtenerValor(int i, int j)
        {
            return table.GetValue(i, j);
        }
        
        public int getCols()
        {
            return table.Col_Count;
        }

        public int getRows()
        {
            return table.Row_Count;
        }

        public int[] PosZero()
        {
            return table.RetornarPosVacio();
        }

        ~TableController()
        {

        }
    }
}
