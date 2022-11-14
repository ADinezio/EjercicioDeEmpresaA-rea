using LibreriaTransportes.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTransportes.Model.Derivadas
{
    public class Helicoptero:Transporte
    {
        public Helicoptero(int capacidad, int velocidad, double costo,int aspas, Piloto piloto, Copiloto copiloto) : base(capacidad, velocidad, costo)
        {
            if (capacidad > 3) this.Capacidad = 1;
            else this.Capacidad = capacidad;
            this.Aspas = aspas;
            this.Piloto = piloto;
            this.Copiloto = copiloto;
        }


        #region propiedades
        public int Aspas { get; set; }
        public Piloto Piloto { get; set; }
        public Copiloto Copiloto { get; set; }
        #endregion

        public override string despegar()
        {
            if (this.Velocidad > 160) return "Llegop a velocidad crucero";

            return base.despegar();
        }

        
    }
}
