using Bethany_sPieShop.Models;
using Bethany_sPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bethany_sPieShop.Controllers
{
    public class HomeController : Controller
    {
        private IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModel(piesOfTheWeek);
            return View(homeViewModel);
        }
    }
}
