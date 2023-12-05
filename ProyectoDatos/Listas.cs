using ProyectoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDatos
{
    public class Listas
    {
        public Nodo Primero;
        public Nodo Ultimo;
        public Listas()
        {
            Primero = null;
            Ultimo = null;
        }
        public void LimpiarLista()
        {
            Primero = null; // Establecer el primer nodo como nulo limpia la lista enlazada.
        }
        public void insertarLista(MInstrumentos instrumentos)
        {
            Nodo Nuevo = new Nodo(instrumentos);
            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;

            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
        }
        public string Mostrar()
        {
            Nodo actual = Primero;
            string resultado = "";

            while (actual != null)
            {
                resultado += $"{actual.Datos.Id}, {actual.Datos.Nombre}, {actual.Datos.Precio}, {actual.Datos.Color}\n";
                actual = actual.Siguiente;
            }

            return resultado;
        
        }
        public bool eliminarPorId(int id)
        {
            if (Primero == null)
            {
                return false; // La lista está vacía
            }

            Nodo actual = Primero;
            Nodo anterior = null;

            while (actual != null)
            {
                if (actual.Datos.Id == id)
                {
                    if (anterior != null)
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    else
                    {
                        Primero = actual.Siguiente;
                    }

                    return true; // Elemento encontrado y eliminado
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            return false; // Elemento no encontrado
        }
        public bool modificarPorId(int id, MInstrumentos instrumentoModificado)
        {
            Nodo actual = Primero;

            while (actual != null)
            {
                if (actual.Datos.Id == id)
                {
                    // Si se encuentra el ID, se modifica el instrumento
                    actual.Datos = instrumentoModificado;
                    return true; // Se ha modificado exitosamente
                }

                actual = actual.Siguiente;
            }

            return false; // El ID no se encontró en la lista
        }
        public MInstrumentos BuscarPorNombre(string nombreABuscar)
        {
            Nodo actual = Primero;

            while (actual != null)
            {
                if (actual.Datos.Nombre == nombreABuscar)
                {
                    return actual.Datos; // Devuelve el instrumento si se encuentra por el nombre
                }
                actual = actual.Siguiente;
            }

            return null; // Si no se encuentra, retorna null
        }
        public void insertarAlInicio(MInstrumentos instrumentos)
        {
            Nodo Nuevo = new Nodo(instrumentos);

            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }
        public bool insertarEnMedio(int posicion, MInstrumentos instrumento)
        {
            if (posicion < 0)
                return false; // Posición inválida

            Nodo nuevoNodo = new Nodo(instrumento);
            Nodo actual = Primero;
            Nodo anterior = null;
            int contador = 0;

            // Moverse a la posición deseada o al final de la lista
            while (actual != null && contador < posicion)
            {
                anterior = actual;
                actual = actual.Siguiente;
                contador++;
            }

            if (contador != posicion)
                return false; // La posición excede la longitud actual de la lista

            // Insertar el nuevo nodo en la posición deseada
            if (anterior == null)
            {
                nuevoNodo.Siguiente = Primero;
                Primero = nuevoNodo;
                if (Ultimo == null)
                    Ultimo = Primero;
            }
            else
            {
                nuevoNodo.Siguiente = actual;
                anterior.Siguiente = nuevoNodo;
                if (nuevoNodo.Siguiente == null)
                    Ultimo = nuevoNodo;
            }

            return true; // Elemento insertado correctamente
        }
        public void insertarAlFinal(MInstrumentos instrumento)
        {
            Nodo nuevoNodo = new Nodo(instrumento);

            if (Ultimo == null)
            {
                Primero = nuevoNodo;
                Ultimo = nuevoNodo;
            }
            else
            {
                Ultimo.Siguiente = nuevoNodo;
                Ultimo = nuevoNodo;
            }
        }
        public int ObtenerLongitudLista()
        {
            int longitud = 0;
            Nodo actual = Primero;

            while (actual != null)
            {
                longitud++;
                actual = actual.Siguiente;
            }

            return longitud;
        }

        public int ObtenerPosicionMedio()
        {
            int longitudLista = ObtenerLongitudLista(); // Necesitas implementar este método para obtener la longitud de tu lista
            return longitudLista / 2;
        }

    }

}
