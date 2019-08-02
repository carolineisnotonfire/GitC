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
    public partial class frmAdicionarVendas : Form
    {
        public frmAdicionarVendas()
        {
            InitializeComponent();
        }
        public Venda vendaRow;
        public DataGridView.QuerysInnerJoinDataSet1.VendasRow VendasRow;

        private void FrmAdicionarVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            vendaRow = new Venda
            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = int.Parse(textBox1.Text),
                Valor = int.Parse(textBox2.Text)

            };
            this.Close();
        }
    }
}
