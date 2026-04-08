namespace api2.Data.Model
{
    public class Professors : Myuser
    {
        public ICollection<Course> Courses { get; set; }
    }
}
