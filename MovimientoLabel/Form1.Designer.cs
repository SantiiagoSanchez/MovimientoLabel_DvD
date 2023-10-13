namespace MovimientoLabel
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
            this.btInicio = new System.Windows.Forms.Button();
            this.lblPantalla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btInicio
            // 
            this.btInicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btInicio.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btInicio.Location = new System.Drawing.Point(345, 385);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(141, 53);
            this.btInicio.TabIndex = 0;
            this.btInicio.Text = "Iniciar/Start";
            this.btInicio.UseVisualStyleBackColor = false;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // lblPantalla
            // 
            this.lblPantalla.AutoSize = true;
            this.lblPantalla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantalla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPantalla.Location = new System.Drawing.Point(296, 362);
            this.lblPantalla.Name = "lblPantalla";
            this.lblPantalla.Size = new System.Drawing.Size(250, 20);
            this.lblPantalla.TabIndex = 1;
            this.lblPantalla.Text = "Pulse el boton/Push de button";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPantalla);
            this.Controls.Add(this.btInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // Figura
            //
       
        }

        #endregion

        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Label lblPantalla;
    }
}

