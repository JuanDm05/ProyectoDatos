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

        public void Insertar(MInstrumentos mInstrumentos)
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

            // Busca el elemento a modificar y almacena los elementos anteriores en la pila auxiliar
            while (cima != null)
            {
                if (cima.Datos.Id == id)
                {
                    cima.Datos = instrumento;
                    encontrado = true;
                    break;
                }

                pilaAuxiliar.Insertar(Pop());
            }

            // Vuelve a colocar los elementos anteriores en la pila principal
            while (pilaAuxiliar.cima != null)
            {
                Insertar(pilaAuxiliar.Pop());
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
                        pilaAuxiliar.Insertar(auxNodo.Datos);
                        auxNodo = auxNodo.Siguiente;
                    }

                    cima = nodoActual.Siguiente;

                    return auxNodo.Datos;
                }

                pilaAuxiliar.Insertar(nodoActual.Datos);
                nodoActual = nodoActual.Siguiente;

            }
            return null;
        }

        public bool BuscarEliminar(int id)
        {
            Nodo nodoActual = cima;
            Pilas pilaAuxiliar = new Pilas();

            while (nodoActual != null)
            {
                if (nodoActual.Datos.Id == id)
                {
                    Nodo auxNodo = cima;
                    while (auxNodo != nodoActual)
                    {
                        pilaAuxiliar.Insertar(auxNodo.Datos);
                        auxNodo = auxNodo.Siguiente;
                    }

                    cima = nodoActual.Siguiente;

                    return true;
                }

                pilaAuxiliar.Insertar(nodoActual.Datos);
                nodoActual = nodoActual.Siguiente;

            }
            return false;
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


        public bool Eliminar(int id)
        {
            Pilas pilaAuxiliar = new Pilas();

            while (cima != null && cima.Datos.Id != id)
            {
                pilaAuxiliar.Insertar(Pop());
            }

            if (cima != null && cima.Datos.Id == id)
            {
                Pop();
            }

            while (pilaAuxiliar.cima != null)
            {
                Insertar(pilaAuxiliar.Pop());
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
                    Insertar(pilaAuxiliar.Pop());
                }

                pilaAuxiliar.Insertar(temp);
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
                    Insertar(pilaAuxiliar.Pop());
                }

                pilaAuxiliar.Insertar(temp);
            }

            cima = pilaAuxiliar.cima;
        }


    }

}
    
