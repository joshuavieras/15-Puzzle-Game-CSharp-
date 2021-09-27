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
        private TableController TC;

        public Form1()
        {

            TC = new TableController(new Tablero(4,4));

            InitializeComponent();

            for (int i=0;i<4;i++)
            {
                for (int j=0;j<4;j++)
                {
                    this.tableLayoutPanel1.GetControlFromPosition(i, j).Text = "" +TC.ObtenerValor(i, j);
                    // this.tableLayoutPanel1.GetChildAtPoint(new Point(i, j)).Text= "" + TC.ObtenerValor(i,j);
                }
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
