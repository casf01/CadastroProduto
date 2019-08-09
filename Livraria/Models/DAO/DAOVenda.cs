using System;
using System.Collections.Generic;
using Livraria.Models.Domain;

namespace Livraria.Models.DAO
{
    public class DAOVenda : Conexao
    {

        public string cadastro(Venda venda)
        {
            string msg = "";

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into venda(idcliente)values(@i)";
                cmd.Parameters.AddWithValue("@i", venda.IdCliente);
                int rs = cmd.ExecuteNonQuery();

                if (rs > 0)
                    msg = "Venda realizada com sucesso!";
                else
                    msg = "Não foi possível realizar a venda";

                cmd.Parameters.Clear();

            }
            catch (Exception e)
            {
                msg = "Erro ao tentar cadastrar a venda -> " + e.Message;
            }
            finally
            {
                con.Close();
            }
            return msg;

        }

        public string atualizar(Venda venda)
        {
            string msg = "";

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "update venda set idcliente=@i where id=@id";
                cmd.Parameters.AddWithValue("@i", venda.IdCliente);
                cmd.Parameters.AddWithValue("@id", venda.Id);
                int rs = cmd.ExecuteNonQuery();

                if (rs > 0)
                    msg = "Venda atualizada com sucesso!";
                else
                    msg = "Não foi possível atualizar a venda";

                cmd.Parameters.Clear();

            }
            catch (Exception e)
            {
                msg = "Erro ao tentar atualizar a venda -> " + e.Message;
            }
            finally
            {
                con.Close();
            }
            return msg;

        }

        public string apagar(Venda venda)
        {
            string msg = "";

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "delete from venda where id=@id";
                cmd.Parameters.AddWithValue("@i", venda.Id);
                int rs = cmd.ExecuteNonQuery();

                if (rs > 0)
                    msg = "Venda apgada com sucesso!";
                else
                    msg = "Não foi possível apagar a venda";

                cmd.Parameters.Clear();

            }
            catch (Exception e)
            {
                msg = "Erro ao tentar apagar a venda -> " + e.Message;
            }
            finally
            {
                con.Close();
            }
            return msg;

        }

        public List<Venda> listar(){
            
            List<Venda> lst = new List<Venda>();
            try{
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * from venda order by id desc";

                dr = cmd.ExecuteReader();
                while(dr.Read()){
                    Venda ve = new Venda();
                    ve.Id = dr.GetInt32("id");
                    ve.IdCliente = dr.GetInt32("idcliente");
                    ve.DataVenda = dr.GetDateTime("datavenda");

                    lst.Add(ve);
                }

            }
            catch(Exception e ){
                throw new Exception("Erro ao tentar selecionar as vendas -> "+e.Message);
            }
            finally{
                con.Close();
            }
            return lst;


        }

         public List<Venda> listar(int id){
            
            List<Venda> lst = new List<Venda>();
            try{
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * from venda where id=@id";
                cmd.Parameters.AddWithValue("@id",id);

                dr = cmd.ExecuteReader();
                while(dr.Read()){
                    Venda ve = new Venda();
                    ve.Id = dr.GetInt32("id");
                    ve.IdCliente = dr.GetInt32("idcliente");
                    ve.DataVenda = dr.GetDateTime("datavenda");

                    lst.Add(ve);
                }

            }
            catch(Exception e ){
                throw new Exception("Erro ao tentar selecionar as vendas -> "+e.Message);
            }
            finally{
                con.Close();
            }
            return lst;
        }

         public List<Venda> listar(DateTime datavenda){
            
            List<Venda> lst = new List<Venda>();
            try{
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * from venda where datavenda=@dt";
                cmd.Parameters.AddWithValue("@dt",datavenda);
                
                dr = cmd.ExecuteReader();
                while(dr.Read()){
                    Venda ve = new Venda();
                    ve.Id = dr.GetInt32("id");
                    ve.IdCliente = dr.GetInt32("idcliente");
                    ve.DataVenda = dr.GetDateTime("datavenda");

                    lst.Add(ve);
                }

            }
            catch(Exception e ){
                throw new Exception("Erro ao tentar selecionar as vendas -> "+e.Message);
            }
            finally{
                con.Close();
            }
            return lst;


        }

    }
}