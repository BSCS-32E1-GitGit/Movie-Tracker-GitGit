using System;
using System.Collections.Generic;

namespace movie_tracker.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public string MovieInfo { get; set; }
        public string Genre { get; set; }
        public List<string> Cast { get; set; }
        public string ImageUrl { get; set; }
    }
}