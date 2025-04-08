using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace eCommerce.API.Database
{
    public class eCommerceContext : DbContext
    {

        #region Conexão sem distinção de ambientes de execução

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = eCommerce; Integrated Security = True;");
        //}

        #endregion
    }
}