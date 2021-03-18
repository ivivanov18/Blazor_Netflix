using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Netflix.Models
{
    public static class Requests
    {
        const string BASE_URL = "https://api.themoviedb.org/3";
        const string API_KEY = "066ba2376eda870cdd0e380a7c487b20";

        public static Dictionary<string, string> Urls {get;} = new Dictionary<string, string>()
        {
            {"fetchTrending", $"{BASE_URL}/trending/all/week?api_key={API_KEY}&language=en-US" },
            {"fetchNetflixOriginals", $"{BASE_URL}/discover/tv?api_key={API_KEY}&with_networks=213" },
            {"fetchTopRated", $"{BASE_URL}/movie/top_rated?api_key={API_KEY}&language=en-US" },
            {"fetchActionMovies", $"{BASE_URL}/discover/movie?api_key={API_KEY}&with_genre=28" },
            {"fetchComedyMovies", $"{BASE_URL}/discover/movie?api_key={API_KEY}&with_genre=35" },
            {"fetchHorrorMovies", $"{BASE_URL}/discover/movie?api_key={API_KEY}&with_genre=27" },
            {"fetchRomanceMovies", $"{BASE_URL}/discover/movie?api_key={API_KEY}&with_genre=10749" },
            {"fetchDocumentaries", $"{BASE_URL}/discover/movie?api_key={API_KEY}&with_genre=99" }
        };
    }
}
