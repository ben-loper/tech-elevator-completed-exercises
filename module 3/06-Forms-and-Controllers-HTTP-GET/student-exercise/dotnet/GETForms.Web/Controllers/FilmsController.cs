using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class FilmsController : Controller
    {
        private IFilmDAL _filmDal;

        private FilmSearchViewModel _filmSearchModel;

        public FilmsController(IFilmDAL filmDal)
        {
            _filmDal = filmDal;

            _filmSearchModel = new FilmSearchViewModel();

            IList<string> genres = _filmDal.GetGenres();

            foreach (string genre in genres)
            {
                _filmSearchModel.PopulateGenresDropdown(genre);
            }
        }

        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(_filmSearchModel);
        }

        /// <summary>
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(string genre, int minLength = 0, int maxLength = 1000 )
        {
            _filmSearchModel.Films.Clear();

            IList<Film> films = _filmDal.GetFilmsBetween(genre, minLength, maxLength);

            _filmSearchModel.Films.AddRange(films);

            return View(_filmSearchModel);
        }
        
    }
}