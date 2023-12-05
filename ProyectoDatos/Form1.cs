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
        private MInstrumentos[] instrumentos; // Elimina la inicialización aquí
        private int contadorInstrumentos = 0;
        private int cantidadInstrumentos = 0;
        private bool arregloInicializado = false; // Bandera para controlar la inicialización


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
            if (radioButtonInicio.Checked)
            {
                AgregarInstrumentoAlInicio();
            }
            else if (radioButtonMedio.Checked)
            {
                InsertarEnMedio();
            }
            else if (radioButtonFinal.Checked)
            {
                InsertarAlFinal();
            }
            else if (radioButtonDefault.Checked)
            {
                AgregarInstrumento();
            }
            else if (radioButtonFinal.Checked == false && radioButtonFinal.Checked == false && radioButtonMedio.Checked == false && radioButtonInicio.Checked == false && Nombre.Checked == false && precio.Checked == false && color.Checked == false)
                
            {
                AgregarInstrumento();
            }

            else if (radioButtonFinal.Checked == false && radioButtonFinal.Checked == false && radioButtonMedio.Checked == false && radioButtonInicio.Checked == false)
            {
                MessageBox.Show("No puedes guardar mediante parametros de busqueda");
                textnombre.Text = string.Empty;
                textprecio.Text = string.Empty;
                textcolor.Text = string.Empty;
            }
        }
        private void InsertarAlFinal()
        {
            if (instrumentos == null || instrumentos.Length == 0)
            {
                MessageBox.Show("El arreglo no tiene espacio para insertar campos.");
                return;
            }
            if (contadorInstrumentos < instrumentos.Length)
            {
                string[] temp = new string[3];
                temp[0] = textnombre.Text;
                temp[1] = textprecio.Text;
                temp[2] = textcolor.Text;

                if (temp[0] == "" || temp[1] == "" || temp[2] == "")
                {
                    MessageBox.Show("No deje ningún espacio vacío");
                }
                else
                {
                    try
                    {
                        string nombre = textnombre.Text;
                        double precio = Convert.ToDouble(textprecio.Text);
                        string color = textcolor.Text;

                        // Inserta el nuevo instrumento al final del arreglo
                        MInstrumentos nuevoInstrumento = new MInstrumentos
                        {
                            Id = ++IdClass,
                            Nombre = nombre,
                            Precio = precio,
                            Color = color
                        };

                        instrumentos[contadorInstrumentos] = nuevoInstrumento; // Inserta al final
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

        private void ModificarInstrumento()
        {
            try
            {
                int idModificar = Convert.ToInt32(textmodificar.Text);

                bool encontrado = false;

                for (int i = 0; i < contadorInstrumentos; i++)
                {
                    if (instrumentos[i].Id == idModificar)
                    {
                        encontrado = true;

                        string newNombre = textnombre.Text;
                        string newPrecioText = textprecio.Text;
                        string newColor = textcolor.Text;

                        // Validar si se han introducido datos en los campos requeridos
                        if (string.IsNullOrWhiteSpace(newNombre) || string.IsNullOrWhiteSpace(newPrecioText) || string.IsNullOrWhiteSpace(newColor))
                        {
                            MessageBox.Show("Por favor, complete todos los campos para modificar el instrumento.");
                            return;
                        }

                        // Validar el nuevo precio antes de la conversión
                        if (!double.TryParse(newPrecioText, out double newPrecio))
                        {
                            MessageBox.Show("Ingrese un precio válido para modificar el instrumento.");
                            return;
                        }

                        // Actualizar los datos del instrumento
                        instrumentos[i].Nombre = newNombre;
                        instrumentos[i].Precio = newPrecio;
                        instrumentos[i].Color = newColor;

                        // Mostrar los instrumentos actualizados
                        MostrarInstrumentos();

                        MessageBox.Show("Instrumento modificado correctamente.");
                        textmodificar.Text = string.Empty;
                        textnombre.Text = string.Empty;
                        textprecio.Text = string.Empty;
                        textcolor.Text = string.Empty;

                        break;
                    }
                }

                if (!encontrado)
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
            try
            {
                if (dginstrumento.SelectedCells.Count > 0)
                {
                    int rowIndex = dginstrumento.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dginstrumento.Rows[rowIndex];

                    int idModificar = Convert.ToInt32(row.Cells["ID"].Value);

                    // Asignar el ID al campo de modificación (si se desea)
                    textmodificar.Text = idModificar.ToString();

                    ModificarInstrumento();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar modificar el instrumento: " + ex.Message);
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
            if (instrumentos == null || instrumentos.Length == 0)
            {
                MessageBox.Show("El arreglo no tiene espacio para insertar campos.");
                return;
            }

            if (contadorInstrumentos < instrumentos.Length)
            {
                string[] temp = new string[3];
                temp[0] = textnombre.Text;
                temp[1] = textprecio.Text;
                temp[2] = textcolor.Text;

                if (temp.Any(string.IsNullOrEmpty))
                {
                    MessageBox.Show("Por favor, complete todos los campos para agregar un instrumento.");
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
                        MessageBox.Show("Hubo un error al agregar el instrumento: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pueden agregar más instrumentos. Límite alcanzado.");
            }
        }

        private void InsertarEnMedio()
        {
            if (instrumentos == null || instrumentos.Length == 0)
            {
                MessageBox.Show("El arreglo no tiene espacio para insertar campos.");
                return;
            }
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

                        // Verifica si el arreglo tiene un número par o impar de elementos
                        int posicionMedia = contadorInstrumentos / 2;

                        // Desplaza los elementos a la derecha desde la posición media hacia el final
                        for (int i = contadorInstrumentos; i > posicionMedia; i--)
                        {
                            instrumentos[i] = instrumentos[i - 1];
                        }

                        // Inserta el nuevo instrumento en la posición media del arreglo
                        MInstrumentos nuevoInstrumento = new MInstrumentos
                        {
                            Id = ++IdClass,
                            Nombre = nombre,
                            Precio = precio,
                            Color = color
                        };

                        instrumentos[posicionMedia] = nuevoInstrumento; // Inserta en la posición media
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

        private void AgregarInstrumentoAlInicio()
        {
            if (instrumentos == null || instrumentos.Length == 0)
            {
                MessageBox.Show("El arreglo no tiene espacio para insertar campos.");
                return;
            }
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

                        // Desplaza los elementos existentes hacia la derecha para hacer espacio para el nuevo elemento
                        for (int i = contadorInstrumentos; i > 0; i--)
                        {
                            instrumentos[i] = instrumentos[i - 1];
                        }

                        // Agrega el nuevo instrumento en la posición inicial del arreglo
                        MInstrumentos nuevoInstrumento = new MInstrumentos
                        {
                            Id = ++IdClass,
                            Nombre = nombre,
                            Precio = precio,
                            Color = color
                        };

                        instrumentos[0] = nuevoInstrumento; // Agrega al inicio
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

        private void txtlong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLongitudGuardar_Click(object sender, EventArgs e)
        {
            if (!arregloInicializado) // Verifica si el arreglo aún no ha sido inicializado
            {
                if (int.TryParse(txtlong.Text, out cantidadInstrumentos))
                {
                    instrumentos = new MInstrumentos[cantidadInstrumentos];
                    arregloInicializado = true; // Cambia el estado de la bandera
                    MessageBox.Show($"Se creó un arreglo de instrumentos con la cantidad de {cantidadInstrumentos} elementos.");
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido para la cantidad de instrumentos.");
                }
            }
            else
            {
                txtlong.Text = string.Empty;

                MessageBox.Show($"El tamaño del arreglo ya ha sido especificado ({cantidadInstrumentos}).");
            }
        }

      

        private void radioButtonInicio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMedio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFinal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDefault_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close(); // Cierra la ventana actual

        }
    } 
}
