using System;

namespace SinemaTakip.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int SalonId { get; set; }
        public string StartTime { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
