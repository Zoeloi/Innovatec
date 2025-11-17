using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Innovatec.Forms;
namespace Innovatec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArbol frm = new FrmArbol();
            frm.Show();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrafo frm = new FrmGrafo();
            frm.Show();
        }
    }
}
