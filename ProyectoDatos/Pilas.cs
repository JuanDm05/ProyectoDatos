using ProyectoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDatos
{
    public class Pilas
    {
        public Nodo cima;

        public Pilas()
        {
            cima = null;
        }

        public void Apilar(MInstrumentos mInstrumentos)
        {
            Nodo Nuevo = new Nodo(mInstrumentos);
            Nuevo.Siguiente = cima;
            cima = Nuevo;
        }

        public string Mostrar()
        {

            Nodo actual = cima;
            string resultado = "";

            while (actual != null)
            {
                resultado += $"{actual.Datos.Id}, {actual.Datos.Nombre}, {actual.Datos.Precio}, {actual.Datos.Color}\n";
                actual = actual.Siguiente;
            }

            return resultado;
        }


        public bool Modificar(int id, MInstrumentos instrumento)
        {
            Pilas pilaAuxiliar = new Pilas();
            bool encontrado = false;
            // Movemos los datos en auxiliar para no perder los originales

            while (cima != null)
            {
                if (cima.Datos.Id == id)
                {
                    cima.Datos = instrumento;
                    encontrado = true;
                    break;
                }

                pilaAuxiliar.Apilar(Pop());
            }
            // Regresamos los datos
            while (pilaAuxiliar.cima != null)
            {
                Apilar(pilaAuxiliar.Pop());
            }

            return encontrado;

        }

        public MInstrumentos Buscar(string Buscado)
        {
            Nodo nodoActual = cima;
            Pilas pilaAuxiliar = new Pilas();

            while (nodoActual != null)
            {
                if (nodoActual.Datos.Nombre == Buscado)
                {
                    Nodo auxNodo = cima;
                    while (auxNodo != nodoActual)
                    {
                        pilaAuxiliar.Apilar(auxNodo.Datos);
                        auxNodo = auxNodo.Siguiente;
                    }

                    cima = nodoActual.Siguiente;

                    return auxNodo.Datos;
                }

                pilaAuxiliar.Apilar(nodoActual.Datos);
                nodoActual = nodoActual.Siguiente;

            }
            return null;
        }

        public MInstrumentos Pop()
        {
            if (cima == null)
            {
                return null;
            }

            MInstrumentos dato = cima.Datos;
            cima = cima.Siguiente;
            return dato;
        }


        public bool Desapilar(int id)
        {
            Pilas pilaAuxiliar = new Pilas();
            // Buscamos el dato en auxiliar para no perder los originales

            while (cima != null && cima.Datos.Id != id)
            {
                pilaAuxiliar.Apilar(Pop());
            }

            //Si esta entra aqui

            if (cima != null && cima.Datos.Id == id)
            {
                Pop();
            }

            // Regresamos los datos

            while (pilaAuxiliar.cima != null)
            {
                Apilar(pilaAuxiliar.Pop());
            }

            return cima != null;

        }

        public void Limpiar()
        {
            cima = null; 
        }

        public void Ascendente()
        {
            Pilas pilaAuxiliar = new Pilas();

            while (cima != null)
            {
                MInstrumentos temp = Pop();

                while (pilaAuxiliar.cima != null && temp.Precio < pilaAuxiliar.cima.Datos.Precio)
                {
                    Apilar(pilaAuxiliar.Pop());
                }

                pilaAuxiliar.Apilar(temp);
            }

            cima = pilaAuxiliar.cima;
        }

        public void Descendente()
        {
            Pilas pilaAuxiliar = new Pilas();

            while (cima != null)
            {
                MInstrumentos temp = Pop();

                while (pilaAuxiliar.cima != null && temp.Precio > pilaAuxiliar.cima.Datos.Precio)
                {
                    Apilar(pilaAuxiliar.Pop());
                }

                pilaAuxiliar.Apilar(temp);
            }

            cima = pilaAuxiliar.cima;
        }


    }

}
    
