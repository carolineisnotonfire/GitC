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
    public partial class frmLocacoes : Form
    {
        public frmLocacoes()
        {
            InitializeComponent();
        }

        private void FrmLocacoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDataSet.Locacao);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacoes formAddLoc = new frmAdicionarLocacoes();
            formAddLoc.ShowDialog();
            if (formAddLoc.locacaoRow?.Livro > 0)

                this.locacaoTableAdapter.Insert(
                formAddLoc.locacaoRow.Livro,
                formAddLoc.locacaoRow.Usuario,
                formAddLoc.locacaoRow.Tipo,
                formAddLoc.locacaoRow.Devolucao,
                true, 1, 1, DateTime.Now, DateTime.Now
                ) ;
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDataSet.Locacao);
        }
    }
}
