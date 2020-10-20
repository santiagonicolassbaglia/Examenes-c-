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

    public partial class control_usuario : Form
    {


        static List<cliente> listaCliente;
        int i;
        cliente miCliente;
        public control_usuario()
        {
            listaCliente = new List<cliente>();
            InitializeComponent();
        }



        public cliente MiCliente { get => miCliente; set => miCliente = value; }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            comercio_compras salir = new comercio_compras(null);// vuelvo al menu anterior
            salir.Show();
            this.Hide();//se me cierra la ventana
        }

      

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            
            
        // creo un nuevo renglon

        int i = dataGridView_Productos.Rows.Add(); // rows es renglon y add agrega

            // cual es la selda que voy a utilizar( cells) y en que posicion [i]

            dataGridView_Productos.Rows[i].Cells[0].Value = txt_nombre.Text;
            dataGridView_Productos.Rows[i].Cells[4].Value = txT_apellido.Text;
            dataGridView_Productos.Rows[i].Cells[1].Value = text_dni.Text;
            dataGridView_Productos.Rows[i].Cells[2].Value = text_usuario.Text;
            dataGridView_Productos.Rows[i].Cells[3].Value = text_contraseña.Text;


            int dni;
            if (int.TryParse(this.text_dni.Text, out dni))
            {
               miCliente = new cliente(this.txt_nombre.Text,
                     dni,
                    this.text_usuario.Text, this.text_contraseña.Text, this.txT_apellido.Text);
                
               listaCliente.Add(miCliente);
                this.DialogResult = DialogResult.OK;
            }



            //limpio los txt

            txt_nombre.Text = "";
            text_dni.Text = "";
            text_usuario.Text = "";
            text_contraseña.Text = "";
            txT_apellido.Text = "";
        }

        // para obtener el nombre en el cuadro que quiero

        private void dataGridView_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex; // la "e" te dice de donde proviene y el rowIndex obtiene el valor de la fila que se obtiene el evento

            if (i != -1)// quiere decir si seleccione algo.. el indice del encabezado es -1
            {
                lblInformacion.Text = (string)dataGridView_Productos.Rows[i].Cells[0].Value; // la celda 0 es el nombre
                                                                                             // el value es de tipo objet .. entonces lo tengo que castear para que se haga de tipo string
            }

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (i != -1)
            {
                dataGridView_Productos.Rows.RemoveAt(i);
                listaCliente.Remove(miCliente);
            }
        }


        public static List<cliente> HardcodeoClientes()
        {
            List<cliente> listaCLientes = new List<cliente>();

            listaCLientes.Add ( new cliente("Lucas", 1435, "elLuqui", "elprof", "simpson"));
            listaCLientes.Add(new cliente("manuel", 1435,"elLuqui","elPRof","sbaglia"));
            listaCLientes.Add(new cliente("Juan", 143855,"homero", "simpson", "simpson"));
            listaCLientes.Add(new cliente("manuel", 14535,"santi","1234","Rodriguez"));
            listaCLientes.Add(new cliente("ezequiel", 14135,"elEze","elPRof","ogiguins"));
            listaCLientes.Add(new cliente("manuel", 1842135,"santi","12345","Rodriguez"));
            listaCLientes.Add(new cliente("manuel", 1435,"elLuqui","elPRof","Rodriguez"));
            listaCLientes.Add(new cliente("santi", 1874435, "alan", "elPRof","Rodriguez"));
            listaCLientes.Add(new cliente("homero", 147358,"homer","hombrepai", "simpson"));
            listaCLientes.Add(new cliente("bart", 143785, "bart_96", "elBarto", "simpson"));
            listaCLientes.Add(new cliente("lisa", 1435,"elLuqui","elPRof", "simpson"));
            listaCLientes.Add(new cliente("santi", 1121435,"elLuqui","elPRof", "ogiguins"));
            listaCLientes.Add(new cliente("manuel", 10435,"elLuqui","elPRof","Rodriguez"));


            return listaCLientes;
            
        }

        

        private void dataGridView_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void control_usuario_Load(object sender, EventArgs e)
        {
            HardcodeoClientes();

        }
    }


}

    

