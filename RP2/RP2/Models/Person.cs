using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RP2.Models
{
    public enum SexType
    { 
        Female=0,
        Male=1
    }
    public class Person
    {
        [Key]
        [Range(1,999)]
        public int PersonId { get; set; }
        [Required]
        [StringLength(60,ErrorMessage ="Debe ser un nombre entre 3 y 60 caracteres",MinimumLength =3)]
        public string Name { get; set; }
        public int CovidCount { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Cumpleaños")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
        public SexType Sex { get; set; }

    }
}