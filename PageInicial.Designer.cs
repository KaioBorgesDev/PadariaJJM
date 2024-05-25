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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageInicial));
            menuStrip1 = new MenuStrip();
            iniciarVendasToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            fecharCaixaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarProdutoToolStripMenuItem = new ToolStripMenuItem();
            adicionarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            adicionarCategoriaToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            procurarProdutoToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem = new ToolStripMenuItem();
            atualizarToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox3 = new PictureBox();
            painelVendas = new Panel();
            panel1 = new Panel();
            troco_caixa = new TextBox();
            lbTroco = new Label();
            label6 = new Label();
            valor_Troco = new Label();
            mtd_Pagamento = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            valorTotallb = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            idProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoBindingSource2 = new BindingSource(components);
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            produtoBindingSource = new BindingSource(components);
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            produtoBindingSource1 = new BindingSource(components);
            hora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            painelVendas.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iniciarVendasToolStripMenuItem, cadastrarProdutoToolStripMenuItem, procurarProdutoToolStripMenuItem, atualizarToolStripMenuItem, removerToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // iniciarVendasToolStripMenuItem
            // 
            iniciarVendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, fecharCaixaToolStripMenuItem });
            iniciarVendasToolStripMenuItem.Name = "iniciarVendasToolStripMenuItem";
            resources.ApplyResources(iniciarVendasToolStripMenuItem, "iniciarVendasToolStripMenuItem");
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            resources.ApplyResources(abrirToolStripMenuItem, "abrirToolStripMenuItem");
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // fecharCaixaToolStripMenuItem
            // 
            fecharCaixaToolStripMenuItem.Name = "fecharCaixaToolStripMenuItem";
            resources.ApplyResources(fecharCaixaToolStripMenuItem, "fecharCaixaToolStripMenuItem");
            fecharCaixaToolStripMenuItem.Click += fecharCaixaToolStripMenuItem_Click;
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
            // atualizarToolStripMenuItem
            // 
            atualizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoToolStripMenuItem });
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            resources.ApplyResources(atualizarToolStripMenuItem, "atualizarToolStripMenuItem");
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            resources.ApplyResources(produtoToolStripMenuItem, "produtoToolStripMenuItem");
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoToolStripMenuItem1 });
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            resources.ApplyResources(removerToolStripMenuItem, "removerToolStripMenuItem");
            // 
            // produtoToolStripMenuItem1
            // 
            produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            resources.ApplyResources(produtoToolStripMenuItem1, "produtoToolStripMenuItem1");
            produtoToolStripMenuItem1.Click += produtoToolStripMenuItem1_Click;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // painelVendas
            // 
            painelVendas.Controls.Add(panel1);
            painelVendas.Controls.Add(dataGridView1);
            painelVendas.Controls.Add(label4);
            painelVendas.Controls.Add(textBox2);
            painelVendas.Controls.Add(label3);
            painelVendas.Controls.Add(textBox1);
            resources.ApplyResources(painelVendas, "painelVendas");
            painelVendas.Name = "painelVendas";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(troco_caixa);
            panel1.Controls.Add(lbTroco);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(valor_Troco);
            panel1.Controls.Add(mtd_Pagamento);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(valorTotallb);
            panel1.Controls.Add(label5);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // troco_caixa
            // 
            resources.ApplyResources(troco_caixa, "troco_caixa");
            troco_caixa.Name = "troco_caixa";
            troco_caixa.TextChanged += troco_caixa_TextChanged;
            // 
            // lbTroco
            // 
            resources.ApplyResources(lbTroco, "lbTroco");
            lbTroco.Name = "lbTroco";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // valor_Troco
            // 
            resources.ApplyResources(valor_Troco, "valor_Troco");
            valor_Troco.ForeColor = Color.PaleTurquoise;
            valor_Troco.Name = "valor_Troco";
            // 
            // mtd_Pagamento
            // 
            mtd_Pagamento.FormattingEnabled = true;
            resources.ApplyResources(mtd_Pagamento, "mtd_Pagamento");
            mtd_Pagamento.Name = "mtd_Pagamento";
            mtd_Pagamento.SelectedIndexChanged += mtd_Pagamento_SelectedIndexChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.White;
            label7.Name = "label7";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.GhostWhite;
            label2.Name = "label2";
            // 
            // valorTotallb
            // 
            resources.ApplyResources(valorTotallb, "valorTotallb");
            valorTotallb.ForeColor = SystemColors.ActiveCaptionText;
            valorTotallb.Name = "valorTotallb";
            valorTotallb.Click += valorTotallb_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.White;
            label5.Name = "label5";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProdutoDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, precoDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, valorTotalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = produtoBindingSource2;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            resources.ApplyResources(idProdutoDataGridViewTextBoxColumn, "idProdutoDataGridViewTextBoxColumn");
            idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            resources.ApplyResources(nomeDataGridViewTextBoxColumn, "nomeDataGridViewTextBoxColumn");
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            resources.ApplyResources(precoDataGridViewTextBoxColumn, "precoDataGridViewTextBoxColumn");
            precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            resources.ApplyResources(quantidadeDataGridViewTextBoxColumn, "quantidadeDataGridViewTextBoxColumn");
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            resources.ApplyResources(valorTotalDataGridViewTextBoxColumn, "valorTotalDataGridViewTextBoxColumn");
            valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            // 
            // produtoBindingSource2
            // 
            produtoBindingSource2.DataSource = typeof(Produto);
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Produto);
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // produtoBindingSource1
            // 
            produtoBindingSource1.DataSource = typeof(Produto);
            // 
            // hora
            // 
            resources.ApplyResources(hora, "hora");
            hora.Name = "hora";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // PageInicial
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(hora);
            Controls.Add(label1);
            Controls.Add(painelVendas);
            Controls.Add(pictureBox3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PageInicial";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            painelVendas.ResumeLayout(false);
            painelVendas.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource1).EndInit();
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
        private ToolStripMenuItem atualizarToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem1;
        private Panel painelVendas;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ToolStripMenuItem iniciarVendasToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem fecharCaixaToolStripMenuItem;
        private BindingSource produtoBindingSource;
        private Button button1;
        private Label label5;
        private Label valorTotallb;
        private Panel panel1;
        private Label label7;
        private TextBox troco;
        private ComboBox mtd_Pagamento;
        private Label valor_Troco;
        private BindingSource produtoBindingSource1;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private BindingSource produtoBindingSource2;
        private Label hora;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private Label lbTroco;
        private TextBox textBox3;
        private TextBox troco_caixa;
    }
}
