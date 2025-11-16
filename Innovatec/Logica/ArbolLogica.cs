using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Innovatec.Logica
{
    public class ArbolLogica
    {
        private List<Clase.ArbolOrganizacional> empleados;

        public ArbolLogica()
        {
            empleados = new List<Clase.ArbolOrganizacional>();
        }

        // 1. AGREGAR EMPLEADO
        public void AgregarEmpleado(string nombre, string cargo, string departamento, string supervisor)
        {
            var nuevoEmpleado = new Clase.ArbolOrganizacional
            {
                Nombre = nombre,
                Cargo = cargo,
                Departamento = departamento,
                Supervisor = supervisor
            };
            empleados.Add(nuevoEmpleado);
        }

        // 2. CONTAR EMPLEADOS (Total)
        public int ContarTotalEmpleados()
        {
            return empleados.Count;
        }

        // 3. BUSCAR EMPLEADO
        public Clase.ArbolOrganizacional BuscarEmpleado(string nombre)
        {
            return empleados.FirstOrDefault(e => e.Nombre == nombre);
        }

        // 4. OBTENER TODOS LOS EMPLEADOS (Para el TreeView)
        public List<Clase.ArbolOrganizacional> ObtenerTodosEmpleados()
        {
            return empleados;
        }

        public void CargarTreeView(TreeView treeView)
        {
            treeView.Nodes.Clear();

            var raiz = empleados.FirstOrDefault(e => string.IsNullOrEmpty(e.Supervisor));

            if (raiz != null)
            {
                TreeNode nodeRaiz = new TreeNode($"{raiz.Nombre} ({raiz.Cargo})");  // ← raiz.Nombre
                treeView.Nodes.Add(nodeRaiz);

                AgregarSubordinados(raiz, nodeRaiz);  // ← (raiz, nodeRaiz)
            }
        }  
        private void AgregarSubordinados(Clase.ArbolOrganizacional empleado, TreeNode nodoPadre)
        {
            var subordinados = empleados.Where(e => e.Supervisor == empleado.Nombre).ToList();

            foreach (var sub in subordinados)
            {
                TreeNode nodoHijo = new TreeNode($"{sub.Nombre} ({sub.Cargo})");
                nodoPadre.Nodes.Add(nodoHijo);

                // Llamar recursivamente para los subordinados de este
                AgregarSubordinados(sub, nodoHijo);
            }
        }
    }
}