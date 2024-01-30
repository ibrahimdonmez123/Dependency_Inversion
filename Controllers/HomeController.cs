using Dependency_Inversion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependency_Inversion.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAracService _aracService;

        public HomeController(IAracService aracService)
        {
            _aracService = aracService;
        }

        public IActionResult Index()
        {
            var aracListesi = _aracService.GetAracListesi();
            return View(aracListesi);
        }
    }

}