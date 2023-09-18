namespace FormComplejos_G2_2024_I
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
            this.components = new System.ComponentModel.Container();
            this.txtbReal1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbImaginaria1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbReal2 = new System.Windows.Forms.TextBox();
            this.txtbImaginaria2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSuma = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnConjugar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbReal1
            // 
            this.txtbReal1.Location = new System.Drawing.Point(38, 97);
            this.txtbReal1.Name = "txtbReal1";
            this.txtbReal1.Size = new System.Drawing.Size(73, 22);
            this.txtbReal1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complejo1";
            // 
            // txtbImaginaria1
            // 
            this.txtbImaginaria1.Location = new System.Drawing.Point(161, 97);
            this.txtbImaginaria1.Name = "txtbImaginaria1";
            this.txtbImaginaria1.Size = new System.Drawing.Size(73, 22);
            this.txtbImaginaria1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "i";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "+";
            // 
            // txtbReal2
            // 
            this.txtbReal2.Location = new System.Drawing.Point(315, 101);
            this.txtbReal2.Name = "txtbReal2";
            this.txtbReal2.Size = new System.Drawing.Size(73, 22);
            this.txtbReal2.TabIndex = 0;
            // 
            // txtbImaginaria2
            // 
            this.txtbImaginaria2.Location = new System.Drawing.Point(429, 100);
            this.txtbImaginaria2.Name = "txtbImaginaria2";
            this.txtbImaginaria2.Size = new System.Drawing.Size(73, 22);
            this.txtbImaginaria2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "=";
            // 
            // lbSuma
            // 
            this.lbSuma.AutoSize = true;
            this.lbSuma.Location = new System.Drawing.Point(575, 103);
            this.lbSuma.Name = "lbSuma";
            this.lbSuma.Size = new System.Drawing.Size(31, 16);
            this.lbSuma.TabIndex = 1;
            this.lbSuma.Text = "0+0i";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Complejo2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(704, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "i";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(38, 170);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 45);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnConjugar
            // 
            this.btnConjugar.Location = new System.Drawing.Point(159, 170);
            this.btnConjugar.Name = "btnConjugar";
            this.btnConjugar.Size = new System.Drawing.Size(75, 45);
            this.btnConjugar.TabIndex = 2;
            this.btnConjugar.Text = "Conjugar";
            this.btnConjugar.UseVisualStyleBackColor = true;
            this.btnConjugar.Click += new System.EventHandler(this.btnConjugar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(272, 170);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 45);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 269);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnConjugar);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbImaginaria2);
            this.Controls.Add(this.txtbImaginaria1);
            this.Controls.Add(this.txtbReal2);
            this.Controls.Add(this.txtbReal1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbReal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbImaginaria1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbReal2;
        private System.Windows.Forms.TextBox txtbImaginaria2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSuma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnConjugar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

