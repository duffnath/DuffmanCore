using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DuffManCore.Models;
using DuffManCore.Services;
using DuffManCore.ViewModels;

namespace DuffManCore.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private ILitterData _litterData;

        public HomeController(IGreeter greeter, ILitterData litterData)
        {
            _greeter = greeter;
            _litterData = litterData;
        }

        public IActionResult Details(int id)
        {
            var model = _litterData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Litters = _litterData.GetAll();
            model.CurrentMessage = _greeter.GetMessage();

            return View(model);
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
