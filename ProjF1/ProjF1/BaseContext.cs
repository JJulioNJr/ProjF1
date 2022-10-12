using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjF1
{
    internal class BaseContext : DbContext
    {
        public BaseContext() : base("Formula1") { }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
    }
}
