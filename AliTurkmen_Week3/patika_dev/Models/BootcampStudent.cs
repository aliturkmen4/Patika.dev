using System.ComponentModel.DataAnnotations;

namespace patika_dev
{
    public class BootcampStudent
    {
        public BootcampStudent()
        {
        }

        [Key]
        public int BootcampStudentId { get; set; }
        [Required]
        public int StudentId { get; set; }
        public virtual Student Students { get; set; }
        [Required]
        public int EducationId { get; set; }
        public virtual Education Educations { get; set; }
        

    }
}
