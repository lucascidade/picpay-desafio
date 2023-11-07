using Microsoft.EntityFrameworkCore;

namespace picpay_desafio.Data
{
    public class PicpayDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source ./Data/picpay_desafio.db");
        }
        public DbSet<User> Users { get; set; }
    }
}
