using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using SistemaControleEntrega;

namespace SistemaControleEntrega
{
    class ClientesBLL
    {
       ClienteDAL dal = null;
        
        public ClientesBLL()
        {

        }

       //
        public DataTable selecionaCliente()
        {
            DataTable tb = new DataTable();
            try { dal = new ClienteDAL();
            tb = dal.selectClientes();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        //
        public void novoCliente(Clientes cliente)
        {

            try
            {
                dal = new ClienteDAL();
                dal.insertClientes(cliente);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public void alterarClientes(Clientes cliente)
        {
            try
            {
                dal = new ClienteDAL();
                dal.updateClientes(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public void excluirClientes(Clientes cliente)
        {
            try
            {
                dal = new ClienteDAL();
                dal.deleteClientes(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public List<Clientes> listaClientes()
        {
            try
            {
                dal = new ClienteDAL();
                return dal.selectLisClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        //
        public Clientes listaClientePorTel(string telefone)
        {
            try
            {
                dal = new ClienteDAL();
                return dal.selectClienteByTel(telefone);
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        //Fim
    }
}
