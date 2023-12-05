using ProyectoDatos.Modelos;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoDatos
{
    public partial class Form1 : Form
    {
        int IdClass = 0;
        private MInstrumentos[] instrumentos = new MInstrumentos[10];
        private int contadorInstrumentos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dginstrumento.Columns.Add("ID", "Id");
            dginstrumento.Columns.Add("Nombre", "Nombre");
            dginstrumento.Columns.Add("Precio", "Precio");
            dginstrumento.Columns.Add("Color", "Color");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento Click del Label3
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Evento TextChanged del TextBox2
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Evento TextChanged del TextBox4
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Evento Click del Button4
        }

        private void dginstrumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento CellContentClick del DataGridView
        }

        private void textid_TextChanged(object sender, EventArgs e)
        {
            // Evento TextChanged del TextBox ID
        }

        private void textprecio_TextChanged(object sender, EventArgs e)
        {
            // Evento TextChanged del TextBox Precio
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            AgregarInstrumento();
        }
        private void ModificarInstrumento()
        {
            try
            {
                int idModificar = Convert.ToInt32(textmodificar.Text);

                int indiceModificar = -1;

                // Buscar el índice del instrumento a modificar en el arreglo
                for (int i = 0; i < contadorInstrumentos; i++)
                {
                    if (instrumentos[i].Id == idModificar)
                    {
                        indiceModificar = i;
                        break;
                    }
                }

                if (indiceModificar != -1)
                {
                    // Actualizar el resto de la información del instrumento
                    instrumentos[indiceModificar].Nombre = textnombre.Text;
                    instrumentos[indiceModificar].Precio = Convert.ToDouble(textprecio.Text);
                    instrumentos[indiceModificar].Color = textcolor.Text;

                    textmodificar.Text = string.Empty;
                    MostrarInstrumentos();

                    MessageBox.Show("Instrumento modificado correctamente.");
                }
                else
                {
                    textmodificar.Text = string.Empty;
                    MessageBox.Show("Instrumento no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la sección Modificar: " + ex.Message);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dginstrumento.SelectedCells.Count > 0)
            {
                int rowIndex = dginstrumento.SelectedCells[0].RowIndex;

                try
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

                        DataGridViewRow row = dginstrumento.Rows[rowIndex];

                        // Guardar los valores originales antes de modificar

                        string oldNombre = row.Cells["Nombre"].Value.ToString();
                        double oldPrecio = Convert.ToDouble(row.Cells["Precio"].Value);
                        string oldColor = row.Cells["Color"].Value.ToString();

                        // Modificar la fila en el DataGridView
                        row.Cells["Nombre"].Value = textnombre.Text;
                        row.Cells["Precio"].Value = textprecio.Text;
                        row.Cells["Color"].Value = textcolor.Text;

                        MessageBox.Show("Instrumento modificado correctamente.");
                        textnombre.Text = string.Empty;
                        textprecio.Text = string.Empty;
                        textcolor.Text = string.Empty;
                        // Verificar si los datos clave han cambiado
                        if (oldNombre != textnombre.Text || oldPrecio != Convert.ToDouble(textprecio.Text) || oldColor != textcolor.Text)
                        {
                            // No se realiza la eliminación aquí
                            // EliminarInstrumento(oldNombre, oldPrecio, oldColor);
                        }
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
        private void EliminarInstrumento(string nombre, double precio, string color)
        {
            try
            {
                bool encontrado = false;

                for (int i = 0; i < contadorInstrumentos; i++)
                {
                    if (instrumentos[i].Nombre == nombre && instrumentos[i].Precio == precio && instrumentos[i].Color == color)
                    {
                        encontrado = true;

                        for (int j = i; j < contadorInstrumentos - 1; j++)
                        {
                            instrumentos[j] = instrumentos[j + 1];
                        }

                        contadorInstrumentos--;
                        MostrarInstrumentos();
                        MessageBox.Show("Instrumento eliminado correctamente.");
                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("Instrumento no encontrado para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al eliminar el instrumento: " + ex.Message);
            }
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (Nombre.Checked)
            {
                BuscarPorNombre();
            }
            else if (precio.Checked)
            {
                BuscarInstrumento();
            }
            else
            {
                BuscarPorColor();
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

                    int indiceInstrumento = -1;

                    for (int i = 0; i < contadorInstrumentos; i++)
                    {
                        if (instrumentos[i].Id == idEliminar)
                        {
                            indiceInstrumento = i;
                            break;
                        }
                    }

                    if (indiceInstrumento != -1)
                    {
                        for (int i = indiceInstrumento; i < contadorInstrumentos - 1; i++)
                        {
                            instrumentos[i] = instrumentos[i + 1];
                        }

                        contadorInstrumentos--;
                        MostrarInstrumentos();
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

        private void AgregarInstrumento()
        {
            if (contadorInstrumentos < instrumentos.Length)
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
                    try
                    {

                        string nombre = textnombre.Text;
                        double precio = Convert.ToDouble(textprecio.Text);
                        string color = textcolor.Text;

                        MInstrumentos nuevoInstrumento = new MInstrumentos
                        {
                            Id = ++IdClass,
                            Nombre = nombre,
                            Precio = precio,
                            Color = color
                        };

                        instrumentos[contadorInstrumentos] = nuevoInstrumento;
                        contadorInstrumentos++;

                        textnombre.Text = string.Empty;
                        textprecio.Text = string.Empty;
                        textcolor.Text = string.Empty;
                        MostrarInstrumentos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error en la sección precio: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pueden agregar más instrumentos. Límite alcanzado.");
            }
        }

        private void MostrarInstrumentos()
        {
            dginstrumento.Rows.Clear();

            for (int i = 0; i < contadorInstrumentos; i++)
            {
                dginstrumento.Rows.Add(instrumentos[i].Id, instrumentos[i].Nombre, instrumentos[i].Precio, instrumentos[i].Color);
            }
        }

       
        private void BuscarInstrumento()
        {
            try
            {
                string buscar1 = textbuscar.Text;
                if (buscar1 == "")
                {
                    MessageBox.Show("Ingrese Precio a buscar");
                }
                else
                {
                    double precioBuscar = Convert.ToDouble(textbuscar.Text);


                    bool encontrado = false;

                    // Limpiar el DataGridView
                    dginstrumento.Rows.Clear();

                    for (int i = 0; i < contadorInstrumentos; i++)
                    {
                        if (instrumentos[i].Precio == precioBuscar)
                        {
                            encontrado = true;
                            textbuscar.Text = string.Empty;

                            // Mostrar el instrumento encontrado en el DataGridView
                            dginstrumento.Rows.Add(instrumentos[i].Id, instrumentos[i].Nombre, instrumentos[i].Precio, instrumentos[i].Color);
                        }
                    }

                    if (!encontrado)
                    {
                        textbuscar.Text = string.Empty;
                        MessageBox.Show("No se encontraron instrumentos con ese precio.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la sección Buscar: " + ex.Message);
            }

        }

        //private void EliminarInstrumento()
        //{
        //    string eliminarPorId = textelim.Text;
        //    if (eliminarPorId == "")
        //    {
        //        MessageBox.Show("Ingrese un Id para eliminar");
        //    }
        //    else
        //    {

        //        try
        //        {
        //            int idEliminar = Convert.ToInt32(textelim.Text);

        //            int indiceInstrumento = -1;

        //            // Buscar el índice del instrumento a eliminar en el arreglo
        //            for (int i = 0; i < contadorInstrumentos; i++)
        //            {
        //                if (instrumentos[i].Id == idEliminar)
        //                {
        //                    indiceInstrumento = i;
        //                    break;
        //                }
        //            }

        //            if (indiceInstrumento != -1)
        //            {
        //                // Mover los elementos siguientes para eliminar el instrumento
        //                for (int i = indiceInstrumento; i < contadorInstrumentos - 1; i++)
        //                {
        //                    instrumentos[i] = instrumentos[i + 1];
        //                }

        //                contadorInstrumentos--;
        //                MostrarInstrumentos();
        //                textelim.Text = string.Empty;
        //                MessageBox.Show("Instrumento eliminado correctamente.");
        //            }
        //            else
        //            {
        //                textelim.Text = string.Empty;
        //                MessageBox.Show("Instrumento no encontrado.");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Hubo un error en la sección eliminar: " + ex.Message);
        //        }
        //    }
        //}
    
        private void textelim_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textmodificar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void irlistas_Click(object sender, EventArgs e)
        {
            ListasEnlazadas listas = new ListasEnlazadas();
            listas.Show();

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            MostrarInstrumentos();
        }
        private void LimpiarCampos()
        {
            textnombre.Text = string.Empty;
            textprecio.Text = string.Empty;
            textcolor.Text = string.Empty;
            textbuscar.Text = string.Empty;

            // Limpiar la tabla
            dginstrumento.Rows.Clear();

            // Restablecer el arreglo de instrumentos y el contador
            instrumentos = new MInstrumentos[10];
            contadorInstrumentos = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BuscarPorNombre()
        {
            try
            {
                string nombreBuscar = textbuscar.Text;

                if (string.IsNullOrEmpty(nombreBuscar))
                {
                    MessageBox.Show("Ingrese un nombre para buscar.");
                }
                else
                {
                    bool encontrado = false;

                    // Limpiar el DataGridView
                    dginstrumento.Rows.Clear();

                    for (int i = 0; i < contadorInstrumentos; i++)
                    {
                        if (instrumentos[i].Nombre.ToLower() == nombreBuscar.ToLower())
                        {
                            encontrado = true;

                            // Mostrar el instrumento encontrado en el DataGridView
                            dginstrumento.Rows.Add(instrumentos[i].Id, instrumentos[i].Nombre, instrumentos[i].Precio, instrumentos[i].Color);
                        }
                    }

                    if (!encontrado)
                    {
                        MessageBox.Show("No se encontraron instrumentos con ese nombre.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la búsqueda por nombre: " + ex.Message);
            }
        }

        private void precio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void color_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BuscarPorColor()
        {
            try
            {
                string colorBuscar = textbuscar.Text; // Obtener el color a buscar desde el campo de texto

                if (string.IsNullOrEmpty(colorBuscar))
                {
                    MessageBox.Show("Ingrese un color para buscar.");
                }
                else
                {
                    bool encontrado = false;

                    // Limpiar el DataGridView
                    dginstrumento.Rows.Clear();

                    for (int i = 0; i < contadorInstrumentos; i++)
                    {
                        if (instrumentos[i].Color.ToLower() == colorBuscar.ToLower())
                        {
                            encontrado = true;

                            // Mostrar el instrumento encontrado en el DataGridView
                            dginstrumento.Rows.Add(instrumentos[i].Id, instrumentos[i].Nombre, instrumentos[i].Precio, instrumentos[i].Color);
                        }
                    }

                    if (!encontrado)
                    {
                        MessageBox.Show("No se encontraron instrumentos con ese color.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la búsqueda por color: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void Descendente_Click(object sender, EventArgs e)
        {
            OrdenarInstrumentosPorPrecioDescendente();
        }
        private void OrdenarInstrumentosPorPrecioDescendente()
        {
            try
            {
                for (int i = 0; i < contadorInstrumentos - 1; i++)
                {
                    for (int j = i + 1; j < contadorInstrumentos; j++)
                    {
                        if (instrumentos[i].Precio < instrumentos[j].Precio)
                        {
                            MInstrumentos temp = instrumentos[i];
                            instrumentos[i] = instrumentos[j];
                            instrumentos[j] = temp;
                        }
                    }
                }

                // Limpiar el DataGridView
                dginstrumento.Rows.Clear();

                // Mostrar los instrumentos ordenados en el DataGridView
                for (int i = 0; i < contadorInstrumentos; i++)
                {
                    dginstrumento.Rows.Add(instrumentos[i].Id, instrumentos[i].Nombre, instrumentos[i].Precio, instrumentos[i].Color);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al ordenar los instrumentos: " + ex.Message);
            }
        }

        private void Ascendnte_Click(object sender, EventArgs e)
        {
            OrdenarInstrumentosPorPrecioAscendente();
        }
        private void OrdenarInstrumentosPorPrecioAscendente()
{
    try
    {
        for (int i = 0; i < contadorInstrumentos - 1; i++)
        {
            for (int j = i + 1; j < contadorInstrumentos; j++)
            {
                if (instrumentos[i].Precio > instrumentos[j].Precio)
                {
                    MInstrumentos temp = instrumentos[i];
                    instrumentos[i] = instrumentos[j];
                    instrumentos[j] = temp;
                }
            }
        }

        // Limpiar el DataGridView
        dginstrumento.Rows.Clear();

        // Mostrar los instrumentos ordenados en el DataGridView
        for (int i = 0; i < contadorInstrumentos; i++)
        {
            dginstrumento.Rows.Add(instrumentos[i].Id, instrumentos[i].Nombre, instrumentos[i].Precio, instrumentos[i].Color);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Hubo un error al ordenar los instrumentos: " + ex.Message);
    }
}

        private void IrPilas_Click(object sender, EventArgs e)
        {
            Pila pila = new Pila();
            pila.Show();
        }

        private void IrColas_Click(object sender, EventArgs e)
        {
            Colas cola = new Colas();
            cola.Show();
        }
    }
}
