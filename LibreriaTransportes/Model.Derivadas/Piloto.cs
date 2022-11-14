using LibreriaTransportes.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTransportes.Model.Derivadas
{
    public class Piloto : Tripulacion
    {
        public Piloto(string nombre, string apellido) : base(nombre, apellido) { }
    }
}
