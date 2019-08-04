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
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet1.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.sistemaBibliotecaDataSet1.Usuario);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.sistemaBibliotecaDataSet.Usuario);

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
            this.usuarioTableAdapter.Fill(this.sistemaBibliotecaDataSet.Usuario);
        }
    }
}
