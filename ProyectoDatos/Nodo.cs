using ProyectoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDatos
{
    public class Nodo
    {
        public MInstrumentos Datos { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(MInstrumentos datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }
}
