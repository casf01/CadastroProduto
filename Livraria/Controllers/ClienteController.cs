
using System.Collections;
using Livraria.Models.DAO;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    public class ClienteController:Controller
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

            /*
            Instancia da camada DAOCliente para ter acesso a lista de clientes que retorna do banco de dados.
            Fizemos um objeto com o nome de daocli 
             */
            DAOCliente daocli = new DAOCliente();

            /*
            Para transitar com os dados em forma de lista da camada DAO para a View, criamos no controller um lista interativa
            para passar os dados ao view. Essa lista interativa é a classe Ilist que pertence a plataforma dotnet(C#) com a Ilist foi 
            criada uma variável com o nome de lst que irá receber o retorno da lista de clientes da camada DAO
             */
            IList lst = daocli.listar();

            /*
            Usamos o comando ViewData(View ->Apresentação | Data -> Dados) para passar os dados da lista interativa para a camada View
            Foi dado um nome de "amarração" Lista e atribuição a variável lst
             */
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