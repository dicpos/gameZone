using GameZone.API.Models;
using Microsoft.EntityFrameworkCore;


namespace GameZone.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Games> Game {get; set;}
    }
}