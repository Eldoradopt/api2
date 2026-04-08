using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace api2.Data.Model
{
    public class Myuser
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        [Required]
        [MaxLength(17)]
        public required string CellPhone { get; set; }

        [MaxLength(50)]
        public string? UserID { get; set; }
    }
}