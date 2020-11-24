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
using System.Threading;

namespace supermercado
{
    public partial class Deliberi1 : Form
    {




        Deliberi2 deliberi2;

        List<Deliberi> deliberiss;

        Thread t1;



        public Deliberi1()
        {
            deliberiss = new List<Deliberi>();
            this.deliberiss = BaseDeDatos.GetDeliberi();
            InitializeComponent();


            deliberi2 = new Deliberi2();
            deliberi2.Show();


            t1 = new Thread(IniciarCiclo);

        }




       
           
        



        public void ActualizarLista()
        {
            if (this.listView1Del.InvokeRequired)
            {
                this.listView1Del.BeginInvoke((MethodInvoker)delegate ()
                {
                    List<string> DatosDeliberi = new List<string>();
                    this.listView1Del.Items.Clear();
                    foreach (Deliberi item in deliberiss)
                    {
                        DatosDeliberi.Add(item.DatosCompletosProd());
                        listView1Del.Items.Add(item.DatosCompletosProd());
                      
                    }
                }
                );
            }
            else
            {
                List<string> DatosDeliberi = new List<string>();
                foreach (Deliberi item in deliberiss)
                {


                    DatosDeliberi.Add(item.DatosCompletosProd());
                    listView1Del.Items.Add(item.DatosCompletosProd());
                }





            }

        }



        public void IniciarCiclo()
        {



            while (deliberiss.Count != 0)
            {


               deliberi2.ActualizarDatoDel(deliberiss[0]);
                Thread.Sleep(4000);

                deliberiss.Remove(deliberiss[0]);

                this.ActualizarLista();
            }

            if (deliberiss.Count == 0)
            {
                MessageBox.Show("Todos los pedidos han sido entregados", $"Deliberi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                {
                    this.Close();
                }

            }
        }

        private void Deliberi1_Load_1(object sender, EventArgs e)
        {
            ActualizarLista();
            t1.Start();


        }
    }
}
