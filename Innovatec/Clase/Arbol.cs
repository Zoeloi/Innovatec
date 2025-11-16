using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovatec.Clase
{
    public class ArbolOrganizacional
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string Supervisor { get; set; } // Jefe directo
        public List<ArbolOrganizacional> Subordinados { get; set; }

        public ArbolOrganizacional()
        {
            Subordinados = new List<ArbolOrganizacional>();
        }
    }
}
