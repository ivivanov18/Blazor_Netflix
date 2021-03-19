using Blazor_Netflix.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Netflix.Components
{
    public partial class Banner
    {
        const string BASE_URL = "https://image.tmdb.org/t/p/original";

        [Parameter]
        public string MovieCategoryFetchUrl { get; set; }

        public Movie? DisplayMovie { get; private set; }
        public string BackgroundImgUrl => DisplayMovie != null ? $"{BASE_URL}{DisplayMovie?.Backdrop_Path}" : string.Empty;


    }
}
