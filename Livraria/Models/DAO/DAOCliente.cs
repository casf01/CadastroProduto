using System;
using System.Collections.Generic;
using Livraria.Models.Domain;
namespace Livraria.Models.DAO
{
   
        //Vamos fazer a daocliente receber automaticamente os dados da classe
        //conexao. Faremos isso o processo conhecido como herança, onde essa classe recebe
        //tudo da classe pai, que neste caso sera a classe conexao
        public class DAOCliente:Conexao
        {
            public string cadastro(Cliente cliente){
                //Vamos criar uma variavel para nos ajudar no retorno da consulta
                string msg= "";
                try{
                    //abrir a conexao com o banco de dados
                   con.Open();
                   //relacionar os comandos de sql(cmd) com o banco de dados
                   cmd.Connection=con;
                //definir o tipo de comando a ser executado. Vamos usar o tipo text
                //e assim escrever o comando insert
            cmd.CommandType = System.Data.CommandType.Text;
            //escrever o comando de sql (insert) que ser executado
            //para inserir os dados na tabela clientes.
            //vamos fazer uma consulta paramentrizada. os parametros 
            //serão definidos cpm arroba(@)
            cmd.CommandText="insert into cliente(nome,email,cpf,telefone,senha)values(@n,@e,@c,@t,@s)";
                //Fazer a passagem dos parametros
                cmd.Parameters.AddWithValue("@n",cliente.Nome);
                cmd.Parameters.AddWithValue("@e",cliente.Email);
                cmd.Parameters.AddWithValue("@c",cliente.Cpf);
                cmd.Parameters.AddWithValue("@t",cliente.Telefone);
                cmd.Parameters.AddWithValue("@s",cliente.Senha);
                    int rs = cmd.ExecuteNonQuery();
                    if(rs>0)
                    msg= "O cliente foi cadastrado";
                    else
                    msg= "Não foi possivel cadastrar o cliente";

                    //vamos limpar a lista de parametros com o comando cmd.parameter.clear()
                    cmd.Parameters.Clear();
                }
                catch(Exception e){
                    msg= "Ocorreu um erro ao cadastrar um cliente ->"+e.Message;

                }
                finally{
                    con.Close();
                }
                return msg;
            }
            public string atualizar(Cliente cliente){
                 //Vamos criar uma variavel para nos ajudar no retorno da consulta
                string msg= "";
                try{
                    //abrir a conexao com o banco de dados
                   con.Open();
                   //relacionar os comandos de sql(cmd) com o banco de dados
                   cmd.Connection=con;
                //definir o tipo de comando a ser executado. Vamos usar o tipo text
                //e assim escrever o comando unpdate
            cmd.CommandType = System.Data.CommandType.Text;
            //escrever o comando de sql (update) que ser executado
            //para inserir os dados na tabela clientes.
            //vamos fazer uma consulta paramentrizada. os parametros 
            //serão definidos cpm arroba(@)
            cmd.CommandText="update cliente set nome=@n, email=@e,cpf=@c,telefone=@t,senha=@s where id=@i";
                //Fazer a passagem dos parametros
                cmd.Parameters.AddWithValue("@n",cliente.Nome);
                cmd.Parameters.AddWithValue("@e",cliente.Email);
                cmd.Parameters.AddWithValue("@c",cliente.Cpf);
                cmd.Parameters.AddWithValue("@t",cliente.Telefone);
                cmd.Parameters.AddWithValue("@s",cliente.Senha);
                cmd.Parameters.AddWithValue("@i",cliente.Id);
                    int rs = cmd.ExecuteNonQuery();
                    if(rs>0)
                    msg= "Os dados do cliente foram atualizados";
                    else
                    msg= "Não foi possivel atualizar os dados do cliente";

                    //vamos limpar a lista de parametros com o comando cmd.parameter.clear()
                    cmd.Parameters.Clear();
                }
                catch(Exception e){
                    msg= "Ocorreu um erro ao atualizar um cliente ->"+e.Message;

                }
                finally{
                    con.Close();
                }
                return msg;

            }
            public string apagar(Cliente cliente){
                 //Vamos criar uma variavel para nos ajudar no retorno da consulta
                string msg= "";
                try{
                    //abrir a conexao com o banco de dados
                   con.Open();
                   //relacionar os comandos de sql(cmd) com o banco de dados
                   cmd.Connection=con;
                //definir o tipo de comando a ser executado. Vamos usar o tipo text
                //e assim escrever o comando delete
            cmd.CommandType = System.Data.CommandType.Text;
            //escrever o comando de sql (delete) que ser executado
            //para apagar os dados na tabela clientes.
            //vamos fazer uma consulta paramentrizada. os parametros 
            //serão definidos cpm arroba(@)
            cmd.CommandText="delete from cliente where id=@i";
                //Fazer a passagem dos parametros
                cmd.Parameters.AddWithValue("@i",cliente.Id);
                
                    int rs = cmd.ExecuteNonQuery();
                    if(rs>0)
                    msg= "O cliente foi apagado";
                    else
                    msg= "Não foi possivel apagado o cliente";

                    //vamos limpar a lista de parametros com o comando cmd.parameter.clear()
                    cmd.Parameters.Clear();
                }
                catch(Exception e){
                    msg= "Ocorreu um erro ao apagar um cliente ->"+e.Message;

                }
                finally{
                    con.Close();
                }
                return msg;
            }
            public List<Cliente> listar(){
                List<Cliente> lst = new List<Cliente>();
                    try{
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "Select * from Cliente";

                        dr= cmd.ExecuteReader();
                        /*
                        Vamos fazer um laço para retornar os dadis cadastrados no banco
                        e popular a listar de cliente
                         */
                         while(dr.Read()){
                             Cliente cli = new Cliente();
                             cli.Id = dr.GetInt32("id");
                             cli.Nome= dr.GetString("nome");
                             cli.Email= dr.GetString("email");
                             cli.Cpf= dr.GetString("cpf");
                             cli.Telefone= dr.GetString("telefone");
                             //adicionar o cliente a lista de cliente
                             lst.Add(cli);
                         }
 
                         }
                         catch(Exception e){
                             /*
                             para exibir a mensagem de erro iremos usar um lançamento com throw new, pois
                             temos nenhuma variavel de string para retornar a mensagem de erro
                              */
                         throw new Exception("Erro ao tentar selecionar os clientes ->"+e.Message);
                         }
                        finally{
                            con.Close();
                        }
                        return lst;            

                
            }
            public List<Cliente> listar(int id){ 
                List<Cliente> lst = new List<Cliente>();
                    try{
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "Select * from Cliente where id=@i";
                        cmd.Parameters.AddWithValue("@id",id);

                        dr= cmd.ExecuteReader();
                        /*
                        Vamos fazer um laço para retornar os dadis cadastrados no banco
                        e popular a listar de cliente
                         */
                         while(dr.Read()){
                             Cliente cli = new Cliente();
                             cli.Id = dr.GetInt32("id");
                             cli.Nome= dr.GetString("nome");
                             cli.Email= dr.GetString("email");
                             cli.Cpf= dr.GetString("cpf");
                             cli.Telefone= dr.GetString("telefone");
                             //adicionar o cliente a lista de cliente
                             lst.Add(cli);
                         }
 
                         }
                         catch(Exception e){
                             /*
                             para exibir a mensagem de erro iremos usar um lançamento com throw new, pois
                             temos nenhuma variavel de string para retornar a mensagem de erro
                              */
                         throw new Exception("Erro ao tentar selecionar os clientes ->"+e.Message);
                         }
                        finally{
                            con.Close();
                        }
                        return lst;

            }
            public List<Cliente> listar(string nome){
                List<Cliente> lst = new List<Cliente>();
                    try{
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "Select * from Cliente where nome like @n";
                        
                        cmd.Parameters.AddWithValue("@n",nome);

                        dr= cmd.ExecuteReader();
                        /*
                        Vamos fazer um laço para retornar os dadis cadastrados no banco
                        e popular a listar de cliente
                         */
                         while(dr.Read()){
                             Cliente cli = new Cliente();
                             cli.Id = dr.GetInt32("id");
                             cli.Nome= dr.GetString("nome");
                             cli.Email= dr.GetString("email");
                             cli.Cpf= dr.GetString("cpf");
                             cli.Telefone= dr.GetString("telefone");
                             //adicionar o cliente a lista de cliente
                             lst.Add(cli);
                         }
 
                         }
                         catch(Exception e){
                             /*
                             para exibir a mensagem de erro iremos usar um lançamento com throw new, pois
                             temos nenhuma variavel de string para retornar a mensagem de erro
                              */
                         throw new Exception("Erro ao tentar selecionar os clientes ->"+e.Message);
                         }
                        finally{
                            con.Close();
                        }
                        return lst;

            }
        }
    }
