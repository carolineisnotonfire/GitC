using CadastroAlunos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAlunos
{
    public partial class TeladeCadastro : Form
    {
        public TeladeCadastro()
        {
            InitializeComponent();
        }

        public Alunos novoAluno = new Alunos();


        private void Button1_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = txbNome.Text;
            novoAluno.Idade = (int)numIdade.Value;
            this.Close();
        }

        private void TeladeCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
