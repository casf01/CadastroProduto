using System;
using NetOffice.ExcelApi;
using Clientes.classes;


namespace Clientes
{
    class Program
    {
        static void Main(string[] args)
        {
           //Vamos instanciar a classe cliente para
           //realizar o cadastro dos clientes
            Cliente cli = new Cliente();
            
            //Vamos instanciar a classe contato
            Contato ct = new Contato();
            ct.telefone = "11-5568-9965";
            ct.celular = "11-99658-9945";
            ct.email = "helena@terra.com.br";

            //Vamos instanciar a classe endereço
            Endereco end = new Endereco();
            end.logradouro = "Rua Nova";
            end.numero = "170A";
            end.complemento = "Casa 12";
            end.bairro = "Jardim Legal";

            cli.nome="Helena";
            cli.idade=24;
            cli.dataNascimento = DateTime.Parse("15/11/1995");
            cli.contato = ct;
            cli.endereco = end;

            Console.WriteLine(cli.cadastrar());            

        }
    }
}
