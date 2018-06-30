namespace AspNetVS2017.Capitulo1.Tabuada
{
    partial class tabuadaForm
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
            this.tabuadaTextBox = new System.Windows.Forms.TextBox();
            this.tabuadalistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tabuadaTextBox
            // 
            this.tabuadaTextBox.Location = new System.Drawing.Point(13, 13);
            this.tabuadaTextBox.Name = "tabuadaTextBox";
            this.tabuadaTextBox.Size = new System.Drawing.Size(267, 20);
            this.tabuadaTextBox.TabIndex = 0;
            this.tabuadaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabuadaTextBox_KeyPress);
            // 
            // tabuadalistBox
            // 
            this.tabuadalistBox.FormattingEnabled = true;
            this.tabuadalistBox.Location = new System.Drawing.Point(12, 39);
            this.tabuadalistBox.Name = "tabuadalistBox";
            this.tabuadalistBox.Size = new System.Drawing.Size(268, 212);
            this.tabuadalistBox.TabIndex = 1;
            // 
            // tabuadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tabuadalistBox);
            this.Controls.Add(this.tabuadaTextBox);
            this.Name = "tabuadaForm";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tabuadaTextBox;
        private System.Windows.Forms.ListBox tabuadalistBox;
    }
}

