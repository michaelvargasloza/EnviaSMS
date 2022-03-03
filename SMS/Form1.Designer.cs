namespace SMS
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.lblPuertos = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnObtener = new System.Windows.Forms.Button();
            this.gbxPuerto = new System.Windows.Forms.GroupBox();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.txtTamañoBufferLectura = new System.Windows.Forms.TextBox();
            this.txtTiempoEspera = new System.Windows.Forms.TextBox();
            this.txtTamañoBufferEscritura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBitsParada = new System.Windows.Forms.ComboBox();
            this.cmbBitDatos = new System.Windows.Forms.ComboBox();
            this.cmbControlFlujo = new System.Windows.Forms.ComboBox();
            this.cmbParidad = new System.Windows.Forms.ComboBox();
            this.cmbBitPorSegundo = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.gbxPuerto.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(240, 195);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(202, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // txtSMS
            // 
            this.txtSMS.Location = new System.Drawing.Point(240, 221);
            this.txtSMS.Multiline = true;
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(202, 102);
            this.txtSMS.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(182, 198);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(52, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Teléfono:";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(182, 224);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(50, 13);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Location = new System.Drawing.Point(240, 332);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(202, 21);
            this.cmbPuerto.TabIndex = 6;
            // 
            // lblPuertos
            // 
            this.lblPuertos.AutoSize = true;
            this.lblPuertos.Location = new System.Drawing.Point(182, 335);
            this.lblPuertos.Name = "lblPuertos";
            this.lblPuertos.Size = new System.Drawing.Size(46, 13);
            this.lblPuertos.TabIndex = 7;
            this.lblPuertos.Text = "Puertos:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(286, 359);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "&Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(205, 359);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(75, 23);
            this.btnObtener.TabIndex = 9;
            this.btnObtener.Text = "&Obtener";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // gbxPuerto
            // 
            this.gbxPuerto.Controls.Add(this.btnReestablecer);
            this.gbxPuerto.Controls.Add(this.txtTamañoBufferLectura);
            this.gbxPuerto.Controls.Add(this.txtTiempoEspera);
            this.gbxPuerto.Controls.Add(this.txtTamañoBufferEscritura);
            this.gbxPuerto.Controls.Add(this.label8);
            this.gbxPuerto.Controls.Add(this.label7);
            this.gbxPuerto.Controls.Add(this.label6);
            this.gbxPuerto.Controls.Add(this.label5);
            this.gbxPuerto.Controls.Add(this.label4);
            this.gbxPuerto.Controls.Add(this.label3);
            this.gbxPuerto.Controls.Add(this.label2);
            this.gbxPuerto.Controls.Add(this.label1);
            this.gbxPuerto.Controls.Add(this.cmbBitsParada);
            this.gbxPuerto.Controls.Add(this.cmbBitDatos);
            this.gbxPuerto.Controls.Add(this.cmbControlFlujo);
            this.gbxPuerto.Controls.Add(this.cmbParidad);
            this.gbxPuerto.Controls.Add(this.cmbBitPorSegundo);
            this.gbxPuerto.Location = new System.Drawing.Point(12, 27);
            this.gbxPuerto.Name = "gbxPuerto";
            this.gbxPuerto.Size = new System.Drawing.Size(430, 162);
            this.gbxPuerto.TabIndex = 10;
            this.gbxPuerto.TabStop = false;
            this.gbxPuerto.Text = "Configuración del puerto:";
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Location = new System.Drawing.Point(231, 125);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(184, 23);
            this.btnReestablecer.TabIndex = 16;
            this.btnReestablecer.Text = "Reestablecer &Valores";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // txtTamañoBufferLectura
            // 
            this.txtTamañoBufferLectura.Location = new System.Drawing.Point(315, 19);
            this.txtTamañoBufferLectura.Name = "txtTamañoBufferLectura";
            this.txtTamañoBufferLectura.Size = new System.Drawing.Size(100, 20);
            this.txtTamañoBufferLectura.TabIndex = 15;
            // 
            // txtTiempoEspera
            // 
            this.txtTiempoEspera.Location = new System.Drawing.Point(315, 71);
            this.txtTiempoEspera.Name = "txtTiempoEspera";
            this.txtTiempoEspera.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoEspera.TabIndex = 14;
            // 
            // txtTamañoBufferEscritura
            // 
            this.txtTamañoBufferEscritura.Location = new System.Drawing.Point(315, 45);
            this.txtTamañoBufferEscritura.Name = "txtTamañoBufferEscritura";
            this.txtTamañoBufferEscritura.Size = new System.Drawing.Size(100, 20);
            this.txtTamañoBufferEscritura.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tiempo espera:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Buffer escritura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Buffer lectura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bits de parada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bits de datos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Control de flujo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Paridad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bits por segundo:";
            // 
            // cmbBitsParada
            // 
            this.cmbBitsParada.FormattingEnabled = true;
            this.cmbBitsParada.Location = new System.Drawing.Point(101, 127);
            this.cmbBitsParada.Name = "cmbBitsParada";
            this.cmbBitsParada.Size = new System.Drawing.Size(121, 21);
            this.cmbBitsParada.TabIndex = 4;
            // 
            // cmbBitDatos
            // 
            this.cmbBitDatos.FormattingEnabled = true;
            this.cmbBitDatos.Location = new System.Drawing.Point(101, 100);
            this.cmbBitDatos.Name = "cmbBitDatos";
            this.cmbBitDatos.Size = new System.Drawing.Size(121, 21);
            this.cmbBitDatos.TabIndex = 3;
            // 
            // cmbControlFlujo
            // 
            this.cmbControlFlujo.FormattingEnabled = true;
            this.cmbControlFlujo.Location = new System.Drawing.Point(101, 73);
            this.cmbControlFlujo.Name = "cmbControlFlujo";
            this.cmbControlFlujo.Size = new System.Drawing.Size(121, 21);
            this.cmbControlFlujo.TabIndex = 2;
            // 
            // cmbParidad
            // 
            this.cmbParidad.FormattingEnabled = true;
            this.cmbParidad.Location = new System.Drawing.Point(101, 46);
            this.cmbParidad.Name = "cmbParidad";
            this.cmbParidad.Size = new System.Drawing.Size(121, 21);
            this.cmbParidad.TabIndex = 1;
            // 
            // cmbBitPorSegundo
            // 
            this.cmbBitPorSegundo.FormattingEnabled = true;
            this.cmbBitPorSegundo.Location = new System.Drawing.Point(101, 19);
            this.cmbBitPorSegundo.Name = "cmbBitPorSegundo";
            this.cmbBitPorSegundo.Size = new System.Drawing.Size(121, 21);
            this.cmbBitPorSegundo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 393);
            this.Controls.Add(this.gbxPuerto);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lblPuertos);
            this.Controls.Add(this.cmbPuerto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtSMS);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxPuerto.ResumeLayout(false);
            this.gbxPuerto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSMS;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.Label lblPuertos;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.GroupBox gbxPuerto;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.TextBox txtTamañoBufferLectura;
        private System.Windows.Forms.TextBox txtTiempoEspera;
        private System.Windows.Forms.TextBox txtTamañoBufferEscritura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBitsParada;
        private System.Windows.Forms.ComboBox cmbBitDatos;
        private System.Windows.Forms.ComboBox cmbControlFlujo;
        private System.Windows.Forms.ComboBox cmbParidad;
        private System.Windows.Forms.ComboBox cmbBitPorSegundo;
    }
}

