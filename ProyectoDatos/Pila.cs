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
    public partial class Pila : Form
    {
        Pilas pila = new Pilas();

        public Pila()
        {
            InitializeComponent();
            InicializarDataGridView();
        }

        private void InicializarDataGridView()
        {
            dginstrumento.Columns.Add("ID", "Id");
            dginstrumento.Columns.Add("Nombre", "Nombre");
            dginstrumento.Columns.Add("Precio", "Precio");
            dginstrumento.Columns.Add("Color", "Color");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void MostrarEnDataGridView()
        {
            dginstrumento.Rows.Clear();

            /*Nodo actual = pila.Cima;

            while (actual != null)
            {
                dginstrumento.Rows.Add(actual.Datos.Id, actual.Datos.Nombre, actual.Datos.Precio, actual.Datos.Color);
                actual = actual.Siguiente;
            }*/
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
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

        private void textnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textcolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void precio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void color_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void Descendente_Click(object sender, EventArgs e)
        {

        }

        private void Ascendnte_Click(object sender, EventArgs e)
        {

        }

        private void dginstrumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
