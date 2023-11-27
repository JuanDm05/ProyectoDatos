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
    }
}