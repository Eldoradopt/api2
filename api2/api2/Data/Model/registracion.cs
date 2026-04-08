using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace api2.Data.Model
{
    [PrimaryKey(nameof(StudentFK), nameof(CourseFK))]
    public class Registracion
    {
        //
        public DateTime RegistrationDate { get; set; }
        
        //[Key]
        public int StudentFK { get; set; }
        public Student Student { get; set; }

       // [Key]
        public int CourseFK { get; set; }
        public Course Course { get; set; }
    }
}
