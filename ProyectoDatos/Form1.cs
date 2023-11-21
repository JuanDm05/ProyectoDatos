using ProyectoDatos.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoDatos
{
    public partial class Form1 : Form
    {
        private MInstrumentos[] instrumentos = new MInstrumentos[10];
        private int contadorInstrumentos = 0;
        private int contador = 0;

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
                string prueba = Convert.ToString(textprecio.Text);
                if (prueba != "")
                {

                    string nombre = textnombre.Text;
                    double precio = Convert.ToDouble(textprecio.Text);
                    string color = textcolor.Text;

                    MInstrumentos nuevoInstrumento = new MInstrumentos
                    {
                        Id = ++contador,
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
                else
                {
                    MessageBox.Show("El campo precio esta vacio");
                }

            }
            else if(contadorInstrumentos > instrumentos.Length) 
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
            if(dginstrumento.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dginstrumento.SelectedRows[0].Index;
                string nuevoNombre = textnombre.Text;
                double nuevoPrecio = Convert.ToDouble(textprecio.Text);
                string nuevoColor = textcolor.Text;

                instrumentos[indiceSeleccionado].Nombre = nuevoNombre;
                instrumentos[indiceSeleccionado].Precio = nuevoPrecio;
                instrumentos[indiceSeleccionado].Color = nuevoColor;

                MostrarInstrumentos();

            }
        }

        private void BuscarInstrumento()
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

                    // Mostrar el instrumento encontrado en el DataGridView
                    dginstrumento.Rows.Add(instrumentos[i].Id, instrumentos[i].Nombre, instrumentos[i].Precio, instrumentos[i].Color);
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron instrumentos con ese precio.");
            }
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
            else if (indiceInstrumento != -1) 
            {
                MessageBox.Show("Instrumento no encontrado.");
            }

        }

        private void textelim_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


