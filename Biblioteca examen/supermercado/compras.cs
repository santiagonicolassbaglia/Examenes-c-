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

        public compras(cliente Cliente)
        {
            InitializeComponent();
            this.ClienteOk = Cliente;
            MiClientess = control_usuario.HardcodeoClientes();

        }


        private void btn_comprar_Click(object sender, EventArgs e)
        {

            int total = 0;



            if (chk_Duff.Checked)
                total = total + 250;

            if (chk_Quilmes.Checked)
                total = total + 70;

            if (chk_Pepsi.Checked)
                total = total + 60;

            if (chk_donas.Checked)
                total = total + 40;

            if (chk_Cola.Checked)
                total = total + 50;

            if (chk_Raspados.Checked)
                total = total + 60;

            if (chk_leche.Checked)
                total = total + 40;

            if (chk_Desodo.Checked)
                total = total + 90;

            if (chk_dentifrico.Checked)
                total = total + 60;

            if (chk_salchchas.Checked)
                total = total + 40;

            if (chk_caramelos.Checked)
                total = total + 2;


            if (total > 0)
            {

                if (this.ClienteOk.Apellido.ToUpper() == "SIMPSON")
                {
                    MessageBox.Show("Por ser miembros de la familia Simpson obtiene un 13% de descuento", "señor/a simpson");
                    double descuento = (total * 0.87);
                    MessageBox.Show($"EL TOTAL ES:{total} ");


                    SoundPlayer player =

                            player = new SoundPlayer(Application.StartupPath + @"\\sonidoApu\gracias.wav");
                    player.Play();



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


    }



}









/*


}


}
}
int comprado=0;

if (checkProductos.Items.Count > 0)// count cuenta cuantos items hay .. entonces verifica que hallas seleccionado alguno
{
    foreach(string elemento in checkProductos.CheckedItems) // el checkedItems te agrega los seleccionados
    {
        lstComprado.Items.Add(elemento.ToString());// le agrega el elemento
    }

    //para limpiar seleccion

    for(int i=0; i<checkProductos.Items.Count;i++)
    {
        checkProductos.SetItemChecked(i, false);    // setitemsChecked de true te lo pasa a false
    }




*/
