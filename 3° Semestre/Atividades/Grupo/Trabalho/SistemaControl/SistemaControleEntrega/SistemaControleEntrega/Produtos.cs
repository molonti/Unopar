using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleEntrega
{
 public class Produtos
    {

        int cod_pizza;
        string nome;
        string descricao;
        string tamanho;
        int valor;

        public int CodPizza
        {
            get { return cod_pizza;}
            set { cod_pizza = value; }
        }
   
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }

        }

        public String Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
     
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
