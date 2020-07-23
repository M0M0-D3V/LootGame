using LootGame.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LootGame.Data
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(_configuration["ConnectionString"]);
        }
        public DbSet<User> Users { get; set; }
    }
}