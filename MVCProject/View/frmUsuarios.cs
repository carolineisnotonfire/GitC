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
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet1.Usuario);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios formAddUsu = new frmAdicionarUsuarios();
            formAddUsu.ShowDialog();
            if (!string.IsNullOrEmpty(formAddUsu.usuarioRow?.Nome))

                this.usuarioTableAdapter.Insert(
                formAddUsu.usuarioRow.Nome,
                formAddUsu.usuarioRow.Login,
                formAddUsu.usuarioRow.Senha,
                formAddUsu.usuarioRow.Email,
                true, 1, 1, DateTime.Now, DateTime.Now

                );
            this.usuarioTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet1.Usuario);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuSelect = ((System.Data.DataRowView)this.dataGridView1.Rows
            [e.RowIndex]
            .DataBoundItem).Row as MVCProject.SistemaBibliotecaDataSet.UsuarioRow;
            switch (e.ColumnIndex)
            {
                case 1:
                    {
                        this.usuarioTableAdapter.DeleteQuery(usuSelect.Id);

                    }
                    break;
                case 0:
                    {
                        frmEditarUsuarios editUsu = new frmEditarUsuarios();
                        editUsu.UsuarioRow = usuSelect;
                        editUsu.ShowDialog();
                        this.usuarioTableAdapter.Update(editUsu.UsuarioRow);
                
                    }
                    break;
            }
            this.usuarioTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet1.Usuario);
        }
    }
}
