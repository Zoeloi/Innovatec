using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatec.Forms
{
    
    public partial class FrmArbol : Form
    {
        private Logica.ArbolLogica logicaArbol = new Logica.ArbolLogica();
        public FrmArbol()
        {
            InitializeComponent();
        }

        

        private void btnContar_Click(object sender, EventArgs e)
        {
            int total = logicaArbol.ContarTotalEmpleados();
            MessageBox.Show($"Total de empleados: {total}");

        }

        

        private void tbnAgregar_Click(object sender, EventArgs e)
        {
            logicaArbol.AgregarEmpleado(tbNombre.Text, tbCargo.Text, tbSupervisor.Text);
            logicaArbol.CargarTreeView(treeView1);
            MessageBox.Show("Empleado agregado");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var empleado = logicaArbol.BuscarEmpleado(tbBuscar.Text);

            // Limpiar el ListBox antes de agregar nuevo resultado
            lbResultados.Items.Clear();

            if (empleado != null)
            {
                // Agregar la info al ListBox
                lbResultados.Items.Add($"Nombre: {empleado.Nombre}");
                lbResultados.Items.Add($"Cargo: {empleado.Cargo}");
                lbResultados.Items.Add($"Supervisor: {empleado.Supervisor}");
                lbResultados.Items.Add(""); // Línea vacía
            }
            else
            {
                lbResultados.Items.Add("Empleado no encontrado");
            }
        }
    }
}
