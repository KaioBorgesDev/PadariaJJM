namespace PadariaJJM
{
    partial class PageInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageInicial));
            menuStrip1 = new MenuStrip();
            cadastrarProdutoToolStripMenuItem = new ToolStripMenuItem();
            adicionarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            adicionarCategoriaToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            procurarProdutoToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem = new ToolStripMenuItem();
            pictureBox3 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarProdutoToolStripMenuItem, procurarProdutoToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            cadastrarProdutoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarCategoriaToolStripMenuItem, adicionarCategoriaToolStripMenuItem1, toolStripMenuItem1 });
            cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            resources.ApplyResources(cadastrarProdutoToolStripMenuItem, "cadastrarProdutoToolStripMenuItem");
            // 
            // adicionarCategoriaToolStripMenuItem
            // 
            adicionarCategoriaToolStripMenuItem.Name = "adicionarCategoriaToolStripMenuItem";
            resources.ApplyResources(adicionarCategoriaToolStripMenuItem, "adicionarCategoriaToolStripMenuItem");
            adicionarCategoriaToolStripMenuItem.Click += adicionarCategoriaToolStripMenuItem_Click;
            // 
            // adicionarCategoriaToolStripMenuItem1
            // 
            adicionarCategoriaToolStripMenuItem1.Name = "adicionarCategoriaToolStripMenuItem1";
            resources.ApplyResources(adicionarCategoriaToolStripMenuItem1, "adicionarCategoriaToolStripMenuItem1");
            adicionarCategoriaToolStripMenuItem1.Click += adicionarCategoriaToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // procurarProdutoToolStripMenuItem
            // 
            procurarProdutoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nomeToolStripMenuItem });
            procurarProdutoToolStripMenuItem.Name = "procurarProdutoToolStripMenuItem";
            resources.ApplyResources(procurarProdutoToolStripMenuItem, "procurarProdutoToolStripMenuItem");
            // 
            // nomeToolStripMenuItem
            // 
            nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            resources.ApplyResources(nomeToolStripMenuItem, "nomeToolStripMenuItem");
            nomeToolStripMenuItem.Click += nomeToolStripMenuItem_Click;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // PageInicial
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(pictureBox3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PageInicial";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private ToolStripMenuItem adicionarCategoriaToolStripMenuItem;
        private ToolStripMenuItem adicionarCategoriaToolStripMenuItem1;
        private ToolStripMenuItem procurarProdutoToolStripMenuItem;
        private ToolStripMenuItem nomeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private PictureBox pictureBox3;
    }
}
