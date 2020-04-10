using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleEntrega
{
    class Clientes
    {
        int cod_cliente;
        string nome;
        string data_nascimento;
        string telefone;
        string endereco;
        string referencia;

        public int CodCliente
        {
            get { return cod_cliente; }
            set { cod_cliente = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String DataNascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; }

        }

        public  string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
    }
}
