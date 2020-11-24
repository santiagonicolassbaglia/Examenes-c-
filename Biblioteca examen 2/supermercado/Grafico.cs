using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace supermercado
{
    public partial class Grafico : Form
    {
        Thread hilo;
        delegate void delegado(int valor);// nos permite ir actualizando la pantalla

        public Grafico()
        {
            InitializeComponent();
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            hilo = new Thread(new ThreadStart(Proceso1));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso2));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso3));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso4));
            hilo.Start();
        }



        #region "Proceso 1"
        public void Proceso1()
        {
            for (int i = 0; i < 101; i++)
            {
                delegado MD = new delegado(Actualizar1);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(70);
            }
        }

        public void Actualizar1(int valor)
        {
            p1.Value = valor;
        }

        #endregion

        #region"Proceso 2"
        public void Proceso2()
        {
            for (int i = 0; i < 101; i++)
            {
                delegado MD = new delegado(Actualizar2);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(150);
            }
        }

        public void Actualizar2(int valor)
        {
            p2.Value = valor;
        }

        #endregion

        #region "Proceso 3"
        public void Proceso3()
        {
            for (int i = 0; i < 101; i++)
            {
                delegado MD = new delegado(Actualizar3);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(40);
            }
        }

        public void Actualizar3(int valor)
        {
            p3.Value = valor;
        }

        #endregion



        public void Proceso4()
        {
            for (int i = 0; i < 101; i++)
            {
                delegado MD = new delegado(Actualizar4);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(145);
            }
        }

        public void Actualizar4(int valor)
        {
            p4.Value = valor;
        }







    }
}
