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
    public partial class frmEditarAutores : Form
    {
        public frmEditarAutores()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.AutoresRow AutoresRow;

        private void FrmEditarAutores_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = AutoresRow.Descricao;
            textBox1.Text = AutoresRow.Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AutoresRow.Descricao = richTextBox1.Text;
            AutoresRow.Nome = textBox1.Text;
            this.Close();
        }
    }
}
