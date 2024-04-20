using System;

namespace SinemaTakip.Models
{
    public class Seans
    {
        public int FilmId { get; set; }
        public int SalonId { get; set; }
        public string StartTime { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }
    }
}
