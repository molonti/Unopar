using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControleEntrega
{
    public partial class ExibirListaClientes : Form
    {
        public ExibirListaClientes()
        {
            InitializeComponent();
        }

        private void ExibirListaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_pizzariaDataSet2.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.banco_pizzariaDataSet2.clientes);

        }
    }
}
