using Microsoft.EntityFrameworkCore;

namespace TaskApplication.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }    
    }
}
