using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database
{
    public class eCommerceContext : DbContext
    {
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Contato> Contatos { get; set; } = null!;
        public DbSet<EnderecoEntrega> EnderecoEntregas { get; set; } = null!;
        public DbSet<Departamento> Departamentos { get; set; } = null!;


        #region Conexão sem distinção de ambientes de execução

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = eCommerce; Integrated Security = True;");
        //}

        #endregion
    }
}