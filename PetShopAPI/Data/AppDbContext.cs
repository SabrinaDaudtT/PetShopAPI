using Microsoft.EntityFrameworkCore;
using PetShopAPI.Models;
using System.Security.Cryptography.X509Certificates;

namespace PetShopAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }
        
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Atendimento> Atendimento { get; set; }
            public DbSet<Funcionario> Funcionario { get; set; }
            public DbSet<Orcamento> Orcamento { get; set; }
            public DbSet<Pet> Pet { get; set; }
            public DbSet<Pet_Raca> Pet_Raca { get; set; }
            public DbSet<Pet_Tipo> Pet_Tipo { get; set; }
            public DbSet<PetCliente> PetCliente { get; set; }
            public DbSet<Servicos_Banho> Servicos_Banho { get; set; }
    }
}

