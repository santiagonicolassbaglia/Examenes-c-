using Biblioteca_examen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermercado
{
    public partial class comercio_compras : Form
    {
        

        cliente Cliente;

        public comercio_compras(cliente Cliente)
        {
            InitializeComponent();
            this.Cliente = Cliente;
        }

        

        /* private void opcionControl_Click(object sender, EventArgs e)
         {
             control_de_usuarios opcion2 = new control_de_usuarios();
             opcion2.Show();
         }*/

        /*   private void opcionInventario_Click(object sender, EventArgs e)
           {
              inventario opcion3 = new inventario();
               opcion3.Show();
           }*/

        private void opcionCompra_Click(object sender, EventArgs e)
        {
            compras opcion4 = new compras(this.Cliente);
            opcion4.Show();
        }



        private void cerrarSesión_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRACIAS, VUELVA PRONTOSSS..!!  ", "Mensaje de APU:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            registroUsuario opcion5 = new registroUsuario();// vuelvo al menu anterior
            opcion5.Show();
            this.Hide();//se me cierra la ventana
        }

        private void salir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Esta seguro que desea salir ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (salir == DialogResult.No)
            {
                return;

            }
            else
            {

                MessageBox.Show("GRACIAS, VUELVA PRONTOSSS..!!  ", "Mensaje de APU:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void opcionControl_Click(object sender, EventArgs e)
        {
            control_usuario opcionControl = new control_usuario();
            opcionControl.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
