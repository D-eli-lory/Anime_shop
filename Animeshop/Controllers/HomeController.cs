using Animeshop.DAL.Interfaces;
using Animeshop.Domain.Entity;
using Animeshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Animeshop.Controllers
{
    public class HomeController : Controller
    {

        public Task<IActionResult> Index()
        {
            return Task.FromResult<IActionResult>(View());
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}