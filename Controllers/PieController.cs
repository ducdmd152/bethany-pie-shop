using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieRepository;
        private readonly ICategoryRepository categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this.pieRepository = pieRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            return View(new PieListViewModel(pieRepository.AllPies, "Cheese cakes"));
        }

        public IActionResult Details(int id)
        {
            var pie = pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}
