using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mac_Movie_Store.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime ReleasedTime { get; set; }

        public string Genre{ get; set; }
        public int NumberOfCopy { get; set; }

    }
}