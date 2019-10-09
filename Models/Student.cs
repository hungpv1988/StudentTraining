﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace StudentMVC.Models
{
    public enum Gender
    {
        Male,
        Female,
    }
    public class Student
    {
        public int ID { get; set; }

        [Required, StringLength(60, MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public virtual string FullName { get { return $"{FirstName} {LastName}"; } }

        [Required, DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DoB { get; set; }

        public Gender Gender { get; set; }

        //public string Address { get; set; }

        //public string AvatarImage { get; set; }
    }

}