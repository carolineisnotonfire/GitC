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
    public partial class frmEditarGeneros : Form
    {
        public frmEditarGeneros()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.GenerosRow GenerosRow;

        private void FrmEditarGeneros_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = GenerosRow.Descricao;
            textBox1.Text = GenerosRow.Tipo;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GenerosRow.Descricao = richTextBox1.Text;
            GenerosRow.Tipo = textBox1.Text;
            this.Close();
        }
    }
}
