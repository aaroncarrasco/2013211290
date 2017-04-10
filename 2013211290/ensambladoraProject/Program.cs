using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ensambladoraProject.Entities;
using System.Threading;
namespace ensambladoraProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Ensambladora ensambladora = new Ensambladora();
            Parabrisas parabrisas = new Parabrisas();
            Volante volante = new Volante();
            Propietario propietario = new Propietario();
            volante.NumSerie = "volante-";
            parabrisas.NumSerie = "para-";
            propietario.DNI = "";
            var a =TipoCarro.automovil;
            var a1 = a.ToString();
            var name = (TipoCarro)Enum.Parse(typeof(TipoCarro), a1);

            // Carro carro = new Carro(volante, parabrisas,4,propietario,name);
            Carro carros= new Carro();
            //carros = new Carro(volante, parabrisas, 4,5, propietario,);
            //carros.NumSerieChasis = Console.ReadLine();
            ensambladora.Agregar( carros);



        }
    }
}
