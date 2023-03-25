using CapaNegocios;
using System.Data;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaAlumnos();
        }

        N_Alumnos objNegocio = new N_Alumnos();

        void ListaAlumnos()
        {
            DataTable dt = objNegocio.N_Listado();
            dataGridView1.DataSource = dt;

        }
    }
}