﻿namespace PadariaJJM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            cadastrarProdutoToolStripMenuItem = new ToolStripMenuItem();
            adicionarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            adicionarCategoriaToolStripMenuItem1 = new ToolStripMenuItem();
            procurarProdutoToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarProdutoToolStripMenuItem, procurarProdutoToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            cadastrarProdutoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarCategoriaToolStripMenuItem, adicionarCategoriaToolStripMenuItem1 });
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
