using Aplicacao_PROVA.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplicacao_PROVA.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { 
        
        }
        public DbSet<VendasModel> Vendas { get; set; }
    }
}
