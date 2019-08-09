using System.Collections;
using Livraria.Models.DAO;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class ProdutoController:Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult Cadastro(){
            return View();
        }
        public IActionResult Atualizar(){
            return View();
        }
        public IActionResult Apagar(){
            return View();
        }
        public IActionResult Listar(){

            DAOProduto daopro = new DAOProduto();

            IList lst = daopro.listar();

            ViewData["Lista"] = lst;
            return View();
        }
        public IActionResult ListarId(int id){
            return View();
        }
        public IActionResult ListarNome(string nome){
            return View();
        }
    }
}