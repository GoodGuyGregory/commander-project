using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        // properties
        [Key]
        public int Id { get; set;}
        
        // add data annotations
        [Required]
        [MaxLength(150)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }

        
    }
}