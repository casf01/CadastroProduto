using System;
using NetOffice.ExcelApi;

namespace Clientes.classes
{
    public class Cliente
    {
        public string nome;
        public int idade;
        public DateTime dataNascimento;
        public Contato contato;
        public Endereco endereco;

        public string cadastrar(){

            string msg = "";
            Application ex = new Application();
            ex.Visible = true;//Abrir o microsoft excel
            ex.Workbooks.Add();//Adicionar uma planilha ao microsoft Excel
            ex.Range("a1").Value = nome;
            ex.Range("b1").Value = idade;
            ex.Range("c1").Value = dataNascimento;
            ex.Range("d1").Value = contato.telefone;
            ex.Range("e1").Value = contato.celular;
            ex.Range("f1").Value = contato.email;
            ex.Range("g1").Value = endereco.logradouro;
            ex.Range("h1").Value = endereco.numero;
            ex.Range("i1").Value = endereco.complemento;
            ex.Range("j1").Value = endereco.bairro;
            //Vamos salvar o arquivo
            ex.ActiveWorkbook.SaveAs(@"c:\edilson\cliente.xlsx");

            //fechar o arquivo de excel
            ex.Quit();

            return "Cliente salvo com sucesso!";

        }
        public string[,] listar(){
            return null;
        }



    }
}