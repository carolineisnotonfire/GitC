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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDataSet.Autores);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarAutores formAddAut = new frmAdicionarAutores();
            formAddAut.ShowDialog();
            if (!string.IsNullOrEmpty(formAddAut.autorRow?.Nome))

                this.autoresTableAdapter.Insert(
                formAddAut.autorRow.Nome,
                formAddAut.autorRow.Descricao
                );
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDataSet.Autores);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autSelect = ((System.Data.DataRowView)this.dataGridView1.Rows
            [e.RowIndex]
            .DataBoundItem).Row as MVCProject.SistemaBibliotecaDataSet.AutoresRow;
            switch (e.ColumnIndex)
            {
                case 2:
                    {
                        this.autoresTableAdapter.DeleteQuery(autSelect.Id);
                    }
                    break;
                case 1:
                   {
                       frmEditarAutores editAut = new frmEditarAutores();
                        editAut.AutoresRow = autSelect;
                        editAut.ShowDialog();
                       this.autoresTableAdapter.Update(editAut.AutoresRow);
                
                   }
                   break;
            }
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDataSet.Autores);
        }
    }
}
