using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {
        private IReviewDAO _reviewDAO;

        public HomeController(IReviewDAO reviewDAO)
        {
            _reviewDAO = reviewDAO;
        }

        // GET: Home
        public ActionResult Index()
        {
            IList<Review> reviews = _reviewDAO.GetAllReviews();
            return View(reviews);
        }

        [HttpGet]
        public ActionResult NewReview()
        {
            Review review = new Review();
            return View(review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewReview(Review newReview)
        {
            newReview.ReviewDate = DateTime.Now;

            _reviewDAO.SaveReview(newReview);

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
