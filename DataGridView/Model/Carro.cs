using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView.Model
{
    public class Carro
    {
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public int Marca { get; set; }
        public bool Ativo { get; set; } = true;
        public int UsuInc { get; set; }
        public int UsuAlt { get; set; }
        public DateTime datInc { get; set; } = DateTime.Now;
        public DateTime datAlt { get; set; } = DateTime.Now;
    }
}
