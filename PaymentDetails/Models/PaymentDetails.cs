using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentDetails.Models
{
    public class PaymentDetails
    {   `
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Payment ID")]
        public int PaymentId { get; set; }

        //----------------------------------------

        [Required]
        [ForeignKey("BookingDetails")]
        [DisplayName("Booking ID")]
        public int BookingId { get; set; }

        //------------------------------------------

        //[Required(ErrorMessage = "Enter Payment Date & Time")]
        //[DisplayName("Payment Date/Time")]
        //public DateTime PaymentDateTime { get; set; }

        //--------------------------------------------

        [Required(ErrorMessage = "Enter Payment Method")]
        [DisplayName("Payment Method")]
        public string PaymentMethod { get; set; }

        //--------------------------------------------

        //[Required(ErrorMessage = "Enter payment status.")]
        [DisplayName("Payment Status")]
        public string PaymentStatus { get; set; }


        //-----------------------------------------------

        [Required(ErrorMessage = "Enter total amount.")]
        [DisplayName("Total Amount")]
        public int TotalAmount { get; set; }

        //-------------------------------------------------
        //public virtual BookingDetails BookingDetails { get; set; }
    }

}
