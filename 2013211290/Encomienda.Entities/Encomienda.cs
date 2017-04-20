using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encomienda.Entities
{
    public class Encomienda
    {
        public int total { get; set; }
        
        public TipoEncomienda TipoEncomienda { get; set; }
        public Encomienda(int total, TipoEncomienda TipoEncomienda)
        {

        }
        static void Main(string[] args)
        {
            Cliente obj = new Cliente(3, 0,0,230,350);
            Encomienda obj1 = new Encomienda(350,0);
           
            Console.WriteLine("El nombre del cliente es " + obj.Nombres);
            Console.WriteLine("El Tipo de encomienda es: " + obj1.TipoEncomienda);
            Console.ReadKey();
           
        }
    }
}
