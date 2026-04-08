using System.ComponentModel.DataAnnotations;

namespace api2.Data.Model
{
    public class Degree
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Logotype { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
