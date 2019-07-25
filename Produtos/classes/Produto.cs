using System.IO;
using NetOffice.ExcelApi;

namespace Produtos.classes
{
    public class Produto
    {
     public string nome;
     public string descricao;
     public decimal preco;
     public int quantidade;
     public Categoria categoria;
     public Fornecedor fornecedor;

     public string cadastrar()
     {
         Application ex = new Application();
         FileInfo arquivo = new FileInfo(@"c:\Caroline\produto.xlsx");
         if (arquivo.Exists)
         {

         ex.Visible = true;

         ex.Workbooks.Open(@"c:\Caroline\produto.xlsx");

         for (int x = 3; x <= 100; x++)
         {

             if (ex.Range("A" + x).Value == null)
             {
                    ex.Range("a" + x).Value = nome;
                    ex.Range("b" + x).Value = descricao;
                    ex.Range("c" + x).Value = preco;
                    ex.Range("d" + x).Value = quantidade;
                    ex.Range("e" + x).Value = categoria;
                    ex.Range("f" + x).Value = categoria.nome;
                    ex.Range("g" + x).Value = categoria.descricao;
                    ex.Range("h" + x).Value = fornecedor;
                    ex.Range("i" + x).Value = fornecedor.razaoSocial;
                    ex.Range("j" + x).Value = fornecedor.nomeFantasia;
                    ex.Range("k" + x).Value = fornecedor.CNPJ;

                    break;
                }
            }
            ex.ActiveWorkbook.Save();
            
        ex.Quit();
     }
     else
     {
         ex.Visible = true;
         ex.Workbooks.Add();


            ex.Range("a1").Value = "Nome do Produto";
            ex.Range("b1").Value = "Descrição";
            ex.Range("c1").Value = "Preço";
            ex.Range("d1").Value = "Quantidade";
            ex.Range("e1").Value = "Categoria";
            ex.Range("f1").Value = "Nome da Categoria";
            ex.Range("g1").Value = "Descrição da Categoria";
            ex.Range("h1").Value = "Fornecedor";
            ex.Range("i1").Value = "Nome da Razão Social";
            ex.Range("j1").Value = "Nome Fantasia";
            ex.Range("k1").Value = "CNPJ";

            ex.Range("a1:k1").Font.Name = "Arial";
            ex.Range("a1:k1").Font.Bold = true;
            ex.Range("a1:k1").Font.Size = 12;

            ex.Range("a2").Value = nome;
            ex.Range("b2").Value = descricao;
            ex.Range("c2").Value = preco;
            ex.Range("d2").Value = quantidade;
            ex.Range("e2").Value = categoria;
            ex.Range("f2").Value = categoria.nome;
            ex.Range("g2").Value = categoria.descricao;
            ex.Range("h2").Value = fornecedor;
            ex.Range("i2").Value = fornecedor.razaoSocial;
            ex.Range("j2").Value = fornecedor.nomeFantasia;
            ex.Range("k2").Value = fornecedor.CNPJ;

            ex.ActiveWorkbook.SaveAs(@"c:\Caroline\produto.xlsx");
            ex.Quit();

        }


        return "Produto salvo com sucesso!";
     
    }
    public string [,] listar()
    {

        string[,] dados = new string[10,10];

        Application ex = new Application();
        ex.Visible = true;
        ex. Workbooks.Open(@"c:\Caroline\produto.xlsx");
        for (int lin=1; lin <= 10; lin++){
            for(int col = 1; col <= 10; col++){
                dados[lin-1,col-1] = ex.Cells[lin,col].Text.ToString();
            }
        }
           ex.Quit();

           return dados; 
    }

}
}

    




 
     
        
        
            
        
            
        
   


 
