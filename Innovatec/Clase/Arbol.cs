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
       
        public string Supervisor { get; set; } 
        public List<ArbolOrganizacional> Subordinados { get; set; }

        public ArbolOrganizacional()
        {
            Subordinados = new List<ArbolOrganizacional>();
        }
    }
}
// La clase Arbol es como una ficha de cada empleado. Guarda su nombre, cargo y jefe directo. Además, tiene una lista donde se apuntan todos los
// empleados que están bajo su mando.
// Esto permite armar la estructura jerárquica completa de la organización, donde cada jefe tiene registrados a sus subordinados.