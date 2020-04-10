using MySql.Data.MySqlClient;
using SistemaControleEntrega;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace SistemaControleEntrega
{
    class produtoDal
    {
        String conexaoMySQL = "";
        public MySqlConnection con;

        public produtoDal()
        {
            conexaoMySQL = "Server=localHost;userid=root;password=;database=banco_pizzaria";
        }


        public List<Produtos> selectListProduto(){
        try {
        using(MySqlConnection conn = new MySqlConnection(conexaoMySQL))
        {
            using (MySqlCommand command = new MySqlCommand("Select * from produto", conn)) 
            {
                 conn.Open();
                 List<Produtos>listaProdutos = new List<Produtos>();
                 using (MySqlDataReader dr = command.ExecuteReader()) 
                {
                    while (dr.Read()) {
                       Produtos produto = new Produtos();
                       produto.CodPizza = (int) dr["cod_pizza"];
                       produto.Nome =  (String) dr["nome"];
                       produto.Descricao = (String) dr["descricao"];
                       produto.Tamanho = (String) dr["tamanho"];
                       produto.Valor = (int)dr["valor"];
                       listaProdutos.Add(produto);
                    }
                }
                return listaProdutos;
            }
        }
    }
    catch (Exception ex) {
        throw new Exception("Erro ao acessar Produtos" + ex.Message);
    }
}		

        public DataTable selectProduto()
        {
            try
            {
                String sql = "SELECT * FROM produto";
                con = new MySqlConnection(conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Produtos selectProdutosByID(int Cod_pizza)
        {
            try
            {
                String sql = "SELECT * FROM produto WHERE cod_pizza = @cod_pizza";
                con = new MySqlConnection (conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cod_pizza", Cod_pizza);
                con.Open();
                MySqlDataReader dr;

                Produtos produto = new Produtos();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    produto.CodPizza = Convert.ToInt32(dr["cod_pizza"]);
                    produto.Nome = dr["nome"].ToString();
                    produto.Descricao = dr["descricao"].ToString();
                    produto.Tamanho = dr["tamanho"].ToString();
                    produto.Valor = Convert.ToInt32(dr["valor"]);
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Inserindo Dados Tabela Produto
        public void insertProduto(Produtos pro)
        {
            

            try {
                con = new MySqlConnection(conexaoMySQL);
                con.Open();

                string inserir = "INSERT INTO produto(nome,descricao,tamanho,valor)values('" + pro.Nome + "','" + pro.Descricao + "','" + pro.Tamanho +"','"+ pro.Valor +"')";
                MySqlCommand comandos = new MySqlCommand(inserir, con);



                comandos.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Comandos:---Inserindo dados<--- " + ex.Message);
            }
           
        }
            
        
        //Atualizando a Tabela Produto
        public void updateProduto(Produtos produto)
        {
            try
            {
                String sql = "UPDATE produto SET nome=@nome, descricao=@descricao, tamanho=@tamanho,valor=@valor WHERE cod_pizza =@cod_pizza";
                con = new MySqlConnection(conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cod_pizza", produto.CodPizza);
                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@tamanho", produto.Tamanho);
                cmd.Parameters.AddWithValue("@valor", produto.Valor);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        
        
        
        //Deletando linha da Tabela Produto
        public void deleteProduto(Produtos produto)
        {
            try
            {
                String sql = "DELETE FROM produto WHERE cod_pizza = @cod_pizza ";
                MySqlConnection con = new MySqlConnection(conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cod_pizza", produto.CodPizza);
                
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();

            }catch (Exception ex)
            
            {
                throw new Exception("Erro de Comandos-> Delet: " + ex.Message);
            }
        }

        public MySqlConnection conex{ get; set; }
    }
}
