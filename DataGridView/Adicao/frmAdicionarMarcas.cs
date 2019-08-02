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
    public partial class frmAdicionarMarcas : Form
    {
        public frmAdicionarMarcas()
        {
            InitializeComponent();
        }
        public Marca marcasRow;

        public DataGridView.QuerysInnerJoinDataSet1.MarcasRow MarcasRow;

        private void FrmAdicionarMarcas_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            marcasRow = new Marca
            {
                Nome = textBox1.Text
            };
            this.Close();
        }
    }
}
