using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PaymentDetails.Models
{
    public class PaymentDetail
    {   
        [Key]
        [DisplayName("Payment ID")]
        public int PaymentId { get; set; }

        //----------------------------------------

        [Required]
        [ForeignKey("BookingID")]
        [DisplayName("Booking ID")]
        public int BookingId { get; set; }

        //------------------------------------------

        [Required]
        [DisplayName("Payment Date/Time")]
        public DateTime PaymentDateTime { get; set; }

        //--------------------------------------------

        [Required(ErrorMessage = "Enter Payment Method")]
        [DisplayName("Payment Method")]
        public string? PaymentMethod { get; set; }

        //--------------------------------------------

        [Required(ErrorMessage = "Enter payment status.")]
        [DisplayName("Payment Status")]
        public string? PaymentStatus { get; set; }


        //-----------------------------------------------

        [Required(ErrorMessage = "Enter total amount.")]
        [DisplayName("Total Amount")]
        public int TotalAmount { get; set; }

        //-------------------------------------------------
        [JsonIgnore]
        public BookingDetail BookingDetails { get; set; }
    }

}
