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
        public void AgregarEmpleado(string nombre, string cargo,  string supervisor)
        {
            var nuevoEmpleado = new Clase.ArbolOrganizacional
            {
                Nombre = nombre,
                Cargo = cargo,
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

            // Buscar TODOS los empleados que no tienen supervisor 
            var supervisores = empleados.Where(e => string.IsNullOrEmpty(e.Supervisor)).ToList();

            foreach (var supervisor in supervisores)
            {
                TreeNode nodoRaiz = new TreeNode($"{supervisor.Nombre} ({supervisor.Cargo})");
                treeView.Nodes.Add(nodoRaiz);

                // Agregar sus subordinados
                AgregarSubordinados(supervisor, nodoRaiz);
            }

            // Si no hay supervisores, mostrar todos los empleados como raíces
            if (!supervisores.Any()) /// me ayudo la IA
            {
                foreach (var empleado in empleados)
                {
                    TreeNode nodo = new TreeNode($"{empleado.Nombre} ({empleado.Cargo})");
                    treeView.Nodes.Add(nodo);
                }
            }
        }
        private void AgregarSubordinados(Clase.ArbolOrganizacional empleado, TreeNode nodoPadre)
        { //me ayudo la IA
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