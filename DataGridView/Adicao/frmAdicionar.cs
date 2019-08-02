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

namespace DataGridView
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }
        public Carro CarroRow;

        public DataGridView.QuerysInnerJoinDataSet1.CarrosRow CarrosRow;
        private void Adicionar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CarroRow = new Carro
            {
                Modelo = textBox1.Text,
                Ano = dateTimePicker1.Value,
                Marca = (int)comboBox1.SelectedValue

            };
            this.Close();
        }
    }
}
