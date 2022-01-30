using System.ComponentModel.DataAnnotations;

namespace patika_dev
{
    public class Student {

        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }

        public string StudentSurname { get; set; }


    }
}
