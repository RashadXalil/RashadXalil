using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PustokApp.Models;
using PustokApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokContext _context;
        public HomeController(PustokContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel HomeVM = new HomeViewModel {
                Sliders = _context.Sliders.ToList(),
                Features = _context.Features.ToList(),
                Promotions = _context.Promotions.ToList()
                };
            return View(HomeVM);
        }
    }
}
