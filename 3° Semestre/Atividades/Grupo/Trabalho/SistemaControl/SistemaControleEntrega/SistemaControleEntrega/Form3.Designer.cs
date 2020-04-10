namespace SistemaControleEntrega
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastraPizza = new System.Windows.Forms.Button();
            this.btnCadastrarClientes = new System.Windows.Forms.Button();
            this.btnCadastrarEntregador = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastraPizza
            // 
            this.btnCadastraPizza.Location = new System.Drawing.Point(56, 112);
            this.btnCadastraPizza.Name = "btnCadastraPizza";
            this.btnCadastraPizza.Size = new System.Drawing.Size(130, 23);
            this.btnCadastraPizza.TabIndex = 0;
            this.btnCadastraPizza.Text = " Cadastrar Pizza";
            this.btnCadastraPizza.UseVisualStyleBackColor = true;
            this.btnCadastraPizza.Click += new System.EventHandler(this.btnCadastraPizza_Click);
            // 
            // btnCadastrarClientes
            // 
            this.btnCadastrarClientes.Location = new System.Drawing.Point(56, 141);
            this.btnCadastrarClientes.Name = "btnCadastrarClientes";
            this.btnCadastrarClientes.Size = new System.Drawing.Size(130, 24);
            this.btnCadastrarClientes.TabIndex = 1;
            this.btnCadastrarClientes.Text = "Cadastrar Cliente";
            this.btnCadastrarClientes.UseVisualStyleBackColor = true;
            this.btnCadastrarClientes.Click += new System.EventHandler(this.btnCadastrarClientes_Click);
            // 
            // btnCadastrarEntregador
            // 
            this.btnCadastrarEntregador.Location = new System.Drawing.Point(56, 171);
            this.btnCadastrarEntregador.Name = "btnCadastrarEntregador";
            this.btnCadastrarEntregador.Size = new System.Drawing.Size(130, 23);
            this.btnCadastrarEntregador.TabIndex = 2;
            this.btnCadastrarEntregador.Text = "Cadastrar Entregador";
            this.btnCadastrarEntregador.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.White;
            this.btnPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPedido.Location = new System.Drawing.Point(235, 112);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(113, 82);
            this.btnPedido.TabIndex = 3;
            this.btnPedido.Text = "Fazer Pedido";
            this.btnPedido.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Janela Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnCadastrarEntregador);
            this.Controls.Add(this.btnCadastrarClientes);
            this.Controls.Add(this.btnCadastraPizza);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastraPizza;
        private System.Windows.Forms.Button btnCadastrarClientes;
        private System.Windows.Forms.Button btnCadastrarEntregador;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Label label1;
    }
}