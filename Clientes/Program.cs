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
            ct.celular = "11-44558-9945";
            ct.email = "pedro@terra.com.br";

            //Vamos instanciar a classe endereço
            Endereco end = new Endereco();
            end.logradouro = "Rua Esperança";
            end.numero = "20";
            end.complemento = "Casa dos fundos";
            end.bairro = "Jardim Maravilha";

            cli.nome="Jessica Fernandes";
            cli.idade=23;
            cli.dataNascimento = DateTime.Parse("15/11/1996");
            cli.contato = ct;
            cli.endereco = end;

            //Console.WriteLine(cli.cadastrar());

            //Passando todos os dados da matriz listar que está carregada com os dados dos clientes para um novo array.
            //Assim esses dados serão carregados de uma só vez.

             string[,] info = cli.listar();

             for(int i = 0 ; i < 10; i++){
                 for(int p = 0; p < 10; p++){
                     Console.Write(info[i,p]+"\t");
                 }
                 Console.WriteLine();
             }

        }
    }
}
