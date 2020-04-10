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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastraPizza_Click(object sender, EventArgs e)
        {
            Form1 ChamaForm1 = new Form1();
            ChamaForm1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            ClientesForm ChamaCliente = new ClientesForm();
            ChamaCliente.Show();
        }
    }
}
