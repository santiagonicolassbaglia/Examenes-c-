using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_examen
{
   public  class empleados : Persona
    {
        
        int ventas;

        public int Ventas { get => ventas; set => ventas = value; }

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

        public static implicit operator List<object>(empleados v)
        {
            throw new NotImplementedException();
        }

        public static List<empleados> HardcodeoEmpleados()
        {
            List<empleados> listaEmpleados = new List<empleados>();

            listaEmpleados.Add(new empleados("Apu", "Nahasamelapetilon", 40009286, 23));
            listaEmpleados.Add(new empleados("manjula", " Nahasamelapetilon", 400186, 8));
            listaEmpleados.Add(new empleados("Daniel", "Sbaglia", 3281812, 15));
            listaEmpleados.Add(new empleados("Juan Carlos ", "Martinez", 848218, 3));

            return listaEmpleados;
        }


   }
}
