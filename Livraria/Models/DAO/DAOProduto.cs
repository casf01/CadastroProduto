using System;
using System.Collections.Generic;
using Livraria.Models.Domain;

namespace Livraria.Models.DAO
{
    /*
    A Classe DAOProduto foi criada para realizar o CRUD na tabela produto.
    Para estabelecer a conexao com o banco de dados e abrir a tabela produto
    precisamos dos objetos de conexao(MySqlConnection) e de comandos (MySqlCommando).
    Este foram criado na classe que se comunicam com o banco. Portanto
    para fazer uso dos objetos de banco, faremos nesta classe um processo
    de herança, onde a classe produto herda todos os objetos da  classe
    conexao.
     */
    public class DAOProduto:Conexao
    {
        public string cadastro (Produto produto){
            //Variavel para ajudar no retorno. Exibindo mensagem
            //cadastrou com sucesso, não cadastrou ou erro
            string msg; 
            try{
                //abrir a conexão com o banco de dados 
                con.Open();
                //estabelecer a relação entre os comandos de sql 
                //com a conexão de banco de dados, neste caso con
                cmd.Connection=con;

                //definir o tipo de comando que iremos executar. esse comando
                //será de text
                cmd.CommandType= System.Data.CommandType.Text;
                //vamos escrever a consulta para inserir os dados no banco
                //de dados. O comando será insert
                cmd.CommandText= "insert into produto(nome,descricao,preco,quantidade,imagem) values(@n,@d,@p,@q,@i)";
                    cmd.Parameters.AddWithValue("@n",produto.Nome);
                    cmd.Parameters.AddWithValue("@d",produto.Descricao);
                    cmd.Parameters.AddWithValue("@p",produto.Preco);
                    cmd.Parameters.AddWithValue("@q",produto.Quantidade);
                    cmd.Parameters.AddWithValue("@i",produto.Imagem);

                int rs = cmd.ExecuteNonQuery();
                if(rs>0)
                msg= "Produto cadastrado com sucesso";
                else 
                msg= "Não foi possivel cadastrar o produto";

                //vamos limpar os parametros.
                cmd.Parameters.Clear();

            }
                catch(Exception e){
                    msg= "Erro ao tentar cadastrar o produto ->"+e.Message;
                }
                finally{
                    con.Close();
                }
                return msg;
        }

