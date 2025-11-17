using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovatec.Clase
{
    public class GrafoSimple
    {
        public string NombreEdificio { get; set; }
        public List<string> EdificiosConectados { get; set; }
        public List<int> Distancias { get; set; }

        public GrafoSimple()
        {
            EdificiosConectados = new List<string>();
            Distancias = new List<int>();
        }
    }
}