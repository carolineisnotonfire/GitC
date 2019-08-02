using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView.Model
{
    public class Venda
    {
        public int Carro { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public bool Ativo { get; set; } = true;
        public int UsuInc { get; set; }
        public int UsuAlt { get; set; }
        public DateTime datInc { get; set; } = DateTime.Now;
        public DateTime datAlt { get; set; } = DateTime.Now;
    }
}
