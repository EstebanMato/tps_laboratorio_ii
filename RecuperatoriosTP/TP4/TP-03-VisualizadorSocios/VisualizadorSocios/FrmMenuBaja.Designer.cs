
namespace VisualizadorSocios
{
    partial class FrmMenuBaja
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
            this.rtbSocios = new System.Windows.Forms.RichTextBox();
            this.numNumeroSocio = new System.Windows.Forms.NumericUpDown();
            this.btnBaja = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbSocios
            // 
            this.rtbSocios.Location = new System.Drawing.Point(0, 0);
            this.rtbSocios.Name = "rtbSocios";
            this.rtbSocios.Size = new System.Drawing.Size(347, 324);
            this.rtbSocios.TabIndex = 0;
            this.rtbSocios.Text = "";
            // 
            // numNumeroSocio
            // 
            this.numNumeroSocio.Location = new System.Drawing.Point(382, 28);
            this.numNumeroSocio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numNumeroSocio.Name = "numNumeroSocio";
            this.numNumeroSocio.Size = new System.Drawing.Size(64, 23);
            this.numNumeroSocio.TabIndex = 1;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(377, 80);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(377, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 15);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Número de ID";
            // 
            // FrmMenuBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 336);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.numNumeroSocio);
            this.Controls.Add(this.rtbSocios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(519, 375);
            this.MinimumSize = new System.Drawing.Size(519, 375);
            this.Name = "FrmMenuBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja socio";
            this.Load += new System.EventHandler(this.FrmMenuBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroSocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSocios;
        private System.Windows.Forms.NumericUpDown numNumeroSocio;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label lblID;
    }
}