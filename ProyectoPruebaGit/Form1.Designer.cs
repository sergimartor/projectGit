namespace ProyectoPruebaGit
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
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxDNI = new System.Windows.Forms.TextBox();
            this.TextBoxLetter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ACCEPT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxDNI
            // 
            this.TextBoxDNI.Location = new System.Drawing.Point(47, 118);
            this.TextBoxDNI.Name = "TextBoxDNI";
            this.TextBoxDNI.Size = new System.Drawing.Size(206, 20);
            this.TextBoxDNI.TabIndex = 1;
            this.TextBoxDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxLetter
            // 
            this.TextBoxLetter.Location = new System.Drawing.Point(259, 118);
            this.TextBoxLetter.Name = "TextBoxLetter";
            this.TextBoxLetter.Size = new System.Drawing.Size(90, 20);
            this.TextBoxLetter.TabIndex = 2;
            this.TextBoxLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 265);
            this.Controls.Add(this.TextBoxLetter);
            this.Controls.Add(this.TextBoxDNI);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxDNI;
        private System.Windows.Forms.TextBox TextBoxLetter;
    }
}

