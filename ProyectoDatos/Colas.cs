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
    public partial class Colas : Form
    {
        int IdClass = 0;

        Cola Cola = new Cola();

        public Colas()
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

        private void MostrarEnDataGridView()
        {
            dginstrumento.Rows.Clear();

            Nodo actual = Cola.Principio;

            while (actual != null)
            {
                dginstrumento.Rows.Add(actual.Datos.Id, actual.Datos.Nombre, actual.Datos.Precio, actual.Datos.Color);
                actual = actual.Siguiente;
            }
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

        private void Nombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void precio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void color_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (Nombre.Checked)
            {
                BuscarPorNombre();
            }
            else if (precio.Checked)
            {
                BuscarPorPrecio();
            }
            else
            {
                BuscarPorColor();
            }
        }

        private void Decendente_Click(object sender, EventArgs e)
        {
            Cola.Descendente();
            MostrarEnDataGridView();
        }

        private void Ascendente_Click(object sender, EventArgs e)
        {
            Cola.Ascendente();
            MostrarEnDataGridView();
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

            Cola.Encolar(nuevoInstrumento);
            MostrarEnDataGridView();
            textnombre.Text = string.Empty;
            textprecio.Text = string.Empty;
            textcolor.Text = string.Empty;
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

                    MInstrumentos instrumentoModificado = new MInstrumentos
                    {
                        Id = idModificar,
                        Nombre = nuevoNombre,
                        Precio = nuevoPrecio,
                        Color = nuevoColor
                    };

                    bool modificado = Cola.Modificar(idModificar, instrumentoModificado);

                    if (modificado)
                    {
                        MostrarEnDataGridView();
                        MessageBox.Show("Instrumento modificado correctamente.");
                        textnombre.Text = string.Empty;
                        textprecio.Text = string.Empty;
                        textcolor.Text = string.Empty;
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
            if (dginstrumento.SelectedCells.Count > 0)
            {
                int rowIndex = dginstrumento.SelectedCells[0].RowIndex;

                try
                {
                    int idEliminar = Convert.ToInt32(dginstrumento.Rows[rowIndex].Cells["ID"].Value);

                    bool eliminado = Cola.Desencolar(idEliminar);

                    if (eliminado)
                    {
                        MostrarEnDataGridView();
                        MessageBox.Show("Instrumento eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Instrumento no encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al eliminar el instrumento: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
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
        private void BuscarPorNombre()
        {
            string nombreABuscar = textbuscar.Text;

            MInstrumentos instrumentoEncontrado = Cola.Buscar(nombreABuscar);

            if (instrumentoEncontrado != null)
            {
                dginstrumento.Rows.Clear();
                dginstrumento.Rows.Add(instrumentoEncontrado.Id, instrumentoEncontrado.Nombre, instrumentoEncontrado.Precio, instrumentoEncontrado.Color);
            }
            else
            {
                MessageBox.Show("No se encontró un instrumento con el nombre indicado.");
            }
        }

        private void BuscarPorPrecio()
        {
            double precioABuscar;
            if (!double.TryParse(textbuscar.Text, out precioABuscar))
            {
                MessageBox.Show("Ingrese un precio válido para buscar.");
                return;
            }

            dginstrumento.Rows.Clear();
            Nodo actual = Cola.Principio;
            bool encontrado = false;

            while (actual != null)
            {
                if (actual.Datos.Precio == precioABuscar)
                {
                    dginstrumento.Rows.Add(actual.Datos.Id, actual.Datos.Nombre, actual.Datos.Precio, actual.Datos.Color);
                    encontrado = true;
                }
                actual = actual.Siguiente;
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron elementos con el precio indicado.");
            }
        }
        private void BuscarPorColor()
        {
            string colorABuscar = textbuscar.Text.Trim();

            dginstrumento.Rows.Clear();
            Nodo actual = Cola.Principio;
            bool encontrado = false;

            while (actual != null)
            {
                if (string.Equals(actual.Datos.Color, colorABuscar, StringComparison.OrdinalIgnoreCase))
                {
                    dginstrumento.Rows.Add(actual.Datos.Id, actual.Datos.Nombre, actual.Datos.Precio, actual.Datos.Color);
                    encontrado = true;
                }
                actual = actual.Siguiente;
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron elementos con el color indicado.");
            }

        }

        private void LimpiarCampos()
        {
            textnombre.Text = string.Empty;
            textprecio.Text = string.Empty;
            textcolor.Text = string.Empty;
            textbuscar.Text = string.Empty;

            dginstrumento.Rows.Clear();

            Cola.Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close(); // Cierra la ventana actual


        }
    }
}
