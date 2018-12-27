using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Diagnostics;
using Telerik.WinControls.Enumerations;

namespace Prueba_Bascula
{
    public partial class Form1 : Form
    {
        private String Salto_Linea = "\n ";
        private Stopwatch watch = new Stopwatch();

        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            try
            {
                ProBar_Estatus.Visible = false;
                ProBar_Estatus.ShowText = true;
                ProBar_Estatus.WaitingSpeed = 10;
                ProBar_Estatus.WaitingStyle = WaitingBarStyles.Dash;
                ProBar_Estatus.Text = "Leyendo datos de la bascula";

                Btn_Activar.Enabled = false;
                Btn_Desactivar.Enabled = false;
                Btn_Pausa.Enabled = false;

                Lbl_Mensajes.Text = "Configurando puerto";


                Serial_Bascula.PortName = "COM4";
                Serial_Bascula.BaudRate = 9600;
                Serial_Bascula.DataBits = 8;
                Serial_Bascula.Parity = Parity.None;
                Serial_Bascula.StopBits = StopBits.One;
                Serial_Bascula.Handshake = Handshake.None;
                Serial_Bascula.RtsEnable = true;
                Serial_Bascula.DtrEnable = true;
                
                if (!Serial_Bascula.IsOpen)
                {
                    Serial_Bascula.Open();
                }

                Lbl_Mensajes.Text += Salto_Linea + "Puerto configurado";

                Btn_Activar.Enabled = true;

            }
            catch (Exception ex)
            {
                Lbl_Mensajes.Text += Salto_Linea + "Error al configurar bascula [" + ex.Message + "]";
                MessageBox.Show("Error al configurar la bascula de la bascula [" + ex.Message + "]", "Configuracion");
                //throw new Exception("Error Form1_Load [" + ex.Message + "]");
            }
            finally
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Serial_Bascula_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                //String A = Serial_Bascula.ReadLine();
                String Lectura_ = Serial_Bascula.ReadExisting();
                //String[] Lectura_Peso = Lectura_.Split(' ');

                Lectura_ = Lectura_.Replace("kg", "");
                Lectura_ = Lectura_.TrimEnd().TrimStart();

                Lbl_Mensajes.Text = Salto_Linea +  " ******Lectura   "  + Lectura_;

                if ((Lectura_ == "NEG.")
                    || (Lectura_ == "N")
                    || (Lectura_ == "E")
                    || (Lectura_ == "G")
                    || (Lectura_ == "."))
                {
                    Txt_Datos_Bascula.Text = "0 Kg";
                    Lbl_Mensajes.Text = "0 Kg";
                }
                else
                {
                    Txt_Datos_Bascula.Text = Lectura_;
                    Lbl_Mensajes.Text = Lectura_;
                }

                Serial_Bascula.DiscardOutBuffer();
            }
            catch (Exception ex)
            {
                Lbl_Mensajes.Text += Salto_Linea + "Error Serial_Bascula_DataReceived [" + ex.Message + "]";
                throw new Exception("Error Serial_Bascula_DataReceived [" + ex.Message + "]");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Serial_Bascula.IsOpen)
                {
                    Serial_Bascula.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Form1_FormClosing [" + ex.Message + "]");
            }
        }

      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Serial_Bascula_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            try
            {
                MessageBox.Show("Error [Serial_Bascula_ErrorReceived]" , "Cierre de conexion serial");
            }
            catch (Exception ex)
            {
                throw new Exception("Error Serial_Bascula_ErrorReceived  [" + ex.Message + "]");
            }

        }
      

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Lbl_Mensajes.Text = "Activando lectura de la bascula";

                watch = new Stopwatch();
                watch.Start();
                ProBar_Estatus.Visible = true;
                ProBar_Estatus.ResetWaiting();
                ProBar_Estatus.StartWaiting();
                watch.Stop();


                timer1.Enabled = true;
                

                Btn_Activar.Enabled = false;
                Btn_Pausa.Enabled = true;
                Btn_Desactivar.Enabled = true;
                Lbl_Mensajes.Text += Salto_Linea + "Lectura lista para usarse";


            }
            catch (Exception ex)
            {
                throw new Exception("Error button1_Click [" + ex.Message + "]");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Pausa_Click(object sender, EventArgs e)
        {
            try
            {
                watch = new Stopwatch();
                watch.Start();
                ProBar_Estatus.Visible = true;
                ProBar_Estatus.StopWaiting();
                watch.Stop();


                Btn_Activar.Enabled = true;
                Btn_Pausa.Enabled = false;
                Btn_Desactivar.Enabled = true;

                timer1.Enabled = false;


            }
            catch (Exception ex)
            {
                throw new Exception("Error button1_Click [" + ex.Message + "]");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Lbl_Mensajes.Text = "Cerrando lectura de la bascula";
                timer1.Enabled = false;

                watch = new Stopwatch();
                watch.Start();
                ProBar_Estatus.Visible = false;
                ProBar_Estatus.StopWaiting();
                watch.Stop();

                Btn_Activar.Enabled = true;
                Btn_Pausa.Enabled = false;
                Btn_Desactivar.Enabled = false;
                Lbl_Mensajes.Text += Salto_Linea + "Lectura deshabilidada";
            }
            catch (Exception ex)
            {
                throw new Exception("Error button2_Click_1 [" + ex.Message + "]");
            }
        }


        #region Timer
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
               Serial_Bascula.WriteLine("P");
            }
            catch (Exception ex)
            {
                Lbl_Mensajes.Text += Salto_Linea + ex.Message;
                //throw new Exception("Error timer1_Tick [" + ex.Message + "]");
            }
        }
        #endregion

     
    }
}
