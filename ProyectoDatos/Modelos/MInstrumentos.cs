using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDatos.Modelos
{
    public class MInstrumentos
    {
        private int Id = 0;

        public int GetId
        {
            get { return ++Id; }
        }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Color {  get; set; }
    }
}
