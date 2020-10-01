using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_examen
{
    class validaciones
    {





        public static int ValidarEntero(int opcionMin, int opcionMax)
        {
            int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < opcionMin || opcion > opcionMax)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error,reingrese opcion valida.\nIngrese una opcion entre {0} y {1}", opcionMin, opcionMax);
            }
            Console.ResetColor();

            return opcion;

        }

        public static string ValidarSoN(string auxDatoIngresado)
        {
            while (string.IsNullOrEmpty(auxDatoIngresado) || (auxDatoIngresado.ToLower().Trim() != "a" && auxDatoIngresado.ToLower().Trim() != "p"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error,reingrese opcion valida.\nIngrese una opcion entre A o P");
                auxDatoIngresado = Console.ReadLine();
            }
            Console.ResetColor();

            return auxDatoIngresado;

        }



    }
}
