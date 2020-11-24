using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_examen
{
  public static class Extenciones
    {
        public static bool EsPar(this int i)
        {
            if (i % 2 == 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public static double Dobletea(this double d)
        {
            return d * 2.0;
        }
    }
}
