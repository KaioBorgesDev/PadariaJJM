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
            data = new DateTimePicker();
            valorMes = new Label();
            ((System.ComponentModel.ISupportInitialize)tbVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // vendaTotal
            // 
            vendaTotal.AutoSize = true;
            vendaTotal.Location = new Point(130, 7);
            vendaTotal.Name = "vendaTotal";
            vendaTotal.Size = new Size(38, 15);
            vendaTotal.TabIndex = 0;
            vendaTotal.Text = "label1";
            // 
            // tbVendas
            // 
            tbVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbVendas.Location = new Point(0, 74);
            tbVendas.Margin = new Padding(3, 2, 3, 2);
            tbVendas.Name = "tbVendas";
            tbVendas.RowHeadersWidth = 51;
            tbVendas.Size = new Size(700, 263);
            tbVendas.TabIndex = 1;
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Produto);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor Geral:";
            // 
            // data
            // 
            data.CustomFormat = "";
            data.Format = DateTimePickerFormat.Custom;
            data.Location = new Point(10, 34);
            data.Name = "data";
            data.Size = new Size(200, 23);
            data.TabIndex = 10;
            data.ValueChanged += data_ValueChanged;
            // 
            // valorMes
            // 
            valorMes.AutoSize = true;
            valorMes.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            valorMes.Location = new Point(396, 34);
            valorMes.Name = "valorMes";
            valorMes.Size = new Size(165, 30);
            valorMes.TabIndex = 11;
            valorMes.Text = "VALOR MENSAL";
            // 
            // Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 334);
            Controls.Add(valorMes);
            Controls.Add(data);
            Controls.Add(label2);
            Controls.Add(tbVendas);
            Controls.Add(vendaTotal);
            Margin = new Padding(3, 2, 3, 2);
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
        private DateTimePicker data;
        private Label valorMes;
    }
}