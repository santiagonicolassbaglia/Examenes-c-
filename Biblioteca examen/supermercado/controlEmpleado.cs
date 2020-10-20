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
    public partial class compra2 : Form
    {
        static List<empleados> ListaEmpleado;
        int i;
        empleados MiEmpleadooo;

        public compra2()
        {
            ListaEmpleado = new List<empleados>();
            InitializeComponent();

            // dataGridView_Empleados = MiEmpleado.Add;
        }

        public empleados MiEmpleado { get => MiEmpleadooo; set => MiEmpleadooo= value; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex; // la "e" te dice de donde proviene y el rowIndex obtiene el valor de la fila que se obtiene el evento

            if (i != -1)// quiere decir si seleccione algo.. el indice del encabezado es -1
            {
                lblInformacion.Text = (string)dataGridView_Empleados.Rows[i].Cells[0].Value; // la celda 0 es el nombre
                                                                                             // el value es de tipo objet .. entonces lo tengo que castear para que se haga de tipo string
            }
            
        }

        private void AltaEmpleado_Click(object sender, EventArgs e)
        { 
            
                


              // creo un nuevo renglon

                int i = dataGridView_Empleados.Rows.Add(); // rows es renglon y add agrega

                      dataGridView_Empleados.Rows[i].Cells[0].Value = txtNombre.Text;
                      dataGridView_Empleados.Rows[i].Cells[1].Value = txtApellido.Text;
                      dataGridView_Empleados.Rows[i].Cells[2].Value = txtDni.Text;
                      dataGridView_Empleados.Rows[i].Cells[3].Value = txtVentas.Text;


            // cual es la selda que voy a utilizar( cells) y en que posicion [i]

            int ventas;
            int dni;
            if (int.TryParse(this.txtDni.Text, out dni)  && int.TryParse(this.txtVentas.Text, out ventas))
            {
                MiEmpleado = new empleados(this.txtNombre.Text,
                            this.txtApellido.Text, dni, ventas);

                ListaEmpleado.Add(MiEmpleado);
                this.DialogResult = DialogResult.OK;
            }



            //limpio los txt

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtVentas.Text = "";
            


           

            

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            comercio_compras salir = new comercio_compras(null);// vuelvo al menu anterior
            salir.Show();
            this.Hide();//se me cierra la ventana
        }

        private void compra2_Load(object sender, EventArgs e)
        {
            
            empleados.HardcodeoEmpleados();
            
        }

        private void BajaEmpleado_Click(object sender, EventArgs e)
        {
            if (i != -1)
            {
                dataGridView_Empleados.Rows.RemoveAt(i);
                ListaEmpleado.Remove(MiEmpleado);
            }
        }

     

        private void EmpleadoConMenosVentas_Click(object sender, EventArgs e)
        {
            List<empleados> misEmpleados = new List<empleados>();
            misEmpleados = empleados.HardcodeoEmpleados();

            foreach (empleados item in misEmpleados)
            {
                if (item.Ventas < 10)
                {

                       MessageBox.Show(item.Nombre,"El empleado con ventas menores a 10 son");
                    
                }
            }

        }
    }
}

    