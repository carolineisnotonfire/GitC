using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm frmUsu= new frm();
            frmUsu.ShowDialog();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores frmAut = new frmAutores();
            frmAut.ShowDialog();
        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros frmGen = new frmGeneros();
            frmGen.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros frmLiv = new frmLivros();
            frmLiv.ShowDialog();
        }

        private void LocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacoes frmLoc = new frmLocacoes();
            frmLoc.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditora frmEdi = new frmEditora();
            frmEdi.ShowDialog();
        }
    }
}
