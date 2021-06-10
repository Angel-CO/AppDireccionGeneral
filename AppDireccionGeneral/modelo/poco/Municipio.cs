using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDireccionGeneral.modelo.poco
{
    class Municipio
    {
        private int idMunicipio;
        private String nombre;

        public int IdMunicipio { get => idMunicipio; set => idMunicipio = value; }
        public String Nombre { get => nombre; set => nombre = value; }
    }
}
