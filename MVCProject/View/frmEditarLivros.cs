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
    public partial class frmEditarLivros : Form
    {
        public frmEditarLivros()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.LivrosRow LivrosRow;

        private void FrmEditarLivros_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = LivrosRow.Registro;
            textBox1.Text = LivrosRow.Titulo;
            textBox2.Text = LivrosRow.Isbn;
            comboBox1.SelectedValue = LivrosRow.Genero;
            comboBox2.SelectedValue = LivrosRow.Editora;
            richTextBox1.Text = LivrosRow.Sinopse;
            richTextBox2.Text = LivrosRow.Observacoes;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LivrosRow.Registro =(int) numericUpDown1.Value;
            LivrosRow.Titulo = textBox1.Text;
            LivrosRow.Isbn = textBox2.Text;
            LivrosRow.Genero = (int)comboBox1.SelectedValue;
            LivrosRow.Editora = (int)comboBox2.SelectedValue;
            LivrosRow.Sinopse = richTextBox1.Text;
            LivrosRow.Observacoes = richTextBox2.Text;
            this.Close();
        }
    }
}
