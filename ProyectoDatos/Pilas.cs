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
        public Nodo Primero;

        public Pilas()
        {
            Primero = null;
        }

        public void Insertar(MInstrumentos mInstrumentos)
        {
            Nodo Nuevo = new Nodo(mInstrumentos);
            Nuevo.Siguiente = Primero;
            Primero = Nuevo;
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


        public bool Modificar(int id, MInstrumentos instrumento)
        {
            Nodo Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    if (Actual.Datos.Id == id)
                    {
                        Actual.Datos = instrumento;
                        return true;
                    }
                    Actual = Actual.Siguiente;
                }

            }
            return false;

        }

        public MInstrumentos Buscar(string Buscado)
        {
            Nodo Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    if (Actual.Datos.Nombre == Buscado)
                    {
                        return Actual.Datos;
                    }
                    Actual = Actual.Siguiente;
                }

            }
                return null;
            
        }

        public bool Eliminar(int id)
        {
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

    }

}
    
