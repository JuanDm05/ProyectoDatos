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
            string[] temp = new string[3];
            temp[0] = textnombre.Text;
            temp[1] = textprecio.Text;
            temp[2] = textcolor.Text;

            if (temp[0] == "" || temp[1] == "" || temp[2] == "")
            {
                MessageBox.Show("No deje ningun espacio vacio");
            }
            else
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
                textnombre.Text = string.Empty;
                textprecio.Text = string.Empty;
                textcolor.Text = string.Empty;
            }
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
            string[] temp = new string[3];
            temp[0] = textnombre.Text;
            temp[1] = textprecio.Text;
            temp[2] = textcolor.Text;

            if (temp[0] == "" || temp[1] == "" || temp[2] == "")
            {
                MessageBox.Show("No deje ningun espacio vacio");
            }
            else
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

                        // Crear un nuevo objeto MInstrumentos con los valores modificados
                        MInstrumentos instrumentoModificado = new MInstrumentos
                        {
                            Id = idModificar,
                            Nombre = nuevoNombre,
                            Precio = nuevoPrecio,
                            Color = nuevoColor
                        };

                        // Llamar al método de modificación en tu lista enlazada
                        bool modificado = lista.modificarPorId(idModificar, instrumentoModificado);

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
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dginstrumento.SelectedCells.Count > 0)
            {
                int rowIndex = dginstrumento.SelectedCells[0].RowIndex;

                try
                {
                    int idEliminar = Convert.ToInt32(dginstrumento.Rows[rowIndex].Cells["ID"].Value);

                    bool eliminado = lista.eliminarPorId(idEliminar);

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

       
    

        private void textbuscar_TextChanged(object sender, EventArgs e)
        {
        }
    
       
     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Decendente_Click(object sender, EventArgs e)
        {
            OrdenarPorPrecioDescendente();
            MostrarEnDataGridView();
        }
        public void OrdenarPorPrecioDescendente()
        {
            Nodo actual = lista.Primero;

            while (actual != null)
            {
                Nodo siguiente = actual.Siguiente;

                while (siguiente != null)
                {
                    if (actual.Datos.Precio < siguiente.Datos.Precio)
                    {
                        // Intercambiar los datos
                        MInstrumentos temp = actual.Datos;
                        actual.Datos = siguiente.Datos;
                        siguiente.Datos = temp;
                    }

                    siguiente = siguiente.Siguiente;
                }

                actual = actual.Siguiente;
            }
        }
        public void OrdenarPorPrecioAscendente()
        {
            Nodo actual = lista.Primero;

            while (actual != null)
            {
                Nodo siguiente = actual.Siguiente;

                while (siguiente != null)
                {
                    if (actual.Datos.Precio > siguiente.Datos.Precio)
                    {
                        // Intercambiar los datos
                        MInstrumentos temp = actual.Datos;
                        actual.Datos = siguiente.Datos;
                        siguiente.Datos = temp;
                    }

                    siguiente = siguiente.Siguiente;
                }

                actual = actual.Siguiente;
            }
        }

        private void Ascendente_Click(object sender, EventArgs e)
        {
            OrdenarPorPrecioAscendente();
            MostrarEnDataGridView();
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
            textbuscar.Text = string.Empty;

            // Limpiar la tabla DataGridView
            dginstrumento.Rows.Clear();

            // Restablecer el arreglo de instrumentos y el contador
            lista.LimpiarLista(); // Puedes implementar un método para limpiar la lista en tu clase Listas si es necesario
        }

        private void Nombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void color_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void precio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textbuscar_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void BuscarPorNombre()
        {
            string nombreABuscar = textbuscar.Text;

            MInstrumentos instrumentoEncontrado = lista.BuscarPorNombre(nombreABuscar);

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
            Nodo actual = lista.Primero;
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
            Nodo actual = lista.Primero;
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


        private void btnbuscar_Click_1(object sender, EventArgs e)
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
    }
}
