namespace Pratica5
{
    partial class FormOrdenacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergesortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shellsortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.heapsortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mergesortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.rdbCresc = new System.Windows.Forms.RadioButton();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.rdbRandom = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 300);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem,
            this.seleçãoToolStripMenuItem,
            this.inserçãoToolStripMenuItem,
            this.shellsortToolStripMenuItem,
            this.quicksortToolStripMenuItem,
            this.heapsortToolStripMenuItem,
            this.mergesortToolStripMenuItem});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algoritmoToolStripMenuItem.Text = "Algoritmo";
            // 
            // bolhaToolStripMenuItem
            // 
            this.bolhaToolStripMenuItem.Name = "bolhaToolStripMenuItem";
            this.bolhaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.bolhaToolStripMenuItem.Text = "Bolha";
            this.bolhaToolStripMenuItem.Click += new System.EventHandler(this.bolhaToolStripMenuItem_Click);
            // 
            // seleçãoToolStripMenuItem
            // 
            this.seleçãoToolStripMenuItem.Name = "seleçãoToolStripMenuItem";
            this.seleçãoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.seleçãoToolStripMenuItem.Text = "Seleção";
            this.seleçãoToolStripMenuItem.Click += new System.EventHandler(this.seleçãoToolStripMenuItem_Click);
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.inserçãoToolStripMenuItem.Text = "Inserção";
            this.inserçãoToolStripMenuItem.Click += new System.EventHandler(this.inserçãoToolStripMenuItem_Click);
            // 
            // shellsortToolStripMenuItem
            // 
            this.shellsortToolStripMenuItem.Name = "shellsortToolStripMenuItem";
            this.shellsortToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.shellsortToolStripMenuItem.Text = "Shellsort";
            this.shellsortToolStripMenuItem.Click += new System.EventHandler(this.shellsortToolStripMenuItem_Click);
            // 
            // quicksortToolStripMenuItem
            // 
            this.quicksortToolStripMenuItem.Name = "quicksortToolStripMenuItem";
            this.quicksortToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.quicksortToolStripMenuItem.Text = "Quicksort";
            this.quicksortToolStripMenuItem.Click += new System.EventHandler(this.quicksortToolStripMenuItem_Click);
            // 
            // heapsortToolStripMenuItem
            // 
            this.heapsortToolStripMenuItem.Name = "heapsortToolStripMenuItem";
            this.heapsortToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.heapsortToolStripMenuItem.Text = "Heapsort";
            this.heapsortToolStripMenuItem.Click += new System.EventHandler(this.heapsortToolStripMenuItem_Click);
            // 
            // mergesortToolStripMenuItem
            // 
            this.mergesortToolStripMenuItem.Name = "mergesortToolStripMenuItem";
            this.mergesortToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mergesortToolStripMenuItem.Text = "Mergesort";
            this.mergesortToolStripMenuItem.Click += new System.EventHandler(this.mergesortToolStripMenuItem_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem1,
            this.seleçãoToolStripMenuItem1,
            this.inserçãoToolStripMenuItem1,
            this.shellsortToolStripMenuItem1,
            this.quicksortToolStripMenuItem1,
            this.heapsortToolStripMenuItem1,
            this.mergesortToolStripMenuItem1});
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // bolhaToolStripMenuItem1
            // 
            this.bolhaToolStripMenuItem1.Name = "bolhaToolStripMenuItem1";
            this.bolhaToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.bolhaToolStripMenuItem1.Text = "Bolha";
            this.bolhaToolStripMenuItem1.Click += new System.EventHandler(this.bolhaToolStripMenuItem1_Click_1);
            // 
            // seleçãoToolStripMenuItem1
            // 
            this.seleçãoToolStripMenuItem1.Name = "seleçãoToolStripMenuItem1";
            this.seleçãoToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.seleçãoToolStripMenuItem1.Text = "Seleção";
            this.seleçãoToolStripMenuItem1.Click += new System.EventHandler(this.seleçãoToolStripMenuItem1_Click);
            // 
            // inserçãoToolStripMenuItem1
            // 
            this.inserçãoToolStripMenuItem1.Name = "inserçãoToolStripMenuItem1";
            this.inserçãoToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.inserçãoToolStripMenuItem1.Text = "Inserção";
            this.inserçãoToolStripMenuItem1.Click += new System.EventHandler(this.inserçãoToolStripMenuItem1_Click);
            // 
            // shellsortToolStripMenuItem1
            // 
            this.shellsortToolStripMenuItem1.Name = "shellsortToolStripMenuItem1";
            this.shellsortToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.shellsortToolStripMenuItem1.Text = "Shellsort";
            this.shellsortToolStripMenuItem1.Click += new System.EventHandler(this.shellsortToolStripMenuItem1_Click);
            // 
            // quicksortToolStripMenuItem1
            // 
            this.quicksortToolStripMenuItem1.Name = "quicksortToolStripMenuItem1";
            this.quicksortToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.quicksortToolStripMenuItem1.Text = "Quicksort";
            this.quicksortToolStripMenuItem1.Click += new System.EventHandler(this.quicksortToolStripMenuItem1_Click);
            // 
            // heapsortToolStripMenuItem1
            // 
            this.heapsortToolStripMenuItem1.Name = "heapsortToolStripMenuItem1";
            this.heapsortToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.heapsortToolStripMenuItem1.Text = "Heapsort";
            this.heapsortToolStripMenuItem1.Click += new System.EventHandler(this.heapsortToolStripMenuItem1_Click);
            // 
            // mergesortToolStripMenuItem1
            // 
            this.mergesortToolStripMenuItem1.Name = "mergesortToolStripMenuItem1";
            this.mergesortToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.mergesortToolStripMenuItem1.Text = "Mergesort";
            this.mergesortToolStripMenuItem1.Click += new System.EventHandler(this.mergesortToolStripMenuItem1_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // rdbCresc
            // 
            this.rdbCresc.AutoSize = true;
            this.rdbCresc.Checked = true;
            this.rdbCresc.Location = new System.Drawing.Point(23, 33);
            this.rdbCresc.Name = "rdbCresc";
            this.rdbCresc.Size = new System.Drawing.Size(107, 17);
            this.rdbCresc.TabIndex = 2;
            this.rdbCresc.TabStop = true;
            this.rdbCresc.Text = "Ordem Crescente";
            this.rdbCresc.UseVisualStyleBackColor = true;
            // 
            // rdbDesc
            // 
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Location = new System.Drawing.Point(136, 33);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(120, 17);
            this.rdbDesc.TabIndex = 3;
            this.rdbDesc.Text = "Ordem Decrescente";
            this.rdbDesc.UseVisualStyleBackColor = true;
            // 
            // rdbRandom
            // 
            this.rdbRandom.AutoSize = true;
            this.rdbRandom.Location = new System.Drawing.Point(262, 33);
            this.rdbRandom.Name = "rdbRandom";
            this.rdbRandom.Size = new System.Drawing.Size(100, 17);
            this.rdbRandom.TabIndex = 4;
            this.rdbRandom.Text = "Ordem Aleatória";
            this.rdbRandom.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1000",
            "10000",
            "50000",
            "100000",
            "500000"});
            this.comboBox1.Location = new System.Drawing.Point(379, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // FormOrdenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 361);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rdbRandom);
            this.Controls.Add(this.rdbDesc);
            this.Controls.Add(this.rdbCresc);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOrdenacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática 5 - Métodos de Ordenação 2020/1";
            this.Load += new System.EventHandler(this.FormOrdenacao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergesortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shellsortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem heapsortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mergesortToolStripMenuItem1;
        private System.Windows.Forms.RadioButton rdbCresc;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.RadioButton rdbRandom;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

