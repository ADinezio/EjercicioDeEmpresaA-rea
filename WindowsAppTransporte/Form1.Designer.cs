namespace WindowsAppTransporte
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
            this.btnCrearInstancias = new System.Windows.Forms.Button();
            this.btnMostrarJet = new System.Windows.Forms.Button();
            this.btnHelicoptero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearInstancias
            // 
            this.btnCrearInstancias.Location = new System.Drawing.Point(96, 88);
            this.btnCrearInstancias.Name = "btnCrearInstancias";
            this.btnCrearInstancias.Size = new System.Drawing.Size(140, 57);
            this.btnCrearInstancias.TabIndex = 0;
            this.btnCrearInstancias.Text = "Crear Instancias";
            this.btnCrearInstancias.UseVisualStyleBackColor = true;
            this.btnCrearInstancias.Click += new System.EventHandler(this.btnCrearInstancias_Click);
            // 
            // btnMostrarJet
            // 
            this.btnMostrarJet.Location = new System.Drawing.Point(333, 88);
            this.btnMostrarJet.Name = "btnMostrarJet";
            this.btnMostrarJet.Size = new System.Drawing.Size(140, 57);
            this.btnMostrarJet.TabIndex = 1;
            this.btnMostrarJet.Text = "Mostrar Jet";
            this.btnMostrarJet.UseVisualStyleBackColor = true;
            this.btnMostrarJet.Click += new System.EventHandler(this.btnMostrarJet_Click);
            // 
            // btnHelicoptero
            // 
            this.btnHelicoptero.Location = new System.Drawing.Point(552, 88);
            this.btnHelicoptero.Name = "btnHelicoptero";
            this.btnHelicoptero.Size = new System.Drawing.Size(140, 57);
            this.btnHelicoptero.TabIndex = 2;
            this.btnHelicoptero.Text = "Mostrar Helicoptero";
            this.btnHelicoptero.UseVisualStyleBackColor = true;
            this.btnHelicoptero.Click += new System.EventHandler(this.btnHelicoptero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 508);
            this.Controls.Add(this.btnHelicoptero);
            this.Controls.Add(this.btnMostrarJet);
            this.Controls.Add(this.btnCrearInstancias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearInstancias;
        private System.Windows.Forms.Button btnMostrarJet;
        private System.Windows.Forms.Button btnHelicoptero;
    }
}

