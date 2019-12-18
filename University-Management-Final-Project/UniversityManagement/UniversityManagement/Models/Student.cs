﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace UniversityManagement.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string RegNo { get; set; } 

        [Required]
        [EmailAddress]
        [Remote("IsEmailExist", "Student", ErrorMessage = "Email already exists!")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid Email")]
        public string Email { set; get; }

        [Required(ErrorMessage = "Contact No is Required")]
        [Phone(ErrorMessage = "Contact No format is Incorrect.")]
        [StringLength(14, MinimumLength = 7, ErrorMessage = "Invalid Phone Number")]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "The Field Date is Required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } 

        
        [Column(TypeName = "varchar")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Field Department is Mandatory.")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}