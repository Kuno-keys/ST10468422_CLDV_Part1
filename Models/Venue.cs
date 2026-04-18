namespace ST10468422_CLDV_Part1.Models;
using System.ComponentModel.DataAnnotations;

public class Venue
{
    public int VenueId { get; set; }

    [Required]
    public string Name { get; set; }

    public string Location { get; set; }

    [Range(1, int.MaxValue)]
    public int Capacity { get; set; }

    public string ImageUrl { get; set; }

    public List<Event> Events { get; set; }
}
