namespace PadariaJJM.entidade
{
    partial class FormAddTributo
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
            button1 = new Button();
            nome = new TextBox();
            valorImposto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(90, 352);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(159, 31);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nome
            // 
            nome.Location = new Point(58, 111);
            nome.Margin = new Padding(3, 4, 3, 4);
            nome.Name = "nome";
            nome.Size = new Size(219, 27);
            nome.TabIndex = 1;
            // 
            // valorImposto
            // 
            valorImposto.Location = new Point(58, 235);
            valorImposto.Margin = new Padding(3, 4, 3, 4);
            valorImposto.Name = "valorImposto";
            valorImposto.Size = new Size(91, 27);
            valorImposto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 87);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 211);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 4;
            label2.Text = "Valor Imposto (%):";
            // 
            // FormAddTributo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 471);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(valorImposto);
            Controls.Add(nome);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddTributo";
            Text = "Adicionar Imposto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox nome;
        private TextBox valorImposto;
    }
}