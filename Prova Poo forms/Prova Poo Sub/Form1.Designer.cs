namespace Prova_Poo_Sub
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
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbCod = new System.Windows.Forms.Label();
            this.lbDescEst = new System.Windows.Forms.Label();
            this.lbFatAlimSaud = new System.Windows.Forms.Label();
            this.rbAlim = new System.Windows.Forms.RadioButton();
            this.rbSaud = new System.Windows.Forms.RadioButton();
            this.txCpf = new System.Windows.Forms.TextBox();
            this.txFatAlimSaud = new System.Windows.Forms.TextBox();
            this.txDescEstab = new System.Windows.Forms.TextBox();
            this.txCod = new System.Windows.Forms.TextBox();
            this.btFat = new System.Windows.Forms.Button();
            this.btRel = new System.Windows.Forms.Button();
            this.lsRelatorio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCpf.Location = new System.Drawing.Point(47, 66);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(29, 17);
            this.lbCpf.TabIndex = 0;
            this.lbCpf.Text = "Cpf";
            this.lbCpf.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCod.Location = new System.Drawing.Point(47, 150);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(33, 17);
            this.lbCod.TabIndex = 2;
            this.lbCod.Text = "Cod";
            // 
            // lbDescEst
            // 
            this.lbDescEst.AutoSize = true;
            this.lbDescEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescEst.Location = new System.Drawing.Point(47, 192);
            this.lbDescEst.Name = "lbDescEst";
            this.lbDescEst.Size = new System.Drawing.Size(40, 17);
            this.lbDescEst.TabIndex = 3;
            this.lbDescEst.Text = "Desc";
            // 
            // lbFatAlimSaud
            // 
            this.lbFatAlimSaud.AutoSize = true;
            this.lbFatAlimSaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFatAlimSaud.Location = new System.Drawing.Point(47, 234);
            this.lbFatAlimSaud.Name = "lbFatAlimSaud";
            this.lbFatAlimSaud.Size = new System.Drawing.Size(54, 17);
            this.lbFatAlimSaud.TabIndex = 4;
            this.lbFatAlimSaud.Text = "FatAlim";
            // 
            // rbAlim
            // 
            this.rbAlim.AutoSize = true;
            this.rbAlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbAlim.Location = new System.Drawing.Point(239, 25);
            this.rbAlim.Name = "rbAlim";
            this.rbAlim.Size = new System.Drawing.Size(103, 21);
            this.rbAlim.TabIndex = 5;
            this.rbAlim.TabStop = true;
            this.rbAlim.Text = "Alimentação";
            this.rbAlim.UseVisualStyleBackColor = true;
            // 
            // rbSaud
            // 
            this.rbSaud.AutoSize = true;
            this.rbSaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbSaud.Location = new System.Drawing.Point(425, 25);
            this.rbSaud.Name = "rbSaud";
            this.rbSaud.Size = new System.Drawing.Size(67, 21);
            this.rbSaud.TabIndex = 6;
            this.rbSaud.TabStop = true;
            this.rbSaud.Text = "Saúde";
            this.rbSaud.UseVisualStyleBackColor = true;
            // 
            // txCpf
            // 
            this.txCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txCpf.Location = new System.Drawing.Point(151, 63);
            this.txCpf.Name = "txCpf";
            this.txCpf.Size = new System.Drawing.Size(518, 23);
            this.txCpf.TabIndex = 7;
            // 
            // txFatAlimSaud
            // 
            this.txFatAlimSaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txFatAlimSaud.Location = new System.Drawing.Point(151, 231);
            this.txFatAlimSaud.Name = "txFatAlimSaud";
            this.txFatAlimSaud.Size = new System.Drawing.Size(518, 23);
            this.txFatAlimSaud.TabIndex = 9;
            // 
            // txDescEstab
            // 
            this.txDescEstab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txDescEstab.Location = new System.Drawing.Point(151, 189);
            this.txDescEstab.Name = "txDescEstab";
            this.txDescEstab.Size = new System.Drawing.Size(518, 23);
            this.txDescEstab.TabIndex = 10;
            // 
            // txCod
            // 
            this.txCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txCod.Location = new System.Drawing.Point(151, 147);
            this.txCod.Name = "txCod";
            this.txCod.Size = new System.Drawing.Size(518, 23);
            this.txCod.TabIndex = 11;
            // 
            // btFat
            // 
            this.btFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btFat.Location = new System.Drawing.Point(251, 298);
            this.btFat.Name = "btFat";
            this.btFat.Size = new System.Drawing.Size(91, 27);
            this.btFat.TabIndex = 12;
            this.btFat.Text = "Faturar";
            this.btFat.UseVisualStyleBackColor = true;
            // 
            // btRel
            // 
            this.btRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btRel.Location = new System.Drawing.Point(425, 298);
            this.btRel.Name = "btRel";
            this.btRel.Size = new System.Drawing.Size(95, 27);
            this.btRel.TabIndex = 13;
            this.btRel.Text = "Relatório";
            this.btRel.UseVisualStyleBackColor = true;
            // 
            // lsRelatorio
            // 
            this.lsRelatorio.FormattingEnabled = true;
            this.lsRelatorio.Location = new System.Drawing.Point(151, 354);
            this.lsRelatorio.Name = "lsRelatorio";
            this.lsRelatorio.Size = new System.Drawing.Size(518, 95);
            this.lsRelatorio.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.lsRelatorio);
            this.Controls.Add(this.btRel);
            this.Controls.Add(this.btFat);
            this.Controls.Add(this.txCod);
            this.Controls.Add(this.txDescEstab);
            this.Controls.Add(this.txFatAlimSaud);
            this.Controls.Add(this.txCpf);
            this.Controls.Add(this.rbSaud);
            this.Controls.Add(this.rbAlim);
            this.Controls.Add(this.lbFatAlimSaud);
            this.Controls.Add(this.lbDescEst);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.lbCpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.Label lbDescEst;
        private System.Windows.Forms.Label lbFatAlimSaud;
        private System.Windows.Forms.RadioButton rbAlim;
        private System.Windows.Forms.RadioButton rbSaud;
        private System.Windows.Forms.TextBox txCpf;
        private System.Windows.Forms.TextBox txFatAlimSaud;
        private System.Windows.Forms.TextBox txDescEstab;
        private System.Windows.Forms.TextBox txCod;
        private System.Windows.Forms.Button btFat;
        private System.Windows.Forms.Button btRel;
        private System.Windows.Forms.ListBox lsRelatorio;
    }
}

