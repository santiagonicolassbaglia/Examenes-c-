using Biblioteca_examen;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermercado
{

    public partial class registroUsuario : Form
    {

        public List<cliente> MiCliente;



        public registroUsuario()
        {
            InitializeComponent();
            MiCliente = new List<cliente>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn_alta_Click(object sender, EventArgs e)
        {
            MiCliente = new List<cliente>();

            Alta_Cliente alta_Cliente = new Alta_Cliente();

            if (alta_Cliente.ShowDialog() == DialogResult.OK)
            {
                MiCliente.Add(alta_Cliente.MiCliente);
                MessageBox.Show(" Se Agregó correctamente ", " Alta de Cliente");
            }




        }



        private void btn_IngresarUsuario_Click(object sender, EventArgs e)
        {

            string user, pass;

            user = txt_usuario.Text;
            pass = txt_contraseña.Text;
            MiCliente = control_usuario.HardcodeoClientes();
            bool aux = false;

            comercio_compras wikieMart;
            if (!validaciones.ValidarString(user))
            {

                foreach (cliente item in this.MiCliente)
                {

                    if (item.Usuario== user && item.Contraseña == pass)
                    {
                        wikieMart = new comercio_compras(item);
                        wikieMart.Show();// muestra el formulario .. habre la otra ventana
                        this.Hide();// cierra la otra venta del login
                        MessageBox.Show($"Bienvenido!!!:", user, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        aux = true;
                        break;

                    }


                }

                if (!aux)
                {
                    MessageBox.Show("El usuario o la contraseña no son compatibles!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            /*
              if ((item.Usuario != user) && (item.Contraseña!=pass))
                    {
                    MessageBox.Show("El usuario o la contraseña no son compatibles!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                        
                }
             */

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }



















        /*

      private void btn_IngresarUsuario_Click(object sender, EventArgs e)
      {
          string user, pass;

          user = txt_usuario.Text;
          pass = txt_contraseña.Text;

          comercio_compras wikieMart = new comercio_compras();

          if ( user =="santi" && pass == "1234" && wikieMart.ShowDialog() == DialogResult.OK)
          {
              MessageBox.Show(" Bienvenido ", " santi  ");
          }


          foreach (cliente item in this.MiCliente)
          {

              if ( String.Equals(item.Usuario, user) && String.Equals(item.Contraseña, pass))
              {


                  if (wikieMart.ShowDialog() != DialogResult.OK)
                  { 
                      MessageBox.Show(" Bienvenido ", " Usuario  ");
                  }
                 else if(wikieMart.ShowDialog() == DialogResult.OK)
                  {
                      MessageBox.Show("El usuario o la contraseña no son compatibles!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }




              }
          }





      */
        /* if ()
         {
             comercio_compras comercio_comp = new comercio_compras();

         }*/
    }









    /*

               private void btn_alta_Click(object sender, EventArgs e)
            {
                Alta_Cliente alta_Cliente = new Alta_Cliente();
              if(  alta_Cliente.ShowDialog() == DialogResult.OK);
                {

                    if (MiCliente + alta_Cliente.MiCliente)
                    {

                        MessageBox.Show(" Se Agregó correctamente ", " Alta de Cliente");

                    }

                }
            }

          */

}

