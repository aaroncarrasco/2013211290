using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encomienda.Entities
{
    public class Agencia
    {
        public Departamento Departamento { get; set; }
        public string NomA { get; set; }
        public List<Encomienda> _Encomienda;
        public List<Encomienda> Encomienda { get; set; }
        
        public Agencia(List<Encomienda> encomienda)
        {
            Departamento = new Departamento();
            Encomienda = encomienda;
        }

    }
}
