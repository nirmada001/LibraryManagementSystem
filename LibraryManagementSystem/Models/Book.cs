using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [Required]
        public String Title { get; set; }
        
        [Required]
        public String Author { get; set; }

        [Required]
        public String Genre { get; set; }

        public bool IsAvailable { get; set; } = true;
        public DateTime? DueDate { get; set; }
    }
}
