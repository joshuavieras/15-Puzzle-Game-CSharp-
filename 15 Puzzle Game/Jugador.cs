using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Puzzle_Game
{
    class Jugador
    {
        private string nombre;
        private int partidasJugadas;

        public Jugador()
        {
            this.nombre = "";
            this.partidasJugadas = 0;
        }

        public Jugador(string nombre, int partidasJugadas = 0)
        {
            this.nombre = nombre;
            this.partidasJugadas = partidasJugadas;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int PartidasJugadas
        {
            get
            {
                return partidasJugadas;
            }
            set
            {
                partidasJugadas = value;
            }
        }
    }
}
