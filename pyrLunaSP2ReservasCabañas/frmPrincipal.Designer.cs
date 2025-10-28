namespace pyrLunaSP2ReservasCabañas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            grpTipoDeCabaña = new GroupBox();
            lblDias = new Label();
            lblPersonas = new Label();
            lblTipo = new Label();
            txtDias = new TextBox();
            cmbPersonas = new ComboBox();
            cmbTipo = new ComboBox();
            grpAdicionales = new GroupBox();
            chkHeladera = new CheckBox();
            chkTelevisor = new CheckBox();
            chkCocina = new CheckBox();
            grpFormaDePago = new GroupBox();
            cmbTarjeta = new ComboBox();
            lblTarjetas = new Label();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            grpTitularDeLaReserva = new GroupBox();
            lblTelefono = new Label();
            lblNombre = new Label();
            txtTelefonos = new TextBox();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            grpTipoDeCabaña.SuspendLayout();
            grpAdicionales.SuspendLayout();
            grpFormaDePago.SuspendLayout();
            grpTitularDeLaReserva.SuspendLayout();
            SuspendLayout();
            // 
            // grpTipoDeCabaña
            // 
            grpTipoDeCabaña.Controls.Add(lblDias);
            grpTipoDeCabaña.Controls.Add(lblPersonas);
            grpTipoDeCabaña.Controls.Add(lblTipo);
            grpTipoDeCabaña.Controls.Add(txtDias);
            grpTipoDeCabaña.Controls.Add(cmbPersonas);
            grpTipoDeCabaña.Controls.Add(cmbTipo);
            grpTipoDeCabaña.Font = new Font("Segoe UI", 14.25F);
            grpTipoDeCabaña.Location = new Point(12, 12);
            grpTipoDeCabaña.Name = "grpTipoDeCabaña";
            grpTipoDeCabaña.Size = new Size(776, 100);
            grpTipoDeCabaña.TabIndex = 0;
            grpTipoDeCabaña.TabStop = false;
            grpTipoDeCabaña.Text = "Tipo de Cabaña";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(547, 35);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(48, 25);
            lblDias.TabIndex = 5;
            lblDias.Text = "Días";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(312, 35);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(87, 25);
            lblPersonas.TabIndex = 4;
            lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(6, 35);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(49, 25);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(601, 32);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(169, 33);
            txtDias.TabIndex = 2;
            txtDias.TextChanged += txtDias_TextChanged;
            // 
            // cmbPersonas
            // 
            cmbPersonas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Location = new Point(405, 32);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(136, 33);
            cmbPersonas.TabIndex = 1;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Tipo A (4 Personas max)", "Tipo B (8 Personas max)" });
            cmbTipo.Location = new Point(61, 32);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(245, 33);
            cmbTipo.TabIndex = 0;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // grpAdicionales
            // 
            grpAdicionales.Controls.Add(chkHeladera);
            grpAdicionales.Controls.Add(chkTelevisor);
            grpAdicionales.Controls.Add(chkCocina);
            grpAdicionales.Font = new Font("Segoe UI", 14.25F);
            grpAdicionales.Location = new Point(12, 118);
            grpAdicionales.Name = "grpAdicionales";
            grpAdicionales.Size = new Size(377, 148);
            grpAdicionales.TabIndex = 3;
            grpAdicionales.TabStop = false;
            grpAdicionales.Text = "Adicionales";
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(6, 67);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(107, 29);
            chkHeladera.TabIndex = 2;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(6, 102);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(104, 29);
            chkTelevisor.TabIndex = 1;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(6, 32);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(89, 29);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // grpFormaDePago
            // 
            grpFormaDePago.Controls.Add(cmbTarjeta);
            grpFormaDePago.Controls.Add(lblTarjetas);
            grpFormaDePago.Controls.Add(optTarjeta);
            grpFormaDePago.Controls.Add(optEfectivo);
            grpFormaDePago.Font = new Font("Segoe UI", 14.25F);
            grpFormaDePago.Location = new Point(411, 118);
            grpFormaDePago.Name = "grpFormaDePago";
            grpFormaDePago.Size = new Size(377, 148);
            grpFormaDePago.TabIndex = 3;
            grpFormaDePago.TabStop = false;
            grpFormaDePago.Text = "Forma de Pago";
            // 
            // cmbTarjeta
            // 
            cmbTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarjeta.FormattingEnabled = true;
            cmbTarjeta.Location = new Point(202, 109);
            cmbTarjeta.Name = "cmbTarjeta";
            cmbTarjeta.Size = new Size(169, 33);
            cmbTarjeta.TabIndex = 3;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(202, 81);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(76, 25);
            lblTarjetas.TabIndex = 2;
            lblTarjetas.Text = "Tarjetas";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(6, 67);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(86, 29);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += optTarjeta_CheckedChanged;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(6, 32);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(96, 29);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // grpTitularDeLaReserva
            // 
            grpTitularDeLaReserva.Controls.Add(lblTelefono);
            grpTitularDeLaReserva.Controls.Add(lblNombre);
            grpTitularDeLaReserva.Controls.Add(txtTelefonos);
            grpTitularDeLaReserva.Controls.Add(txtNombre);
            grpTitularDeLaReserva.Font = new Font("Segoe UI", 14.25F);
            grpTitularDeLaReserva.Location = new Point(12, 272);
            grpTitularDeLaReserva.Name = "grpTitularDeLaReserva";
            grpTitularDeLaReserva.Size = new Size(776, 127);
            grpTitularDeLaReserva.TabIndex = 4;
            grpTitularDeLaReserva.TabStop = false;
            grpTitularDeLaReserva.Text = "Titular de la Reserva";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(18, 74);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(92, 25);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfonos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtTelefonos
            // 
            txtTelefonos.Location = new Point(116, 71);
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.Size = new Size(654, 33);
            txtTelefonos.TabIndex = 1;
            txtTelefonos.TextChanged += txtTelefonos_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(654, 33);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 14.25F);
            btnAceptar.Location = new Point(682, 405);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 33);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(grpTitularDeLaReserva);
            Controls.Add(grpFormaDePago);
            Controls.Add(grpAdicionales);
            Controls.Add(grpTipoDeCabaña);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Reservas de Cabañas";
            Load += frmPrincipal_Load;
            grpTipoDeCabaña.ResumeLayout(false);
            grpTipoDeCabaña.PerformLayout();
            grpAdicionales.ResumeLayout(false);
            grpAdicionales.PerformLayout();
            grpFormaDePago.ResumeLayout(false);
            grpFormaDePago.PerformLayout();
            grpTitularDeLaReserva.ResumeLayout(false);
            grpTitularDeLaReserva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTipoDeCabaña;
        private TextBox txtDias;
        private ComboBox cmbPersonas;
        private ComboBox cmbTipo;
        private GroupBox grpAdicionales;
        private CheckBox chkHeladera;
        private CheckBox chkTelevisor;
        private CheckBox chkCocina;
        private GroupBox grpFormaDePago;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private GroupBox grpTitularDeLaReserva;
        private TextBox txtTelefonos;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Label lblDias;
        private Label lblPersonas;
        private Label lblTipo;
        private ComboBox cmbTarjeta;
        private Label lblTarjetas;
        private Label lblTelefono;
        private Label lblNombre;
    }
}
