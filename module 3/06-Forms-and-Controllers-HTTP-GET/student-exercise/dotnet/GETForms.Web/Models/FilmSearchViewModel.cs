using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class FilmSearchViewModel
    {
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public string Genre { get; set; }

        public List<string> AvailableGenres { get; set; }

        public List<Film> Films = new List<Film>();

        public List<SelectListItem> Genres = new List<SelectListItem>();

        public void PopulateGenresDropdown(string genre)
        {
            Genres.Add(new SelectListItem() { Text = genre, Value = genre });    
        }

        
    }
}
