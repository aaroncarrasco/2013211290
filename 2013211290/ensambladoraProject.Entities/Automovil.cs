using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensambladoraProject.Entities
{
    public class Automovil
    {
        TipoAuto TipoAuto;
        Volante _volante;
        Parabrisas _parabrisas;
        Propietario _propietario;
        int numAsiento;
        private Volante volante;
        private Parabrisas parabrisas;
        private int v;
        private Propietario propietario;
        private TipoCarro tipoCarro;

       /* public  Automovil(Volante volante, Parabrisas parabrisas, int numAsientos, Propietario propietario, TipoAuto tipoAuto) {
            TipoAuto= tipoAuto;
             volante= _volante;
            _parabrisas = parabrisas;
            _propietario = propietario;
            numAsiento = numAsientos;
        }*/

        public Automovil(Volante volante, Parabrisas parabrisas, int numAsiento, Propietario propietario)
        {
            this.volante = volante;
            this.parabrisas = parabrisas;
            this.numAsiento = numAsiento;
            this.propietario = propietario;
            //this.tipoCarro = tipoCarro;
        }
    }
}
