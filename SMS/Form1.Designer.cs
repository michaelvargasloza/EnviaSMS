namespace SMS
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btnEnviar = new System.Windows.Forms.Button();
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
            this.gbxConfiguracion = new System.Windows.Forms.GroupBox();
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
            this.gbxPuerto = new System.Windows.Forms.GroupBox();
            this.gbxMensaje = new System.Windows.Forms.GroupBox();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.lbxEstado = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbxConfiguracion.SuspendLayout();
            this.gbxPuerto.SuspendLayout();
            this.gbxMensaje.SuspendLayout();
            this.gbxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(379, 125);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "&Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(68, 18);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(386, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // txtSMS
            // 
            this.txtSMS.Location = new System.Drawing.Point(68, 44);
            this.txtSMS.Multiline = true;
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(386, 74);
            this.txtSMS.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(10, 21);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(52, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Teléfono:";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(10, 47);
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
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
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
            this.cmbPuerto.Location = new System.Drawing.Point(119, 19);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(335, 21);
            this.cmbPuerto.TabIndex = 6;
            // 
            // lblPuertos
            // 
            this.lblPuertos.AutoSize = true;
            this.lblPuertos.Location = new System.Drawing.Point(6, 22);
            this.lblPuertos.Name = "lblPuertos";
            this.lblPuertos.Size = new System.Drawing.Size(107, 13);
            this.lblPuertos.TabIndex = 7;
            this.lblPuertos.Text = "Seleccione el puerto:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(379, 48);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "&Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(298, 48);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(75, 23);
            this.btnObtener.TabIndex = 9;
            this.btnObtener.Text = "&Obtener";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // gbxConfiguracion
            // 
            this.gbxConfiguracion.Controls.Add(this.btnReestablecer);
            this.gbxConfiguracion.Controls.Add(this.txtTamañoBufferLectura);
            this.gbxConfiguracion.Controls.Add(this.txtTiempoEspera);
            this.gbxConfiguracion.Controls.Add(this.txtTamañoBufferEscritura);
            this.gbxConfiguracion.Controls.Add(this.label8);
            this.gbxConfiguracion.Controls.Add(this.label7);
            this.gbxConfiguracion.Controls.Add(this.label6);
            this.gbxConfiguracion.Controls.Add(this.label5);
            this.gbxConfiguracion.Controls.Add(this.label4);
            this.gbxConfiguracion.Controls.Add(this.label3);
            this.gbxConfiguracion.Controls.Add(this.label2);
            this.gbxConfiguracion.Controls.Add(this.label1);
            this.gbxConfiguracion.Controls.Add(this.cmbBitsParada);
            this.gbxConfiguracion.Controls.Add(this.cmbBitDatos);
            this.gbxConfiguracion.Controls.Add(this.cmbControlFlujo);
            this.gbxConfiguracion.Controls.Add(this.cmbParidad);
            this.gbxConfiguracion.Controls.Add(this.cmbBitPorSegundo);
            this.gbxConfiguracion.Location = new System.Drawing.Point(12, 27);
            this.gbxConfiguracion.Name = "gbxConfiguracion";
            this.gbxConfiguracion.Size = new System.Drawing.Size(460, 159);
            this.gbxConfiguracion.TabIndex = 10;
            this.gbxConfiguracion.TabStop = false;
            this.gbxConfiguracion.Text = "Configuración del puerto:";
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Location = new System.Drawing.Point(270, 125);
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
            this.txtTamañoBufferLectura.Size = new System.Drawing.Size(139, 20);
            this.txtTamañoBufferLectura.TabIndex = 15;
            // 
            // txtTiempoEspera
            // 
            this.txtTiempoEspera.Location = new System.Drawing.Point(315, 71);
            this.txtTiempoEspera.Name = "txtTiempoEspera";
            this.txtTiempoEspera.Size = new System.Drawing.Size(139, 20);
            this.txtTiempoEspera.TabIndex = 14;
            // 
            // txtTamañoBufferEscritura
            // 
            this.txtTamañoBufferEscritura.Location = new System.Drawing.Point(315, 45);
            this.txtTamañoBufferEscritura.Name = "txtTamañoBufferEscritura";
            this.txtTamañoBufferEscritura.Size = new System.Drawing.Size(139, 20);
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
            // gbxPuerto
            // 
            this.gbxPuerto.Controls.Add(this.lblPuertos);
            this.gbxPuerto.Controls.Add(this.cmbPuerto);
            this.gbxPuerto.Controls.Add(this.btnObtener);
            this.gbxPuerto.Controls.Add(this.btnConectar);
            this.gbxPuerto.Location = new System.Drawing.Point(12, 192);
            this.gbxPuerto.Name = "gbxPuerto";
            this.gbxPuerto.Size = new System.Drawing.Size(460, 77);
            this.gbxPuerto.TabIndex = 11;
            this.gbxPuerto.TabStop = false;
            this.gbxPuerto.Text = "Puerto:";
            // 
            // gbxMensaje
            // 
            this.gbxMensaje.Controls.Add(this.txtSMS);
            this.gbxMensaje.Controls.Add(this.btnEnviar);
            this.gbxMensaje.Controls.Add(this.txtTelefono);
            this.gbxMensaje.Controls.Add(this.lblMensaje);
            this.gbxMensaje.Controls.Add(this.lblNumero);
            this.gbxMensaje.Location = new System.Drawing.Point(12, 275);
            this.gbxMensaje.Name = "gbxMensaje";
            this.gbxMensaje.Size = new System.Drawing.Size(460, 154);
            this.gbxMensaje.TabIndex = 12;
            this.gbxMensaje.TabStop = false;
            this.gbxMensaje.Text = "Mensaje:";
            // 
            // gbxEstado
            // 
            this.gbxEstado.Controls.Add(this.lbxEstado);
            this.gbxEstado.Location = new System.Drawing.Point(12, 435);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(460, 131);
            this.gbxEstado.TabIndex = 13;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estado:";
            // 
            // lbxEstado
            // 
            this.lbxEstado.FormattingEnabled = true;
            this.lbxEstado.Location = new System.Drawing.Point(6, 19);
            this.lbxEstado.Name = "lbxEstado";
            this.lbxEstado.Size = new System.Drawing.Size(448, 95);
            this.lbxEstado.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(9, 569);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(110, 13);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "01/01/2000 00:00:00";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 591);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.gbxMensaje);
            this.Controls.Add(this.gbxPuerto);
            this.Controls.Add(this.gbxConfiguracion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxConfiguracion.ResumeLayout(false);
            this.gbxConfiguracion.PerformLayout();
            this.gbxPuerto.ResumeLayout(false);
            this.gbxPuerto.PerformLayout();
            this.gbxMensaje.ResumeLayout(false);
            this.gbxMensaje.PerformLayout();
            this.gbxEstado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
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
        private System.Windows.Forms.GroupBox gbxConfiguracion;
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
        private System.Windows.Forms.GroupBox gbxPuerto;
        private System.Windows.Forms.GroupBox gbxMensaje;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.ListBox lbxEstado;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
    }
}

