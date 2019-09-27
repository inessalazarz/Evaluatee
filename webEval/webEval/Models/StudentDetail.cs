using System.ComponentModel.DataAnnotations;

namespace webEval.Models
{
    public enum StateType
    {
        Aprobado,
        Reprobado
    }
    public class StudentDetail
    {
        [Key]
        public int DetailId { get; set; }
        public int StudentId { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal Grade { get; set; }
        public StateType Type { get; set; }
    }
}