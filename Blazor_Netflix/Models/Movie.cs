using System;

namespace Blazor_Netflix.Models
{
    public class Movie
    {
        private const string BASE_URL = "https://image.tmdb.org/t/p/original/";
        public string Name { get; set; }
        public string Poster_Path { get; set; }
        public string Backdrop_Path { get; set; }
        public string Overview { get; set; }
        public string Full_Poster_Path => $"{BASE_URL}{Poster_Path}";
    }
}
