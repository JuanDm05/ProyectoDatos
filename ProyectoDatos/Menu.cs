using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDatos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        private void Arreglos_Click(object sender, EventArgs e)
        {
            Form1 arreglo = new Form1();
            arreglo.Show(); // Muestra el formulario "arreglo"
            this.Hide(); // Oculta el formulario actual "Menu"

        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            ListasEnlazadas listas = new ListasEnlazadas(); 
            listas.Show();
            this.Hide(); // Oculta el formulario actual "Menu"


        }

        private void BtnPilas_Click(object sender, EventArgs e)
        {
            Pila pilas = new Pila();    
            pilas.Show();
            this.Hide(); // Oculta el formulario actual "Menu"


        }

        private void btncolas_Click(object sender, EventArgs e)
        {
           Colas a = new Colas();
            a.Show();
            this.Hide(); // Oculta el formulario actual "Menu"



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
