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
            checkBox2 = new CheckBox();
            barCode = new TextBox();
            label6 = new Label();
            pesoPreco = new TextBox();
            checkboxPeso = new CheckBox();
            fornecedor = new TextBox();
            label3 = new Label();
            checkBox3 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // nome
            // 
            nome.Location = new Point(12, 75);
            nome.Name = "nome";
            nome.Size = new Size(328, 23);
            nome.TabIndex = 0;
            // 
            // preco
            // 
            preco.Location = new Point(12, 128);
            preco.Name = "preco";
            preco.Size = new Size(137, 23);
            preco.TabIndex = 1;
            // 
            // quantidade
            // 
            quantidade.Location = new Point(12, 254);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(137, 23);
            quantidade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Preço:";
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(12, 236);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(137, 15);
            lbQuantidade.TabIndex = 6;
            lbQuantidade.Text = "Quantidade em Estoque:";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 299);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "Tem Validade?";
            // 
            // data
            // 
            data.Enabled = false;
            data.Format = DateTimePickerFormat.Short;
            data.Location = new Point(12, 317);
            data.Name = "data";
            data.Size = new Size(200, 23);
            data.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(99, 298);
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
            label5.Location = new Point(12, 364);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 11;
            label5.Text = "Codigo De Barras?";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(121, 363);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(46, 19);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Sim";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // barCode
            // 
            barCode.Enabled = false;
            barCode.Location = new Point(12, 382);
            barCode.Name = "barCode";
            barCode.Size = new Size(200, 23);
            barCode.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 164);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 14;
            label6.Text = "Por Peso?";
            // 
            // pesoPreco
            // 
            pesoPreco.Enabled = false;
            pesoPreco.Location = new Point(12, 189);
            pesoPreco.Name = "pesoPreco";
            pesoPreco.Size = new Size(137, 23);
            pesoPreco.TabIndex = 15;
            // 
            // checkboxPeso
            // 
            checkboxPeso.AutoSize = true;
            checkboxPeso.Location = new Point(85, 164);
            checkboxPeso.Name = "checkboxPeso";
            checkboxPeso.Size = new Size(46, 19);
            checkboxPeso.TabIndex = 16;
            checkboxPeso.Text = "Sim";
            checkboxPeso.UseVisualStyleBackColor = true;
            checkboxPeso.CheckedChanged += checkboxPeso_CheckedChanged;
            // 
            // fornecedor
            // 
            fornecedor.Enabled = false;
            fornecedor.Location = new Point(12, 446);
            fornecedor.Name = "fornecedor";
            fornecedor.Size = new Size(200, 23);
            fornecedor.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 428);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 18;
            label3.Text = "Fornecedor";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(85, 427);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(46, 19);
            checkBox3.TabIndex = 19;
            checkBox3.Text = "Sim";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(24, 510);
            button1.Name = "button1";
            button1.Size = new Size(178, 37);
            button1.TabIndex = 20;
            button1.Text = "Adicionar Produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormAdicionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 597);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(label3);
            Controls.Add(fornecedor);
            Controls.Add(checkboxPeso);
            Controls.Add(pesoPreco);
            Controls.Add(label6);
            Controls.Add(barCode);
            Controls.Add(checkBox2);
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
        private TextBox pesoPreco;
        private CheckBox checkboxPeso;
        private TextBox fornecedor;
        private Label label3;
        private CheckBox checkBox3;
        private Button button1;
    }
}