﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFExampleTwo.DataAccess.DataModels
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}