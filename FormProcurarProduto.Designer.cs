namespace PadariaJJM
{
    partial class FormProcurarProduto
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcurarProduto));
            comboBox1 = new ComboBox();
            tabela = new DataGridView();
            idProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isPesoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataValidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoBarrasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fornecedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tributoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)tabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(430, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabela
            // 
            tabela.AllowUserToAddRows = false;
            tabela.AllowUserToDeleteRows = false;
            tabela.AutoGenerateColumns = false;
            tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela.Columns.AddRange(new DataGridViewColumn[] { idProdutoDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, precoDataGridViewTextBoxColumn, isPesoDataGridViewCheckBoxColumn, quantidadeDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, dataValidadeDataGridViewTextBoxColumn, codigoBarrasDataGridViewTextBoxColumn, fornecedorDataGridViewTextBoxColumn, tributoDataGridViewTextBoxColumn });
            tabela.DataSource = produtoBindingSource;
            tabela.Location = new Point(12, 167);
            tabela.Name = "tabela";
            tabela.ReadOnly = true;
            tabela.Size = new Size(1097, 378);
            tabela.TabIndex = 1;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            idProdutoDataGridViewTextBoxColumn.HeaderText = "idProduto";
            idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isPesoDataGridViewCheckBoxColumn
            // 
            isPesoDataGridViewCheckBoxColumn.DataPropertyName = "IsPeso";
            isPesoDataGridViewCheckBoxColumn.HeaderText = "IsPeso";
            isPesoDataGridViewCheckBoxColumn.Name = "isPesoDataGridViewCheckBoxColumn";
            isPesoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "DataValidade";
            dataValidadeDataGridViewTextBoxColumn.HeaderText = "DataValidade";
            dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            dataValidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarras";
            codigoBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoBarras";
            codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            codigoBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tributoDataGridViewTextBoxColumn
            // 
            tributoDataGridViewTextBoxColumn.DataPropertyName = "Tributo";
            tributoDataGridViewTextBoxColumn.HeaderText = "Tributo";
            tributoDataGridViewTextBoxColumn.Name = "tributoDataGridViewTextBoxColumn";
            tributoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Produto);
            // 
            // FormProcurarProduto
            // 
            ClientSize = new Size(1121, 571);
            Controls.Add(tabela);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProcurarProduto";
            Text = "Procurando Produtos";
            Load += FormProcurarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)tabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        private ComboBox comboBox1;
        private DataGridView tabela;
        private BindingSource produtoBindingSource;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isPesoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataValidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tributoDataGridViewTextBoxColumn;
    }
}