using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_examen
{
   public  class Empleado : Persona
    {
        
        int ventas;

        public int cantVentas { get => ventas; set => ventas = value; }


        public Empleado(string nombre, string apellido, int dni, int ventas) : base(nombre, apellido, dni)
        {
            this.ventas = ventas;
        }

       

        public static bool operator +(Empleado[] Empleado, Empleado Empleados)
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
            Array.Resize<Empleado>(ref Empleado, Empleado.Length + 1);

            Empleado[Empleado.Length - 1] = Empleados;
            return true;

        }

        public static implicit operator List<object>(Empleado v)
        {
            throw new NotImplementedException();
        }

        public static List<Empleado> HardcodeoEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado("Apu", "Nahasamelapetilon", 40009286, 23));
            listaEmpleados.Add(new Empleado("manjula", " Nahasamelapetilon", 400186, 8));
            listaEmpleados.Add(new Empleado("Daniel", "Sbaglia", 3281812, 15));
            listaEmpleados.Add(new Empleado("Juan Carlos ", "Martinez", 848218, 3));

            return listaEmpleados;
        }


   }
}
