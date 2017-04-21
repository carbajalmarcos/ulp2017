namespace Ejercicio2
{
    partial class frmForm1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.Location = new System.Drawing.Point(155, 9);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(100, 59);
            this.lblEtiqueta.TabIndex = 3;
            this.lblEtiqueta.Tag = "";
            this.lblEtiqueta.Text = "MENSAJE ";
            this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBoton1
            // 
            this.btnBoton1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBoton1.Location = new System.Drawing.Point(37, 27);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(75, 23);
            this.btnBoton1.TabIndex = 2;
            this.btnBoton1.Text = "BOTON";
            this.btnBoton1.UseVisualStyleBackColor = false;
            this.btnBoton1.Click += new System.EventHandler(this.btnBoton1_Click);
            // 
            // frmForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 77);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnBoton1);
            this.Name = "frmForm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Button btnBoton1;
    }
}

