using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTransportes.Model.Base
{
    public abstract class Transporte
    {
        #region constructor
        public Transporte(int capacidad, int velocidad, double costo)
        {
            this.Capacidad = capacidad;
            this.Velocidad = velocidad;
            this.Costo = costo;
        }

        #endregion

        #region propiedades
        public int Capacidad { get; set; }
        public int Velocidad { get; set; }
        public double Costo { get; set; }
        #endregion

        #region metodos
        public string msj()
        {
            return $"Capacidad : {this.Capacidad}\nVelocidad : {this.Velocidad}\nCosto : {this.Costo}";
        }

        public virtual string despegar(string valor)
        {
            string msj = "";
            if (valor.ToUpper() == "PISTA") msj = "Despegando !";
            else msj = "Hasta que no se solicite pista no se puede despegar !";

            return msj;
        }

        public virtual string despegar()
        {
            return "Despegando !";
        }
        public virtual string aterrizar(string valor)
        {
            string msj = "";
            if (valor.ToUpper() == "PISTA") msj = "Aterrizando !";
            else msj = "Hasta que no se solicite pista no se puede aterrizar !";

            return msj;
        }
        public virtual string aterrizar()
        {
            return "Aterrizando";
        }

        #endregion

    }
}
