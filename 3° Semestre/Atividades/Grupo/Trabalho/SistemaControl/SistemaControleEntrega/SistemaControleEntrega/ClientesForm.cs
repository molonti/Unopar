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
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string telefone = txtPesquisa.Text.ToString();
            Clientes c = new Clientes();

            txtNome.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtTelefone.Enabled = true;
            txtEndereco.Enabled = true;
            txtReferencia.Enabled = true;

            try
            {



                ClientesBLL bll = new ClientesBLL();
                c = bll.listaClientePorTel(telefone);

                txtCodCliente.Text = c.CodCliente.ToString();
                txtNome.Text = c.Nome;
                txtDataNascimento.Text = c.DataNascimento;
                txtTelefone.Text = c.Telefone;
                txtEndereco.Text = c.Endereco;
                txtReferencia.Text = c.Referencia;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNome.Enabled == false)//Deixa Campos enbled True
            {
                txtNome.Enabled = true;
                txtDataNascimento.Enabled = true;
                txtTelefone.Enabled = true;
                txtEndereco.Enabled = true;
                txtReferencia.Enabled = true;

            }
            else
            {
                if (((txtNome.TextLength) > 0) && ((txtDataNascimento.TextLength) > 0) && ((txtTelefone.TextLength) > 0) && ((txtEndereco.TextLength) > 0) && ((txtReferencia.TextLength) > 0))
                {


                    Clientes c = new Clientes();
                    Clientes fon = new Clientes();

                    string fone = txtTelefone.Text.ToString();

                    c.Nome = (String)txtNome.Text;
                    c.DataNascimento = (String)txtDataNascimento.Text;
                    c.Telefone = (String)txtTelefone.Text;
                    c.Endereco = (String)txtEndereco.Text;
                    c.Referencia = (String)txtReferencia.Text;
                   
                    txtPesquisa.Text = "";
                    txtCodCliente.Text = "";
                    txtNome.Text = "";
                    txtDataNascimento.Text = "";
                    txtTelefone.Text = "";
                    txtEndereco.Text = "";
                    txtReferencia.Text = "";

                    

                    try
                    {

                        ClientesBLL bll = new ClientesBLL();
                        fon = bll.listaClientePorTel(fone);
                       
                        if (fon.Telefone == c.Telefone)
                        {
                            MessageBox.Show("Esse Numero de Cliente ja Existe!");
                        }
                        else
                        {

                            bll.novoCliente(c);

                            MessageBox.Show("Dados Salvos em Clientes!");
                        }
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show(" Erro em Salvar: " + ex.Message.ToString());

                    }
                }
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesBLL bll = new ClientesBLL();
                gdvClientes.DataSource = bll.selecionaCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message.ToString());
            }
        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            if ((txtCodCliente.TextLength) <= 0)
            {
                MessageBox.Show("Sem Dados para ser Excluir! Faça uma Pesquisa...");

                txtNome.Enabled = false;
                txtTelefone.Enabled = false;
                txtDataNascimento.Enabled = false;
                txtEndereco.Enabled = false;
                txtReferencia.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else
            {
                c.CodCliente = Convert.ToInt32(txtCodCliente.Text);
            }
            
            try
            {
                ClientesBLL bll = new ClientesBLL();
                bll.excluirClientes(c);

                txtCodCliente.Text = "";
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtDataNascimento.Text = "";
                txtEndereco.Text = "";
                txtReferencia.Text = "";
                txtPesquisa.Text = "";

                MessageBox.Show(" Excluido!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : Excl" + ex.Message.ToString());
            } 
        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtDataNascimento.TextLength)
                {
                    case 0:
                        txtDataNascimento.Text = "";
                        break;
                    case 2:
                        txtDataNascimento.Text = txtDataNascimento.Text + "/";
                        txtDataNascimento.SelectionStart = 4;
                        break;

                    case 5:
                        txtDataNascimento.Text = txtDataNascimento.Text + "/";
                        txtDataNascimento.SelectionStart = 9;
                        break;
                }
            }
        }

        private void btnExibir_Click_1(object sender, EventArgs e)
        {
            ExibirListaClientes chamaExibirClientes = new ExibirListaClientes();
            chamaExibirClientes.Show();

            try
            {
                ClientesBLL bll = new ClientesBLL();
                gdvClientes.DataSource = bll.selecionaCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message.ToString());
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();


            c.CodCliente = Convert.ToInt32(txtCodCliente.Text);
            c.Nome = (String)txtNome.Text;
            c.Telefone = (String)txtTelefone.Text;
            c.DataNascimento = (String)txtDataNascimento.Text;
            c.Endereco = (String)txtEndereco.Text;
            c.Referencia = (String)txtReferencia.Text;

            txtCodCliente.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtDataNascimento.Text = "";
            txtEndereco.Text = "";
            txtReferencia.Text = "";
            txtPesquisa.Text = "";

            MessageBox.Show("Alteração feito com Sucesso!");
            try
            {

                ClientesBLL bll = new ClientesBLL();

                bll.alterarClientes(c);

            }

            catch (Exception ex)
            {

                MessageBox.Show(" Erro : " + ex.Message.ToString());

            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTelefone.TextLength)
                {
                    case 0:
                       txtTelefone.Text = txtTelefone.Text + "(";
                        txtTelefone.SelectionStart = 2;
                        break;
                    
                    case 3:
                        txtTelefone.Text = txtTelefone.Text + ")";
                        txtTelefone.SelectionStart = 7;
                        break;

                    case 8:
                        txtTelefone.Text = txtTelefone.Text + "-";
                        txtTelefone.SelectionStart = 12;
                        break;
                }
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtPesquisa.TextLength)
                {
                    case 0:
                        txtPesquisa.Text = txtPesquisa.Text + "(";
                        txtPesquisa.SelectionStart = 2;
                        break;

                    case 3:
                        txtPesquisa.Text = txtPesquisa.Text + ")";
                        txtPesquisa.SelectionStart = 7;
                        break;

                    case 8:
                        txtPesquisa.Text = txtPesquisa.Text + "-";
                        txtPesquisa.SelectionStart = 12;
                        break;
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if ((txtPesquisa.TextLength) > 0)
            {
                btnPesquisa.Enabled = true;
            }
            else
            {
                btnPesquisa.Enabled = false;
            }
        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            if (((txtCodCliente.TextLength) > 0) || ((txtPesquisa.TextLength) > 0))
                 {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                
            }
            else
            {
                if ((txtCodCliente.TextLength) <= 0)
                {
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
        }

        
    }
}
