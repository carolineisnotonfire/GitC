using MVCProject.Model;
using MVCProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        public Usuario UsuarioRow;
        private void Button1_Click(object sender, EventArgs e)
        {
            var result = this.usuarioTableAdapter1.LoginQuery(textBox1.Text, textBox2.Text);

            if (result != null)
            {
                Session.user = new Usuario();
                Session.user.Id = (int)result;

                frmPrincipal frmprin = new frmPrincipal();
                frmprin.ShowDialog();
                this.Close();
            }
            else
            {
                //MessageBox.Show("Login inválido!");
                throw new Exception("hehe!");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {   

        }
    }
}
