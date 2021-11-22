
namespace VisualizadorSocios
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnAltaSocio = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirTxtStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirXmlStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirJsonStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarTxtStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarXmlStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarJsonStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConexionDBStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirDBStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarDBStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBajaSocio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(62, 205);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(146, 59);
            this.btnEstadisticas.TabIndex = 8;
            this.btnEstadisticas.Text = "Estadisticas históricas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnAltaSocio
            // 
            this.btnAltaSocio.Location = new System.Drawing.Point(62, 140);
            this.btnAltaSocio.Name = "btnAltaSocio";
            this.btnAltaSocio.Size = new System.Drawing.Size(146, 59);
            this.btnAltaSocio.TabIndex = 7;
            this.btnAltaSocio.Text = "Alta socio";
            this.btnAltaSocio.UseVisualStyleBackColor = true;
            this.btnAltaSocio.Click += new System.EventHandler(this.btnAltaSocio_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoStripMenuItem,
            this.ConexionDBStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArchivoStripMenuItem
            // 
            this.ArchivoStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirStripMenuItem,
            this.GuardarStripMenuItem});
            this.ArchivoStripMenuItem.Name = "ArchivoStripMenuItem";
            this.ArchivoStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ArchivoStripMenuItem.Text = "Archivo";
            // 
            // AbrirStripMenuItem
            // 
            this.AbrirStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirTxtStripMenuItem,
            this.AbrirXmlStripMenuItem,
            this.AbrirJsonStripMenuItem});
            this.AbrirStripMenuItem.Name = "AbrirStripMenuItem";
            this.AbrirStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.AbrirStripMenuItem.Text = "Abrir";
            // 
            // AbrirTxtStripMenuItem
            // 
            this.AbrirTxtStripMenuItem.Name = "AbrirTxtStripMenuItem";
            this.AbrirTxtStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AbrirTxtStripMenuItem.Text = "Abrir Txt";
            this.AbrirTxtStripMenuItem.Click += new System.EventHandler(this.AbrirTxtStripMenuItem_Click);
            // 
            // AbrirXmlStripMenuItem
            // 
            this.AbrirXmlStripMenuItem.Name = "AbrirXmlStripMenuItem";
            this.AbrirXmlStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AbrirXmlStripMenuItem.Text = "Abrir Xml";
            this.AbrirXmlStripMenuItem.Click += new System.EventHandler(this.AbrirXmlStripMenuItem_Click);
            // 
            // AbrirJsonStripMenuItem
            // 
            this.AbrirJsonStripMenuItem.Name = "AbrirJsonStripMenuItem";
            this.AbrirJsonStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AbrirJsonStripMenuItem.Text = "Abrir Json";
            // 
            // GuardarStripMenuItem
            // 
            this.GuardarStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuardarTxtStripMenuItem,
            this.GuardarXmlStripMenuItem,
            this.GuardarJsonStripMenuItem});
            this.GuardarStripMenuItem.Name = "GuardarStripMenuItem";
            this.GuardarStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.GuardarStripMenuItem.Text = "Guardar";
            // 
            // GuardarTxtStripMenuItem
            // 
            this.GuardarTxtStripMenuItem.Name = "GuardarTxtStripMenuItem";
            this.GuardarTxtStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.GuardarTxtStripMenuItem.Text = "Guardar Txt";
            this.GuardarTxtStripMenuItem.Click += new System.EventHandler(this.GuardarTxtStripMenuItem_Click);
            // 
            // GuardarXmlStripMenuItem
            // 
            this.GuardarXmlStripMenuItem.Name = "GuardarXmlStripMenuItem";
            this.GuardarXmlStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.GuardarXmlStripMenuItem.Text = "Guardar Xml";
            this.GuardarXmlStripMenuItem.Click += new System.EventHandler(this.GuardarXmlStripMenuItem_Click);
            // 
            // GuardarJsonStripMenuItem
            // 
            this.GuardarJsonStripMenuItem.Name = "GuardarJsonStripMenuItem";
            this.GuardarJsonStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.GuardarJsonStripMenuItem.Text = "Guardar Json";
            // 
            // ConexionDBStripMenuItem1
            // 
            this.ConexionDBStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirDBStripMenuItem1,
            this.GuardarDBStripMenuItem});
            this.ConexionDBStripMenuItem1.Name = "ConexionDBStripMenuItem1";
            this.ConexionDBStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.ConexionDBStripMenuItem1.Text = "Conexión DB";
            // 
            // AbrirDBStripMenuItem1
            // 
            this.AbrirDBStripMenuItem1.Name = "AbrirDBStripMenuItem1";
            this.AbrirDBStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.AbrirDBStripMenuItem1.Text = "Abrir DB";
            this.AbrirDBStripMenuItem1.Click += new System.EventHandler(this.AbrirDBStripMenuItem1_Click);
            // 
            // GuardarDBStripMenuItem
            // 
            this.GuardarDBStripMenuItem.Name = "GuardarDBStripMenuItem";
            this.GuardarDBStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.GuardarDBStripMenuItem.Text = "Guardar en DB";
            this.GuardarDBStripMenuItem.Click += new System.EventHandler(this.GuardarDBStripMenuItem_Click);
            // 
            // btnBajaSocio
            // 
            this.btnBajaSocio.Location = new System.Drawing.Point(62, 270);
            this.btnBajaSocio.Name = "btnBajaSocio";
            this.btnBajaSocio.Size = new System.Drawing.Size(146, 59);
            this.btnBajaSocio.TabIndex = 10;
            this.btnBajaSocio.Text = "Baja socio";
            this.btnBajaSocio.UseVisualStyleBackColor = true;
            this.btnBajaSocio.Click += new System.EventHandler(this.btnBajaSocio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 353);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBajaSocio);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnAltaSocio);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(277, 392);
            this.MinimumSize = new System.Drawing.Size(277, 392);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios River Plate";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnAltaSocio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArchivoStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarTxtStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirTxtStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirXmlStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarXmlStripMenuItem;
        private System.Windows.Forms.Button btnBajaSocio;
        private System.Windows.Forms.ToolStripMenuItem AbrirJsonStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarJsonStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConexionDBStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AbrirDBStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem GuardarDBStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}