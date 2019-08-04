using MVCProject.Model;
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
    public partial class frmAdicionarEditora : Form
    {
        public frmAdicionarEditora()
        {
            InitializeComponent();
        }

        public Editora editoraRow;
        public MVCProject.SistemaBibliotecaDataSet.EditoraRow EditoraRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            editoraRow = new Editora
            {
                Nome = textBox1.Text,
                Descricao = richTextBox1.Text
            };
            this.Close();
        }
    }
}
