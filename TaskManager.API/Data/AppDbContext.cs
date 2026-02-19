using Microsoft.EntityFrameworkCore;
using TaskManager.Models.Entities;

namespace TaskManager.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TaskStatusLookup> TaskStatuses { get; set; }

    }
}