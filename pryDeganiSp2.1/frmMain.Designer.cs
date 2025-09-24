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
            comboBoxTipo_Cabaña = new ComboBox();
            comboBoxCant_Personas = new ComboBox();
            textBoxCant_Dias = new TextBox();
            groupBoxAdicionales = new GroupBox();
            checkBoxCocina = new CheckBox();
            checkBoxHeladera = new CheckBox();
            checkBoxTelevisor = new CheckBox();
            groupBoxForma_Pago = new GroupBox();
            radioButtonEfectivo = new RadioButton();
            radioButtonTarjeta = new RadioButton();
            comboBoxTarjetas = new ComboBox();
            lblTarjetas = new Label();
            groupBoxTitular_Reserva = new GroupBox();
            lblNombre = new Label();
            labelTelefono = new Label();
            textBoxNombre = new TextBox();
            textBoxTelefono = new TextBox();
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
            groupBoxTipo_Cabaña.Controls.Add(textBoxCant_Dias);
            groupBoxTipo_Cabaña.Controls.Add(comboBoxCant_Personas);
            groupBoxTipo_Cabaña.Controls.Add(comboBoxTipo_Cabaña);
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
            // comboBoxTipo_Cabaña
            // 
            comboBoxTipo_Cabaña.FormattingEnabled = true;
            comboBoxTipo_Cabaña.Location = new Point(79, 60);
            comboBoxTipo_Cabaña.Name = "comboBoxTipo_Cabaña";
            comboBoxTipo_Cabaña.Size = new Size(151, 28);
            comboBoxTipo_Cabaña.TabIndex = 3;
            // 
            // comboBoxCant_Personas
            // 
            comboBoxCant_Personas.FormattingEnabled = true;
            comboBoxCant_Personas.Location = new Point(340, 60);
            comboBoxCant_Personas.Name = "comboBoxCant_Personas";
            comboBoxCant_Personas.Size = new Size(112, 28);
            comboBoxCant_Personas.TabIndex = 4;
            // 
            // textBoxCant_Dias
            // 
            textBoxCant_Dias.Location = new Point(534, 61);
            textBoxCant_Dias.Name = "textBoxCant_Dias";
            textBoxCant_Dias.Size = new Size(98, 27);
            textBoxCant_Dias.TabIndex = 5;
            // 
            // groupBoxAdicionales
            // 
            groupBoxAdicionales.Controls.Add(checkBoxTelevisor);
            groupBoxAdicionales.Controls.Add(checkBoxHeladera);
            groupBoxAdicionales.Controls.Add(checkBoxCocina);
            groupBoxAdicionales.Location = new Point(43, 173);
            groupBoxAdicionales.Name = "groupBoxAdicionales";
            groupBoxAdicionales.Size = new Size(250, 163);
            groupBoxAdicionales.TabIndex = 4;
            groupBoxAdicionales.TabStop = false;
            groupBoxAdicionales.Text = "Adicionales";
            // 
            // checkBoxCocina
            // 
            checkBoxCocina.AutoSize = true;
            checkBoxCocina.Location = new Point(40, 35);
            checkBoxCocina.Name = "checkBoxCocina";
            checkBoxCocina.Size = new Size(76, 24);
            checkBoxCocina.TabIndex = 0;
            checkBoxCocina.Text = "Cocina";
            checkBoxCocina.UseVisualStyleBackColor = true;
            // 
            // checkBoxHeladera
            // 
            checkBoxHeladera.AutoSize = true;
            checkBoxHeladera.Location = new Point(40, 65);
            checkBoxHeladera.Name = "checkBoxHeladera";
            checkBoxHeladera.Size = new Size(92, 24);
            checkBoxHeladera.TabIndex = 1;
            checkBoxHeladera.Text = "Heladera";
            checkBoxHeladera.UseVisualStyleBackColor = true;
            // 
            // checkBoxTelevisor
            // 
            checkBoxTelevisor.AutoSize = true;
            checkBoxTelevisor.Location = new Point(40, 95);
            checkBoxTelevisor.Name = "checkBoxTelevisor";
            checkBoxTelevisor.Size = new Size(89, 24);
            checkBoxTelevisor.TabIndex = 2;
            checkBoxTelevisor.Text = "Televisor";
            checkBoxTelevisor.UseVisualStyleBackColor = true;
            // 
            // groupBoxForma_Pago
            // 
            groupBoxForma_Pago.Controls.Add(lblTarjetas);
            groupBoxForma_Pago.Controls.Add(comboBoxTarjetas);
            groupBoxForma_Pago.Controls.Add(radioButtonTarjeta);
            groupBoxForma_Pago.Controls.Add(radioButtonEfectivo);
            groupBoxForma_Pago.Location = new Point(325, 173);
            groupBoxForma_Pago.Name = "groupBoxForma_Pago";
            groupBoxForma_Pago.Size = new Size(399, 163);
            groupBoxForma_Pago.TabIndex = 5;
            groupBoxForma_Pago.TabStop = false;
            groupBoxForma_Pago.Text = "Forma de Pago";
            // 
            // radioButtonEfectivo
            // 
            radioButtonEfectivo.AutoSize = true;
            radioButtonEfectivo.Location = new Point(20, 35);
            radioButtonEfectivo.Name = "radioButtonEfectivo";
            radioButtonEfectivo.Size = new Size(83, 24);
            radioButtonEfectivo.TabIndex = 0;
            radioButtonEfectivo.TabStop = true;
            radioButtonEfectivo.Text = "Efectivo";
            radioButtonEfectivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonTarjeta
            // 
            radioButtonTarjeta.AutoSize = true;
            radioButtonTarjeta.Location = new Point(20, 65);
            radioButtonTarjeta.Name = "radioButtonTarjeta";
            radioButtonTarjeta.Size = new Size(74, 24);
            radioButtonTarjeta.TabIndex = 1;
            radioButtonTarjeta.TabStop = true;
            radioButtonTarjeta.Text = "Tarjeta";
            radioButtonTarjeta.UseVisualStyleBackColor = true;
            // 
            // comboBoxTarjetas
            // 
            comboBoxTarjetas.FormattingEnabled = true;
            comboBoxTarjetas.Location = new Point(192, 119);
            comboBoxTarjetas.Name = "comboBoxTarjetas";
            comboBoxTarjetas.Size = new Size(183, 28);
            comboBoxTarjetas.TabIndex = 2;
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
            // groupBoxTitular_Reserva
            // 
            groupBoxTitular_Reserva.Controls.Add(textBoxTelefono);
            groupBoxTitular_Reserva.Controls.Add(textBoxNombre);
            groupBoxTitular_Reserva.Controls.Add(labelTelefono);
            groupBoxTitular_Reserva.Controls.Add(lblNombre);
            groupBoxTitular_Reserva.Location = new Point(43, 366);
            groupBoxTitular_Reserva.Name = "groupBoxTitular_Reserva";
            groupBoxTitular_Reserva.Size = new Size(681, 125);
            groupBoxTitular_Reserva.TabIndex = 6;
            groupBoxTitular_Reserva.TabStop = false;
            groupBoxTitular_Reserva.Text = "Titular Reserva";
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
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(52, 81);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(67, 20);
            labelTelefono.TabIndex = 1;
            labelTelefono.Text = "Telefono";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(148, 38);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(427, 27);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(148, 78);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(427, 27);
            textBoxTelefono.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(577, 515);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(144, 58);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
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
        private TextBox textBoxCant_Dias;
        private ComboBox comboBoxCant_Personas;
        private ComboBox comboBoxTipo_Cabaña;
        private GroupBox groupBoxAdicionales;
        private CheckBox checkBoxTelevisor;
        private CheckBox checkBoxHeladera;
        private CheckBox checkBoxCocina;
        private GroupBox groupBoxForma_Pago;
        private Label lblTarjetas;
        private ComboBox comboBoxTarjetas;
        private RadioButton radioButtonTarjeta;
        private RadioButton radioButtonEfectivo;
        private GroupBox groupBoxTitular_Reserva;
        private TextBox textBoxTelefono;
        private TextBox textBoxNombre;
        private Label labelTelefono;
        private Label lblNombre;
        private Button btnAceptar;
    }
}
