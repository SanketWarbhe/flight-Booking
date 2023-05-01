using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PaymentDetails.Models
{
    public class Seat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Seat Number")]
        public int SeatNo { get; set; }

        //----------------------------------------------------------------

        [StringLength(50)]
        [Required(ErrorMessage = "Enter Ticket Class: ")]
        [DisplayName("Ticket Class")]
        public string Ticketclass { get; set; }

        //------------------------------------------------------------------
    }
}
