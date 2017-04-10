using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{
    

    class Asiento
    {
        string NumSerie { get; set; }
        Cinturon _cinturon;

        public Asiento() {
            _cinturon = new Cinturon();
        }
    }
}
