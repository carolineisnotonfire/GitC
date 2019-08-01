using DataGridView.Edicao;
using DataGridView.QuerysInnerJoinDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);

        }
        
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var venSelect = ((System.Data.DataRowView)this.dataGridView1.Rows
            [e.RowIndex]
             .DataBoundItem).Row as DataGridView.QuerysInnerJoinDataSet1.VendasRow;
            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(venSelect.Id);

                    }
                    break;
                case 1:
                    {
                        frmEdicaoVendas editVendas = new frmEdicaoVendas
                        {
                            VendasRow = venSelect
                        };
                        editVendas.ShowDialog();
                        this.vendasTableAdapter.Update(editVendas.VendasRow);
                    }
                    break;

            }
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);

        }
    }
}
