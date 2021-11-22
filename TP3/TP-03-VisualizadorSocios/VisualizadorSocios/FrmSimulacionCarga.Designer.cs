
namespace VisualizadorSocios
{
    partial class FrmSimulacionCarga
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
            this.progressBarCargando = new System.Windows.Forms.ProgressBar();
            this.lblCargando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarCargando
            // 
            this.progressBarCargando.Location = new System.Drawing.Point(12, 23);
            this.progressBarCargando.Name = "progressBarCargando";
            this.progressBarCargando.Size = new System.Drawing.Size(305, 32);
            this.progressBarCargando.TabIndex = 0;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Location = new System.Drawing.Point(12, 5);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(59, 15);
            this.lblCargando.TabIndex = 1;
            this.lblCargando.Text = "Cargando";
            // 
            // FrmSimulacionCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 67);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.progressBarCargando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(345, 106);
            this.MinimumSize = new System.Drawing.Size(345, 106);
            this.Name = "FrmSimulacionCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga en curso";
            this.Load += new System.EventHandler(this.FrmSimulacionCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarCargando;
        private System.Windows.Forms.Label lblCargando;
    }
}