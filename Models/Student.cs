using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models
{
    public class Student
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }
        public string Faculty { get; set; } 
    }
}
