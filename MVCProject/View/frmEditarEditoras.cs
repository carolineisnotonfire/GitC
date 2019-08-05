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
    public partial class frmEditarEditoras : Form
    {
        public frmEditarEditoras()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.EditoraRow EditoraRow;

        private void FrmEditarEditoras_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = EditoraRow.Descricao;
            textBox1.Text = EditoraRow.Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EditoraRow.Descricao = richTextBox1.Text;
            EditoraRow.Nome = textBox1.Text;
            this.Close();
        }
    }
}
