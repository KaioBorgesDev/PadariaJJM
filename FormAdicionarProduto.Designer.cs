namespace PadariaJJM
{
    partial class FormAdicionarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarProduto));
            nome = new TextBox();
            preco = new TextBox();
            quantidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbQuantidade = new Label();
            label4 = new Label();
            data = new DateTimePicker();
            checkBox1 = new CheckBox();
            label5 = new Label();
            barCode = new TextBox();
            label6 = new Label();
            checkboxPeso = new CheckBox();
            fornecedor = new TextBox();
            label3 = new Label();
            checkBox3 = new CheckBox();
            button1 = new Button();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // nome
            // 
            nome.Location = new Point(9, 145);
            nome.Name = "nome";
            nome.Size = new Size(328, 23);
            nome.TabIndex = 0;
            // 
            // preco
            // 
            preco.Location = new Point(9, 198);
            preco.Name = "preco";
            preco.Size = new Size(137, 23);
            preco.TabIndex = 1;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(9, 331);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(137, 23);
            quantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 127);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 180);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 5;
            label2.Text = "Preço (Uni/Kg):";
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(9, 313);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(200, 15);
            lbQuantidade.TabIndex = 6;
            lbQuantidade.Text = "Quantidade em Estoque (Uni ou Kg):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 366);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "Tem Validade?";
            // 
            // data
            // 
            data.Enabled = false;
            data.Format = DateTimePickerFormat.Short;
            data.Location = new Point(9, 384);
            data.Name = "data";
            data.Size = new Size(200, 23);
            data.TabIndex = 9;
            data.Value = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(107, 365);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(46, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Sim";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 73);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 11;
            label5.Text = "Codigo De Barras / Codigo";
            // 
            // barCode
            // 
            barCode.Location = new Point(9, 91);
            barCode.Name = "barCode";
            barCode.Size = new Size(200, 23);
            barCode.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 234);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 14;
            label6.Text = "Peso (Kg)?";
            // 
            // checkboxPeso
            // 
            checkboxPeso.AutoSize = true;
            checkboxPeso.Location = new Point(85, 234);
            checkboxPeso.Name = "checkboxPeso";
            checkboxPeso.Size = new Size(46, 19);
            checkboxPeso.TabIndex = 16;
            checkboxPeso.Text = "Sim";
            checkboxPeso.UseVisualStyleBackColor = true;
            // 
            // fornecedor
            // 
            fornecedor.Enabled = false;
            fornecedor.Location = new Point(9, 442);
            fornecedor.Name = "fornecedor";
            fornecedor.Size = new Size(200, 23);
            fornecedor.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 424);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 18;
            label3.Text = "Fornecedor";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(82, 423);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(46, 19);
            checkBox3.TabIndex = 19;
            checkBox3.Text = "Sim";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(211, 548);
            button1.Name = "button1";
            button1.Size = new Size(178, 37);
            button1.TabIndex = 20;
            button1.Text = "Adicionar Produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 256);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 22;
            label7.Text = "Categoria";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 274);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(9, 497);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 23);
            comboBox2.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 479);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 24;
            label8.Text = "Imposto ?";
            // 
            // FormAdicionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 597);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(label3);
            Controls.Add(fornecedor);
            Controls.Add(checkboxPeso);
            Controls.Add(label6);
            Controls.Add(barCode);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(data);
            Controls.Add(label4);
            Controls.Add(lbQuantidade);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quantidade);
            Controls.Add(preco);
            Controls.Add(nome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAdicionarProduto";
            Text = "Adicionar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nome;
        private TextBox preco;
        private TextBox quantidade;
        private Label label1;
        private Label label2;
        private Label lbQuantidade;
        private Label label4;
        private DateTimePicker data;
        private CheckBox checkBox1;
        private Label label5;
        private CheckBox checkBox2;
        private TextBox barCode;
        private Label label6;
        private CheckBox checkboxPeso;
        private TextBox fornecedor;
        private Label label3;
        private CheckBox checkBox3;
        private Button button1;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label8;
    }
}