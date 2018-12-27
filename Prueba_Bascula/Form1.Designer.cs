namespace Prueba_Bascula
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
            this.components = new System.ComponentModel.Container();
            this.Serial_Bascula = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Mensajes = new Telerik.WinControls.UI.RadRichTextEditor();
            this.Table_Botones = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Pausa = new Telerik.WinControls.UI.RadButton();
            this.Tabla_Texto = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_Datos_Bascula = new System.Windows.Forms.TextBox();
            this.ProBar_Estatus = new Telerik.WinControls.UI.RadWaitingBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.Btn_Activar = new Telerik.WinControls.UI.RadButton();
            this.Btn_Desactivar = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_Mensajes)).BeginInit();
            this.Table_Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Pausa)).BeginInit();
            this.Tabla_Texto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProBar_Estatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Activar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Desactivar)).BeginInit();
            this.SuspendLayout();
            // 
            // Serial_Bascula
            // 
            this.Serial_Bascula.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.Serial_Bascula_ErrorReceived);
            this.Serial_Bascula.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_Bascula_DataReceived);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Lbl_Mensajes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Table_Botones, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Tabla_Texto, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 413);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Lbl_Mensajes
            // 
            this.Lbl_Mensajes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.Lbl_Mensajes.CaretWidth = float.NaN;
            this.tableLayoutPanel1.SetColumnSpan(this.Lbl_Mensajes, 2);
            this.Lbl_Mensajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Mensajes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mensajes.Location = new System.Drawing.Point(3, 209);
            this.Lbl_Mensajes.Name = "Lbl_Mensajes";
            this.Lbl_Mensajes.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.Lbl_Mensajes.Size = new System.Drawing.Size(510, 201);
            this.Lbl_Mensajes.TabIndex = 6;
            // 
            // Table_Botones
            // 
            this.Table_Botones.ColumnCount = 1;
            this.Table_Botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Botones.Controls.Add(this.Btn_Pausa, 0, 1);
            this.Table_Botones.Controls.Add(this.Btn_Activar, 0, 0);
            this.Table_Botones.Controls.Add(this.Btn_Desactivar, 0, 2);
            this.Table_Botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Botones.Location = new System.Drawing.Point(261, 3);
            this.Table_Botones.Name = "Table_Botones";
            this.Table_Botones.RowCount = 3;
            this.Table_Botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Table_Botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Table_Botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Table_Botones.Size = new System.Drawing.Size(252, 200);
            this.Table_Botones.TabIndex = 7;
            // 
            // Btn_Pausa
            // 
            this.Btn_Pausa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Pausa.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pausa.Image = global::Prueba_Bascula.Properties.Resources.Pausa;
            this.Btn_Pausa.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Pausa.Location = new System.Drawing.Point(3, 69);
            this.Btn_Pausa.Name = "Btn_Pausa";
            this.Btn_Pausa.Size = new System.Drawing.Size(246, 60);
            this.Btn_Pausa.TabIndex = 7;
            this.Btn_Pausa.Text = "Pausa";
            this.Btn_Pausa.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Pausa.ThemeName = "Aqua";
            this.Btn_Pausa.Click += new System.EventHandler(this.Btn_Pausa_Click);
            // 
            // Tabla_Texto
            // 
            this.Tabla_Texto.ColumnCount = 1;
            this.Tabla_Texto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tabla_Texto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tabla_Texto.Controls.Add(this.Txt_Datos_Bascula, 0, 2);
            this.Tabla_Texto.Controls.Add(this.ProBar_Estatus, 0, 4);
            this.Tabla_Texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabla_Texto.Location = new System.Drawing.Point(3, 3);
            this.Tabla_Texto.Name = "Tabla_Texto";
            this.Tabla_Texto.RowCount = 5;
            this.Tabla_Texto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tabla_Texto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tabla_Texto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tabla_Texto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tabla_Texto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tabla_Texto.Size = new System.Drawing.Size(252, 200);
            this.Tabla_Texto.TabIndex = 8;
            // 
            // Txt_Datos_Bascula
            // 
            this.Txt_Datos_Bascula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Datos_Bascula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Datos_Bascula.Location = new System.Drawing.Point(3, 83);
            this.Txt_Datos_Bascula.Name = "Txt_Datos_Bascula";
            this.Txt_Datos_Bascula.Size = new System.Drawing.Size(246, 29);
            this.Txt_Datos_Bascula.TabIndex = 2;
            this.Txt_Datos_Bascula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProBar_Estatus
            // 
            this.ProBar_Estatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProBar_Estatus.Location = new System.Drawing.Point(3, 163);
            this.ProBar_Estatus.Name = "ProBar_Estatus";
            this.ProBar_Estatus.Size = new System.Drawing.Size(246, 34);
            this.ProBar_Estatus.TabIndex = 3;
            this.ProBar_Estatus.Text = "radWaitingBar1";
            this.ProBar_Estatus.ThemeName = "TelerikMetroBlue";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn_Activar
            // 
            this.Btn_Activar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Activar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Activar.Image = global::Prueba_Bascula.Properties.Resources.img_vigente;
            this.Btn_Activar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Activar.Location = new System.Drawing.Point(3, 3);
            this.Btn_Activar.Name = "Btn_Activar";
            this.Btn_Activar.Size = new System.Drawing.Size(246, 60);
            this.Btn_Activar.TabIndex = 8;
            this.Btn_Activar.Text = "Activar";
            this.Btn_Activar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Activar.ThemeName = "Aqua";
            this.Btn_Activar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Desactivar
            // 
            this.Btn_Desactivar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Desactivar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Desactivar.Image = global::Prueba_Bascula.Properties.Resources.img_sin_alta;
            this.Btn_Desactivar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Desactivar.Location = new System.Drawing.Point(3, 135);
            this.Btn_Desactivar.Name = "Btn_Desactivar";
            this.Btn_Desactivar.Size = new System.Drawing.Size(246, 62);
            this.Btn_Desactivar.TabIndex = 9;
            this.Btn_Desactivar.Text = "Desactivar";
            this.Btn_Desactivar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Desactivar.ThemeName = "Aqua";
            this.Btn_Desactivar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 413);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Bascula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_Mensajes)).EndInit();
            this.Table_Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Pausa)).EndInit();
            this.Tabla_Texto.ResumeLayout(false);
            this.Tabla_Texto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProBar_Estatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Activar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Desactivar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort Serial_Bascula;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadRichTextEditor Lbl_Mensajes;
        private System.Windows.Forms.TableLayoutPanel Table_Botones;
        private System.Windows.Forms.TableLayoutPanel Tabla_Texto;
        private System.Windows.Forms.TextBox Txt_Datos_Bascula;
        private Telerik.WinControls.UI.RadWaitingBar ProBar_Estatus;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadButton Btn_Pausa;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadButton Btn_Activar;
        private Telerik.WinControls.UI.RadButton Btn_Desactivar;
    }
}

