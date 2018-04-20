using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFExampleTwo.DataAccess.DataModels
{
    public class Student
    {
        [Key]
        [Display(Name = "Registration Number")]
        public string StudentId { get; set; }
        [Required]
        [MaxLength(50), MinLength(3)]
        public string StudentName { get; set; }

        [Display(Name = "Joining Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfJoin { get; set; }

        public string Gender { get; set; }

        public bool IsAdmitted { get; set; }

        public string Notes { get; set; }
        public Department Department { get; set; }
    }
}