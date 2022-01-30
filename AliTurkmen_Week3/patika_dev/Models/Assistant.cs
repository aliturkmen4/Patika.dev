
using System.ComponentModel.DataAnnotations;


namespace patika_dev
{
    public class Assistant 
    {
        [Key]
        public int AssistantId { get; set; }
        [Required]
        public string AssistantName { get; set; }

        public string AssistantSurname { get; set; }

    }
}
