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
using SistemaControleEntrega;

namespace SistemaControleEntrega
{
    public partial class Form1 : Form
    {
    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            Form2 chamaExibir = new Form2();
            chamaExibir.Show();

            try
            {
                ProdutoBLL bll = new ProdutoBLL();
                gdvProdutos.DataSource = bll.selecionaProduto();
            }
            catch (Exception ex) { MessageBox.Show("Erro:" + ex.Message.ToString());
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNome.Enabled == false)//Deixa Campos enbled True
            {
                txtNome.Enabled = true;
                txtDescricao.Enabled = true;
                txtTamanho.Enabled = true;
                txtValor.Enabled = true;

            }
            else
            {
                if( ((txtNome.TextLength) > 0) && ((txtDescricao.TextLength) > 0) && ((txtValor.TextLength) > 0)){

                   
                Produtos p = new Produtos();

                p.Nome = (String)txtNome.Text;
                p.Descricao = (String)txtDescricao.Text;
                p.Tamanho = (String)txtTamanho.Text;
                p.Valor = Convert.ToInt32(txtValor.Text);


                txtCodPizza.Text = "";
                txtNome.Text = "";
                txtDescricao.Text = "";
                txtTamanho.Text = "";
                txtValor.Text = "";

                try

                {

                    ProdutoBLL bll = new ProdutoBLL();

                    bll.novoProduto(p);

                    MessageBox.Show("Dados Salvos com sucesso!");

                }

                catch (Exception ex)
                {

                    MessageBox.Show(" Erro : " + ex.Message.ToString());

                }
            }
        }}

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            Produtos p = new Produtos();
           
            
                p.CodPizza = Convert.ToInt32(txtCodPizza.Text);
                p.Nome = (String)txtNome.Text;
                p.Descricao = (String)txtDescricao.Text;
                p.Tamanho = (String)txtTamanho.Text;
                p.Valor = Convert.ToInt32(txtValor.Text);

                txtCodPizza.Text = "";
                txtNome.Text = "";
                txtDescricao.Text = "";
                txtTamanho.Text = "";
                txtValor.Text = "";
            try
            {

                ProdutoBLL bll = new ProdutoBLL();

                bll.alterarProduto(p);

            }

            catch (Exception ex)
            {

                MessageBox.Show(" Erro : " + ex.Message.ToString());

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produtos p = new Produtos();
            p.CodPizza = Convert.ToInt32(txtCodPizza.Text);
            try
            {
                ProdutoBLL bll = new ProdutoBLL();
                bll.excluirProduto(p);

                txtCodPizza.Text = "";
                txtNome.Text = "";
                txtDescricao.Text = "";
                txtTamanho.Text = "";
                txtValor.Text = "";

                MessageBox.Show(" Excluido!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : Excl" + ex.Message.ToString());
            } 
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            int cod_pizza = Convert.ToInt32(txtCodPizza.Text);
            Produtos p = new Produtos();
            
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtTamanho.Enabled = true;
            txtValor.Enabled = true;
            
            try
            {
               
                

                ProdutoBLL bll = new ProdutoBLL();
                p = bll.listaProdutoPorCod(cod_pizza);
                txtNome.Text = p.Nome;
                txtDescricao.Text = p.Descricao;
                txtTamanho.Text = p.Tamanho;
                txtValor.Text = p.Valor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void txtCodPizza_TextChanged(object sender, EventArgs e)
        {
            
            if((txtCodPizza.TextLength) > 0){
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnProcurar.Enabled = true;
            }else{
              btnAlterar.Enabled = false;
              btnExcluir.Enabled = false;
              btnProcurar.Enabled = false;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNome.Text == String.Empty)
            {
                this.txtNome.Focus();

                return;

            }
           
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (this.txtValor.Text == String.Empty)
            {
                this.txtValor.Focus();

                return;

            }
           
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDescricao.Text == String.Empty)
            {
                this.txtDescricao.Focus();

                return;

            }
            
        }

        private void txtTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.txtTamanho.Text == String.Empty)
            {
                this.txtTamanho.Focus();

                return;

            }
        }





        public string vazil { get; set; }
    }
}
