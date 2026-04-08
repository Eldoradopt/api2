using System.ComponentModel.DataAnnotations;

namespace api2.Data.Model
{
    public class Student : Myuser
    {
        public int StudentNumber { get; set; }

        [DataType(DataType.Currency)]
        public decimal TuitionFee { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
