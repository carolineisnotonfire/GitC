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
    public partial class frmEditarUsuarios : Form
    {
        public frmEditarUsuarios()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.UsuarioRow UsuarioRow;

        private void FrmEditarUsuarios_Load(object sender, EventArgs e)
        {
            textBox1.Text = UsuarioRow.Nome;
            textBox2.Text = UsuarioRow.Login;
            textBox3.Text = UsuarioRow.Senha;
            textBox4.Text = UsuarioRow.Email;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UsuarioRow.Nome = textBox1.Text;
            UsuarioRow.Login = textBox2.Text;
            UsuarioRow.Senha = textBox3.Text;
            UsuarioRow.Email = textBox4.Text;
            this.Close();
        }
    }
}
