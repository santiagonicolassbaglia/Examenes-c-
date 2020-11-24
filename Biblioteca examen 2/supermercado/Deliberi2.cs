using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_examen;

namespace supermercado
{
    public partial class Deliberi2 : Form
    {
        Deliberi3 deliberi3;
        public Deliberi2()
        {
            deliberi3 = new Deliberi3();
            deliberi3.Show();
            InitializeComponent();
        }

        public void ActualizarDatoDel(Deliberi dato)
        {

            if (this.richTextBox1.InvokeRequired)
            {
                this.richTextBox1.BeginInvoke((MethodInvoker)delegate ()
                {
                    deliberi3.ActualizarDatoDel(this.richTextBox1.Text);

                    this.richTextBox1.Text = dato.DatosCompletosProd();
                }
                );
            }
            else
            {
                this.richTextBox1.Text = dato.DatosCompletosProd();
            }

        }


    }
}
