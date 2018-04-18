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
        public string StudentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string StudentName { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public Department Department { get; set; }
    }
}