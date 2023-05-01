using demo1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentDetails.Models
{
    public class BookingDetails
    {
        [Key]
        public int BookingId { get; set;}
        //---------------------------------------------------------------

        [Required]
        [ForeignKey("FlightId")]
        public string FlightId { get; set;}

        //-------------------------------------------------------------
        [Required]
        [ForeignKey("PassengerId")]
        public string PassengerId { get; set; }

        //----------------------------------------------------------------

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime BookingDateTime { get; set; }

        //-------------------------------------------------------

        [Required]
        [Range(1, int.MaxValue)]
        public int NoOfPassengers { get; set; }
        //----------------------------------------------------

        [Required]
        [Range(1, int.MaxValue)]
        [ForeignKey("SeatNo")]
        public int SeatNo { get; set; }


         //---------------------------------------------------
        [Required]
        public string? Status { get; set; }

        //----------------------------------------------------------------

        public FlightDetails FlightDetails { get; set; }

        public Passenger Passenger { get; set; }

        public PaymentDetails PaymentDetails { get; set; }  

    }
}
