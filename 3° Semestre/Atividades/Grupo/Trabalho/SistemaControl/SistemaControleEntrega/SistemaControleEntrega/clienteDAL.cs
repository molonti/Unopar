using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaControleEntrega;
using System.Data;

namespace SistemaControleEntrega
{
    class ClienteDAL
    {
        String conexaoMySQL = "";
        public MySqlConnection con;
 

        public ClienteDAL()
        {

            //Fazendo a Conexão com o Banco de Dados e Salvando na Variavel conexaoMySQL
            conexaoMySQL = "Server=localHost;userid=root;password=;database=banco_pizzaria";
        }

        //Seleciona a Tabela "Clientes" do Banco de Dados MySQL
        public List<Clientes> selectLisClientes(){
        try {
        using(MySqlConnection conn = new MySqlConnection(conexaoMySQL))
        {
            using (MySqlCommand command = new MySqlCommand("Select * from clientes", conn)) 
            {
                 conn.Open();
                 List<Clientes>listaClientes = new List<Clientes>();
                 using (MySqlDataReader dr = command.ExecuteReader()) 
                {
                    while (dr.Read()) {
                       Clientes cliente = new Clientes();
                       cliente.CodCliente = (int) dr["cod_cliente"];
                       cliente.Nome =  (string) dr["nome"];
                       cliente.DataNascimento = (string) dr["data_nascimento"];
                       cliente.Telefone = (string) dr["telefone"];
                       cliente.Endereco = (string)dr["endereco"];
                       cliente.Referencia = (string)dr["referencia"];
                       listaClientes.Add(cliente);
                    }
                }
                return listaClientes;
            }
        }
    }
    catch (Exception ex) {
        throw new Exception("Erro ao acessar Tabela Clientes" + ex.Message);
    }
}		
        // Select Tabela Clientes
        public DataTable selectClientes()
        {
            try
            {
                String sql = "SELECT * FROM clientes";
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

        //Fazendo SELEC em Tabela
        public Clientes selectClienteByTel(string telefone)
        {
            try
            {
                String sql = "SELECT * FROM clientes WHERE telefone=@telefone";
                con = new MySqlConnection (conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                con.Open();
                MySqlDataReader dr;

                Clientes cliente = new Clientes();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    cliente.CodCliente = Convert.ToInt32(dr["cod_cliente"]);
                    cliente.Nome = dr["nome"].ToString();
                    cliente.DataNascimento = dr["data_nascimento"].ToString();
                    cliente.Telefone = dr["telefone"].ToString();
                    cliente.Endereco = dr["endereco"].ToString();
                    cliente.Referencia = dr["referencia"].ToString();
                 
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Inserindo Dados Tabela Produto
        public void insertClientes(Clientes cli)
        {
            

            try {
                con = new MySqlConnection(conexaoMySQL);
                con.Open();

                string inserir = "INSERT INTO clientes(nome,data_nascimento,telefone,endereco,referencia)values('" + cli.Nome + "','" + cli.DataNascimento + "','" + cli.Telefone +"','"+ cli.Endereco +"','"+ cli.Referencia +"')";
                MySqlCommand comandos = new MySqlCommand(inserir, con);



                comandos.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Comandos ->Inserindo dados<- :" + ex.Message);
            }
           
        }
            
        
        //Atualizando a Tabela Cliente
        public void updateClientes(Clientes cliente)
        {
            try
            {
                String sql = "UPDATE clientes SET nome=@nome, data_nascimento=@data_nascimento, telefone=@telefone,endereco=@endereco, referencia=@referencia WHERE cod_cliente =@cod_cliente";
                con = new MySqlConnection(conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cod_cliente", cliente.CodCliente);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@data_nascimento", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@referencia", cliente.Referencia);
                
                con.Open();//abri conexão com banco
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

        
        
        
        //Deletando Clientes --> Aqui Tudo Ok
        public void deleteClientes(Clientes cliente)
        {
            try
            {
                String sql = "DELETE FROM clientes WHERE cod_cliente = @cod_cliente ";
                MySqlConnection con = new MySqlConnection(conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cod_cliente", cliente.CodCliente);
                
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
