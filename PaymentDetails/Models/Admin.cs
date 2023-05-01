using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PaymentDetails.Models
{
    public class Admin
    {
        [Key]

        public int UserId { get; set; }
        //---------------------------------------------------------

        [Required(ErrorMessage = "Name is required")]
        [EmailAddress(ErrorMessage = "Invalid Name")]
        [DisplayName("User Name")]
        public string Name { get; set; }

        //----------------------------------------------------------

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [DisplayName("Email-Id")]
        public string Email { get; set; }

        //---------------------------------------------------------\

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
        ErrorMessage = "Password should be between 8 to 10 characters, and contain at least one lowercase letter, one uppercase letter, one numeric digit, and one special character.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

    }
}
