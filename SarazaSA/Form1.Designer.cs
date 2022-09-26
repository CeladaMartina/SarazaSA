
namespace SarazaSA
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
            this.LblObjetivo = new System.Windows.Forms.Label();
            this.cboArmas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDisparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblObjetivo
            // 
            this.LblObjetivo.AutoSize = true;
            this.LblObjetivo.Location = new System.Drawing.Point(36, 56);
            this.LblObjetivo.Name = "LblObjetivo";
            this.LblObjetivo.Size = new System.Drawing.Size(171, 17);
            this.LblObjetivo.TabIndex = 0;
            this.LblObjetivo.Text = "El objetivo se encuenta a ";
            // 
            // cboArmas
            // 
            this.cboArmas.FormattingEnabled = true;
            this.cboArmas.Location = new System.Drawing.Point(120, 135);
            this.cboArmas.Name = "cboArmas";
            this.cboArmas.Size = new System.Drawing.Size(265, 24);
            this.cboArmas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arma";
            // 
            // BtnDisparar
            // 
            this.BtnDisparar.Location = new System.Drawing.Point(527, 130);
            this.BtnDisparar.Name = "BtnDisparar";
            this.BtnDisparar.Size = new System.Drawing.Size(89, 33);
            this.BtnDisparar.TabIndex = 4;
            this.BtnDisparar.Text = "Disparar";
            this.BtnDisparar.UseVisualStyleBackColor = true;
            this.BtnDisparar.Click += new System.EventHandler(this.BtnDisparar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 236);
            this.Controls.Add(this.BtnDisparar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboArmas);
            this.Controls.Add(this.LblObjetivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblObjetivo;
        private System.Windows.Forms.ComboBox cboArmas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDisparar;
    }
}

