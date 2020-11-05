using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Age")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "age must be numeric")]
        public string Age { get; set; }

        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Please Enter Valid Phone number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "age must be numeric")]
        [Required]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required]
        public string Email { get; set; }
    }
}
