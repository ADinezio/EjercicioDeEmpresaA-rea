using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTransportes.Model.Base
{
    public abstract class Tripulacion
    { 

        #region contructor
        public Tripulacion() { }
        public Tripulacion(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        #endregion

        #region propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion

        #region metodos
        public string Datos() => $"Nombre : {this.Nombre}\nApellido : {this.Apellido}";
        
        #endregion
    }
}

