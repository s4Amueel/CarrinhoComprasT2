namespace WindowsFormsAppHelloT2
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
            this.LblHello = new System.Windows.Forms.Label();
            this.BtnHello = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHello
            // 
            this.LblHello.AutoSize = true;
            this.LblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHello.Location = new System.Drawing.Point(227, 107);
            this.LblHello.Name = "LblHello";
            this.LblHello.Size = new System.Drawing.Size(0, 42);
            this.LblHello.TabIndex = 0;
            this.LblHello.Click += new System.EventHandler(this.LblHello_Click);
            // 
            // BtnHello
            // 
            this.BtnHello.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnHello.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHello.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnHello.Location = new System.Drawing.Point(142, 212);
            this.BtnHello.Name = "BtnHello";
            this.BtnHello.Size = new System.Drawing.Size(427, 182);
            this.BtnHello.TabIndex = 1;
            this.BtnHello.Text = "Pressiona-me!";
            this.BtnHello.UseVisualStyleBackColor = false;
            this.BtnHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsAppHelloT2.Properties.Resources.imagem1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 147);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnHello);
            this.Controls.Add(this.LblHello);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1st app";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHello;
        private System.Windows.Forms.Button BtnHello;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

