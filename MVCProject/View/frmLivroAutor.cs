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
    public partial class frmLivroAutor : Form
    {
        public frmLivroAutor()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.LivrosRow LivrosRow;

        private void FrmLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDataSet.Autores);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDataSet.LivroAutor);
            label1.Text = LivrosRow.Titulo;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.livroAutorTableAdapter.Insert(LivrosRow.Id,
                (int)comboBox1.SelectedValue);

            this.livroAutorTableAdapter.FillBy(this.sistemaBibliotecaDataSet.LivroAutor, LivrosRow.Id);
        }
    }
}
