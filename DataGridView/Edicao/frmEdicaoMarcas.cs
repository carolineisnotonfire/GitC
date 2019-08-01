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
    public partial class frmEdicaoMarcas : Form
    {
        public frmEdicaoMarcas()
        {
            InitializeComponent();
        }

        public DataGridView.QuerysInnerJoinDataSet1.MarcasRow MarcasRow;

        private void FrmEdicaoMarcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet1.Marcas);

            textBox1.Text = MarcasRow.Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MarcasRow.Nome = textBox1.Text;
            this.Close();

        }


        


    }
}
