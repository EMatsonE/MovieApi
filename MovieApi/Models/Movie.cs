using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Models
{
    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string poster { get; set; }
        public string plot { get; set; }
        public List<Actor> cast { get; set; }
    }
}
