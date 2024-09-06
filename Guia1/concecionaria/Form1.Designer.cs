namespace concecionaria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.nModelo = new System.Windows.Forms.NumericUpDown();
            this.nAnioCalcular = new System.Windows.Forms.NumericUpDown();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbTasa = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.btnCacularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAnioCalcular)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año a calcular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de fabricacion $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tasa de depreciacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vida Útil (años):";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(95, 22);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 6;
            // 
            // nModelo
            // 
            this.nModelo.Location = new System.Drawing.Point(95, 55);
            this.nModelo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nModelo.Name = "nModelo";
            this.nModelo.Size = new System.Drawing.Size(93, 20);
            this.nModelo.TabIndex = 7;
            // 
            // nAnioCalcular
            // 
            this.nAnioCalcular.Location = new System.Drawing.Point(95, 93);
            this.nAnioCalcular.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nAnioCalcular.Name = "nAnioCalcular";
            this.nAnioCalcular.Size = new System.Drawing.Size(93, 20);
            this.nAnioCalcular.TabIndex = 8;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(128, 137);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 9;
            // 
            // tbTasa
            // 
            this.tbTasa.Location = new System.Drawing.Point(350, 21);
            this.tbTasa.Name = "tbTasa";
            this.tbTasa.Size = new System.Drawing.Size(100, 20);
            this.tbTasa.TabIndex = 10;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(350, 53);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tbVidaUtil.TabIndex = 11;
            // 
            // btnCacularCosto
            // 
            this.btnCacularCosto.Location = new System.Drawing.Point(70, 177);
            this.btnCacularCosto.Name = "btnCacularCosto";
            this.btnCacularCosto.Size = new System.Drawing.Size(80, 38);
            this.btnCacularCosto.TabIndex = 12;
            this.btnCacularCosto.Text = "Calcular Costo";
            this.btnCacularCosto.UseVisualStyleBackColor = true;
            this.btnCacularCosto.Click += new System.EventHandler(this.btnCacularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(429, 177);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 38);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 227);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCacularCosto);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.tbTasa);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.nAnioCalcular);
            this.Controls.Add(this.nModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAnioCalcular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.NumericUpDown nModelo;
        private System.Windows.Forms.NumericUpDown nAnioCalcular;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbTasa;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.Button btnCacularCosto;
        private System.Windows.Forms.Button btnCerrar;
    }
}

