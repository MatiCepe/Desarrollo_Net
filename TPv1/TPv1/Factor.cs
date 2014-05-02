using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPv1
{
    class Factor
    {
        public int idFactor { get; set; }
        public string nombre { get; set; }

        public Factor(){
        }
        
        public Factor(int id, string nm){
            idFactor = id;
            nombre = nm; 
        }
    }

}
