using DataGridView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Adicao
{
    public partial class frmAdicionarUsuarios : Form
    {
        public frmAdicionarUsuarios()
        {
            InitializeComponent();
        }
        public Usu usuarioRow;
        public DataGridView.QuerysInnerJoinDataSet1.UsuariosRow UsuariosRow;


        private void FrmAdicionarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usuarioRow = new Usu
            {
                Usuario = textBox1.Text
            };
            this.Close();
        }
    }
}
