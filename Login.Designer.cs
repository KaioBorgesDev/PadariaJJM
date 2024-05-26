namespace PadariaJJM
{
    partial class Login
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
            usuario = new TextBox();
            senha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            entrar = new Button();
            SuspendLayout();
            // 
            // usuario
            // 
            usuario.Location = new Point(12, 80);
            usuario.Name = "usuario";
            usuario.Size = new Size(328, 27);
            usuario.TabIndex = 0;
            // 
            // senha
            // 
            senha.Location = new Point(12, 160);
            senha.Name = "senha";
            senha.Size = new Size(328, 27);
            senha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // entrar
            // 
            entrar.Location = new Point(79, 258);
            entrar.Name = "entrar";
            entrar.Size = new Size(190, 29);
            entrar.TabIndex = 4;
            entrar.Text = "Entrar";
            entrar.UseVisualStyleBackColor = true;
            entrar.Click += entrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 363);
            Controls.Add(entrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(senha);
            Controls.Add(usuario);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usuario;
        private TextBox senha;
        private Label label1;
        private Label label2;
        private Button entrar;
    }
}