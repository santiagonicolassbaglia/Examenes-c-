using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using supermercado;

namespace Biblioteca_examen
{
    public partial class compras : Form
    {
        public List<cliente> MiClientess;

        cliente ClienteOk;
        Producto ProductoOk;

        public compras(cliente Cliente)
        {
            InitializeComponent();
            this.ClienteOk = Cliente;
            
            MiClientess = control_usuario.HardcodeoClientes();

        }


        private void btn_comprar_Click(object sender, EventArgs e)
        {
              List<Producto> misProductos = new List<Producto>();
              misProductos =  Producto.HardcodeoProductos();
            Double total = 0;


            if (chk_Duff.Checked)
            {
                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo == 4562)
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:" , item.Tipo);
                        }
                    }
                }
                
            }

            if (chk_Quilmes.Checked)
            {
                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo == 4563)
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:", item.Tipo);
                        }
                    }
                }
            }
           
            
            
            if (chk_Pepsi.Checked)
            {
                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo == 4564)
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:", item.Tipo);
                        }
                    }
                }
            }





            if (chk_donas.Checked)
            {
                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo == 1102)
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:", item.Tipo);
                        }
                    }
                }
            }





            if (chk_Cola.Checked)
            {
                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo == 4565)
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:", item.Tipo);
                        }
                    }
                }

            }




            if (chk_Raspados.Checked)
            {

                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo ==1103 )
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:", item.Tipo);
                        }
                    }
                }
            }

            if (chk_leche.Checked)
            {
                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo == 1104)
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:", item.Tipo);
                        }
                    }
                }
            }

            
            if (chk_Desodo.Checked)
            {

                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo == 1982)
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:", item.Tipo);
                        }
                    }
                }

            }

            if (chk_dentifrico.Checked)
            {
                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo == 1983)
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:", item.Tipo);
                        }
                    }
                }
            }



            if (chk_salchchas.Checked)
            {

                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo == 1105)
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:", item.Tipo);
                        }
                    }
                }
            }

            if (chk_caramelos.Checked)
            {
                foreach (Producto item in misProductos)
                {
                    if (item.NumArticulo == 1106)
                    {
                        total = total + item.PrecioUnitario;
                        item.Unidades--;
                        if (item.Unidades <= 0)
                        {
                            MessageBox.Show("Disculpe nos quedamos sin stock del sierto producto:", item.Tipo);
                        }
                    }
                }
            }


            if (total > 0)
            {

                if (this.ClienteOk.Apellido.ToUpper() == "SIMPSON")
                {
                    MessageBox.Show("Por ser miembros de la familia Simpson obtiene un 13% de descuento", "señor/a simpson");
                    double descuento = (total * 0.87);
                    MessageBox.Show($"EL TOTAL ES:{total} ");

                    try
                    {
                        SoundPlayer player =

                            player = new SoundPlayer(Application.StartupPath + @"\\sonidoApu\gracias.wav");
                    player.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex);
                       
                    }


                }
                else
                {

                    MessageBox.Show($"EL TOTAL ES:{total} ");

                    SoundPlayer player =

                            player = new SoundPlayer(Application.StartupPath + @"\\sonidoApu\gracias.wav");
                    player.Play();

                }



            }






        }

        private void stockMenor10_Click(object sender, EventArgs e)
        {
            List<Producto> misProductos = new List<Producto>();
            misProductos = Producto.HardcodeoProductos();

           
            foreach (Producto item in misProductos)
            {
                if (item.Unidades < 10)
                {
                    
                        MessageBox.Show(item.Descripcion, "Los productos con stock menor a 10 son:");
                    
                }

            }

        }
        
    }



}








