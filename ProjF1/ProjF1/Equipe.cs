using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjF1
{
    internal class Equipe
    {
        [Key()]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? UltimoAnoCampeao { get; set; }

        public override string ToString()
        {
            return  $"Nome: {this.Nome}" +
                    $"\nUltimo Campeonato: {this.UltimoAnoCampeao}";
        }
    }
}
