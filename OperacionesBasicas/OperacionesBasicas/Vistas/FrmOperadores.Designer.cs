
namespace OperacionesBasicas
{
    partial class FrmSuma
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
            this.label4 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textDato2 = new System.Windows.Forms.TextBox();
            this.textDato1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Resultado";
            this.label4.UseWaitCursor = true;
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(312, 154);
            this.textResultado.Margin = new System.Windows.Forms.Padding(2);
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(56, 20);
            this.textResultado.TabIndex = 37;
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textResultado.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 27);
            this.button1.TabIndex = 36;
            this.button1.Text = "Suma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textDato2
            // 
            this.textDato2.Location = new System.Drawing.Point(242, 162);
            this.textDato2.Margin = new System.Windows.Forms.Padding(2);
            this.textDato2.Name = "textDato2";
            this.textDato2.Size = new System.Drawing.Size(40, 20);
            this.textDato2.TabIndex = 35;
            this.textDato2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDato2.UseWaitCursor = true;
            // 
            // textDato1
            // 
            this.textDato1.Location = new System.Drawing.Point(242, 137);
            this.textDato1.Margin = new System.Windows.Forms.Padding(2);
            this.textDato1.Name = "textDato1";
            this.textDato1.Size = new System.Drawing.Size(40, 20);
            this.textDato1.TabIndex = 34;
            this.textDato1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDato1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Valores";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Suma";
            this.label1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 286);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 27);
            this.button2.TabIndex = 39;
            this.button2.Text = "Resta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 286);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 27);
            this.button3.TabIndex = 40;
            this.button3.Text = "Multiplicacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(461, 286);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 27);
            this.button4.TabIndex = 41;
            this.button4.Text = "Division";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDato2);
            this.Controls.Add(this.textDato1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSuma";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FrmSuma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textDato2;
        private System.Windows.Forms.TextBox textDato1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

