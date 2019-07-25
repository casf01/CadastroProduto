using System;
using NetOffice.ExcelApi;
using Produtos.classes;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Categoria cat = new Categoria();
           cat.nome = "Gamers";
           cat.descricao= "";

           Fornecedor forn = new Fornecedor();
           forn.razaoSocial = "Kalunga Comércio e Indústria Gráfica Ltda. ";
           forn.CNPJ = "43.283.811/0023-65";
           forn.nomeFantasia = "Kalunga";
           

           Produto pro = new Produto();
           pro.nome = "Cadeira Gamer";
           pro.descricao = "Cadeira Gamer Cloud preta/vermelha/branca 16408 Links CX 1 UN";
           pro.preco = 60210M;
           pro.quantidade = 1;
           pro.categoria = cat;
           pro.fornecedor = forn;

        //Console.WriteLine(pro.cadastrar());

        // string[,] info = pro.listar();

        //      for(int i = 0 ; i < 10; i++){
        //          for(int p = 0; p < 10; p++){
        //              Console.Write(info[i,p]+"\t");
        //          }
        //          Console.WriteLine();
          
        }
    }
}



