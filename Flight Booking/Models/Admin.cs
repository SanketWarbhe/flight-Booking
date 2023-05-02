using demo1.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PaymentDetails.Models
{
    public class Admin
    {
        [Key]

        public int AdminId { get; set; }
        //---------------------------------------------------------
        [ForeignKey("FlightId")]
        public int FlightId { get; set; }
        //---------------------------------------------------------
        
        [Required(ErrorMessage = "Name is required")]
        [DisplayName("Admin Name")]
        public string Name { get; set; }

        //----------------------------------------------------------

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [DisplayName("Email-Id")]
        public string Email { get; set; }

        //---------------------------------------------------------

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
        ErrorMessage = "Password should be between 8 to 10 characters, and contain at least one lowercase letter, one uppercase letter, one numeric digit, and one special character.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //---------------------------------------------------------

        [JsonIgnore]
        public FlightDetail FlightDetail { get; set; }

    }
}
