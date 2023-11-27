using ProyectoDatos.Modelos;
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
    public partial class ListasEnlazadas : Form
    {
        int IdClass = 0;

        Listas lista = new Listas();

        public ListasEnlazadas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textcolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = textnombre.Text;
            double precio;
            if (!double.TryParse(textprecio.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }
            string color = textcolor.Text;

            MInstrumentos nuevoInstrumento = new MInstrumentos
            {
                Id = ++IdClass,
                Nombre = nombre,
                Precio = precio,
                Color = color
            };

            lista.insertarLista(nuevoInstrumento);
            MostrarEnDataGridView();

        }
        private void MostrarEnDataGridView()
        {
            dginstrumento.Rows.Clear();

            Nodo actual = lista.Primero;
            while (actual != null)
            {
                dginstrumento.Rows.Add(actual.Datos.Id, actual.Datos.Nombre, actual.Datos.Precio, actual.Datos.Color);
                actual = actual.Siguiente;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void textmodificar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void textelim_TextChanged(object sender, EventArgs e)
        {

        }

        private void dginstrumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void ListasEnlazadas_Load(object sender, EventArgs e)
        {
            dginstrumento.Columns.Add("ID", "Id");
            dginstrumento.Columns.Add("Nombre", "Nombre");
            dginstrumento.Columns.Add("Precio", "Precio");
            dginstrumento.Columns.Add("Color", "Color");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
