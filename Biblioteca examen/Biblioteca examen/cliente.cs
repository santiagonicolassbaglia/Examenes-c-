using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_examen
{
   public class cliente:Persona
    {


        private string usuario;
        private string contraseña;




        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                this.usuario = value;
            }

        }








        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                this.contraseña = value;
            }

        }



        public cliente(string nombre, int dni, string usuario, string contraseña,string apellido) :base(nombre,apellido,dni)
        {
            
            this.usuario = usuario;
            this.contraseña = contraseña;

            
        }




       
        /* public static bool operator +(cliente[]Clientes, cliente Clientess)
         {

             //recorro buscando libres
             for (int i = 0; i < Clientes.Length; i++)
             {
                 if (Clientes[i] == null)
                 {
                     Clientes[i] = Clientess;
                     return true;
                 }
             }

             //si no encontre libres agrego un lugar
             Array.Resize<cliente>(ref Clientes, Clientes.Length + 1);

             Clientes[Clientes.Length - 1] = Clientess;
             return true;

         }*/



        // esta al pedo porque se hizo de otra manera pero  lo queria tener ! 
        public static bool operator ==(cliente usuario, cliente contraseña)
        {
            return (usuario.Usuario == usuario.Contraseña);
        }



        public static bool operator !=(cliente usuario, cliente contraseña)
        {
            return !(usuario.Usuario == usuario.Contraseña);
        }


        public static bool ValidarCliente(cliente auxCliente)
        {

            if (auxCliente.Apellido == "Simpson")
            {
                return true;
            }

            return false;
        }



    }
}
