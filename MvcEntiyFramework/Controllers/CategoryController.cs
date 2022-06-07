using Microsoft.AspNetCore.Mvc;
using MvcEntiyFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntiyFramework.Controllers
{
    public class CategoryController : Controller
    {
        AppDbContext dbContext = new AppDbContext();
        public IActionResult Index()
        {
            // AppDbContext dbContext = new AppDbContext();
            var result = dbContext.Categories.ToList();
            return View(result);
        }

        public IActionResult Top10Category()
        {
            //AppDbContext dbContext = new AppDbContext();
            var result = dbContext.Categories.OrderBy(c => c.Id).Take(10).ToList();

            return View(result);
        }
    }
}