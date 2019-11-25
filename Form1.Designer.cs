namespace ProyectVisual.Net
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
            this.btnanswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnumber2 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnanswer
            // 
            this.btnanswer.Location = new System.Drawing.Point(90, 128);
            this.btnanswer.Name = "btnanswer";
            this.btnanswer.Size = new System.Drawing.Size(75, 23);
            this.btnanswer.TabIndex = 0;
            this.btnanswer.Text = "ANSWER";
            this.btnanswer.UseVisualStyleBackColor = true;
            this.btnanswer.Click += new System.EventHandler(this.btnanswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NUMBER 1";
            // 
            // lblnumber2
            // 
            this.lblnumber2.AutoSize = true;
            this.lblnumber2.Location = new System.Drawing.Point(168, 61);
            this.lblnumber2.Name = "lblnumber2";
            this.lblnumber2.Size = new System.Drawing.Size(63, 13);
            this.lblnumber2.TabIndex = 2;
            this.lblnumber2.Text = "NUMBER 2";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(12, 77);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(100, 20);
            this.txtnumber1.TabIndex = 4;
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(148, 77);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(100, 20);
            this.txtnumber2.TabIndex = 5;
            // 
            // txtanswer
            // 
            this.txtanswer.Location = new System.Drawing.Point(77, 169);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(100, 20);
            this.txtanswer.TabIndex = 6;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(189, 237);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 272);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.lblnumber2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnanswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnanswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnumber2;
        private System.Windows.Forms.TextBox txtnumber1;
        private System.Windows.Forms.TextBox txtnumber2;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Button btnsalir;
    }
}

