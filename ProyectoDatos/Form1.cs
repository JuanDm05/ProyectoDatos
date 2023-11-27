using ProyectoDatos.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoDatos
{
    public partial class Form1 : Form
    {
        int IdClass = 0;
        int buscar = 0;
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            ModificarInstrumento();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarInstrumento();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EliminarInstrumento();
        }

        private void AgregarInstrumento()
        {
            if (contadorInstrumentos < instrumentos.Length)
            {
                string [] temp = new string[3];
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
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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

        private void ModificarInstrumento()
        {

            //int idModificar = IdClass;
            string Excepcion = textmodificar.Text;
            if (Excepcion == "")
            {
                MessageBox.Show("Ingrese una id");
            }
            else
            {

                string temp = textmodificar.Text;
                buscar = Convert.ToInt32(temp);
                int idModificar = buscar;
                string modificar = Convert.ToString(IdClass);

                bool encontrado = false;
                // Buscar el índice del instrumento a modificar en el arreglo
                for (int i = 0; i < contadorInstrumentos; i++)
                {
                    if (instrumentos[i].Id == idModificar)
                    {

                        // Actualizar el resto de la información del instrumento
                        instrumentos[i].Nombre = textnombre.Text;
                        instrumentos[i].Precio = Convert.ToDouble(textprecio.Text);
                        instrumentos[i].Color = textcolor.Text;

                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
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
        }
        private void BuscarInstrumento()
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

        private void EliminarInstrumento()
        {
            string eliminarPorId = textelim.Text;
            if (eliminarPorId == "")
            {
                MessageBox.Show("Ingrese un Id para eliminar");
            }
            else
            {


                int idEliminar = Convert.ToInt32(textelim.Text);

                int indiceInstrumento = -1;

                // Buscar el índice del instrumento a eliminar en el arreglo
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
                    // Mover los elementos siguientes para eliminar el instrumento
                    for (int i = indiceInstrumento; i < contadorInstrumentos - 1; i++)
                    {
                        instrumentos[i] = instrumentos[i + 1];
                    }

                    contadorInstrumentos--;
                    MostrarInstrumentos();
                    textelim.Text = string.Empty;
                    MessageBox.Show("Instrumento eliminado correctamente.");
                }
                else
                {
                    textelim.Text = string.Empty;
                    MessageBox.Show("Instrumento no encontrado.");
                }
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
    }
}


