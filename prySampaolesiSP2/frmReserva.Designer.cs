namespace prySampaolesiSP2
{
    partial class frmReserva
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpbTipo = new GroupBox();
            lblTipo = new Label();
            lblPersonas = new Label();
            lblDias = new Label();
            cmbTipo = new ComboBox();
            cmbPersonas = new ComboBox();
            txtDias = new TextBox();
            gpbAdicionales = new GroupBox();
            chkCocina = new CheckBox();
            chkHeladera = new CheckBox();
            chkTelevisor = new CheckBox();
            gpbFormasPago = new GroupBox();
            optEfectivo = new RadioButton();
            optTarjeta = new RadioButton();
            cmbTarjetas = new ComboBox();
            lblTarjetas = new Label();
            gpbTitular = new GroupBox();
            lblNombre = new Label();
            lblTelefonos = new Label();
            txtNombre = new TextBox();
            txtTelefonos = new TextBox();
            btnAceptar = new Button();
            gpbTipo.SuspendLayout();
            gpbAdicionales.SuspendLayout();
            gpbFormasPago.SuspendLayout();
            gpbTitular.SuspendLayout();
            SuspendLayout();
            // 
            // gpbTipo
            // 
            gpbTipo.Controls.Add(txtDias);
            gpbTipo.Controls.Add(cmbPersonas);
            gpbTipo.Controls.Add(cmbTipo);
            gpbTipo.Controls.Add(lblDias);
            gpbTipo.Controls.Add(lblPersonas);
            gpbTipo.Controls.Add(lblTipo);
            gpbTipo.Location = new Point(12, 12);
            gpbTipo.Name = "gpbTipo";
            gpbTipo.Size = new Size(668, 76);
            gpbTipo.TabIndex = 0;
            gpbTipo.TabStop = false;
            gpbTipo.Text = "Tipo de cabañas";
            gpbTipo.Enter += groupBox1_Enter;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(39, 30);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(271, 33);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(66, 20);
            lblPersonas.TabIndex = 1;
            lblPersonas.Text = "Personas";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(493, 33);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(38, 20);
            lblDias.TabIndex = 2;
            lblDias.Text = "Días";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(84, 30);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(130, 28);
            cmbTipo.TabIndex = 3;
            // 
            // cmbPersonas
            // 
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Location = new Point(343, 30);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(88, 28);
            cmbPersonas.TabIndex = 4;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(537, 30);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(88, 27);
            txtDias.TabIndex = 5;
            // 
            // gpbAdicionales
            // 
            gpbAdicionales.Controls.Add(chkTelevisor);
            gpbAdicionales.Controls.Add(chkHeladera);
            gpbAdicionales.Controls.Add(chkCocina);
            gpbAdicionales.Location = new Point(12, 94);
            gpbAdicionales.Name = "gpbAdicionales";
            gpbAdicionales.Size = new Size(172, 159);
            gpbAdicionales.TabIndex = 1;
            gpbAdicionales.TabStop = false;
            gpbAdicionales.Text = "Adicionales";
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(18, 34);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(76, 24);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(18, 73);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(92, 24);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(18, 113);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(89, 24);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // gpbFormasPago
            // 
            gpbFormasPago.Controls.Add(lblTarjetas);
            gpbFormasPago.Controls.Add(cmbTarjetas);
            gpbFormasPago.Controls.Add(optTarjeta);
            gpbFormasPago.Controls.Add(optEfectivo);
            gpbFormasPago.Location = new Point(190, 94);
            gpbFormasPago.Name = "gpbFormasPago";
            gpbFormasPago.Size = new Size(490, 159);
            gpbFormasPago.TabIndex = 2;
            gpbFormasPago.TabStop = false;
            gpbFormasPago.Text = "Formas de Pago";
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(47, 34);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(83, 24);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(47, 73);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(80, 24);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjetas";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // cmbTarjetas
            // 
            cmbTarjetas.FormattingEnabled = true;
            cmbTarjetas.Location = new Point(220, 100);
            cmbTarjetas.Name = "cmbTarjetas";
            cmbTarjetas.Size = new Size(235, 28);
            cmbTarjetas.TabIndex = 2;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(220, 77);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(59, 20);
            lblTarjetas.TabIndex = 3;
            lblTarjetas.Text = "Tarjetas";
            // 
            // gpbTitular
            // 
            gpbTitular.Controls.Add(txtTelefonos);
            gpbTitular.Controls.Add(txtNombre);
            gpbTitular.Controls.Add(lblTelefonos);
            gpbTitular.Controls.Add(lblNombre);
            gpbTitular.Location = new Point(12, 259);
            gpbTitular.Name = "gpbTitular";
            gpbTitular.Size = new Size(668, 140);
            gpbTitular.TabIndex = 3;
            gpbTitular.TabStop = false;
            gpbTitular.Text = "Titular de la Reserva";
            gpbTitular.Enter += groupBox1_Enter_1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefonos
            // 
            lblTelefonos.AutoSize = true;
            lblTelefonos.Location = new Point(18, 93);
            lblTelefonos.Name = "lblTelefonos";
            lblTelefonos.Size = new Size(73, 20);
            lblTelefonos.TabIndex = 1;
            lblTelefonos.Text = "Telefonos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(524, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(119, 86);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(524, 27);
            txtTelefonos.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(560, 414);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 40);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 475);
            Controls.Add(btnAceptar);
            Controls.Add(gpbTitular);
            Controls.Add(gpbFormasPago);
            Controls.Add(gpbAdicionales);
            Controls.Add(gpbTipo);
            Name = "frmReserva";
            Text = "Reserva de Cabañas";
            gpbTipo.ResumeLayout(false);
            gpbTipo.PerformLayout();
            gpbAdicionales.ResumeLayout(false);
            gpbAdicionales.PerformLayout();
            gpbFormasPago.ResumeLayout(false);
            gpbFormasPago.PerformLayout();
            gpbTitular.ResumeLayout(false);
            gpbTitular.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbTipo;
        private ComboBox cmbPersonas;
        private ComboBox cmbTipo;
        private Label lblDias;
        private Label lblPersonas;
        private Label lblTipo;
        private TextBox txtDias;
        private GroupBox gpbAdicionales;
        private CheckBox chkTelevisor;
        private CheckBox chkHeladera;
        private CheckBox chkCocina;
        private GroupBox gpbFormasPago;
        private Label lblTarjetas;
        private ComboBox cmbTarjetas;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private GroupBox gpbTitular;
        private TextBox txtTelefonos;
        private TextBox txtNombre;
        private Label lblTelefonos;
        private Label lblNombre;
        private Button btnAceptar;
    }
}
