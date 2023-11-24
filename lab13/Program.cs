using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = pantalla.MenuPrincipal();

            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = pantalla.RealizarEncuesta();
                        break;
                    case 2:
                        opcion = pantalla.DatosInscritos();
                        break;
                    case 3:
                        opcion = pantalla.Eliminar();
                        break;
                    case 4:
                        opcion = pantalla.Ordenar();
                        break;
                    case 0:
                    default:
                        opcion = pantalla.MenuPrincipal();
                        break;
                }
            } while (opcion != 5);
        }
    }
}
