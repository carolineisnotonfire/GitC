using CadastrodeLanches.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrodeLanches
{
    public partial class TeladeCadastro : Form
    {
        public TeladeCadastro()
        {
            InitializeComponent();
        }

        private void TeladeCadastro_Load(object sender, EventArgs e)
        {

        }
        public Lanche novoLanche = new Lanche();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoLanche.Nome = tbxNome.Text;
            novoLanche.Quantidade = (int)nrQuant.Value;
            novoLanche.Valor = double.Parse(tbxValor.Text);

            this.Close();
        }
    }
}
