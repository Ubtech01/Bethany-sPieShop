using Bethany_sPieShop.Models;
using Bethany_sPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bethany_sPieShop.Controllers
{
    public class PieController : Controller
    {

        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
            
        }
        public IActionResult List()
        {
        //    ViewBag.CurrentCategory = "Cheese cakes";
        //    return View();

            PieListViewModel pieListViewModel = new PieListViewModel
            (_pieRepository.AllPies, "All pies");
            return View(pieListViewModel);
        }

        public IActionResult Details(int id) 
        {
             var pie = _pieRepository.GetPieById(id);
            if(pie == null) 
                return NotFound();
            return View(pie);   
        }


    }
}
