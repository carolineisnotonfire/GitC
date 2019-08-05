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
    public partial class frmAdicionarGeneros : Form
    {
        public frmAdicionarGeneros()
        {
            InitializeComponent();
        }

        public Genero generoRow;
       
        private void Button1_Click(object sender, EventArgs e)
        {
            generoRow = new Genero
            {
                
                Tipo = textBox1.Text,
                Descricao = richTextBox1.Text

            };
            this.Close();
        }

        private void FrmAdicionarGeneros_Load(object sender, EventArgs e)
        {

        }
    }
}
