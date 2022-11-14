using LibreriaTransportes.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTransportes.Model.Derivadas
{
    public class Azafata : Tripulacion
    {
        #region constructor
        public Azafata() { }
        public Azafata(string nombre, string apellido) : base(nombre, apellido) { }
        #endregion

        public string MostrarAzafatas(List<Azafata> azafatas)
        {
            string msj = "";
            foreach (var azafata in azafatas)
            {
                msj += $"Nombre : {azafata.Nombre}\nApellido : {azafata.Apellido}\n";
            }
            return msj;
        }
    }
}
