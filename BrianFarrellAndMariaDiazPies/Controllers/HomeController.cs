using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BrianFarrellAndMariaDiazPies.Models;
using BrianFarrellAndMariaDiazPies.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrianFarrellAndMariaDiazPies.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository; 

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Pies = pies.ToList(),
                Title = "Welcome to BrianAndMaria's Pie Shop",
                
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }

    }
}
