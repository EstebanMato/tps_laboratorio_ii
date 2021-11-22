
namespace VisualizadorSocios
{
    partial class FrmMenuAlta
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
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTipoSocio = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.cmbTipoSocio = new System.Windows.Forms.ComboBox();
            this.numupEdad = new System.Windows.Forms.NumericUpDown();
            this.grpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpbSocioCompleto = new System.Windows.Forms.GroupBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTribuna = new System.Windows.Forms.Label();
            this.numudDescuento = new System.Windows.Forms.NumericUpDown();
            this.cmbTribuna = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numupEdad)).BeginInit();
            this.grpbSexo.SuspendLayout();
            this.grpbSocioCompleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(24, 157);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 29;
            this.lblEdad.Text = "Edad";
            // 
            // lblTipoSocio
            // 
            this.lblTipoSocio.AutoSize = true;
            this.lblTipoSocio.Location = new System.Drawing.Point(167, 60);
            this.lblTipoSocio.Name = "lblTipoSocio";
            this.lblTipoSocio.Size = new System.Drawing.Size(78, 15);
            this.lblTipoSocio.TabIndex = 28;
            this.lblTipoSocio.Text = "Tipo de Socio";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(167, 15);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(56, 15);
            this.lblProvincia.TabIndex = 27;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(24, 101);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(25, 15);
            this.lblDni.TabIndex = 26;
            this.lblDni.Text = "Dni";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(24, 59);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(106, 287);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(81, 32);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // cmbTipoSocio
            // 
            this.cmbTipoSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSocio.FormattingEnabled = true;
            this.cmbTipoSocio.Items.AddRange(new object[] {
            "Simple",
            "Completo"});
            this.cmbTipoSocio.Location = new System.Drawing.Point(167, 78);
            this.cmbTipoSocio.Name = "cmbTipoSocio";
            this.cmbTipoSocio.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoSocio.TabIndex = 6;
            this.cmbTipoSocio.SelectedIndexChanged += new System.EventHandler(this.cmbTipoSocio_SelectedIndexChanged);
            // 
            // numupEdad
            // 
            this.numupEdad.Location = new System.Drawing.Point(24, 175);
            this.numupEdad.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numupEdad.Name = "numupEdad";
            this.numupEdad.Size = new System.Drawing.Size(49, 23);
            this.numupEdad.TabIndex = 4;
            // 
            // grpbSexo
            // 
            this.grpbSexo.Controls.Add(this.rbtnMasculino);
            this.grpbSexo.Controls.Add(this.rbtnFemenino);
            this.grpbSexo.Location = new System.Drawing.Point(167, 107);
            this.grpbSexo.Name = "grpbSexo";
            this.grpbSexo.Size = new System.Drawing.Size(49, 78);
            this.grpbSexo.TabIndex = 7;
            this.grpbSexo.TabStop = false;
            this.grpbSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(6, 22);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(36, 19);
            this.rbtnMasculino.TabIndex = 22;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(6, 47);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(31, 19);
            this.rbtnFemenino.TabIndex = 23;
            this.rbtnFemenino.Text = "F";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "Capital Federal",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucumán"});
            this.cmbProvincia.Location = new System.Drawing.Point(167, 34);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 23);
            this.cmbProvincia.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(24, 117);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(24, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(24, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // grpbSocioCompleto
            // 
            this.grpbSocioCompleto.Controls.Add(this.lblDescuento);
            this.grpbSocioCompleto.Controls.Add(this.lblTribuna);
            this.grpbSocioCompleto.Controls.Add(this.numudDescuento);
            this.grpbSocioCompleto.Controls.Add(this.cmbTribuna);
            this.grpbSocioCompleto.Enabled = false;
            this.grpbSocioCompleto.Location = new System.Drawing.Point(24, 204);
            this.grpbSocioCompleto.Name = "grpbSocioCompleto";
            this.grpbSocioCompleto.Size = new System.Drawing.Size(251, 69);
            this.grpbSocioCompleto.TabIndex = 8;
            this.grpbSocioCompleto.TabStop = false;
            this.grpbSocioCompleto.Text = "Socio completo";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(155, 19);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(76, 15);
            this.lblDescuento.TabIndex = 11;
            this.lblDescuento.Text = "Descuento %";
            // 
            // lblTribuna
            // 
            this.lblTribuna.AutoSize = true;
            this.lblTribuna.Location = new System.Drawing.Point(25, 19);
            this.lblTribuna.Name = "lblTribuna";
            this.lblTribuna.Size = new System.Drawing.Size(89, 15);
            this.lblTribuna.TabIndex = 10;
            this.lblTribuna.Text = "Asignar Tribuna";
            // 
            // numudDescuento
            // 
            this.numudDescuento.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numudDescuento.Location = new System.Drawing.Point(163, 40);
            this.numudDescuento.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numudDescuento.Name = "numudDescuento";
            this.numudDescuento.Size = new System.Drawing.Size(45, 23);
            this.numudDescuento.TabIndex = 9;
            // 
            // cmbTribuna
            // 
            this.cmbTribuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTribuna.FormattingEnabled = true;
            this.cmbTribuna.Items.AddRange(new object[] {
            "Sivori",
            "Centenario",
            "Belgrano",
            "San Martin"});
            this.cmbTribuna.Location = new System.Drawing.Point(12, 40);
            this.cmbTribuna.Name = "cmbTribuna";
            this.cmbTribuna.Size = new System.Drawing.Size(121, 23);
            this.cmbTribuna.TabIndex = 8;
            // 
            // FrmMenuAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 331);
            this.Controls.Add(this.grpbSocioCompleto);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblTipoSocio);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.cmbTipoSocio);
            this.Controls.Add(this.numupEdad);
            this.Controls.Add(this.grpbSexo);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(314, 370);
            this.MinimumSize = new System.Drawing.Size(314, 370);
            this.Name = "FrmMenuAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de socio";
            ((System.ComponentModel.ISupportInitialize)(this.numupEdad)).EndInit();
            this.grpbSexo.ResumeLayout(false);
            this.grpbSexo.PerformLayout();
            this.grpbSocioCompleto.ResumeLayout(false);
            this.grpbSocioCompleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTipoSocio;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ComboBox cmbTipoSocio;
        private System.Windows.Forms.NumericUpDown numupEdad;
        private System.Windows.Forms.GroupBox grpbSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpbSocioCompleto;
        private System.Windows.Forms.NumericUpDown numudDescuento;
        private System.Windows.Forms.ComboBox cmbTribuna;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTribuna;
    }
}