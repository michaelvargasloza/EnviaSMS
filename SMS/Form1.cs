using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;//libreria para manejar los puertos
using System.Collections;

namespace SMS
{
    public partial class Form1 : Form
    {
        SerialPort PuertoSerie = new SerialPort(); //Puerto de conexion COM

        public Form1()
        {
            InitializeComponent();
            PuertosInicial(); //Establece los valores del puerto por defecto
            ObtenerPuertos();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PuertoSerie.IsOpen == false)
            {
                //OPCIONES.SelectedTab = tabConfiguracionModem;
                MessageBox.Show("Antes de enviar el mensaje debe de introducir los datos del modem y seleccionarlo", "◄ TRS SMS ►", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefono.Clear();
                txtSMS.Clear();
                //dataGridView1.Columns.Clear();
            }
            else
            {
                if (txtTelefono.Text == "" | txtSMS.Text == "")
                    MessageBox.Show("Introduzca # de teléfono y su mensaje", "◄ TRS SMS ►", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    try
                    {
                        //Poner AT en modo texto
                        PuertoSerie.Write("AT+CMGF=1" + Convert.ToChar(13));
                        System.Threading.Thread.Sleep(1000);
                        PuertoSerie.Write("AT+CMGS=" + Convert.ToChar(34) + txtTelefono.Text
                            + Convert.ToChar(34) + Convert.ToChar(13));
                        System.Threading.Thread.Sleep(1000);
                        PuertoSerie.Write(txtSMS.Text + Convert.ToChar(26));
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(1000);
                        if (PuertoSerie.ReadExisting().IndexOf("OK") > 0)
                        {
                            MessageBox.Show("EL SMS HA SIDO ENVIADO A :" + txtTelefono.Text, "◄ TRS SMS ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtTelefono.Clear();
                            txtSMS.Clear();
                            //dataGridView1.Columns.Clear();
                        }
                        else
                            //Error no esposible el envio
                            MessageBox.Show("No es posible el envio del mensaje", "◄ TRS SMS ►", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        PuertoSerie.DiscardInBuffer();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR : " + ex.ToString());
                    }
                }
            }
        }

        //Metodo que lista los puertos de la PC
        private void ObtenerPuertos()
        {
            ArrayList PuertoSerie = ObtenerPuertosPC();
            cmbPuerto.Items.Clear();
            foreach (string Puerto in PuertoSerie)
            {
                cmbPuerto.Items.Add(Puerto);
            }
            if (cmbPuerto.Items.Count >= 1)
                cmbPuerto.SelectedIndex = 0;
            else
                MessageBox.Show("No se han detectado puertos serie en su equipo, " +
                   "asegúrese de que están correctamente configurados.", "Mensaje");
        }

        //Obtiene los puertos de la PC
        private ArrayList ObtenerPuertosPC()
        {
            ArrayList PuertosSerie = new ArrayList(); //Permite listar los puertos
            try
            {
                foreach (string PuertoObtenido in SerialPort.GetPortNames())
                {
                    PuertosSerie.Add(PuertoObtenido);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return PuertosSerie;
        }

        //Abre el puerto seleccionado
        private void AbrirPuertosSerie(string puerto)
        {
            try
            {
                if (PuertoSerie.IsOpen == true)
                    PuertoSerie.Close();
                else
                {
                    //Introducimos datos del puerto
                    PuertoSerie.PortName = cmbPuerto.Text;
                    PuertoSerie.BaudRate = int.Parse(cmbBitPorSegundo.Text);
                    PuertoSerie.DataBits = int.Parse(cmbBitDatos.Text);
                    switch (cmbBitsParada.Text)
                    {
                        case "1":
                            PuertoSerie.StopBits = System.IO.Ports.StopBits.One;
                            break;
                        case "1.5":
                            PuertoSerie.StopBits = System.IO.Ports.StopBits.OnePointFive;
                            break;
                        case "2":
                            PuertoSerie.StopBits = System.IO.Ports.StopBits.Two;
                            break;
                        case "Ninguno":
                            PuertoSerie.StopBits = System.IO.Ports.StopBits.None;
                            break;
                    }
                    switch (cmbParidad.Text)
                    {
                        case "Par":
                            PuertoSerie.Parity = System.IO.Ports.Parity.Even;
                            break;
                        case "Impar":
                            PuertoSerie.Parity = System.IO.Ports.Parity.Odd;
                            break;
                        case "Ninguno":
                            PuertoSerie.Parity = System.IO.Ports.Parity.None;
                            break;
                        case "Marca":
                            PuertoSerie.Parity = System.IO.Ports.Parity.Mark;
                            break;
                        case "Espacio":
                            PuertoSerie.Parity = System.IO.Ports.Parity.Space;
                            break;
                    }
                    switch (cmbControlFlujo.Text)
                    {
                        case "Hardware":
                            PuertoSerie.Handshake = System.IO.Ports.Handshake.RequestToSend;
                            break;
                        case "Xon / Xoff":
                            PuertoSerie.Handshake = System.IO.Ports.Handshake.XOnXOff;
                            break;
                        case "Ninguno":
                            PuertoSerie.Handshake = System.IO.Ports.Handshake.None;
                            break;
                        case "Hardware y Xon/Xoff":
                            PuertoSerie.Handshake = System.IO.Ports.Handshake.RequestToSendXOnXOff;
                            break;
                    }
                    PuertoSerie.DtrEnable = false;
                    PuertoSerie.ReadBufferSize = int.Parse(txtTamañoBufferLectura.Text);
                    PuertoSerie.WriteBufferSize = int.Parse(txtTamañoBufferEscritura.Text);
                    PuertoSerie.WriteTimeout = int.Parse(txtTiempoEspera.Text);
                    PuertoSerie.RtsEnable = true;
                    PuertoSerie.Encoding = System.Text.Encoding.Default;
                    PuertoSerie.Open();
                }

            }
            catch (Exception)
            {
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            ObtenerPuertos();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPuerto.Text == "")
                    MessageBox.Show("Haga click en: '<<Obtener' para escoger el puerto", "◄ TRS SMS ►", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                //OK
                {
                    //Abrir puertos serie
                    //AbrirPuertosSerie(cmbPuerto.Text);
                    AbrirPuertosSerie(cmbPuerto.Text);
                    PuertoSerie.Write("AT" + Convert.ToChar(13));
                    System.Threading.Thread.Sleep(1000);
                    if (PuertoSerie.ReadExisting().IndexOf("OK") >= 1)
                    {
                        //lbPModem.Text = "MODEM GSM Encontrado";
                        //lbPModem.ForeColor = Color.Green;
                        //OPCIONES.SelectedIndex = 2;
                        //label19.Refresh();
                        //label19.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                        //label19.Refresh();
                        //timer2.Enabled = true;
                        //button7.Enabled = false;
                        //button8.Enabled = true;
                        //lblEstado.Text = "SMS Sort Iniciado";
                        MessageBox.Show("PROGRAMA SMS INICIADO", "◄ TRS SMS ►", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        //lbPModem.Text = "MODEM GSM No Encontrado";
                        //lbPModem.ForeColor = Color.Red;
                    }
                    PuertoSerie.DiscardInBuffer();
                    PuertoSerie.Write("AT+CREG?" + Convert.ToChar(13));
                    System.Threading.Thread.Sleep(1000);
                    if (PuertoSerie.ReadExisting().IndexOf("0,1") >= 1)
                    {
                        //lbEstadoRedMovil.Text = "Red móvil disponible";
                        //lbEstadoRedMovil.ForeColor = Color.Green;
                        MessageBox.Show("CONEXION EXITOSA, PUEDE ENVIAR SMS", "◄ TRS SMS ►", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //OPCIONES.SelectedIndex = 2;
                        //label19.Refresh();
                        //label19.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                        //label19.Refresh();
                        //timer2.Enabled = true;
                        //button7.Enabled = false;
                        //button8.Enabled = true;
                        //lblEstado.Text = "SMS Sort Iniciado";
                    }
                    else
                    {
                        MessageBox.Show("Conexión exitosa, puede enviar sms", "◄ TRS SMS ►", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //lbEstadoRedMovil.Text = "No hay red móvil";
                        //lbEstadoRedMovil.ForeColor = Color.Red;
                        //label19.Refresh();
                        //label19.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                        //label19.Refresh();
                        //timer2.Enabled = true;
                        //button7.Enabled = false;
                        //button8.Enabled = true;
                        //lblEstado.Text = "SMS Sort Iniciado";
                    }
                    PuertoSerie.DiscardInBuffer();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR : EL PUERTO NO PUEDE SER USADO", "◄ TRS SMS ►", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PuertosInicial()
        {
            cmbBitPorSegundo.Text = "9600";
            cmbBitDatos.Text = "8";
            cmbParidad.Text = "Ninguno";
            cmbBitsParada.Text = "1";
            cmbControlFlujo.Text = "Ninguno";
            txtTamañoBufferLectura.Text = "1024";
            txtTamañoBufferEscritura.Text = "1024";
            txtTiempoEspera.Text = "500";
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            cmbBitPorSegundo.Text = "9600";
            cmbParidad.Text = "Ninguno";
            cmbControlFlujo.Text = "Ninguno";
            cmbBitDatos.Text = "8";            
            cmbBitsParada.Text = "1";
            
            txtTamañoBufferLectura.Text = "1024";
            txtTamañoBufferEscritura.Text = "1024";
            txtTiempoEspera.Text = "500";
        }
    }
}
