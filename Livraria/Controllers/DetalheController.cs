using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class DetalheController:Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}