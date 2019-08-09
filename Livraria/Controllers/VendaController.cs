using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class VendaController:Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}