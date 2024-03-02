
using SQLitePCL;

namespace TaskApplication.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private TaskContext _taskContext;
        public EFTaskRepository(TaskContext temp) 
        {
            _taskContext = temp;
        }

        public List<Task> Tasks => _taskContext.Tasks.ToList();

        public void AddTask(Task task)
        {
            _taskContext.Tasks.Add(task);
            _taskContext.SaveChanges();
        }
    }
}
