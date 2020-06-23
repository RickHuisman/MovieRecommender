using System;
using CsvHelper.Configuration.Attributes;

namespace MovieRecommender
{
    public class Movie
    {
        [Index(0)]
        public int ReleaseYear { get; set; }
        [Index(1)]
        public string Title { get; set; }
        [Index(2)]
        public string Origin { get; set; }
        [Index(3)]
        public string Director { get; set; }
        [Index(4)]
        public string Cast { get; set; }
        [Index(5)]
        public string Genre { get; set; }
        [Index(6)]
        public string WikiPage { get; set; }
        [Index(7)]
        public string Plot { get; set; }
    }
}
