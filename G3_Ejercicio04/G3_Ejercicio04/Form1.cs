using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3_Ejercicio04
{
    public partial class Form1 : Form
    {
        public List<Persona> Personas = new List<Persona>();
        private int edit_indice = -1;
        private void actualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Personas; /*los nombres de columna que veremos
                                                    son los de las propiedades*/
        }
        private void limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
        }
        public class Persona
        {
            string nombre;
            string apellido;
            string telefono;
            string correo;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public string Apellido
            {
                get { return apellido; }
                set { apellido = value; }
            }
            public string Telefono
            {
                get { return telefono; }
                set { telefono = value; }
            }
            public string Correo
            {
                get { return correo; }
                set { correo = value; }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            FrmRecibe formulario = new FrmRecibe(); //instancia de otro formulario
            formulario.PersonaRecibe = Personas; /*lista original Personas es enviada
            a la lista PersonaRecibe que está en el formulario 2 y que puede ser invocada por medio de
            la instancia del segundo formulario */
            formulario.Show(); //mostar el segundo formulario
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dataGridView1.SelectedRows[0];
            int pos = dataGridView1.Rows.IndexOf(seleccion); //almacena en cual fila estoy
            edit_indice = pos; //copio esa variable en índice editado

            Persona per = Personas[pos]; /*esta variable de tipo persona, se carga con los
            valores que le pasa el listado*/

            txtnombre.Text = per.Nombre; //lo que tiene el atributo se lo doy al textbox
            txtapellido.Text = per.Apellido;
            txttelefono.Text = per.Telefono;
            txtcorreo.Text = per.Correo;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //creo un objeto de la clase persona y guardo a través de las propiedades
            Persona per = new Persona();
            per.Nombre = txtnombre.Text;
            per.Apellido = txtapellido.Text;
            per.Telefono = txttelefono.Text;
            per.Correo = txtcorreo.Text;
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Personas[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {

                Personas.Add(per); /*al arreglo de Personas le agrego el objeto creado
                                        con todos los datos que recolecté*/

            }
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            limpiar();//mandamos a llamar la función que limpia
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado

            {
                Personas.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                limpiar();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Debe dar doble click primero sobre contacto");
            }
        }
    }
}
