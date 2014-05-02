using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPv1
{
    class Valor
    {
        public int idValor{ get; set; }
        public string nombre { get; set; }
        public short influencia{ get; set; }

        public Valor(){
        }

        public Valor(int id, string nm, short influ)
        {
            idValor = id;
            nombre = nm;
            influencia = influ;
        }
    }
}
