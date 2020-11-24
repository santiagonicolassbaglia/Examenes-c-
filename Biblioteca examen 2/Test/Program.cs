using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_examen;
using Archivos;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {





            try
            {


                Producto prod1 = new Producto(1, "savalo", 209.99f, null);


                BaseDeDatos.InsertarProducto(prod1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.ReadKey();




            try
            {

                int numero = 55;

                bool par = numero.EsPar();

                Console.WriteLine("{0} es {1}", numero, par);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            try
            {
                double valor = 55.18;

                Console.WriteLine(valor.Dobletea());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }







            try
            {


                Cliente prod1 = new Cliente("rodrigo", 4080808, "rodrii", "1324", "evez");


                BaseDeDatos.InsertarCliente(prod1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.ReadKey();






            //        try
            //        {
            //            List<Cliente> clientes = new List<Cliente>();


            //            clientes.Add(new Cliente("santiago", 40009286, "ssanntii_96", "1234","sbaglia"));
            //            clientes.Add(new Cliente("Alan", 42009259, "Velascosss", "4087", "Velasco"));
            //            Serializador <List<Cliente>> serializador = new Serializador<List<Cliente>>();

            //            serializador.Serializador(clientes, "santi.xml");

            //            List<Cliente> clientes2 = new List<Cliente>();
            //            clientes2 = serializador.Deserializar("santi.xml");

            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine($"ocurrio un error: { ex.ToString()}");
            //        }

            ////  Console.ReadKey();


            //  List<Pedido> Leer()
            //{
            //    List<Pedido> datos = new List<Pedido>();
            //    string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "inventario.xml");
            //    Xml<List<Pedido>> auxPedidos = new Xml<List<Pedido>>();

            //    auxPedidos.Leer(path, out datos);

            //    return datos;

            //}

        }
    }
}
