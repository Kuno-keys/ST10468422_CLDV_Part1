namespace ST10468422_CLDV_Part1.Models;
using System.ComponentModel.DataAnnotations;

public class Booking
{
    public int BookingId { get; set; }

    [Required]
    public string CustomerName { get; set; }

    [Range(1, int.MaxValue)]
    public int NumberOfTickets { get; set; }

    public DateTime BookingDate { get; set; }

    public int EventId { get; set; }
    public Event Event { get; set; }
}
