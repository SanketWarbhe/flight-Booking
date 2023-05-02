using demo1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PaymentDetails.Models
{
    public class BookingDetail
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
        [StringLength(30)]
        public string Source { get; set; }

        //----------------------------------------------------------------

        [Required]
        [StringLength(30)]
        public string Destination { get; set; }
        //----------------------------------------------------------------

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime BookingDateTime { get; set; }

        //-------------------------------------------------------
       

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DepartureTime { get; set; }

        //------------------------------------------------------------

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ArrivalTime { get; set; }

        //------------------------------------------------------------

        [Required]
        [Range(1, int.MaxValue)]
        public int NoOfPassengers { get; set; }
        //----------------------------------------------------

        //[Required]
       
        //[Range(1, int.MaxValue)]
        ////[ForeignKey("SeatNo")]
        //public int SeatNo { get; set; }

        //---------------------------------------------------

        [Required, Range(1, int.MaxValue)]
        public float TotalAmount { get; set; }

        //---------------------------------------------------
        [Required]
        public string BookingStatus { get; set; }

        //----------------------------------------------------------------
        [JsonIgnore]
        public FlightDetail FlightDetails { get; set; }

        [JsonIgnore]
        public IEnumerable<Passenger> Passenger { get; set; }


        //[JsonIgnore]
        //public Seat Seat { get; set; }

    }
}
