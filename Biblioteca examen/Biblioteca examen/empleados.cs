using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_examen
{
    class empleados : Persona
    {
        
        int ventas;


        public empleados(string nombre, string apellido, int dni, int ventas) : base(nombre, apellido, dni)
        {
            this.ventas = ventas;
        }



        public static bool operator +(empleados[] Empleado, empleados Empleados)
        {

            //recorro buscando libres
            for (int i = 0; i < Empleado.Length; i++)
            {
                if (Empleado[i] == null)
                {
                    Empleado[i] = Empleados;
                    return true;
                }
            }

            //si no encontre libres agrego un lugar
            Array.Resize<empleados>(ref Empleado, Empleado.Length + 1);

            Empleado[Empleado.Length - 1] = Empleados;
            return true;

        }




    }
}
