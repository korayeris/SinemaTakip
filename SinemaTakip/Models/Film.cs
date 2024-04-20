using System;

namespace SinemaTakip.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
