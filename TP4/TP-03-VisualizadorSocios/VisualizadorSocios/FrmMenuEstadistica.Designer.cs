
namespace VisualizadorSocios
{
    partial class FrmMenuEstadistica
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
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.btnExpotarTxt = new System.Windows.Forms.Button();
            this.cmbListaEstadisticas = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInforme
            // 
            this.rtbInforme.Location = new System.Drawing.Point(12, 50);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.Size = new System.Drawing.Size(540, 302);
            this.rtbInforme.TabIndex = 0;
            this.rtbInforme.Text = "";
            // 
            // btnExpotarTxt
            // 
            this.btnExpotarTxt.Location = new System.Drawing.Point(12, 358);
            this.btnExpotarTxt.Name = "btnExpotarTxt";
            this.btnExpotarTxt.Size = new System.Drawing.Size(94, 36);
            this.btnExpotarTxt.TabIndex = 2;
            this.btnExpotarTxt.Text = "Exportar en Txt";
            this.btnExpotarTxt.UseVisualStyleBackColor = true;
            this.btnExpotarTxt.Click += new System.EventHandler(this.btnGuardarInfo_Click);
            // 
            // cmbListaEstadisticas
            // 
            this.cmbListaEstadisticas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaEstadisticas.FormattingEnabled = true;
            this.cmbListaEstadisticas.Items.AddRange(new object[] {
            "Socios Totales",
            "Socios Activos",
            "Simples",
            "Completos",
            "Provincia con más socios",
            "Tribunas con más asignados",
            "Total de ingresos mensuales"});
            this.cmbListaEstadisticas.Location = new System.Drawing.Point(12, 12);
            this.cmbListaEstadisticas.Name = "cmbListaEstadisticas";
            this.cmbListaEstadisticas.Size = new System.Drawing.Size(295, 23);
            this.cmbListaEstadisticas.TabIndex = 8;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(424, 8);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(128, 36);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FrmMenuEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 399);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbListaEstadisticas);
            this.Controls.Add(this.btnExpotarTxt);
            this.Controls.Add(this.rtbInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(580, 438);
            this.MinimumSize = new System.Drawing.Size(580, 438);
            this.Name = "FrmMenuEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInforme;
        private System.Windows.Forms.Button btnExpotarTxt;
        private System.Windows.Forms.ComboBox cmbListaEstadisticas;
        private System.Windows.Forms.Button btnMostrar;
    }
}