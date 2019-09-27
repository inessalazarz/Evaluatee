using System;
using System.ComponentModel.DataAnnotations;

namespace webEval.Models
{
    public enum SexType
    {
        masculino,
        femenino
    }
    public class Eval
    {
            [Key]
            public int StudentId { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime BirthDate { get; set; }
            [Required]
            public SexType Type { get; set; }
            
        }

}