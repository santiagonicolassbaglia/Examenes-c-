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
    public partial class Deliberi3 : Form
    {
        Grafico grafico;

        public Deliberi3()
        {
            grafico = new Grafico();
            grafico.Show();
            InitializeComponent();
        }
   



public void ActualizarDatoDel(string dato)
{
    if (this.richTextBoxDel.InvokeRequired)
    {
        this.richTextBoxDel.BeginInvoke((MethodInvoker)delegate ()
        {
            this.richTextBox2.Text += this.richTextBoxDel.Text;
            this.richTextBoxDel.Text = dato;
        }
        );
    }
    else
    {
        this.richTextBox2.Text += this.richTextBoxDel.Text + "\n";
        this.richTextBoxDel.Text = dato;
    }

}



 }
}