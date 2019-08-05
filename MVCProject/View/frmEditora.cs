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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ediSelect = ((System.Data.DataRowView)this.dataGridView1.Rows
            [e.RowIndex]
            .DataBoundItem).Row as MVCProject.SistemaBibliotecaDataSet.EditoraRow;
            switch (e.ColumnIndex)
            {
                case 1:
                    {
                        frmEditarEditoras editEdi = new frmEditarEditoras();
                        editEdi.EditoraRow = ediSelect;
                        editEdi.ShowDialog();
                        this.editoraTableAdapter.Update(editEdi.EditoraRow);

                    }
                    break;
            }
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaDataSet.Editora);
        }
    }
}
