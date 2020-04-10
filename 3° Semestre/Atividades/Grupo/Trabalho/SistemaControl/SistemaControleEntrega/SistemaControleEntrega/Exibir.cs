using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using SistemaControleEntrega;


namespace SistemaControleEntrega
{
    public partial class Exibir: Form
    {
        public Exibir()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new System.NotImplementedException();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_pizzariaDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.banco_pizzariaDataSet1.produto);

        }
    }
}

