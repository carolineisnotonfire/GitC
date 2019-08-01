using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Edicao
{
    public partial class frmEdicaoVendas : Form
    {
        public frmEdicaoVendas()
        {
            InitializeComponent();
        }
        public DataGridView.QuerysInnerJoinDataSet1.VendasRow VendasRow;

        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {

            VendasRow.Carro = Convert.ToInt32 (textBox1.Text);
            VendasRow.Quantidade = Convert.ToInt32 (textBox1.Text);
            VendasRow.Valor = Convert.ToInt32 (textBox1.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VendasRow.Carro = Convert.ToInt32 (textBox1.Text);
            VendasRow.Quantidade = Convert.ToInt32 (textBox1.Text);
            VendasRow.Valor = Convert.ToInt32 (textBox1.Text);

            this.Close();

        }

    }
}