        public string atualizar(Produto produto){
        //Variavel para ajudar no retorno. Exibindo mensagem
            //cadastrou com sucesso, não cadastrou ou erro
            string msg; 
            try{
                //abrir a conexão com o banco de dados 
                con.Open();
                //estabelecer a relação entre os comandos de sql 
                //com a conexão de banco de dados, neste caso con
                cmd.Connection=con;

                //definir o tipo de comando que iremos executar. esse comando
                //será de text
                cmd.CommandType= System.Data.CommandType.Text;
                //vamos escrever a consulta para inserir os dados no banco
                //de dados. O comando será update
                cmd.CommandText= "update produto set nome=@n,descricao=@d,preco=@p,quantidade=@q,imagem=@i where id@id";
                    cmd.Parameters.AddWithValue("@n",produto.Nome);
                    cmd.Parameters.AddWithValue("@d",produto.Descricao);
                    cmd.Parameters.AddWithValue("@p",produto.Preco);
                    cmd.Parameters.AddWithValue("@q",produto.Quantidade);
                    cmd.Parameters.AddWithValue("@i",produto.Imagem);
                    cmd.Parameters.AddWithValue("@id",produto.Id);

                int rs = cmd.ExecuteNonQuery();
                if(rs>0)
                msg= "Produto atualizado com sucesso";
                else 
                msg= "Não foi possivel atualizar o produto";

                //vamos limpar os parametros.
                cmd.Parameters.Clear();

            }
                catch(Exception e){
                    msg= "Erro ao tentar atualizar o produto ->"+e.Message;
                }
                finally{
                    con.Close();
                }
                return msg;

        }
        public string apagar(Produto produto){
            //Variavel para ajudar no retorno. Exibindo mensagem
            //cadastrou com sucesso, não cadastrou ou erro
            string msg; 
            try{
                //abrir a conexão com o banco de dados 
                con.Open();
                //estabelecer a relação entre os comandos de sql 
                //com a conexão de banco de dados, neste caso con
                cmd.Connection=con;

                //definir o tipo de comando que iremos executar. esse comando
                //será de text
                cmd.CommandType= System.Data.CommandType.Text;
                //vamos escrever a consulta para inserir os dados no banco
                //de dados. O comando será update
                cmd.CommandText= "delete from produto where id@id";
                    
                cmd.Parameters.AddWithValue("@id",produto.Id);

                int rs = cmd.ExecuteNonQuery();
                if(rs>0)
                msg= "Produto apagado com sucesso";
                else 
                msg= "Não foi possivel apagar o produto";

                //vamos limpar os parametros.
                cmd.Parameters.Clear();

            }
                catch(Exception e){
                    msg= "Erro ao tentar apagar o produto ->"+e.Message;
                }
                finally{
                    con.Close();
                }
                return msg;
        }
        public List<Produto> listar(){
            List<Produto> lst = new List<Produto>();
            try{
                con.Open();
                cmd.Connection = con;
                cmd.CommandType= System.Data.CommandType.Text;
                cmd.CommandText= "select * from Produto order by id desc";
                
                dr = cmd.ExecuteReader(); 
                
                while(dr.Read()){
                    Produto pro = new Produto();
                    pro.Id = dr.GetInt32("id");
                    pro.Nome = dr.GetString("nome");
                    pro.Descricao = dr.GetString("descricao");
                    pro.Preco = dr.GetDouble("preco");
                    pro.Quantidade = dr.GetInt32("quantidade");
                    pro.Imagem = dr.GetString("imagem");
                    //adicionar o produtoo acima na lista de produtos
                    lst.Add(pro);

                }
            }
             catch(Exception e){
                 throw new Exception("Erro ao tentar selecionar o produto ->"+e.Message);
             }
             finally{
                 con.Close();
             }
            return lst;
        }
        public List<Produto> listar(int id){
            List<Produto> lst = new List<Produto>();
            try{
                con.Open();
                cmd.Connection = con;
                cmd.CommandType= System.Data.CommandType.Text;
                cmd.CommandText= "select * from produto where id=@id";
                
                cmd.Parameters.AddWithValue("@id", id);
  
                dr = cmd.ExecuteReader(); 
                
                while(dr.Read()){
                    Produto pro = new Produto();
                    pro.Id = dr.GetInt32("id");
                    pro.Nome = dr.GetString("nome");
                    pro.Descricao = dr.GetString("descricao");
                    pro.Preco = dr.GetDouble("preco");
                    pro.Quantidade = dr.GetInt32("quantidade");
                    pro.Imagem = dr.GetString("imagem");
                    //adicionar o produtoo acima na lista de produtos
                    lst.Add(pro);

                }
            }
             catch(Exception e){
                 throw new Exception("Erro ao tentar selecionar o produto ->"+e.Message);
             }
             finally{
                 con.Close();
             }
            return lst;

        }
        public List<Produto> listar(string nome){
            List<Produto> lst = new List<Produto>();
            try{
                con.Open();
                cmd.Connection = con;
                cmd.CommandType= System.Data.CommandType.Text;
                cmd.CommandText= "select * from produto where nome like @n";

                cmd.Parameters.AddWithValue("@n",nome);
                
                dr = cmd.ExecuteReader(); 
                
                while(dr.Read()){
                    Produto pro = new Produto();
                    pro.Id = dr.GetInt32("id");
                    pro.Nome = dr.GetString("nome");
                    pro.Descricao = dr.GetString("descricao");
                    pro.Preco = dr.GetDouble("preco");
                    pro.Quantidade = dr.GetInt32("quantidade");
                    pro.Imagem = dr.GetString("imagem");
                    //adicionar o produtoo acima na lista de produtos
                    lst.Add(pro);

                }
            }
             catch(Exception e){
                 throw new Exception("Erro ao tentar selecionar o produto ->"+e.Message);
             }
             finally{
                 con.Close();
             }
            return lst;
        }

    }
}