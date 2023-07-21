using Animeshop.DAL.Interfaces;
using Animeshop.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Animeshop.Controllers
{
    public class AProductsController : Controller
    {

        [HttpGet]
        public async Task<IActionResult> GetAProducts()
        {
            return View();
        }
        [HttpPost]


    }
}
