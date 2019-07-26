using System;
using MySql.Data.MySqlClient;

namespace BancoClientes.domian
{
    public class Cliente
    {
        //Atributos da classe cliente
        public int id;
        public string nome;
        public string email;
        public string telefone;
        public int idade;
        public DateTime datacadastro; 

        public string cadastrar(){
            // Criação da variável mgs para nos ajudar a retornar uma mensagem de cadastro realizado com secesso o não.
            string msg = "";

            //Vamos chamar as classes do mysql para estabelecer a comunicação com o banco de dados e realizar os comando de CRUD na 
            //tabela clientes.

            //Utilizaremos a classe MysqlConnection para nos ajudar a estabelecer a comunicação com o servidor de banco de dados.
            //Nesta classe você deve passar os seguintes itens:
            /*
                -Endereço do Servidor de banco de dados(localhost |127.0.0.1)
                -Porta de comunicação(3306 | 3307)
                -Nome do banco de dados(dbcliente)
                -Nome de usuário (root)
                -Senha(Não tem) 
            */

            MySqlConnection conexao = new MySqlConnection("Server=localhost;Port=3306;Database=dbcliente;User Id=root;Password=");
            //Vamos abrir o banco de dados com o comando Open
            conexao.Open();

            /*
            Vamos fazer umainstancia da classe MySqlCommand. Essa classe nos ajuda a executar os comandos do sql no banco de dados.
            Portanto se você quer realizar um insert na tabela, utilizará uma instância do comando MySqlCommand  */
            MySqlCommand cmd = new MySqlCommand();

            /*
            Para que o C# entenda que os comandos escritos no cmd precisam ser executados no banco de dados dbcliente, que foi 
            representado com o objeto conexao, é necessário estabelecer uma relação entre cmd e conexao. Faremos isso com o comando
            cmd.connection=conexao

            */
            cmd.Connection = conexao;

            /*
            Vamos dizer qual será o tipo de comando que será executado no banco de dados:
                -StoreProcedure -> Stored(Armazenamento) Procedure(Procedimento|Função)
                -Text -> Você escreve o comando sql ponto a ponto para ser executado
                -DirecTable ->Manipular a tabela diretamente
                */

                cmd.CommandType = System.Data.CommandType.Text;

                /*
                Após ter selecionado o tipo de comando a ser executado, você precisa escrever o comando, efetivamente, o comando que será
                executado. Neste caso utilizaremos o comando Insert
                 */

                cmd.CommandText = "insert into cliente (nome,email,telefone,idade) values ('"+nome+"','"+email+"','"+telefone+"',"+idade+")";


                /*
                Vamos executar a consulta com o comando ExecuteNonQuery(). Execute -> executa a consulta, Non(None -> Nenhum) Query(Consulta),
                ou seja, o comando será executado, porém não retorna o que foi inserido apenas se foi inserido(1) ou não (0)
                 */

                 int rs = cmd.ExecuteNonQuery();

                 if(rs > 0)
                 msg = "Cliente cadastrado com Sucesso!";
                 else
                 msg = "Não foi possível cadastrar o cliente!";

                 //fechar conexão com o bando de dados.
                 conexao.Close();

                 return msg;
        }
    }
}