namespace PadariaJJM
{
    partial class ProdutoRemoverForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isPesoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataValidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoBarrasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fornecedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tributoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoBindingSource = new BindingSource(components);
            button1 = new Button();
            idProduto = new TextBox();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProdutoDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, precoDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, isPesoDataGridViewCheckBoxColumn, categoriaDataGridViewTextBoxColumn, dataValidadeDataGridViewTextBoxColumn, codigoBarrasDataGridViewTextBoxColumn, fornecedorDataGridViewTextBoxColumn, tributoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = produtoBindingSource;
            dataGridView1.Location = new Point(7, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 71);
            dataGridView1.TabIndex = 0;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            idProdutoDataGridViewTextBoxColumn.HeaderText = "N° Produto";
            idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // isPesoDataGridViewCheckBoxColumn
            // 
            isPesoDataGridViewCheckBoxColumn.DataPropertyName = "IsPeso";
            isPesoDataGridViewCheckBoxColumn.HeaderText = "IsPeso";
            isPesoDataGridViewCheckBoxColumn.Name = "isPesoDataGridViewCheckBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "DataValidade";
            dataValidadeDataGridViewTextBoxColumn.HeaderText = "DataValidade";
            dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarras";
            codigoBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoBarras";
            codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            // 
            // tributoDataGridViewTextBoxColumn
            // 
            tributoDataGridViewTextBoxColumn.DataPropertyName = "Tributo";
            tributoDataGridViewTextBoxColumn.HeaderText = "Tributo";
            tributoDataGridViewTextBoxColumn.Name = "tributoDataGridViewTextBoxColumn";
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Produto);
            // 
            // button1
            // 
            button1.Location = new Point(175, 31);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Procurar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // idProduto
            // 
            idProduto.Location = new Point(24, 31);
            idProduto.Name = "idProduto";
            idProduto.Size = new Size(124, 23);
            idProduto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Nº Produto";
            // 
            // button2
            // 
            button2.Location = new Point(204, 180);
            button2.Name = "button2";
            button2.Size = new Size(171, 56);
            button2.TabIndex = 4;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // ProdutoRemoverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 248);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(idProduto);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ProdutoRemoverForm";
            Text = "ProdutoRemoverForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource produtoBindingSource;
        private Button button1;
        private TextBox idProduto;
        private Label label1;
        private Button button2;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isPesoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataValidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tributoDataGridViewTextBoxColumn;
    }
}