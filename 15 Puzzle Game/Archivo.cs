using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _15_Puzzle_Game
{
    class Archivo
    {
        public static bool GuardarJuego(Jugador jugador, int numero_movimientos, bool resultado)
        {
            string path = @"Archivos\Resultados.txt";

            try
            {
                if (File.Exists(path))
                {
                    using StreamWriter sw = new StreamWriter(path);

                    sw.WriteLine(numero_movimientos);

                    if (resultado)
                    {
                        sw.WriteLine("ganador");
                    }
                    else
                    {
                        sw.WriteLine("perdedor");
                    }

                    return GuardarJuegador(jugador, sw);
                }
                else
                {
                    using StreamWriter sw = File.CreateText(path);

                    sw.WriteLine(numero_movimientos);

                    if (resultado)
                    {
                        sw.WriteLine("ganador");
                    }
                    else
                    {
                        sw.WriteLine("perdedor");
                    }

                    return GuardarJuegador(jugador, sw);
                }
            }
            catch (Exception)
            {
                return false;
            }

            
        }

        public static bool GuardarJuegador(Jugador jugador, StreamWriter sw)
        {
            sw.WriteLine(jugador.Nombre);

            sw.WriteLine(jugador.PartidasJugadas);

            sw.Close();

            return true;
        }
        
        public static string CargarRegistros()
        {
            string registros = "";

            string path = @"Archivos\Resultados.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                int i = 0, j = 1;
                while ((s = sr.ReadLine()) != null)
                {
                    switch (i)
                    {
                        case 0:
                            registros += "Registro N" + j + "\n";
                            registros += "El numero de movimiento fueron " + s + "\n";
                            i++;
                            break;
                        case 1:
                            registros += "El resultado del juego fue " + s + "\n";
                            i++;
                            break;
                        case 2:
                            registros += "El nombre del jugador es " + s + "\n";
                            i++;
                            break;
                        case 3:
                            registros += "El total de juegos del jugador es " + s + "\n\n";
                            i = 0;
                            j++;
                            break;
                        default:
                            break;
                    }
                }
            }

            return registros;
        }
    }
}
