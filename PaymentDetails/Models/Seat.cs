using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PaymentDetails.Models
{
    public class Seat
    {
        [Key]
        [DisplayName("Seat Number")]
        public int SeatNo { get; set; }

        //----------------------------------------------------------------

        [StringLength(50)]
        [Required(ErrorMessage = "Enter Ticket Class: ")]
        [DisplayName("Seat Class")]
        public string Seatclass { get; set; }

        //------------------------------------------------------------------
        [Required]
        [ForeignKey("BookingId")]
        public int BookingId { get; set; }

        //------------------------------------------------------------------
        [JsonIgnore]
        public BookingDetail BookingDetail { get; set; }
    }
}
