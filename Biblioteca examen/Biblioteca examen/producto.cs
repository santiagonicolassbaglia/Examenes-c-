using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_examen
{
   public class producto
    {
        string marca;
        float precio;
        bool stock;

        public producto(string marca, float precio, bool stock)
        {
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
        }

        public string Marca
        {
            get { return this.marca; }

        }

        public float Precio
        {
            get { return this.precio; }

        }


        public bool Stock
        {
            get { return this.stock; }

        }

        public static string MostrarProducto(producto producto)
        {
            StringBuilder stringBuilder = new StringBuilder();// te hace una concatenacion con los string
            stringBuilder.AppendLine(string.Format("Producto marca {0}", producto.marca));
            stringBuilder.AppendLine(string.Format("Producto precio {0}", producto.precio));


            return stringBuilder.ToString();

        }






        public enum Productos_cerveza

        {

            duff,

            quilmes,

            brahama,

            stella,

            heinecke,
        }

        public enum Productos_cocina
        {
            leche,

            cafe,

            yerba,

            azucar,

            helado,

            aceite,

            rosquillas,

            sal,
            
            galletitas
        }


          public enum Productos_gaseosa
        {

            coca,

            sevenUp,

            manaos,

            sprite,
            
            pepsi
        }




        public enum Productos_limpieza
        {

            desodorante,

            jabon,

            dentifrico,

            ala,

            magistral
        }


        public enum Productos_fiambres
        {


            salame,

            queso,
            
            mortadela,

            jamon,


        }


        }

        // ...
/*
        DiasDeLaSemana dia = DiasDeLaSemana.Lunes;

        int i = (int)DiasDeLaSemana.Lunes;

        Console.WriteLine(dia); // Mostrará "Lunes"

        Console.WriteLine(i); // Mostrará 1
*/


/*
        // para verificar que se aplique el descuento entre el producto y la persona simpsons
        public static bool operator == (producto producto1, cliente apellido )
        {
            return (producto1 == cliente.);
        }



        public static bool operator !=(producto producto1, cliente apellido)
        {
            return !(producto1 == cliente.apellido);
        }


        */



    
}
