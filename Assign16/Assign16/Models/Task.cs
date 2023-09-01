using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assign16.Models
{
    [Table("Task")]
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}
