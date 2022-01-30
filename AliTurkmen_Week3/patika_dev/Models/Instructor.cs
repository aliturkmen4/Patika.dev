using System.ComponentModel.DataAnnotations;


namespace patika_dev
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        [Required]
        public string InstructorName { get; set; }

        public string InstructorSurname { get; set; }

    }
}
