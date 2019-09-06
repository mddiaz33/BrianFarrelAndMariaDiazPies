﻿using BrianFarrellAndMariaDiazPies.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrianFarrellAndMariaDiazPies.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackrepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
         {
            _feedbackrepository = feedbackRepository; 

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackrepository.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }
            return View(feedback);
        }
        public IActionResult FeedbackComplete()
        {
            return View();
        }

    }
}
