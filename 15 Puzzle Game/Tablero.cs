using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Puzzle_Game
{
    class Tablero
    {
        private int col_count;
        private int row_count;
        private int[,] table;
        
        private readonly Random _random;

        public Tablero(int col, int row)
        {
            _random = new Random();

            this.col_count = col;
            this.row_count = row;

            table = new int[this.col_count, this.row_count];

            for (int i = 0; i < row_count; i++)
            {
                for (int j = 0; j < col_count; j++)
                {
                    table[i, j] = 0;
                }
            }
            FillTable();
        }

        public int Col_Count
        {
            get
            {
                return col_count;
            }

            set { ; }
        }

        public int Row_Count
        {
            get
            {
                return row_count;
            }

            set {; }
        }

        private int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public void FillTable()
        {
            int numRand = 0, contador = 0;

            for (int i = 0; i < row_count; i++)
            {
                for (int j = 0; j < col_count; j++)
                {
                    numRand = RandomNumber(1, (row_count * col_count));

                    while (VerifiyNumber(numRand))
                    {
                        numRand = RandomNumber(1, (row_count * col_count));
                    }

                    table[i, j] = numRand;
                    contador++;

                    if (contador == 15)
                    {
                        return;
                    }
                }
            }
        }

        /*
         True if already on table;
         False if not
        */
        private bool VerifiyNumber(int number)
        {
            for (int i = 0; i < row_count; i++)
            {
                for (int j = 0; j < col_count; j++)
                {
                    if (table[i, j] == number)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public int[] RetornarPosVacio()
        {
            int[] pos = new int[2];

            for (int i = 0; i < row_count; i++)
            {
                for (int j = 0; j < col_count; j++)
                {
                    if (table[i, j] == 0)
                    {
                        pos[0] = i;
                        pos[1] = j;
                        return pos;
                    }
                }
            }

            pos[0] = -1;
            pos[1] = -1;

            return pos;
        }

        public void Swap(int i, int j, TableController.Moves move)
        {
            switch (move)
            {
                case TableController.Moves.MOVE_UP:
                    {
                        int aux = 0;
                        aux = table[i - 1, j];
                        table[i - 1, j] = table[i, j];
                        table[i, j] = aux;
                        break;
                    }
                case TableController.Moves.MOVE_DOWN:
                    {
                        int aux = 0;
                        aux = table[i + 1, j];
                        table[i + 1, j] = table[i, j];
                        table[i, j] = aux;
                        break;
                    }
                   
                case TableController.Moves.MOVE_LEFT:
                    {
                        int aux = 0;
                        aux = table[i, j - 1];
                        table[i, j - 1] = table[i, j];
                        table[i, j] = aux;
                        break;
                    }
                    
                case TableController.Moves.MOVE_RIGHT:
                    {
                        int aux = 0;
                        aux = table[i, j + 1];
                        table[i, j + 1] = table[i, j];
                        table[i, j] = aux;
                    }
                    
                    break;
                default:
                    break;
            }
            
        }

        public bool Compare(int i, int j, int number)
        {
            if(table[i, j] == number)
            {
                return true;
            }

            return false;
        }
        
        public int GetValue(int i, int j)
        {
            return table[i, j];
        }
        ~Tablero()
        {

        }
    }
}
