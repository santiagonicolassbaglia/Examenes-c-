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
    public partial class Alta_Cliente : Form
    {

        private cliente miCliente;

        public cliente MiCliente { get => miCliente; set => miCliente = value; }



        public Alta_Cliente()
        {
            InitializeComponent();
        }

        private void Alta_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_alta_Click(object sender, EventArgs e)
        {
            int dni;
            if (int.TryParse(this.dnI_alta.Text, out dni ))
            {
                miCliente = new cliente(this.nombre_alta.Text,
                    this.apellido_alta.Text, dni,
                    this.usuario_alta.Text,this.contraseña_alta.Text);

                this.DialogResult = DialogResult.OK;
            }
        }

        
    }
}
