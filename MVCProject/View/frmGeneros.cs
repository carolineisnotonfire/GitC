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
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarGeneros formAddGen = new frmAdicionarGeneros();
            formAddGen.ShowDialog();
            if (!string.IsNullOrEmpty(formAddGen.generoRow?.Tipo))

                this.generosTableAdapter.InsertQuery(
                formAddGen.generoRow.Tipo,
                formAddGen.generoRow.Descricao
                );
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Generos);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var genSelect = ((System.Data.DataRowView)this.dataGridView1.Rows
            [e.RowIndex]
            .DataBoundItem).Row as MVCProject.SistemaBibliotecaDataSet.GenerosRow;
            switch (e.ColumnIndex)
            {
                case 1:
                    {
                        this.generosTableAdapter.DeleteQuery(genSelect.Id);

                    }
                    break;
                case 2:
                    {
                        frmEditarGeneros editGen = new frmEditarGeneros();
                        editGen.GenerosRow = genSelect;
                        editGen.ShowDialog();
                        this.generosTableAdapter.Update(editGen.GenerosRow);

                    }
                    break;
            }
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Generos);
        }
    }
}
