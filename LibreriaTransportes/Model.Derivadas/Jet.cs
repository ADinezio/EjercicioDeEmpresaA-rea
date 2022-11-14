using LibreriaTransportes.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace LibreriaTransportes.Model.Derivadas
{
    public class Jet : Transporte
    {
        #region constructor
        public Jet(int capacidad, int velocidad, double costo,Piloto piloto,Copiloto copiloto,List<Azafata> azafatas) : base(capacidad, velocidad, costo)
        {
            if (capacidad > 5) this.Capacidad = 1;
            else Capacidad = capacidad;
            this.Piloto=piloto;
            this.Copiloto = copiloto;
            this.Azafatas=azafatas;

        }
        #endregion

        public Piloto Piloto { get; set; }
        public Copiloto Copiloto { get; set; }

        public Azafata Azafata=new Azafata();

        public List<Azafata> Azafatas { get; set; }

        #region Metodos


        public string datosTripulacion()
        {
            string msj = "";
            if (Azafatas.Count > 0) msj = $"Piloto\n{Piloto.Datos()}\nCopiloto\n{Copiloto.Datos()}\nAzafatas\n{Azafata.MostrarAzafatas(Azafatas)}\nPasajeros\n{Capacidad}";
            else msj = $"Piloto\n{Piloto.Datos()}\nCopiloto\n{Copiloto.Datos()}\nPasajeros\n{Capacidad}";
            return msj;
        }

        public string mantenimiento () {

            quitarAzafata();
            return "En mantenimiento !";
        }

        public string agregarAzafata(Azafata azafata)
        {
            Azafatas.Add(azafata);
            return $"Nombre : {azafata.Nombre}\nApellido : {azafata.Apellido}";
        }
        public void quitarAzafata()
        {
            foreach (var azafata in Azafatas)
            {
                azafata.Nombre = null;
                azafata.Apellido = null;
            }
        }
        #endregion

        
    }
}
