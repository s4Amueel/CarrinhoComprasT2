namespace CarrinhoComprasT2
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.lstCarrinho = new System.Windows.Forms.ListBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemoverTudo = new System.Windows.Forms.Button();
            this.btnRemoverUm = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(40, 58);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(193, 20);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria de produtos:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstProdutos
            // 
            this.lstProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.ItemHeight = 20;
            this.lstProdutos.Items.AddRange(new object[] {
            "Monitor",
            "Teclado",
            "Rato",
            "Impressora",
            "Windows 10",
            "Windows 11",
            "Linux Ubuntu",
            "Office 2022 ",
            "Visual Studio 2022 Enterprise"});
            this.lstProdutos.Location = new System.Drawing.Point(44, 147);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(245, 204);
            this.lstProdutos.TabIndex = 3;
            this.lstProdutos.MouseEnter += new System.EventHandler(this.lstProdutos_MouseEnter);
            // 
            // lstCarrinho
            // 
            this.lstCarrinho.BackColor = System.Drawing.SystemColors.Window;
            this.lstCarrinho.Enabled = false;
            this.lstCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarrinho.FormattingEnabled = true;
            this.lstCarrinho.ItemHeight = 20;
            this.lstCarrinho.Location = new System.Drawing.Point(476, 147);
            this.lstCarrinho.Name = "lstCarrinho";
            this.lstCarrinho.Size = new System.Drawing.Size(245, 244);
            this.lstCarrinho.TabIndex = 3;
            // 
            // lblErro
            // 
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(254, 369);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(35, 34);
            this.lblErro.TabIndex = 4;
            this.lblErro.Text = "*";
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErro.MouseHover += new System.EventHandler(this.lblErro_MouseHover);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CarrinhoComprasT2.Properties.Resources.Shopping_Cart_icon;
            this.button1.Location = new System.Drawing.Point(727, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check Out";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoverTudo
            // 
            this.btnRemoverTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverTudo.Image = global::CarrinhoComprasT2.Properties.Resources.Remove_Cart_icon;
            this.btnRemoverTudo.Location = new System.Drawing.Point(727, 212);
            this.btnRemoverTudo.Name = "btnRemoverTudo";
            this.btnRemoverTudo.Size = new System.Drawing.Size(121, 59);
            this.btnRemoverTudo.TabIndex = 2;
            this.btnRemoverTudo.Text = "Remover todos";
            this.btnRemoverTudo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoverTudo.UseVisualStyleBackColor = true;
            this.btnRemoverTudo.Click += new System.EventHandler(this.btnRemoverTudo_Click);
            // 
            // btnRemoverUm
            // 
            this.btnRemoverUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverUm.Image = global::CarrinhoComprasT2.Properties.Resources.Remove_Cart_icon;
            this.btnRemoverUm.Location = new System.Drawing.Point(727, 147);
            this.btnRemoverUm.Name = "btnRemoverUm";
            this.btnRemoverUm.Size = new System.Drawing.Size(121, 59);
            this.btnRemoverUm.TabIndex = 2;
            this.btnRemoverUm.Text = "Remover produto";
            this.btnRemoverUm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoverUm.UseVisualStyleBackColor = true;
            this.btnRemoverUm.Click += new System.EventHandler(this.btnRemoverUm_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Image = global::CarrinhoComprasT2.Properties.Resources.Add_Cart_icon;
            this.btnSelecionar.Location = new System.Drawing.Point(44, 357);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(189, 61);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar produto";
            this.btnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Image = global::CarrinhoComprasT2.Properties.Resources.search_icon;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(305, 91);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(127, 33);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "Escolher";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lstCarrinho);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoverTudo);
            this.Controls.Add(this.btnRemoverUm);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCategoria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.ListBox lstCarrinho;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btnRemoverUm;
        private System.Windows.Forms.Button btnRemoverTudo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

