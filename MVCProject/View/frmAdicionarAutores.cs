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
    public partial class frmAdicionarAutores : Form
    {
        public frmAdicionarAutores()
        {
            InitializeComponent();
        }
        public Autor autorRow;
        public MVCProject.SistemaBibliotecaDataSet.AutoresRow AutoresRow;
        private void FrmAdicionarAutores_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            autorRow = new Autor
            {
                Nome = textBox1.Text,
                Descricao = richTextBox1.Text
            };
            this.Close();
        }
    }
}
