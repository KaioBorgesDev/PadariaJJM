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
            tabela = new DataGridView();
            produtoBindingSource1 = new BindingSource(components);
            produtoBindingSource = new BindingSource(components);
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isPesoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataValidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoBarrasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fornecedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tributoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabela
            // 
            tabela.AllowUserToAddRows = false;
            tabela.AllowUserToDeleteRows = false;
            tabela.AutoGenerateColumns = false;
            tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, precoDataGridViewTextBoxColumn, isPesoDataGridViewCheckBoxColumn, quantidadeDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, dataValidadeDataGridViewTextBoxColumn, codigoBarrasDataGridViewTextBoxColumn, fornecedorDataGridViewTextBoxColumn, tributoDataGridViewTextBoxColumn });
            tabela.DataSource = produtoBindingSource1;
            tabela.Dock = DockStyle.Fill;
            tabela.Location = new Point(0, 0);
            tabela.Name = "tabela";
            tabela.ReadOnly = true;
            tabela.RowHeadersWidth = 51;
            tabela.Size = new Size(1179, 571);
            tabela.TabIndex = 1;
            // 
            // produtoBindingSource1
            // 
            produtoBindingSource1.DataSource = typeof(Produto);
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Produto);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Produto";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            precoDataGridViewTextBoxColumn.ReadOnly = true;
            precoDataGridViewTextBoxColumn.Width = 125;
            // 
            // isPesoDataGridViewCheckBoxColumn
            // 
            isPesoDataGridViewCheckBoxColumn.DataPropertyName = "IsPeso";
            isPesoDataGridViewCheckBoxColumn.HeaderText = "Peso ? ";
            isPesoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isPesoDataGridViewCheckBoxColumn.Name = "isPesoDataGridViewCheckBoxColumn";
            isPesoDataGridViewCheckBoxColumn.ReadOnly = true;
            isPesoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Qtd ESTOQUE";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            categoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "DataValidade";
            dataValidadeDataGridViewTextBoxColumn.HeaderText = "Validade";
            dataValidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            dataValidadeDataGridViewTextBoxColumn.ReadOnly = true;
            dataValidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarras";
            codigoBarrasDataGridViewTextBoxColumn.HeaderText = "Código";
            codigoBarrasDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            codigoBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            codigoBarrasDataGridViewTextBoxColumn.Width = 125;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            fornecedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // tributoDataGridViewTextBoxColumn
            // 
            tributoDataGridViewTextBoxColumn.DataPropertyName = "Tributo";
            tributoDataGridViewTextBoxColumn.HeaderText = "Imposto";
            tributoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tributoDataGridViewTextBoxColumn.Name = "tributoDataGridViewTextBoxColumn";
            tributoDataGridViewTextBoxColumn.ReadOnly = true;
            tributoDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormProcurarProduto
            // 
            ClientSize = new Size(1179, 571);
            Controls.Add(tabela);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProcurarProduto";
            Text = "Procurando Produtos";
            ((System.ComponentModel.ISupportInitialize)tabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        private ComboBox comboBox1;
        private DataGridView tabela;
        private BindingSource produtoBindingSource;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private BindingSource produtoBindingSource1;
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