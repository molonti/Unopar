namespace SistemaControleEntrega
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cadastro = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodPizza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.TabPage();
            this.gdvProdutos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Cadastro.SuspendLayout();
            this.Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Cadastro);
            this.tabControl1.Controls.Add(this.Lista);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // Cadastro
            // 
            this.Cadastro.AllowDrop = true;
            this.Cadastro.Controls.Add(this.label7);
            this.Cadastro.Controls.Add(this.label6);
            this.Cadastro.Controls.Add(this.txtTamanho);
            this.Cadastro.Controls.Add(this.label5);
            this.Cadastro.Controls.Add(this.txtDescricao);
            this.Cadastro.Controls.Add(this.label4);
            this.Cadastro.Controls.Add(this.txtValor);
            this.Cadastro.Controls.Add(this.txtNome);
            this.Cadastro.Controls.Add(this.txtCodPizza);
            this.Cadastro.Controls.Add(this.label3);
            this.Cadastro.Controls.Add(this.label2);
            this.Cadastro.Controls.Add(this.label1);
            this.Cadastro.Controls.Add(this.btnProcurar);
            this.Cadastro.Controls.Add(this.btnExibir);
            this.Cadastro.Controls.Add(this.btnAlterar);
            this.Cadastro.Controls.Add(this.btnNovo);
            this.Cadastro.Controls.Add(this.btnExcluir);
            this.Cadastro.Location = new System.Drawing.Point(4, 25);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastro.Size = new System.Drawing.Size(396, 321);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = ",00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "R$";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Enabled = false;
            this.txtTamanho.FormattingEnabled = true;
            this.txtTamanho.Items.AddRange(new object[] {
            "Medio",
            "Grande",
            "Familia"});
            this.txtTamanho.Location = new System.Drawing.Point(99, 195);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(100, 21);
            this.txtTamanho.TabIndex = 15;
            this.txtTamanho.Text = "Pequeno";
            this.txtTamanho.SelectedIndexChanged += new System.EventHandler(this.txtTamanho_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tamanho";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(99, 126);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(203, 63);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descrição";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(124, 86);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(31, 26);
            this.txtValor.TabIndex = 10;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(99, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 20);
            this.txtNome.TabIndex = 9;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCodPizza
            // 
            this.txtCodPizza.Location = new System.Drawing.Point(99, 32);
            this.txtCodPizza.Name = "txtCodPizza";
            this.txtCodPizza.Size = new System.Drawing.Size(75, 20);
            this.txtCodPizza.TabIndex = 8;
            this.txtCodPizza.TextChanged += new System.EventHandler(this.txtCodPizza_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor/Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Enabled = false;
            this.btnProcurar.Location = new System.Drawing.Point(191, 32);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 20);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.Text = "Pesquisar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(286, 279);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(124, 279);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(43, 279);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(205, 279);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.gdvProdutos);
            this.Lista.Location = new System.Drawing.Point(4, 25);
            this.Lista.Name = "Lista";
            this.Lista.Padding = new System.Windows.Forms.Padding(3);
            this.Lista.Size = new System.Drawing.Size(396, 321);
            this.Lista.TabIndex = 1;
            this.Lista.Text = "Lista";
            this.Lista.UseVisualStyleBackColor = true;
            // 
            // gdvProdutos
            // 
            this.gdvProdutos.AllowUserToAddRows = false;
            this.gdvProdutos.AllowUserToDeleteRows = false;
            this.gdvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProdutos.Location = new System.Drawing.Point(6, 6);
            this.gdvProdutos.Name = "gdvProdutos";
            this.gdvProdutos.ReadOnly = true;
            this.gdvProdutos.Size = new System.Drawing.Size(384, 196);
            this.gdvProdutos.TabIndex = 0;
            this.gdvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvProdutos_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 401);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            this.Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        private void gdvProdutos_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cadastro;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TabPage Lista;
        private System.Windows.Forms.DataGridView gdvProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtTamanho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

