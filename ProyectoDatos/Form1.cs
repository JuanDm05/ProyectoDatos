using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoDatos
{
    public partial class Form1 : Form
    {
        private InstrumentoMusical[] instrumentos = new InstrumentoMusical[10];
        private int contadorInstrumentos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dginstrumento.Columns.Add("Id", "ID");
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
                int id = Convert.ToInt32(textid.Text);
                string nombre = textnombre.Text;
                double precio = Convert.ToDouble(textprecio.Text);
                string color = textcolor.Text;

                InstrumentoMusical nuevoInstrumento = new InstrumentoMusical
                {
                    Id = id,
                    Nombre = nombre,
                    Precio = precio,
                    Color = color
                };

                instrumentos[contadorInstrumentos] = nuevoInstrumento;
                contadorInstrumentos++;

                MostrarInstrumentos();
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
        }

        private void BuscarInstrumento()
        {
        }

        private void EliminarInstrumento()
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
                MessageBox.Show("Instrumento eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Instrumento no encontrado.");
            }
        }

        private void textelim_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

    // Clase que representa un instrumento musical
    public class InstrumentoMusical
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public string Color {  get; set; }
    }

