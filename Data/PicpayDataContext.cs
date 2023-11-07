using Microsoft.EntityFrameworkCore;
using picpay_desafio.Models;

namespace picpay_desafio.Data
{
    public class PicpayDataContext : DbContext
    {
        public PicpayDataContext(DbContextOptions<PicpayDataContext> options) 
            :base(options){ }
        public DbSet<User> Users { get; set; }
    }
}
