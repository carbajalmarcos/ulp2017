namespace Ejercicio2
{
    partial class frmForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBoton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoton2
            // 
            this.btnBoton2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBoton2.Location = new System.Drawing.Point(105, 29);
            this.btnBoton2.Name = "btnBoton2";
            this.btnBoton2.Size = new System.Drawing.Size(75, 23);
            this.btnBoton2.TabIndex = 3;
            this.btnBoton2.Text = "BOTON";
            this.btnBoton2.UseVisualStyleBackColor = false;
            this.btnBoton2.Click += new System.EventHandler(this.btnBoton2_Click);
            // 
            // frmForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.btnBoton2);
            this.Name = "frmForm2";
            this.Text = "frmForm2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoton2;
    }
}