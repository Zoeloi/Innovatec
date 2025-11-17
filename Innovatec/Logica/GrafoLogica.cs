using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovatec.Logica
{
    public class GrafoLogica
    {
        private List<Clase.GrafoSimple> edificios; // inicializo grafo 

        public GrafoLogica()
        {
            edificios = new List<Clase.GrafoSimple>();
        }

        // Agregar edificio
        public void AgregarEdificio(string nombre) //agregamos nodos
        {
            edificios.Add(new Clase.GrafoSimple { NombreEdificio = nombre });
        }

        // Conectar edificios
        public void ConectarEdificios(string edificio1, string edificio2, int distancia) // agregamos aristas
        {
            // Conectar edificio1 → edificio2
            var edificioA = edificios.Find(e => e.NombreEdificio == edificio1);
            if (edificioA != null)
            {
                edificioA.EdificiosConectados.Add(edificio2);
                edificioA.Distancias.Add(distancia);
            }

            // Conectar edificio2 → edificio1 
            var edificioB = edificios.Find(e => e.NombreEdificio == edificio2);
            if (edificioB != null)
            {
                edificioB.EdificiosConectados.Add(edificio1);
                edificioB.Distancias.Add(distancia);
            }
        }

        // Calcular ruta esto si esta chatgepeteado eddy se disculpa le falle
        public string CalcularRutaMasCorta(string origen, string destino)
        {
            // Verificar que existen los edificios
            if (!edificios.Any(e => e.NombreEdificio == origen) ||
                !edificios.Any(e => e.NombreEdificio == destino))
            {
                return "Uno de los edificios no existe";
            }

            // Lista para guardar todas las rutas posibles
            var rutasEncontradas = new List<string>();

            // Buscar TODAS las rutas posibles
            BuscarTodasLasRutas(origen, destino, new List<string> { origen }, 0, rutasEncontradas);

            if (rutasEncontradas.Count > 0)
            {
                // Encontrar la ruta más corta
                var rutaMasCorta = rutasEncontradas.OrderBy(r => {
                    // Extraer la distancia del string "A → B → C (200m)"
                    var start = r.LastIndexOf('(') + 1;
                    var end = r.LastIndexOf('m');
                    return int.Parse(r.Substring(start, end - start));
                }).First();

                return rutaMasCorta;
            }

            return "No hay ruta disponible";
        }

        // Método recursivo para buscar rutas
        private void BuscarTodasLasRutas(string actual, string destino, List<string> rutaActual, int distanciaActual, List<string> rutasEncontradas)
        {
            if (actual == destino)
            {
                string ruta = string.Join(" → ", rutaActual) + $" ({distanciaActual}m)";
                rutasEncontradas.Add(ruta);
                return;
            }

            var edificio = edificios.Find(e => e.NombreEdificio == actual);
            if (edificio == null) return;

            for (int i = 0; i < edificio.EdificiosConectados.Count; i++)
            {
                string siguiente = edificio.EdificiosConectados[i];
                int distancia = edificio.Distancias[i];

                if (!rutaActual.Contains(siguiente)) // Evitar ciclos
                {
                    var nuevaRuta = new List<string>(rutaActual) { siguiente };
                    BuscarTodasLasRutas(siguiente, destino, nuevaRuta, distanciaActual + distancia, rutasEncontradas);
                }
            }
        }
    }
}