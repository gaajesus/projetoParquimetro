namespace Parquimetro
{
    partial class frmParquimetro
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
            this.components = new System.ComponentModel.Container();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb25 = new System.Windows.Forms.RadioButton();
            this.rdb50 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(102, 165);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(185, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 165);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Checked = true;
            this.rdb10.Location = new System.Drawing.Point(194, 40);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(66, 17);
            this.rdb10.TabIndex = 11;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "R$ 0,10 ";
            this.rdb10.UseVisualStyleBackColor = true;
            // 
            // rdb25
            // 
            this.rdb25.AutoSize = true;
            this.rdb25.Location = new System.Drawing.Point(194, 63);
            this.rdb25.Name = "rdb25";
            this.rdb25.Size = new System.Drawing.Size(63, 17);
            this.rdb25.TabIndex = 12;
            this.rdb25.Text = "R$ 0,25";
            this.rdb25.UseVisualStyleBackColor = true;
            // 
            // rdb50
            // 
            this.rdb50.AutoSize = true;
            this.rdb50.Location = new System.Drawing.Point(194, 86);
            this.rdb50.Name = "rdb50";
            this.rdb50.Size = new System.Drawing.Size(63, 17);
            this.rdb50.TabIndex = 13;
            this.rdb50.Text = "R$ 0,50";
            this.rdb50.UseVisualStyleBackColor = true;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(194, 109);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(63, 17);
            this.rdb1.TabIndex = 14;
            this.rdb1.Text = "R$ 1,00";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 44);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblSaldo2
            // 
            this.lblSaldo2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaldo2.Location = new System.Drawing.Point(55, 42);
            this.lblSaldo2.Name = "lblSaldo2";
            this.lblSaldo2.Size = new System.Drawing.Size(103, 20);
            this.lblSaldo2.TabIndex = 10;
            // 
            // frmParquimetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 205);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.rdb50);
            this.Controls.Add(this.rdb25);
            this.Controls.Add(this.rdb10);
            this.Controls.Add(this.lblSaldo2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblSaldo);
            this.Name = "frmParquimetro";
            this.Text = "Parquimetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.RadioButton rdb25;
        private System.Windows.Forms.RadioButton rdb50;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldo2;
    }
}

