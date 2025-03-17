using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContasMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ContasMVC.Data
{
    public class ContasDbContext : DbContext
    {
        public ContasDbContext(DbContextOptions<ContasDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<DespesaModel> Despesas { get; set; }
        public DbSet<ReceitaModel> Receitas { get; set; }


    }
}