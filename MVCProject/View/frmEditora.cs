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
    public partial class frmEditora : Form
    {
        public frmEditora()
        {
            InitializeComponent();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaDataSet.Editora);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarEditora formAddEdi = new frmAdicionarEditora();
            formAddEdi.ShowDialog();
            if (!string.IsNullOrEmpty(formAddEdi.editoraRow?.Nome))

                this.editoraTableAdapter.Insert(
                formAddEdi.editoraRow.Nome,
                formAddEdi.editoraRow.Descricao
                );
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaDataSet.Editora);
        }
    }
}
