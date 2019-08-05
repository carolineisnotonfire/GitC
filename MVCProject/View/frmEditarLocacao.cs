using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmEditarLocacao : Form
    {
        public frmEditarLocacao()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.LocacaoRow LocacaoRow;

        private void FrmEditarLocacao_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = LocacaoRow.Livro;
            comboBox2.SelectedValue = LocacaoRow.Usuario;
            comboBox3.SelectedValue = LocacaoRow.Tipo;
            dateTimePicker1.Value = LocacaoRow.Devolucao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LocacaoRow.Livro = (int)comboBox1.SelectedValue;
            LocacaoRow.Usuario = (int)comboBox2.SelectedValue;
            LocacaoRow.Tipo = (int)comboBox3.SelectedValue;
            LocacaoRow.Devolucao = dateTimePicker1.Value;
            this.Close();
        }
    }
}
