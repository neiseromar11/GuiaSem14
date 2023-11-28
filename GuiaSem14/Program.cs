using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaSem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.MenuPrincipal();
            do
            {
                //omar estuvo aqui
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.Vacunacion();
                        break;
                    case 2:
                        opcion = Pantallas.DatosEncuesta();
                        break;
                    case 3:
                        opcion = Pantallas.Resultados();
                        break;
                    case 4:
                        opcion = Pantallas.Buscador();
                        break;
                    case 0:
                    default:
                        opcion = Pantallas.MenuPrincipal();
                        break;
                }
            } while (opcion != 5);
            Console.ReadLine();
        }
    }
}
