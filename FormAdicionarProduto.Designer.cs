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
            nome.Location = new Point(10, 193);
            nome.Margin = new Padding(3, 4, 3, 4);
            nome.Name = "nome";
            nome.Size = new Size(374, 27);
            nome.TabIndex = 0;
            // 
            // preco
            // 
            preco.Location = new Point(10, 264);
            preco.Margin = new Padding(3, 4, 3, 4);
            preco.Name = "preco";
            preco.Size = new Size(156, 27);
            preco.TabIndex = 1;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(10, 441);
            quantidade.Margin = new Padding(3, 4, 3, 4);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(156, 27);
            quantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 169);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 4;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 240);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 5;
            label2.Text = "Preço (Uni/Kg):";
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(10, 417);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(251, 20);
            lbQuantidade.TabIndex = 6;
            lbQuantidade.Text = "Quantidade em Estoque (Uni ou Kg):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 488);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 8;
            label4.Text = "Tem Validade?";
            // 
            // data
            // 
            data.Enabled = false;
            data.Format = DateTimePickerFormat.Short;
            data.Location = new Point(10, 512);
            data.Margin = new Padding(3, 4, 3, 4);
            data.Name = "data";
            data.Size = new Size(228, 27);
            data.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(122, 487);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Sim";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 97);
            label5.Name = "label5";
            label5.Size = new Size(189, 20);
            label5.TabIndex = 11;
            label5.Text = "Codigo De Barras / Codigo";
            // 
            // barCode
            // 
            barCode.Location = new Point(10, 121);
            barCode.Margin = new Padding(3, 4, 3, 4);
            barCode.Name = "barCode";
            barCode.Size = new Size(228, 27);
            barCode.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 312);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 14;
            label6.Text = "Peso (Kg)?";
            // 
            // checkboxPeso
            // 
            checkboxPeso.AutoSize = true;
            checkboxPeso.Location = new Point(97, 312);
            checkboxPeso.Margin = new Padding(3, 4, 3, 4);
            checkboxPeso.Name = "checkboxPeso";
            checkboxPeso.Size = new Size(56, 24);
            checkboxPeso.TabIndex = 16;
            checkboxPeso.Text = "Sim";
            checkboxPeso.UseVisualStyleBackColor = true;
            // 
            // fornecedor
            // 
            fornecedor.Enabled = false;
            fornecedor.Location = new Point(10, 589);
            fornecedor.Margin = new Padding(3, 4, 3, 4);
            fornecedor.Name = "fornecedor";
            fornecedor.Size = new Size(228, 27);
            fornecedor.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 565);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 18;
            label3.Text = "Fornecedor";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(94, 564);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(56, 24);
            checkBox3.TabIndex = 19;
            checkBox3.Text = "Sim";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(241, 731);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(203, 49);
            button1.TabIndex = 20;
            button1.Text = "Adicionar Produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 341);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 22;
            label7.Text = "Categoria";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 365);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 28);
            comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(10, 663);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(186, 28);
            comboBox2.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 639);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 24;
            label8.Text = "Imposto ?";
            // 
            // FormAdicionarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 796);
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
            Margin = new Padding(3, 4, 3, 4);
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