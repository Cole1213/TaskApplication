namespace TaskApplication.Models
{
    public class Task
    {
        public int TaskID { get; set; }

        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }

        public int Quadrant { get; set; }

        public int Category { get; set; }

        public int CompletionStatus { get; set; }
    }
}
