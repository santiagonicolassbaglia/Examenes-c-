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
            control_usuario alta_Usuario =new control_usuario();

            if (alta_Cliente.ShowDialog() == DialogResult.OK)
            {
                MiCliente.Add(alta_Cliente.MiCliente);
                MiCliente.Add(alta_Usuario.MiCliente);
               
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

                    if (item.Usuario == user && item.Contraseña == pass)
                    {
                        wikieMart = new comercio_compras(item);
                        wikieMart.Show();// muestra el formulario .. abre la otra ventana
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


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }







    }

}

