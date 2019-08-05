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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivros formAddLiv = new frmAdicionarLivros();
            formAddLiv.ShowDialog();
            if (!string.IsNullOrEmpty(formAddLiv.livroRow?.Titulo))

                this.livrosTableAdapter.Insert(
                formAddLiv.livroRow.Registro,
                formAddLiv.livroRow.Titulo,
                formAddLiv.livroRow.Isbn,
                formAddLiv.livroRow.Genero,
                formAddLiv.livroRow.Editora,
                formAddLiv.livroRow.Sinopse,
                formAddLiv.livroRow.Observacoes,
                true, 1, 1, DateTime.Now, DateTime.Now

                );
            this.livrosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Livros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livSelect = ((System.Data.DataRowView)this.dataGridView1.Rows
            [e.RowIndex]
            .DataBoundItem).Row as MVCProject.SistemaBibliotecaDataSet.LivrosRow;
            switch (e.ColumnIndex)
            {
                case 1:
                    {
                        this.livrosTableAdapter.DeleteQuery(livSelect.Id);

                    }
                    break;
                    case 2:
                        {
                            frmEditarLivros editLic = new frmEditarLivros();
                        editLic.LivrosRow = livSelect;
                        editLic.ShowDialog();
                            this.livrosTableAdapter.Update(editLic.LivrosRow);
                    
                        }
                        break;
            }
            this.livrosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Livros);
        }
    }
}
