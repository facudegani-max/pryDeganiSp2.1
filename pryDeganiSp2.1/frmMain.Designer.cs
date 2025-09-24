namespace pryDeganiSp2._1
{
    partial class frmMain
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
            lblTipo = new Label();
            lblPersonas = new Label();
            lblCant_Dias = new Label();
            groupBoxTipo_Cabaña = new GroupBox();
            txtDias = new TextBox();
            cmbPersonas = new ComboBox();
            cmbTipo = new ComboBox();
            groupBoxAdicionales = new GroupBox();
            chkTelevisor = new CheckBox();
            chkHeladera = new CheckBox();
            chkCocina = new CheckBox();
            groupBoxForma_Pago = new GroupBox();
            lblTarjetas = new Label();
            cmbTarjeta = new ComboBox();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            groupBoxTitular_Reserva = new GroupBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            labelTelefono = new Label();
            lblNombre = new Label();
            btnAceptar = new Button();
            groupBoxTipo_Cabaña.SuspendLayout();
            groupBoxAdicionales.SuspendLayout();
            groupBoxForma_Pago.SuspendLayout();
            groupBoxTitular_Reserva.SuspendLayout();
            SuspendLayout();
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(18, 64);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(252, 64);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(66, 20);
            lblPersonas.TabIndex = 1;
            lblPersonas.Text = "Personas";
            // 
            // lblCant_Dias
            // 
            lblCant_Dias.AutoSize = true;
            lblCant_Dias.Location = new Point(474, 64);
            lblCant_Dias.Name = "lblCant_Dias";
            lblCant_Dias.Size = new Size(38, 20);
            lblCant_Dias.TabIndex = 2;
            lblCant_Dias.Text = "Dias";
            // 
            // groupBoxTipo_Cabaña
            // 
            groupBoxTipo_Cabaña.Controls.Add(txtDias);
            groupBoxTipo_Cabaña.Controls.Add(cmbPersonas);
            groupBoxTipo_Cabaña.Controls.Add(cmbTipo);
            groupBoxTipo_Cabaña.Controls.Add(lblTipo);
            groupBoxTipo_Cabaña.Controls.Add(lblCant_Dias);
            groupBoxTipo_Cabaña.Controls.Add(lblPersonas);
            groupBoxTipo_Cabaña.Location = new Point(43, 24);
            groupBoxTipo_Cabaña.Name = "groupBoxTipo_Cabaña";
            groupBoxTipo_Cabaña.Size = new Size(681, 134);
            groupBoxTipo_Cabaña.TabIndex = 3;
            groupBoxTipo_Cabaña.TabStop = false;
            groupBoxTipo_Cabaña.Text = "Tipo de cabaña";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(534, 61);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(98, 27);
            txtDias.TabIndex = 5;
            txtDias.TextChanged += txtDias_TextChanged;
            // 
            // cmbPersonas
            // 
            cmbPersonas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Location = new Point(340, 60);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(112, 28);
            cmbPersonas.TabIndex = 4;
            cmbPersonas.SelectedIndexChanged += cmbPersonas_SelectedIndexChanged;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(79, 60);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 3;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // groupBoxAdicionales
            // 
            groupBoxAdicionales.Controls.Add(chkTelevisor);
            groupBoxAdicionales.Controls.Add(chkHeladera);
            groupBoxAdicionales.Controls.Add(chkCocina);
            groupBoxAdicionales.Location = new Point(43, 173);
            groupBoxAdicionales.Name = "groupBoxAdicionales";
            groupBoxAdicionales.Size = new Size(250, 163);
            groupBoxAdicionales.TabIndex = 4;
            groupBoxAdicionales.TabStop = false;
            groupBoxAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(40, 95);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(89, 24);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(40, 65);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(92, 24);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(40, 35);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(76, 24);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // groupBoxForma_Pago
            // 
            groupBoxForma_Pago.Controls.Add(lblTarjetas);
            groupBoxForma_Pago.Controls.Add(cmbTarjeta);
            groupBoxForma_Pago.Controls.Add(optTarjeta);
            groupBoxForma_Pago.Controls.Add(optEfectivo);
            groupBoxForma_Pago.Location = new Point(325, 173);
            groupBoxForma_Pago.Name = "groupBoxForma_Pago";
            groupBoxForma_Pago.Size = new Size(399, 163);
            groupBoxForma_Pago.TabIndex = 5;
            groupBoxForma_Pago.TabStop = false;
            groupBoxForma_Pago.Text = "Forma de Pago";
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(192, 96);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(59, 20);
            lblTarjetas.TabIndex = 3;
            lblTarjetas.Text = "Tarjetas";
            // 
            // cmbTarjeta
            // 
            cmbTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarjeta.FormattingEnabled = true;
            cmbTarjeta.Location = new Point(192, 119);
            cmbTarjeta.Name = "cmbTarjeta";
            cmbTarjeta.Size = new Size(183, 28);
            cmbTarjeta.TabIndex = 2;
            cmbTarjeta.SelectedIndexChanged += cmbTarjeta_SelectedIndexChanged;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(20, 65);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(74, 24);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += radioButtonTarjeta_CheckedChanged;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(20, 35);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(83, 24);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // groupBoxTitular_Reserva
            // 
            groupBoxTitular_Reserva.Controls.Add(txtTelefono);
            groupBoxTitular_Reserva.Controls.Add(txtNombre);
            groupBoxTitular_Reserva.Controls.Add(labelTelefono);
            groupBoxTitular_Reserva.Controls.Add(lblNombre);
            groupBoxTitular_Reserva.Location = new Point(43, 366);
            groupBoxTitular_Reserva.Name = "groupBoxTitular_Reserva";
            groupBoxTitular_Reserva.Size = new Size(681, 125);
            groupBoxTitular_Reserva.TabIndex = 6;
            groupBoxTitular_Reserva.TabStop = false;
            groupBoxTitular_Reserva.Text = "Titular Reserva";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(148, 78);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(427, 27);
            txtTelefono.TabIndex = 3;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(427, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(52, 81);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(67, 20);
            labelTelefono.TabIndex = 1;
            labelTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(52, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(577, 515);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(144, 58);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 589);
            Controls.Add(btnAceptar);
            Controls.Add(groupBoxTitular_Reserva);
            Controls.Add(groupBoxForma_Pago);
            Controls.Add(groupBoxAdicionales);
            Controls.Add(groupBoxTipo_Cabaña);
            Name = "frmMain";
            Text = "Reserva de Cabañas";
            groupBoxTipo_Cabaña.ResumeLayout(false);
            groupBoxTipo_Cabaña.PerformLayout();
            groupBoxAdicionales.ResumeLayout(false);
            groupBoxAdicionales.PerformLayout();
            groupBoxForma_Pago.ResumeLayout(false);
            groupBoxForma_Pago.PerformLayout();
            groupBoxTitular_Reserva.ResumeLayout(false);
            groupBoxTitular_Reserva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTipo;
        private Label lblPersonas;
        private Label lblCant_Dias;
        private GroupBox groupBoxTipo_Cabaña;
        private TextBox txtDias;
        private ComboBox cmbPersonas;
        private ComboBox cmbTipo;
        private GroupBox groupBoxAdicionales;
        private CheckBox chkTelevisor;
        private CheckBox chkHeladera;
        private CheckBox chkCocina;
        private GroupBox groupBoxForma_Pago;
        private Label lblTarjetas;
        private ComboBox cmbTarjeta;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private GroupBox groupBoxTitular_Reserva;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label labelTelefono;
        private Label lblNombre;
        private Button btnAceptar;
    }
}
