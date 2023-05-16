using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EFCoreBasics.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfRegistration { get; set; } = DateTime.UtcNow.AddHours(5.3);

    }
}
