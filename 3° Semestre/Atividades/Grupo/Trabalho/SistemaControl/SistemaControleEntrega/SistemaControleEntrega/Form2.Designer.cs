namespace SistemaControleEntrega
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.gdvProdutos = new System.Windows.Forms.DataGridView();
            this.codpizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_pizzariaDataSet = new SistemaControleEntrega.banco_pizzariaDataSet();
            this.produtoTableAdapter = new SistemaControleEntrega.banco_pizzariaDataSetTableAdapters.produtoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pizzariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvProdutos
            // 
            this.gdvProdutos.AllowUserToAddRows = false;
            this.gdvProdutos.AllowUserToDeleteRows = false;
            this.gdvProdutos.AutoGenerateColumns = false;
            this.gdvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpizzaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.tamanhoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.gdvProdutos.DataSource = this.produtoBindingSource;
            this.gdvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvProdutos.Location = new System.Drawing.Point(0, 0);
            this.gdvProdutos.Name = "gdvProdutos";
            this.gdvProdutos.ReadOnly = true;
            this.gdvProdutos.Size = new System.Drawing.Size(543, 261);
            this.gdvProdutos.TabIndex = 1;
            this.gdvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvProdutos_CellContentClick);
            // 
            // codpizzaDataGridViewTextBoxColumn
            // 
            this.codpizzaDataGridViewTextBoxColumn.DataPropertyName = "cod_pizza";
            this.codpizzaDataGridViewTextBoxColumn.HeaderText = "cod_pizza";
            this.codpizzaDataGridViewTextBoxColumn.Name = "codpizzaDataGridViewTextBoxColumn";
            this.codpizzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "tamanho";
            this.tamanhoDataGridViewTextBoxColumn.HeaderText = "tamanho";
            this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            this.tamanhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.banco_pizzariaDataSet;
            // 
            // banco_pizzariaDataSet
            // 
            this.banco_pizzariaDataSet.DataSetName = "banco_pizzariaDataSet";
            this.banco_pizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Controls.Add(this.gdvProdutos);
            this.Name = "Form2";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pizzariaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvProdutos;
        private banco_pizzariaDataSet banco_pizzariaDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private banco_pizzariaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}