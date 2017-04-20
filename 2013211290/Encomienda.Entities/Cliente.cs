using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encomienda.Entities
{
    public class Cliente:Persona
    {
        public int Sueldo { get; set; }
        public List<Encomienda> Encomienda;
        
        public Cliente(int PersonaId,Iden iden, Nombres Nombres, int Sueldo,int total )
            :base(PersonaId, iden, Nombres)
        {
            this.Sueldo = Sueldo;
            Encomienda = new List<Encomienda>(total);
            
        }
    }
}
