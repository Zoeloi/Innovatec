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
            
            foreach (var edificio in edificios)
            {
                if (edificio.NombreEdificio == edificio1)
                {
                    edificio.EdificiosConectados.Add(edificio2);
                    edificio.Distancias.Add(distancia);
                }
            }
        }

        // Calcular ruta esto si esta chatgepeteado eddy se disculpa le falle
        public string CalcularRutaMasCorta(string origen, string destino)
        {
            // Buscar si hay conexión directa
            foreach (var edificio in edificios)
            {
                if (edificio.NombreEdificio == origen)
                {
                    for (int i = 0; i < edificio.EdificiosConectados.Count; i++)
                    {
                        if (edificio.EdificiosConectados[i] == destino)
                        {
                            int distancia = edificio.Distancias[i];
                            return $"{origen} → {destino} ({distancia}m) - Ruta directa";
                        }
                    }
                }
            }

            // Buscar rutas con una escala
            foreach (var edificio in edificios)
            {
                if (edificio.NombreEdificio == origen)
                {
                    foreach (string conexion in edificio.EdificiosConectados)
                    {
                        var edificioConexion = edificios.Find(e => e.NombreEdificio == conexion);
                        if (edificioConexion != null && edificioConexion.EdificiosConectados.Contains(destino))
                        {
                            int dist1 = edificio.Distancias[edificio.EdificiosConectados.IndexOf(conexion)];
                            int dist2 = edificioConexion.Distancias[edificioConexion.EdificiosConectados.IndexOf(destino)];
                            return $"{origen} → {conexion} → {destino} ({dist1 + dist2}m)";
                        }
                    }
                }
            }

            return "No hay ruta disponible";
        }
    }
}