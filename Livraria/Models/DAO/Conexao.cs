using MySql.Data.MySqlClient;

namespace Livraria.Models.DAO
{
    public class Conexao
    {
        //Vamos fazer a instacia da classe MySqlConnection
        public MySqlConnection con = new MySqlConnection("Server=localhost;Port=3306;Database=livraria;User Id=root; password=");
        //vamos fazer a instacia da classe MySqlCommand
        public MySqlCommand cmd = new MySqlCommand();
        
        //Para Guardar os retornos do banco de dados com o comando selct, precisamos da instancia DataReader(Leitor de dados)
        public MySqlDataReader dr;
    }
}