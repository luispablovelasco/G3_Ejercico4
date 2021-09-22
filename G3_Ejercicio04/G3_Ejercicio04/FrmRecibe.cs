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
    public partial class FrmRecibe : Form
    {

        public List <Form1.Persona> PersonaRecibe = null; //creación de una lista que reciba
        public FrmRecibe()
        {
            InitializeComponent();
        }
        private void actualizarGrid() //función que llena el DGV del formulario 2
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PersonaRecibe;
        }
        private void btnLlenar_Click(object sender, EventArgs e)
        { actualizarGrid(); } //actualiza DGV cada vez que se presione.

        private void FrmRecibe_Load(object sender, EventArgs e)
        {

        }

        private void btnllenar_Click(object sender, EventArgs e)
        {
            actualizarGrid();
        }
    }
}
