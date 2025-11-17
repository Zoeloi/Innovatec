
using Innovatec.Logica;
using System.Windows.Forms;

namespace Innovatec.Forms
{

    public partial class FrmGrafo : Form
    {
        private Logica.GrafoLogica GrafoLogica;

        public FrmGrafo()
        {
            InitializeComponent();
            GrafoLogica = new Logica.GrafoLogica();
        }

        private void btnAgregar_Click(object sender, System.EventArgs e) //Agregamos aqui nodos al grafi
        {
            string nombre = tbNombre.Text;
            if (!string.IsNullOrEmpty(nombre))
            {
                GrafoLogica.AgregarEdificio(nombre);
                lbListaEdificio.Items.Add(nombre);
                tbNombre.Clear();
            }
        }

        private void btnConectar_Click(object sender, System.EventArgs e)
        {
            if (lbListaEdificio.Items.Count < 2)
            {
                MessageBox.Show("Necesitas al menos 2 edificios");
                return;
            }

            string edificio1 = tbEdificio1.Text;
            string edificio2 = tbEdificio2.Text;

            if (int.TryParse(tbDistancia.Text, out int distancia))
            {
                GrafoLogica.ConectarEdificios(edificio1, edificio2, distancia); // conectamos nodos con aristas
                lbConexiones.Items.Add($"{edificio1} → {edificio2} ({distancia}m)");

                tbEdificio1.Clear();
                tbEdificio2.Clear();
                tbDistancia.Clear();
            }
            else
            {
                MessageBox.Show("La distancia debe ser un número");
            }
        }

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            string origen = tbOrigen.Text;
            string destino = tbDestino.Text;

            string ruta = GrafoLogica.CalcularRutaMasCorta(origen, destino);
            MessageBox.Show(ruta, "Ruta Más Corta");
        }
    }
}
