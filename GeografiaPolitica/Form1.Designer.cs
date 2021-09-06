namespace GeografiaPolitica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.gbPais = new System.Windows.Forms.GroupBox();
            this.argentina = new System.Windows.Forms.RadioButton();
            this.mexico = new System.Windows.Forms.RadioButton();
            this.chile = new System.Windows.Forms.RadioButton();
            this.brasil = new System.Windows.Forms.RadioButton();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.gbPais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(155, 19);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(328, 122);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.Text = resources.GetString("txtTexto.Text");
            // 
            // gbPais
            // 
            this.gbPais.Controls.Add(this.argentina);
            this.gbPais.Controls.Add(this.mexico);
            this.gbPais.Controls.Add(this.chile);
            this.gbPais.Controls.Add(this.brasil);
            this.gbPais.Location = new System.Drawing.Point(43, 12);
            this.gbPais.Name = "gbPais";
            this.gbPais.Size = new System.Drawing.Size(106, 129);
            this.gbPais.TabIndex = 1;
            this.gbPais.TabStop = false;
            this.gbPais.Text = "Selecione o Pais";
            this.gbPais.Enter += new System.EventHandler(this.gbPais_Enter);
            // 
            // argentina
            // 
            this.argentina.AutoSize = true;
            this.argentina.Location = new System.Drawing.Point(7, 89);
            this.argentina.Name = "argentina";
            this.argentina.Size = new System.Drawing.Size(70, 17);
            this.argentina.TabIndex = 0;
            this.argentina.TabStop = true;
            this.argentina.Text = "Argentina";
            this.argentina.UseVisualStyleBackColor = true;
            this.argentina.CheckedChanged += new System.EventHandler(this.argentina_CheckedChanged);
            // 
            // mexico
            // 
            this.mexico.AutoSize = true;
            this.mexico.Location = new System.Drawing.Point(7, 66);
            this.mexico.Name = "mexico";
            this.mexico.Size = new System.Drawing.Size(59, 17);
            this.mexico.TabIndex = 0;
            this.mexico.TabStop = true;
            this.mexico.Text = "México";
            this.mexico.UseVisualStyleBackColor = true;
            this.mexico.CheckedChanged += new System.EventHandler(this.mexico_CheckedChanged);
            // 
            // chile
            // 
            this.chile.AutoSize = true;
            this.chile.Location = new System.Drawing.Point(7, 43);
            this.chile.Name = "chile";
            this.chile.Size = new System.Drawing.Size(48, 17);
            this.chile.TabIndex = 0;
            this.chile.TabStop = true;
            this.chile.Text = "Chile";
            this.chile.UseVisualStyleBackColor = true;
            this.chile.CheckedChanged += new System.EventHandler(this.chile_CheckedChanged);
            // 
            // brasil
            // 
            this.brasil.AutoSize = true;
            this.brasil.Checked = true;
            this.brasil.Location = new System.Drawing.Point(7, 20);
            this.brasil.Name = "brasil";
            this.brasil.Size = new System.Drawing.Size(50, 17);
            this.brasil.TabIndex = 0;
            this.brasil.TabStop = true;
            this.brasil.Text = "Brasil";
            this.brasil.UseVisualStyleBackColor = true;
            this.brasil.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pbImagem
            // 
            this.pbImagem.Image = global::GeografiaPolitica.Properties.Resources.brasil;
            this.pbImagem.Location = new System.Drawing.Point(43, 147);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(440, 291);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 2;
            this.pbImagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.gbPais);
            this.Controls.Add(this.txtTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geografia Politica - Luan da Costa Oliveira Esposito - RGM: 2294933-0";
            this.gbPais.ResumeLayout(false);
            this.gbPais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.GroupBox gbPais;
        private System.Windows.Forms.RadioButton argentina;
        private System.Windows.Forms.RadioButton mexico;
        private System.Windows.Forms.RadioButton chile;
        private System.Windows.Forms.RadioButton brasil;
        private System.Windows.Forms.PictureBox pbImagem;
    }
}

