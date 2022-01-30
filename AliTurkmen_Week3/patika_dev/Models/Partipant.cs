using System.ComponentModel.DataAnnotations;

namespace patika_dev
{
    public class Partipant
    {
        [Key]
        public int PartipantId { get; set; }
        [Required]
        public string PartipantName { get; set; }

        public string APartipantSurname { get; set; }
    }
}
