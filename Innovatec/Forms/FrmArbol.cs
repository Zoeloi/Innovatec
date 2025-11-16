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
            
            var empleado = logicaArbol.BuscarEmpleado(btnBuscar.Text);

            if (empleado != null)
            {
                MessageBox.Show($"Encontrado: {empleado.Nombre} - {empleado.Cargo}");
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
        }

        

        private void tbnAgregar_Click(object sender, EventArgs e)
        {
            logicaArbol.AgregarEmpleado(tbNombre.Text, tbCargo.Text, tbDepartamento.Text, tbSupervisor.Text);
            logicaArbol.CargarTreeView(treeView1);
            MessageBox.Show("Empleado agregado");
        }
    }
}
