using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace api2.Data.Model
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public required string Name { get; set; }
        public int CurricularYear { get; set; }

        public int Semester { get; set; }



    }
}
