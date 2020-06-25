using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieDatabase
{
    public class Movie
    {
        [Key]
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string Language { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Description { get; set; }
        public double AvgVote { get; set; }
        public int Votes { get; set; }
    }
}
