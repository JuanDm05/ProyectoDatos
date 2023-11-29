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
                Id = pila.Cima?.Datos.Id + 1 ?? 1,
                Nombre = nombre,
                Precio = precio,
                Color = color
            };

            pila.InsertarPila(nuevoInstrumento);
            MostrarEnDataGridView();
            LimpiarCampos();
        }

        private void MostrarEnDataGridView()
        {
            dginstrumento.Rows.Clear();

            Nodo actual = pila.Cima;

            while (actual != null)
            {
                dginstrumento.Rows.Add(actual.Datos.Id, actual.Datos.Nombre, actual.Datos.Precio, actual.Datos.Color);
                actual = actual.Siguiente;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dginstrumento.SelectedCells.Count > 0)
            {
                int rowIndex = dginstrumento.SelectedCells[0].RowIndex;

                try
                {
                    int idModificar = Convert.ToInt32(dginstrumento.Rows[rowIndex].Cells["ID"].Value);

                    // Aquí puedes obtener los nuevos valores del instrumento desde tus TextBox o controles de entrada
                    string nuevoNombre = textnombre.Text;
                    double nuevoPrecio;
                    if (!double.TryParse(textprecio.Text, out nuevoPrecio))
                    {
                        MessageBox.Show("Ingrese un precio válido.");
                        return;
                    }
                    string nuevoColor = textcolor.Text;

                    // Buscar el instrumento en la pila por su ID
                    MInstrumentos instrumentoExistente = pila.BuscarPorId(idModificar);

                    if (instrumentoExistente != null)
                    {
                        // Actualizar los valores del instrumento existente sin cambiar su ID
                        instrumentoExistente.Nombre = nuevoNombre;
                        instrumentoExistente.Precio = nuevoPrecio;
                        instrumentoExistente.Color = nuevoColor;

                        MostrarEnDataGridView();
                        MessageBox.Show("Instrumento modificado correctamente.");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Instrumento no encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al modificar el instrumento: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (pila.Cima != null)
            {
                try
                {
                    bool eliminado = pila.Eliminar();

                    if (eliminado)
                    {
                        MostrarEnDataGridView();
                        MessageBox.Show("Instrumento eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("La pila está vacía, no se puede eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al eliminar el instrumento: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("La pila está vacía, no se puede eliminar.");
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            MostrarEnDataGridView();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos de texto
            textnombre.Text = string.Empty;
            textprecio.Text = string.Empty;
            textcolor.Text = string.Empty;
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
