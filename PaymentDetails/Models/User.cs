using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demo1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        //------------------------------------------------------
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        [DisplayName("User Name")]
        public string Name { get; set; }
        //------------------------------------------------------

        [Required(ErrorMessage = "Email Id is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string EmailId { get; set; }

        //------------------------------------------------------

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //------------------------------------------------------

        //[Required(ErrorMessage = "Role is required.")]
        //public string Role { get; set; }
    }
}