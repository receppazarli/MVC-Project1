using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad gereklidir.")]
        public string Name { get; set; }
        public string Surname { get; set; }

        [Required(ErrorMessage = "Tc Kimlik No eksik olamaz.")]
        [DisplayName("Türkiye Cumhuriyeti Kimlik Numarası")]
        [MinLength(11, ErrorMessage = "11 karakterden kısa olamaz.")]
        [MaxLength(11, ErrorMessage = "11 karakterden uzun olamaz.")]
        public string IdentityNumber { get; set; }
        public string DepartmentName { get; set; }
        public int EntryYear { get; set; }

    }
}