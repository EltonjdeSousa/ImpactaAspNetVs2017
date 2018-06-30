namespace AspNetVs2017.Capitulo01.Variaveis
{
    partial class VariaveisForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmeticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incremetaisDecrementaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booleanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.ternariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacoesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacoesToolStripMenuItem
            // 
            this.operacoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritmeticasToolStripMenuItem,
            this.reduzidasToolStripMenuItem,
            this.incremetaisDecrementaisToolStripMenuItem,
            this.booleanasToolStripMenuItem,
            this.logicaToolStripMenuItem,
            this.ternariaToolStripMenuItem});
            this.operacoesToolStripMenuItem.Name = "operacoesToolStripMenuItem";
            this.operacoesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.operacoesToolStripMenuItem.Text = "&Operações";
            // 
            // aritmeticasToolStripMenuItem
            // 
            this.aritmeticasToolStripMenuItem.Name = "aritmeticasToolStripMenuItem";
            this.aritmeticasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.aritmeticasToolStripMenuItem.Text = "&Aritméticas";
            this.aritmeticasToolStripMenuItem.Click += new System.EventHandler(this.aritmeticasToolStripMenuItem_Click);
            // 
            // reduzidasToolStripMenuItem
            // 
            this.reduzidasToolStripMenuItem.Name = "reduzidasToolStripMenuItem";
            this.reduzidasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.reduzidasToolStripMenuItem.Text = "&Reduzidas";
            this.reduzidasToolStripMenuItem.Click += new System.EventHandler(this.reduzidasToolStripMenuItem_Click);
            // 
            // incremetaisDecrementaisToolStripMenuItem
            // 
            this.incremetaisDecrementaisToolStripMenuItem.Name = "incremetaisDecrementaisToolStripMenuItem";
            this.incremetaisDecrementaisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.incremetaisDecrementaisToolStripMenuItem.Text = "&Incremetais/Decrementais";
            this.incremetaisDecrementaisToolStripMenuItem.Click += new System.EventHandler(this.incremetaisDecrementaisToolStripMenuItem_Click);
            // 
            // booleanasToolStripMenuItem
            // 
            this.booleanasToolStripMenuItem.Name = "booleanasToolStripMenuItem";
            this.booleanasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.booleanasToolStripMenuItem.Text = "&Booleanas";
            this.booleanasToolStripMenuItem.Click += new System.EventHandler(this.booleanasToolStripMenuItem_Click);
            // 
            // logicaToolStripMenuItem
            // 
            this.logicaToolStripMenuItem.Name = "logicaToolStripMenuItem";
            this.logicaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.logicaToolStripMenuItem.Text = "&Lógica";
            this.logicaToolStripMenuItem.Click += new System.EventHandler(this.logicaToolStripMenuItem_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(0, 24);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(719, 471);
            this.resultadoListBox.TabIndex = 1;
            // 
            // ternariaToolStripMenuItem
            // 
            this.ternariaToolStripMenuItem.Name = "ternariaToolStripMenuItem";
            this.ternariaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ternariaToolStripMenuItem.Text = "Ternária";
            this.ternariaToolStripMenuItem.Click += new System.EventHandler(this.ternariaToolStripMenuItem_Click);
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 495);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VariaveisForm";
            this.Text = "Variáveis e Operações";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmeticasToolStripMenuItem;
        private System.Windows.Forms.ListBox resultadoListBox;
        private System.Windows.Forms.ToolStripMenuItem reduzidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incremetaisDecrementaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booleanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ternariaToolStripMenuItem;
    }
}

