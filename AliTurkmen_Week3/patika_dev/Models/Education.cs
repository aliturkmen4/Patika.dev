using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace patika_dev
{
   
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        [Required]
        public string EducationName { get; set; }
        public int TeacherId { get; set; }
        public virtual Instructor Instructors { get; set; }
        public int AssistantId { get; set; }
        public virtual Assistant Assistants { get; set; }
        public int PartipantsId { get; set; }
        public virtual ICollection<Partipant> Partipants { get; set; }



    }
}
