using DataGridView.Edicao;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marSelect = ((System.Data.DataRowView)this.dataGridView1.Rows
            [e.RowIndex]
             .DataBoundItem).Row as DataGridView.QuerysInnerJoinDataSet1.MarcasRow;
            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.marcasTableAdapter.DeleteQuery(marSelect.Id);

                    }
                    break;
                case 1:
                    {
                        frmEdicaoMarcas editMarca = new frmEdicaoMarcas();

                        editMarca.MarcasRow = marSelect;
                        editMarca.ShowDialog();
                        this.marcasTableAdapter.Update(editMarca.MarcasRow);
                    }
                    break;

            }
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);

        }
    }
}