using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{

    /*
     Se deben crear 4 automóviles y 2 buses, uno por cada tipo que exista. Estos carros
deben estar disponibles para personalizarlos (colocarle numero de motor y numero de
chasis).
▪ Asuma sólo 4 llantas para automóviles y 6 para buses. No considerar la llanta de
repuesto.
▪ Asuma sólo 5 asientos para automóviles y 10 asientos para buses, independiente del
modelo de carro.
▪ El inicio de la personalización sólo involucra agregarle un numero de chasis a cada carro.
El numero de chasis debe ser diferente para cada carro y debe incluir el tipo de carro en
el identificador del Chasis (numero de chasis).
▪ La finalización de la personalización sólo involucra mostrar un reporte de todos los carros
personalizados. El reporte sólo debe contener el tipo de auto y el numero de chasis.
▪ Agregar comentarios en el código fuente si fuera necesario para explicar su programa.
         */
    public class Ensambladora
    {

        List<Carro> _Carros;
        Volante volante;
        Parabrisas parabrisas;
        Propietario propietario;
        TipoAuto tipoauto;

        public Ensambladora()
        {
            _Carros = new List<Carro>();
            volante = new Volante();
            propietario = new Propietario();
            parabrisas = new Parabrisas();
            tipoauto = new TipoAuto();
        }

        public void Agregar(Carro carro)
        {
            if (_Carros.Count == 6)
                return;
            volante.NumSerie = "volante-"; //me tiene que salir esta vaina amor, anda come algo mas
            parabrisas.NumSerie = "parabrisas-";
             //int numAsientos=0;
             var tipoCarro = TipoCarro.automovil.ToString();
            var name = (TipoCarro)Enum.Parse(typeof(TipoCarro), tipoCarro);
            // TipoAuto.Coupe;

            if (tipoCarro ==null) {
                  _Carros.Add(new Automovil(volante, parabrisas, 4, propietario));
              }
              else {
                  //_Carros.Add(new Bus(6));
              }





        }
    }
}
