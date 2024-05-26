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
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isPesoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataValidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoBarrasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fornecedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tributoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoBindingSource1 = new BindingSource(components);
            produtoBindingSource = new BindingSource(components);
            button1 = new Button();
            barCode = new TextBox();
            label1 = new Label();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, precoDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, isPesoDataGridViewCheckBoxColumn, categoriaDataGridViewTextBoxColumn, dataValidadeDataGridViewTextBoxColumn, codigoBarrasDataGridViewTextBoxColumn, fornecedorDataGridViewTextBoxColumn, tributoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = produtoBindingSource1;
            dataGridView1.Location = new Point(8, 112);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(622, 95);
            dataGridView1.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            precoDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // isPesoDataGridViewCheckBoxColumn
            // 
            isPesoDataGridViewCheckBoxColumn.DataPropertyName = "IsPeso";
            isPesoDataGridViewCheckBoxColumn.HeaderText = "IsPeso";
            isPesoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isPesoDataGridViewCheckBoxColumn.Name = "isPesoDataGridViewCheckBoxColumn";
            isPesoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "DataValidade";
            dataValidadeDataGridViewTextBoxColumn.HeaderText = "DataValidade";
            dataValidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            dataValidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarras";
            codigoBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoBarras";
            codigoBarrasDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            codigoBarrasDataGridViewTextBoxColumn.Width = 125;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            fornecedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // tributoDataGridViewTextBoxColumn
            // 
            tributoDataGridViewTextBoxColumn.DataPropertyName = "Tributo";
            tributoDataGridViewTextBoxColumn.HeaderText = "Tributo";
            tributoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tributoDataGridViewTextBoxColumn.Name = "tributoDataGridViewTextBoxColumn";
            tributoDataGridViewTextBoxColumn.Width = 125;
            // 
            // produtoBindingSource1
            // 
            produtoBindingSource1.DataSource = typeof(Produto);
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Produto);
            // 
            // button1
            // 
            button1.Location = new Point(200, 41);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 1;
            button1.Text = "Procurar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // barCode
            // 
            barCode.Location = new Point(27, 41);
            barCode.Margin = new Padding(3, 4, 3, 4);
            barCode.Name = "barCode";
            barCode.Size = new Size(141, 27);
            barCode.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 16);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "Nº Produto";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(233, 240);
            btnRemover.Margin = new Padding(3, 4, 3, 4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(195, 75);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += button2_Click_1;
            // 
            // ProdutoRemoverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 331);
            Controls.Add(btnRemover);
            Controls.Add(label1);
            Controls.Add(barCode);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProdutoRemoverForm";
            Text = "ProdutoRemoverForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource produtoBindingSource;
        private Button button1;
        private TextBox barCode;
        private Label label1;
        private Button btnRemover;
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
        private BindingSource produtoBindingSource1;
    }
}