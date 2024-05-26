namespace PadariaJJM
{
    partial class Relatorio
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
            vendaTotal = new Label();
            tbVendas = new DataGridView();
            produtoBindingSource = new BindingSource(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // vendaTotal
            // 
            vendaTotal.AutoSize = true;
            vendaTotal.Location = new Point(148, 9);
            vendaTotal.Name = "vendaTotal";
            vendaTotal.Size = new Size(50, 20);
            vendaTotal.TabIndex = 0;
            vendaTotal.Text = "label1";
            // 
            // tbVendas
            // 
            tbVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbVendas.Location = new Point(0, 98);
            tbVendas.Name = "tbVendas";
            tbVendas.RowHeadersWidth = 51;
            tbVendas.Size = new Size(800, 351);
            tbVendas.TabIndex = 1;
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Produto);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor Geral:";
            // 
            // Relatorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 446);
            Controls.Add(label2);
            Controls.Add(tbVendas);
            Controls.Add(vendaTotal);
            Name = "Relatorio";
            Text = "Relatorio";
            ((System.ComponentModel.ISupportInitialize)tbVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView tbVendas;
        private BindingSource produtoBindingSource;
        private Label vendaTotal;
        private Label label2;
    }
}