using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Puzzle_Game
{
    public partial class Form1 : Form
    {
        private readonly TableController TC;

        private bool cero_pressed;

        private int num_moves;

        private void ChangeStateExcept(int k, int l, int mode = 1)
        {
            if (mode == 1)
            {
                for (int i = 0; i < TC.getRows(); i++)
                {
                    for (int j = 0; j < TC.getCols(); j++)
                    {
                        if (i != k || j != l)
                        {
                            this.tableLayoutPanel1.GetControlFromPosition(i, j).Enabled = false;
                        }
                    }
                }
            }
            else if (mode == 404)
            {
                for (int i = 0; i < TC.getRows(); i++)
                {
                    for (int j = 0; j < TC.getCols(); j++)
                    {
                        this.tableLayoutPanel1.GetControlFromPosition(i, j).Enabled = true;   
                    }
                }
            }
            else
            {
                for (int i = 0; i < TC.getRows(); i++)
                {
                    for (int j = 0; j < TC.getCols(); j++)
                    {
                        if (i != k || j != l)
                        {
                            this.tableLayoutPanel1.GetControlFromPosition(i, j).Enabled = true;
                        }
                    }
                }
            }
        }

        private void UnlockValidMoves(int i, int j)
        {
            if (TC.CheckIfValidMove(TableController.Moves.MOVE_UP) == 1)
            {
                this.tableLayoutPanel1.GetControlFromPosition(i - 1, j).Enabled = true;
            }

            if (TC.CheckIfValidMove(TableController.Moves.MOVE_DOWN) == 1)
            {
                this.tableLayoutPanel1.GetControlFromPosition(i + 1, j).Enabled = true;
            }

            if (TC.CheckIfValidMove(TableController.Moves.MOVE_LEFT) == 1)
            {
                this.tableLayoutPanel1.GetControlFromPosition(i, j - 1).Enabled = true;
            }

            if (TC.CheckIfValidMove(TableController.Moves.MOVE_RIGHT) == 1)
            {
                this.tableLayoutPanel1.GetControlFromPosition(i, j + 1).Enabled = true;
            }
        }

        private TableController.Moves ReturnMoveMade(int i, int j)
        {
            int[] pos = TC.PosZero();

            int i0 = pos[0], j0 = pos[1];

            if (i0 == i)
            {
                if (j0 + 1 == j)
                {
                    return TableController.Moves.MOVE_RIGHT;
                }

                if (j0 - 1 == j)
                {
                    return TableController.Moves.MOVE_LEFT;
                }
            }
            else if (j0 == j)
            {
                if (i + 1 == i)
                {
                    return TableController.Moves.MOVE_UP;
                }

                if (i - 1 == i)
                {
                    return TableController.Moves.MOVE_DOWN;
                }
            }
            else
            {
                return TableController.Moves.UNDEFINED;
            }

            return TableController.Moves.UNDEFINED;
        }
        
        private void UpdateTable()
        {
            for (int i = 0; i < TC.getRows(); i++)
            {
                for (int j = 0; j < TC.getCols(); j++)
                {
                    this.tableLayoutPanel1.GetControlFromPosition(i, j).Text = "" + TC.ObtenerValor(i, j);
                    // this.tableLayoutPanel1.GetChildAtPoint(new Point(i, j)).Text= "" + TC.ObtenerValor(i,j);
                }
            }
        }

        public Form1()
        {
            TC = new TableController(new Tablero(4,4)); 

            cero_pressed = false;

            num_moves = 0;

            InitializeComponent();

            this.label3.Text = "" + num_moves;

            for (int i = 0; i < TC.getRows(); i++) 
            {
                for (int j = 0; j < TC.getCols(); j++) 
                {
                    this.tableLayoutPanel1.GetControlFromPosition(i, j).Text = "" +TC.ObtenerValor(i, j);
                    // this.tableLayoutPanel1.GetChildAtPoint(new Point(i, j)).Text= "" + TC.ObtenerValor(i,j);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click (object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(0, 0);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(0, 0, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(0, 1);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(0, 1, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button3.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(0, 2);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(0, 2, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(0, 3);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(0, 3, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button5.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(1, 0);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(1, 0, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.button6.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(1, 1);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(1, 1, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.button7.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(1, 2);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(1, 2, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.button8.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(1, 3);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(1, 3, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.button9.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(2, 0);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(2, 0, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.button10.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(2, 1);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(2, 1, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.button11.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(2, 2);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(2, 2, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.button12.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(2, 3);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(2, 3, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (this.button13.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(3, 0);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(3, 0, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (this.button14.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(3, 1);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(3, 1, 0);

                    cero_pressed = false;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (this.button15.Text == "0")
            {
                if (!cero_pressed)
                {
                    ChangeStateExcept(3, 2);

                    cero_pressed = true;
                }
                else
                {
                    ChangeStateExcept(3, 2, 0);

                    cero_pressed = false;
                }
            }
            else
            {
                // Do the move
                if (cero_pressed)
                {
                    ChangeStateExcept(69, 69, 404);

                    //Aqui está el bug, técnicamente si retorna bien el movimiento que se quiere hacer pero no lo hace bien
                    TableController.Moves move = ReturnMoveMade(3, 2);

                    this.label3.Text = "" + move;

                    TC.DoTheMove(move);

                    UpdateTable();

                    cero_pressed = false;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (this.button16.Text == "0")
            {
                if (!cero_pressed)
                {
                    // Deshabilita todos los botones que no sean cero
                    ChangeStateExcept(3, 3);

                    cero_pressed = true;

                    UnlockValidMoves(3, 3);
                }
                else
                {
                    // Habilita todos los botones que no sean cero
                    ChangeStateExcept(3, 3, 0);

                    cero_pressed = false;
                }
            }
            else
            {
                // Do the move
                if (cero_pressed)
                {

                }
            }
        }
    }
}
