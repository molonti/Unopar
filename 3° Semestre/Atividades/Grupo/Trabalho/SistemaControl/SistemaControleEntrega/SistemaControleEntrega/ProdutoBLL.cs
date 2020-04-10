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
    class ProdutoBLL
    {
        produtoDal dal = null;
        public ProdutoBLL()
        {

        }

       
        public DataTable selecionaProduto()
        {
            DataTable tb = new DataTable();
            try { dal = new produtoDal();
            tb = dal.selectProduto();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return tb;
        }
        public void novoProduto(Produtos produto)
        {

            try
            {
                dal = new produtoDal();
                dal.insertProduto(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void alterarProduto(Produtos produto)
        {
            try
            {
                dal = new produtoDal();
                dal.updateProduto(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void excluirProduto(Produtos produto)
        {
            try
            {
                dal = new produtoDal();
                dal.deleteProduto(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Produtos> listaProdutos()
        {
            try
            {
                dal = new produtoDal();
                return dal.selectListProduto();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public Produtos listaProdutoPorCod(int cod_pizza)
        {
            try
            {
                dal = new produtoDal();
                return dal.selectProdutosByID(cod_pizza);
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}
