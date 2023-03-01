using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime Duration { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int MinAge { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Company { get; set; }
        public int LevelOfFear { get; set; }
        public int LevelOfComplexity { get; set; }
        public int Rating { get; set; }
        public string? Logo { get; set; }
        public List<string> ImageGallery { get; set; }

        public Room()
        {
            ImageGallery = new List<string>();
        }
    }
}
