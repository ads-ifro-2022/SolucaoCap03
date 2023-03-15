
namespace RegistroConsumoEnergia
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
            this.lblNrCasa = new System.Windows.Forms.Label();
            this.txtNrCasa = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvLeituras = new System.Windows.Forms.DataGridView();
            this.btnProcessarDados = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalConsumoSemDesconto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrCasa
            // 
            this.lblNrCasa.AutoSize = true;
            this.lblNrCasa.Location = new System.Drawing.Point(29, 28);
            this.lblNrCasa.Name = "lblNrCasa";
            this.lblNrCasa.Size = new System.Drawing.Size(48, 13);
            this.lblNrCasa.TabIndex = 0;
            this.lblNrCasa.Text = "Nr. Casa";
            // 
            // txtNrCasa
            // 
            this.txtNrCasa.Location = new System.Drawing.Point(83, 25);
            this.txtNrCasa.Name = "txtNrCasa";
            this.txtNrCasa.Size = new System.Drawing.Size(70, 20);
            this.txtNrCasa.TabIndex = 1;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(226, 25);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(129, 20);
            this.txtConsumo.TabIndex = 3;
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(169, 28);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(51, 13);
            this.lblConsumo.TabIndex = 2;
            this.lblConsumo.Text = "Consumo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(369, 23);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvLeituras
            // 
            this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeituras.Location = new System.Drawing.Point(32, 64);
            this.dgvLeituras.Name = "dgvLeituras";
            this.dgvLeituras.Size = new System.Drawing.Size(412, 171);
            this.dgvLeituras.TabIndex = 5;
            // 
            // btnProcessarDados
            // 
            this.btnProcessarDados.Location = new System.Drawing.Point(32, 256);
            this.btnProcessarDados.Name = "btnProcessarDados";
            this.btnProcessarDados.Size = new System.Drawing.Size(121, 23);
            this.btnProcessarDados.TabIndex = 6;
            this.btnProcessarDados.Text = "Processar dados";
            this.btnProcessarDados.UseVisualStyleBackColor = true;
            this.btnProcessarDados.Click += new System.EventHandler(this.btnProcessarDados_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(232, 261);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(147, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total consumo com desconto";
            // 
            // lblTotalConsumoSemDesconto
            // 
            this.lblTotalConsumoSemDesconto.AutoSize = true;
            this.lblTotalConsumoSemDesconto.Location = new System.Drawing.Point(409, 261);
            this.lblTotalConsumoSemDesconto.Name = "lblTotalConsumoSemDesconto";
            this.lblTotalConsumoSemDesconto.Size = new System.Drawing.Size(0, 13);
            this.lblTotalConsumoSemDesconto.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 296);
            this.Controls.Add(this.lblTotalConsumoSemDesconto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnProcessarDados);
            this.Controls.Add(this.dgvLeituras);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtNrCasa);
            this.Controls.Add(this.lblNrCasa);
            this.Name = "Form1";
            this.Text = "Registro de Consumo de Energia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNrCasa;
        private System.Windows.Forms.TextBox txtNrCasa;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvLeituras;
        private System.Windows.Forms.Button btnProcessarDados;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalConsumoSemDesconto;
    }
}

