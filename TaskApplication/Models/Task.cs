using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskApplication.Models
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }

        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }

        public int Quadrant { get; set; }

        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }

        public int CompletionStatus { get; set; }
    }
}
