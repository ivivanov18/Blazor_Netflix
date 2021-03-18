using Blazor_Netflix.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Blazor_Netflix.Components
{
    public partial class Row
    {
        [Parameter] public string Title { get; set; }
        [Parameter] public string FetchUrl { get; set; }
        private List<Movie> movies;
    }
}
