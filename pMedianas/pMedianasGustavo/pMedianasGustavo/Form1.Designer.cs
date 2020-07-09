namespace pMedianasGustavo
{
    partial class Form1
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
            this.btnResolver = new System.Windows.Forms.Button();
            this.picDesenhoResultado = new System.Windows.Forms.PictureBox();
            this.txtNumeroMedianas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDesenhoResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(24, 74);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(75, 23);
            this.btnResolver.TabIndex = 0;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // picDesenhoResultado
            // 
            this.picDesenhoResultado.Location = new System.Drawing.Point(139, 17);
            this.picDesenhoResultado.Name = "picDesenhoResultado";
            this.picDesenhoResultado.Size = new System.Drawing.Size(600, 600);
            this.picDesenhoResultado.TabIndex = 1;
            this.picDesenhoResultado.TabStop = false;
            // 
            // txtNumeroMedianas
            // 
            this.txtNumeroMedianas.Location = new System.Drawing.Point(25, 43);
            this.txtNumeroMedianas.Name = "txtNumeroMedianas";
            this.txtNumeroMedianas.Size = new System.Drawing.Size(73, 20);
            this.txtNumeroMedianas.TabIndex = 2;
            this.txtNumeroMedianas.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 672);
            this.Controls.Add(this.txtNumeroMedianas);
            this.Controls.Add(this.picDesenhoResultado);
            this.Controls.Add(this.btnResolver);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDesenhoResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.PictureBox picDesenhoResultado;
        private System.Windows.Forms.TextBox txtNumeroMedianas;
    }
}

