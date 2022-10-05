
using Front_to_back.Data;
using Front_to_back.Models;
using Front_to_back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           List<SliderDetail> sliderDetail = _context.SliderDetails.ToList();

            List<Work> works = _context.Works.ToList();

            HomeVM model = new HomeVM
            {
                SliderDetails = sliderDetail,
                Works = works
            };

            
            return View(model);
        }
     
    }
}
