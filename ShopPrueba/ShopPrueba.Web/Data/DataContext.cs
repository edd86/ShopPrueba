namespace ShopPrueba.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using ShopPrueba.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
