using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPv1
{
    class Gerente
    {
        public int idGerente { get; set; }
        public string nombre { get; set; }
       
        public Gerente() { }

        public Gerente(int id, string nm)
        {
            idGerente = id;
            nombre = nm;
        }

        public string toString()
        {
            return "Nombre: " + nombre;
        }
        
    }
}