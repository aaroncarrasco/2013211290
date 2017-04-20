using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encomienda.Entities
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public Iden iden { get; set; }
        
        public Nombres Nombres { get; set; }

        public Persona()
        {

        }
        public Persona(int PersonaId, Iden iden, Nombres Nombres )
        {
            
        }
    }
}
