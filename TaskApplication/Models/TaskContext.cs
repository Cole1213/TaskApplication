using Microsoft.EntityFrameworkCore;

namespace TaskApplication.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }
        
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasKey(t => t.TaskID);

            modelBuilder.Entity<Task>()
                .Property(t => t.TaskID)
                .ValueGeneratedOnAdd();

            // Other configurations...
        }

    }
}
