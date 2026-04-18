namespace ST10468422_CLDV_Part1.Models;
using System.ComponentModel.DataAnnotations;

public class Event
{
    public int EventId { get; set; }

    [Required]
    public string Name { get; set; }

    public DateTime Date { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public int VenueId { get; set; }
    public Venue Venue { get; set; }

    public List<Booking> Bookings { get; set; }
}
