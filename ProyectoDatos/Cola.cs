using ProyectoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDatos
{
    public class Cola
    {
        public Nodo Principio;
        public Nodo Final;

        public Cola()
        {
            Principio = null;
            Final = null;
        }

        public bool ColaVacia()
        {
            return Principio == null;
        }


        public void Encolar(MInstrumentos instrumento)
        {
            Nodo nuevoNodo = new Nodo(instrumento);

            if (Final == null)
            {
                Principio = nuevoNodo;
                Final = nuevoNodo;
            }
            else
            {
                Final.Siguiente = nuevoNodo;
                Final = nuevoNodo;
            }
        }

        public MInstrumentos Pop()
        {
            if (Principio == null)
            {
                return null;
            }

            MInstrumentos dato = Principio.Datos;
            Principio = Principio.Siguiente;

            if (Principio == null)
            {
                Final = null;
            }

            return dato;
        }

        public bool Desencolar(int id)
        {
            Cola colaAuxiliar = new Cola();
            bool encontrado = false;

            while (Principio != null)
            {
                MInstrumentos actual = Pop();

                if (actual.Id == id)
                {
                    encontrado = true;
                }
                else
                {
                    colaAuxiliar.Encolar(actual);
                }
            }

            while (!colaAuxiliar.ColaVacia())
            {
                Encolar(colaAuxiliar.DesencolarBuscar());
            }

            return encontrado;
        }


        public MInstrumentos DesencolarBuscar()
        {
            if (ColaVacia())
            {
                return null;
            }

            MInstrumentos datoDesencolado = Principio.Datos;
            Principio = Principio.Siguiente;

            if (Principio == null)
            {
                Final = null;
            }
            // Movemos los datos en auxiliar para no perder los originales
            Cola colaAuxiliar = new Cola();
            while (Principio != null)
            {
                colaAuxiliar.Encolar(DesencolarBuscar());
            }
            // Regresamos los datos

            while (!colaAuxiliar.ColaVacia())
            {
                Encolar(colaAuxiliar.DesencolarBuscar());
            }

            return datoDesencolado;
        }

        public string Mostrar()
        {
            string resultado = "";
            if (ColaVacia())
            {
                return null;
            }

            Cola colaAuxiliar = new Cola();


            while (!ColaVacia())
            {
                MInstrumentos actual = DesencolarBuscar();
                colaAuxiliar.Encolar(actual);

                resultado += $"{actual.Id}, {actual.Nombre}, {actual.Precio}, {actual.Color}\n";
            }

            while (!colaAuxiliar.ColaVacia())
            {
                Encolar(colaAuxiliar.DesencolarBuscar());
            }

            return resultado;
        }

        public MInstrumentos Buscar(string buscado)
        {
            Cola colaAuxiliar = new Cola();
            MInstrumentos instrumentoEncontrado = null;
            // Movemos los datos en auxiliar para no perder los originales
            while (!ColaVacia())
            {
                MInstrumentos instrumentoActual = DesencolarBuscar();
                colaAuxiliar.Encolar(instrumentoActual);

                if (instrumentoActual.Nombre == buscado)
                {
                    instrumentoEncontrado = instrumentoActual;
                    break; 
                }
            }

            // Regresamos los datos
            while (!colaAuxiliar.ColaVacia())
            {
                Encolar(colaAuxiliar.DesencolarBuscar());
            }

            return instrumentoEncontrado;
        }

        public bool Modificar(int id, MInstrumentos nuevoInstrumento)
        {
            bool encontrado = false;

            // Guardar datos en auxiliar para no perder los datos
            Cola colaAuxiliar = new Cola();

            while (!ColaVacia())
            {
                MInstrumentos instrumentoActual = DesencolarBuscar();

                if (instrumentoActual.Id == id)
                {
                    encontrado = true;
                    instrumentoActual = nuevoInstrumento;
                }

                colaAuxiliar.Encolar(instrumentoActual);
            }

            // Regresamos los datos
            while (!colaAuxiliar.ColaVacia())
            {
                Encolar(colaAuxiliar.DesencolarBuscar());
            }

            return encontrado;
        }

        public void Limpiar()
        {
            Principio = null;
            Final = null;
        }

        public void Ascendente()
        {
            if (ColaVacia() || Principio == Final)
            {
                return;
            }

            Cola colaAuxiliar = new Cola();

            while (!ColaVacia())
            {
                MInstrumentos actual = DesencolarBuscar();

                while (!colaAuxiliar.ColaVacia() && actual.Id < colaAuxiliar.Principio.Datos.Id)
                {
                    Encolar(colaAuxiliar.DesencolarBuscar());
                }

                colaAuxiliar.Encolar(actual);
            }

            while (!colaAuxiliar.ColaVacia())
            {
                Encolar(colaAuxiliar.DesencolarBuscar());
            }
        }

        public void Descendente()
        {
            if (ColaVacia() || Principio == Final)
            {
                return;
            }

            Cola colaAuxiliar = new Cola();

            while (!ColaVacia())
            {
                MInstrumentos actual = DesencolarBuscar();

                while (!colaAuxiliar.ColaVacia() && actual.Id > colaAuxiliar.Principio.Datos.Id)
                {
                    Encolar(colaAuxiliar.DesencolarBuscar());
                }

                colaAuxiliar.Encolar(actual);
            }

            while (!colaAuxiliar.ColaVacia())
            {
                Encolar(colaAuxiliar.DesencolarBuscar());
            }
        }

    }


}
