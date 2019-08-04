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
    public partial class frmAdicionarLivros : Form
    {
        public frmAdicionarLivros()
        {
            InitializeComponent();
        }
        public Livro livroRow;
        public MVCProject.SistemaBibliotecaDataSet.LivrosRow LivrosRow;
        private void FrmAdicionarLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaDataSet.Editora);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livroRow = new Livro
            {
                Registro = (int)numericUpDown1.Value,
                Titulo = textBox1.Text,
                Isbn = textBox2.Text,
                Genero = (int) comboBox1.SelectedValue,
                Editora = (int)comboBox2.SelectedValue,
                Sinopse = richTextBox1.Text,
                Observacoes = richTextBox2.Text
                
            };
            this.Close();
        }
    }
}
