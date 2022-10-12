using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjF1
{
    internal class Carro
    {
        [Key()]
        public int Id { get; set; }
        public string Nome { get; set; }
        [ForeignKey("Equipe")]
        public int EquipeId { get; set; }
        public virtual Equipe Equipe { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome}" +
                    $"\nEquipe: {this.Equipe.ToString()}";
                 
        }

    }
}
