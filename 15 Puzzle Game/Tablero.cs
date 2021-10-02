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
            ProbarGane();
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

        public void Swap(TableController.Moves move)
        {
            int[] pos = RetornarPosVacio();
            int i = pos[0], j = pos[1];

            switch (move)
            {
                case TableController.Moves.MOVE_LEFT: //LEFT | UP
                    {
                        int aux;
                        aux = table[i - 1, j];
                        table[i - 1, j] = table[i, j];
                        table[i, j] = aux;
                        break;
                    }
                case TableController.Moves.MOVE_RIGHT://RIGHT | DOWN
                    {
                        int aux = 0;
                        aux = table[i + 1, j];
                        table[i + 1, j] = table[i, j];
                        table[i, j] = aux;
                        break;
                    }

                case TableController.Moves.MOVE_UP://UP | LEFT
                    {
                        int aux = 0;
                        aux = table[i, j - 1];
                        table[i, j - 1] = table[i, j];
                        table[i, j] = aux;
                        break;
                    }

                case TableController.Moves.MOVE_DOWN://DOWN | RIGHT
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

        public void ProbarGane()
        {
            table[0, 0] = 1;
            table[1, 0] = 2;
            table[2, 0] = 3;
            table[3, 0] = 4;

            table[0, 1] = 5;
            table[1, 1] = 6;
            table[2, 1] = 7;
            table[3, 1] = 8;

            table[0, 2] = 9;
            table[1, 2] = 10;
            table[2, 2] = 11;
            table[3, 2] = 12;

            table[0, 3] = 13;
            table[1, 3] = 14;
            table[2, 3] = 0;
            table[3, 3] = 15;
        }
        ~Tablero()
        {

        }
    }
}
