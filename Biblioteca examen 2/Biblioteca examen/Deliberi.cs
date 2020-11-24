



namespace Biblioteca_examen
{
    public class Deliberi
    {
        private  string direccion;
        private float precio;
        private string nombre;

        public Deliberi( string nombre,string direccion, float precio)
        {
            Direccion = direccion;
            Precio = precio;
            Nombre = nombre;
        }



        public Deliberi(string nombre, float precio)
        {
           
            Precio = precio;
            Nombre = nombre;
        }


        public Deliberi(string nombre, string direccion)
        {

            Direccion = direccion;
            Nombre = nombre;
        }

       

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }



        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }



        public string DatosCompletosProd()
        {
            return "NOMBRE::"+Nombre + " " + "Direccion:"+Direccion + " " + "Monto:$"+Precio;
        }



    }
}