namespace Cliente_SP
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxCuadrado = new System.Windows.Forms.TextBox();
            this.TxBaseTri = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TxCirculo = new System.Windows.Forms.TextBox();
            this.BtnCuadrado = new System.Windows.Forms.Button();
            this.BtnTriangulo = new System.Windows.Forms.Button();
            this.BtnCirculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio Web para calcular Areas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cálculo Área del Cuadrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cálculo Área del Triangulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese Base ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingrese Altura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cálculo Área del Circulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ingrese Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Resultado";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LblResultado.Location = new System.Drawing.Point(684, 130);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 16);
            this.LblResultado.TabIndex = 9;
            // 
            // TxCuadrado
            // 
            this.TxCuadrado.Location = new System.Drawing.Point(154, 117);
            this.TxCuadrado.Name = "TxCuadrado";
            this.TxCuadrado.Size = new System.Drawing.Size(100, 22);
            this.TxCuadrado.TabIndex = 10;
            // 
            // TxBaseTri
            // 
            this.TxBaseTri.Location = new System.Drawing.Point(154, 229);
            this.TxBaseTri.Name = "TxBaseTri";
            this.TxBaseTri.Size = new System.Drawing.Size(100, 22);
            this.TxBaseTri.TabIndex = 11;
            this.TxBaseTri.TextChanged += new System.EventHandler(this.TxBaseTri_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(376, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 12;
            // 
            // TxCirculo
            // 
            this.TxCirculo.Location = new System.Drawing.Point(154, 345);
            this.TxCirculo.Name = "TxCirculo";
            this.TxCirculo.Size = new System.Drawing.Size(100, 22);
            this.TxCirculo.TabIndex = 13;
            // 
            // BtnCuadrado
            // 
            this.BtnCuadrado.Location = new System.Drawing.Point(546, 99);
            this.BtnCuadrado.Name = "BtnCuadrado";
            this.BtnCuadrado.Size = new System.Drawing.Size(75, 23);
            this.BtnCuadrado.TabIndex = 14;
            this.BtnCuadrado.Text = "button1";
            this.BtnCuadrado.UseVisualStyleBackColor = true;
            this.BtnCuadrado.Click += new System.EventHandler(this.BtnCuadrado_Click);
            // 
            // BtnTriangulo
            // 
            this.BtnTriangulo.Location = new System.Drawing.Point(546, 225);
            this.BtnTriangulo.Name = "BtnTriangulo";
            this.BtnTriangulo.Size = new System.Drawing.Size(75, 23);
            this.BtnTriangulo.TabIndex = 15;
            this.BtnTriangulo.Text = "button2";
            this.BtnTriangulo.UseVisualStyleBackColor = true;
            // 
            // BtnCirculo
            // 
            this.BtnCirculo.Location = new System.Drawing.Point(546, 345);
            this.BtnCirculo.Name = "BtnCirculo";
            this.BtnCirculo.Size = new System.Drawing.Size(75, 23);
            this.BtnCirculo.TabIndex = 16;
            this.BtnCirculo.Text = "button3";
            this.BtnCirculo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCirculo);
            this.Controls.Add(this.BtnTriangulo);
            this.Controls.Add(this.BtnCuadrado);
            this.Controls.Add(this.TxCirculo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TxBaseTri);
            this.Controls.Add(this.TxCuadrado);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxCuadrado;
        private System.Windows.Forms.TextBox TxBaseTri;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TxCirculo;
        private System.Windows.Forms.Button BtnCuadrado;
        private System.Windows.Forms.Button BtnTriangulo;
        private System.Windows.Forms.Button BtnCirculo;
    }
}

