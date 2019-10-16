using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeDine.DAL;
using CafeDine.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CafeDine
{
    public class HomeController : Controller
    {
        private readonly DineContext _context;

        public HomeController(DineContext context)
        {
            _context = context;
        }
        public ViewResult Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                Sliders = _context.Sliders,
                Foods = _context.Foods
            };
            return View(homeIndexVM);
        }

        public ViewResult About()
        {
            return View();
        }
    }
}
