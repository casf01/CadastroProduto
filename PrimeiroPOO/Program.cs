using System;
using PrimeiroPOO.classes;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
           //Instância da classe Usuario
           Usuario us1 = new Usuario();
           //Passar os dados para o objeto Usuário
           us1.login = "admin";
           us1.senha = "123";
           us1.acesso = "geral";

           Console.WriteLine(us1.cadastrar());
           Console.WriteLine("O usuário cadastrado é "+us1.login);
           Console.WriteLine(us1.atualizarSenha("123456"));
           Console.WriteLine(us1.logar("admin","123456"));
           Console.WriteLine(us1.logout());
           
        }
    }
}
