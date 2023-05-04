using System.ComponentModel.DataAnnotations;

namespace ComplexModelbinding.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Instructor Teacher { get; set; }
    }
}
