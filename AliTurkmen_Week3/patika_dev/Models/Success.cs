using System.ComponentModel.DataAnnotations;

namespace patika_dev
{
    public class Success
    {
        [Key]
        public int SuccessId { get; set; }
        [Required]
        public float SuccessStatus { get; set; }
        
        public int AttendanceId { get; set; }
        public Attendance Attendances { get; set; }

    }
}
