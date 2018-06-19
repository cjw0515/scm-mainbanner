using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using scm_mainbanner.Data.Repositories;
using scm_mainbanner.Models;
using scm_mainbanner.ViewModels;

namespace scm_mainbanner.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBannerRepository _repository;

        public HomeController(IBannerRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {

            var banners = _repository.GetAllBanners();
            var viewModel = new BannerViewModel()
            {
                Banners = banners
            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
