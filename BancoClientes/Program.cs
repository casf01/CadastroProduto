using System;
using System.Collections.Generic;
using BancoClientes.domian;

namespace BancoClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia da classe cliente
            Cliente cli = new Cliente();
            Console.Clear();

            // Console.WriteLine("Digite o nome do cliente");
            // cli.nome = Console.ReadLine();

            // Console.WriteLine("Digite o email do cliente");
            // cli.email = Console.ReadLine();

            // Console.WriteLine("Digite o telefone do cliente");
            // cli.telefone = Console.ReadLine();

            // Console.WriteLine("Digite a idade do cliente");
            // cli.idade = int.Parse(Console.ReadLine());

            // Console.WriteLine(cli.cadastrar());

            List<Cliente> rs = cli.Listar();

            for(int i = 0; i < rs.Count; i++){
                Console.WriteLine(rs[i].id+"\t"+rs[i].nome+"\t"+rs[i].email+rs[i].telefone+"\t"+rs[i].idade+"\t"+rs[i].datacadastro+"\t");
            }

        }
    }
}
