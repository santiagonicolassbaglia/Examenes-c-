using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_examen
{
   public class Cliente:Persona
    {


        private string usuario;
        private string contrasenia;




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








        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }

            set
            {
                this.contrasenia = value;
            }

        }



        public Cliente(string nombre, int dni, string usuario, string contraseña,string apellido) :base(nombre,apellido,dni)
        {
            
            this.usuario = usuario;
            this.contrasenia = contraseña;

            
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
        public static bool operator ==(Cliente usuario, Cliente contraseña)
        {
            return (usuario.Usuario == usuario.Contrasenia);
        }



        public static bool operator !=(Cliente usuario, Cliente contraseña)
        {
            return !(usuario.Usuario == usuario.Contrasenia);
        }


        public static bool ValidarCliente(Cliente auxCliente)
        {

            if (auxCliente.Apellido == "Simpson")
            {
                return true;
            }

            return false;
        }



    }
}
