using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Netflix.Models
{
    public class MovieDBAPiResponse
    {
        public int Page { get; set; }
        public List<Movie> results { get; set; }
    }
}
