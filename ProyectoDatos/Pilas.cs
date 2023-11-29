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
        public Nodo Cima;

        public Pilas()
        {
            Cima = null;
        }

        public void LimpiarPila()
        {
            Cima = null; // Establecer la cima como nulo limpia la pila.
        }

        public void InsertarPila(MInstrumentos instrumento)
        {
            Nodo Nuevo = new Nodo(instrumento);
            Nuevo.Siguiente = Cima;
            Cima = Nuevo;
        }

        public string Mostrar()
        {
            Nodo actual = Cima;
            string resultado = "";

            while (actual != null)
            {
                resultado += $"{actual.Datos.Id}, {actual.Datos.Nombre}, {actual.Datos.Precio}, {actual.Datos.Color}\n";
                actual = actual.Siguiente;
            }

            return resultado;
        }

        public bool Eliminar()
        {
            if (Cima == null)
            {
                return false; // La pila está vacía
            }

            Cima = Cima.Siguiente;
            return true; // Elemento en la cima eliminado
        }

        public bool Modificar(MInstrumentos nuevoInstrumento)
        {
            if (Cima != null)
            {
                // Si la pila no está vacía, se modifica el instrumento en la cima
                Cima.Datos = nuevoInstrumento;
                return true; // Se ha modificado exitosamente
            }

            return false; // La pila está vacía, no se puede modificar
        }

        public MInstrumentos BuscarPorNombre(string nombreABuscar)
        {
            Nodo actual = Cima;

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
    }

}
    
