using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPv1
{
    class Proyecto
    {
        public int idProyecto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public short caracterizacion{ get; set; }

        public Proyecto() { }

        public Proyecto(int id, string nm, string des, DateTime fe, short carac)
        {
            idProyecto = id;
            nombre = nm;
            descripcion = des;
            fecha = fe;
            caracterizacion = carac;
        }
    }
}
