﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace demo1.Models
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        //-------------------------------------------------------------------------------------------------------

        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        //-------------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        //-------------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [DisplayName("Email-Id")]
        public string Email { get; set; }

        //-------------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
        ErrorMessage = "Password should be between 8 to 10 characters, and contain at least one lowercase letter, one uppercase letter, one numeric digit, and one special character.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //-------------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        public int Age { get; set; }

        //-------------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        //-------------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Phone no. is required")]
        [Phone(ErrorMessage = "Invalid phone no.")]
        [DisplayName("Phone Number")]
        public string PhoneNo { get; set; }

        //-------------------------------------------------------------------------------------------------------

        [JsonIgnore]
        public User User { get; set; }
    }
}