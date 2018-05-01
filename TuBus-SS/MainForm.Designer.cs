namespace TuBus_SS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnParqueo = new System.Windows.Forms.Button();
            this.tbParqueoEstado = new System.Windows.Forms.TextBox();
            this.tbIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endpoints = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbListaTarjetas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbListaChofer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbListaBus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUpdatePosicion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLlegadaBus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbIngresoPasajero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSalidaBus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRegistrarRecorrido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbListaRuta = new System.Windows.Forms.TextBox();
            this.tbSalida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbApiBaseDev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.nTerminalId = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbApiBaseProd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbEnv = new System.Windows.Forms.ComboBox();
            this.endpoints.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTerminalId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParqueo
            // 
            this.btnParqueo.Location = new System.Drawing.Point(75, 126);
            this.btnParqueo.Margin = new System.Windows.Forms.Padding(4);
            this.btnParqueo.Name = "btnParqueo";
            this.btnParqueo.Size = new System.Drawing.Size(185, 44);
            this.btnParqueo.TabIndex = 0;
            this.btnParqueo.Text = "Iniciar Parqueo";
            this.btnParqueo.UseVisualStyleBackColor = true;
            this.btnParqueo.Click += new System.EventHandler(this.btnParqueo_Click);
            // 
            // tbParqueoEstado
            // 
            this.tbParqueoEstado.Location = new System.Drawing.Point(200, 227);
            this.tbParqueoEstado.Margin = new System.Windows.Forms.Padding(4);
            this.tbParqueoEstado.Name = "tbParqueoEstado";
            this.tbParqueoEstado.Size = new System.Drawing.Size(684, 31);
            this.tbParqueoEstado.TabIndex = 2;
            this.tbParqueoEstado.Text = "ParqueoPublico/ObtenerParqueoPorTerminal";
            // 
            // tbIngreso
            // 
            this.tbIngreso.Location = new System.Drawing.Point(200, 129);
            this.tbIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.tbIngreso.Name = "tbIngreso";
            this.tbIngreso.Size = new System.Drawing.Size(684, 31);
            this.tbIngreso.TabIndex = 4;
            this.tbIngreso.Text = "ParqueoPublico/RegistrarIngreso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingreso Parqueo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado Parqueo:";
            // 
            // endpoints
            // 
            this.endpoints.Controls.Add(this.tbApiBaseProd);
            this.endpoints.Controls.Add(this.label15);
            this.endpoints.Controls.Add(this.label14);
            this.endpoints.Controls.Add(this.tbListaTarjetas);
            this.endpoints.Controls.Add(this.label13);
            this.endpoints.Controls.Add(this.tbListaChofer);
            this.endpoints.Controls.Add(this.label12);
            this.endpoints.Controls.Add(this.tbListaBus);
            this.endpoints.Controls.Add(this.label11);
            this.endpoints.Controls.Add(this.tbUpdatePosicion);
            this.endpoints.Controls.Add(this.label10);
            this.endpoints.Controls.Add(this.tbLlegadaBus);
            this.endpoints.Controls.Add(this.label9);
            this.endpoints.Controls.Add(this.tbIngresoPasajero);
            this.endpoints.Controls.Add(this.label8);
            this.endpoints.Controls.Add(this.tbSalidaBus);
            this.endpoints.Controls.Add(this.label7);
            this.endpoints.Controls.Add(this.tbRegistrarRecorrido);
            this.endpoints.Controls.Add(this.label2);
            this.endpoints.Controls.Add(this.tbListaRuta);
            this.endpoints.Controls.Add(this.tbSalida);
            this.endpoints.Controls.Add(this.label6);
            this.endpoints.Controls.Add(this.tbApiBaseDev);
            this.endpoints.Controls.Add(this.label5);
            this.endpoints.Controls.Add(this.tbIngreso);
            this.endpoints.Controls.Add(this.label3);
            this.endpoints.Controls.Add(this.tbParqueoEstado);
            this.endpoints.Controls.Add(this.label1);
            this.endpoints.Location = new System.Drawing.Point(12, 241);
            this.endpoints.Margin = new System.Windows.Forms.Padding(4);
            this.endpoints.Name = "endpoints";
            this.endpoints.Padding = new System.Windows.Forms.Padding(4);
            this.endpoints.Size = new System.Drawing.Size(906, 725);
            this.endpoints.TabIndex = 8;
            this.endpoints.TabStop = false;
            this.endpoints.Text = "Endpoints";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 426);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Lista tarjetas:";
            // 
            // tbListaTarjetas
            // 
            this.tbListaTarjetas.Location = new System.Drawing.Point(200, 423);
            this.tbListaTarjetas.Margin = new System.Windows.Forms.Padding(4);
            this.tbListaTarjetas.Name = "tbListaTarjetas";
            this.tbListaTarjetas.Size = new System.Drawing.Size(684, 31);
            this.tbListaTarjetas.TabIndex = 28;
            this.tbListaTarjetas.Text = "Tarjeta/GetAllCards";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 377);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Lista choferes:";
            // 
            // tbListaChofer
            // 
            this.tbListaChofer.Location = new System.Drawing.Point(200, 374);
            this.tbListaChofer.Margin = new System.Windows.Forms.Padding(4);
            this.tbListaChofer.Name = "tbListaChofer";
            this.tbListaChofer.Size = new System.Drawing.Size(684, 31);
            this.tbListaChofer.TabIndex = 26;
            this.tbListaChofer.Text = "Chofer/ObtenerChofer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 328);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Lista buses:";
            // 
            // tbListaBus
            // 
            this.tbListaBus.Location = new System.Drawing.Point(200, 325);
            this.tbListaBus.Margin = new System.Windows.Forms.Padding(4);
            this.tbListaBus.Name = "tbListaBus";
            this.tbListaBus.Size = new System.Drawing.Size(684, 31);
            this.tbListaBus.TabIndex = 24;
            this.tbListaBus.Text = "Bus/ObtenerBuses";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 671);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Posicion bus:";
            // 
            // tbUpdatePosicion
            // 
            this.tbUpdatePosicion.Location = new System.Drawing.Point(200, 668);
            this.tbUpdatePosicion.Margin = new System.Windows.Forms.Padding(4);
            this.tbUpdatePosicion.Name = "tbUpdatePosicion";
            this.tbUpdatePosicion.Size = new System.Drawing.Size(684, 31);
            this.tbUpdatePosicion.TabIndex = 22;
            this.tbUpdatePosicion.Text = "Recorrido/UpdatePosicion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 622);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Llegada bus:";
            // 
            // tbLlegadaBus
            // 
            this.tbLlegadaBus.Location = new System.Drawing.Point(200, 619);
            this.tbLlegadaBus.Margin = new System.Windows.Forms.Padding(4);
            this.tbLlegadaBus.Name = "tbLlegadaBus";
            this.tbLlegadaBus.Size = new System.Drawing.Size(684, 31);
            this.tbLlegadaBus.TabIndex = 20;
            this.tbLlegadaBus.Text = "Recorrido/Llegada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 573);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ingreso pasajero:";
            // 
            // tbIngresoPasajero
            // 
            this.tbIngresoPasajero.Location = new System.Drawing.Point(200, 570);
            this.tbIngresoPasajero.Margin = new System.Windows.Forms.Padding(4);
            this.tbIngresoPasajero.Name = "tbIngresoPasajero";
            this.tbIngresoPasajero.Size = new System.Drawing.Size(684, 31);
            this.tbIngresoPasajero.TabIndex = 18;
            this.tbIngresoPasajero.Text = "Recorrido/Ingreso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 524);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Salida de bus:";
            // 
            // tbSalidaBus
            // 
            this.tbSalidaBus.Location = new System.Drawing.Point(200, 521);
            this.tbSalidaBus.Margin = new System.Windows.Forms.Padding(4);
            this.tbSalidaBus.Name = "tbSalidaBus";
            this.tbSalidaBus.Size = new System.Drawing.Size(684, 31);
            this.tbSalidaBus.TabIndex = 16;
            this.tbSalidaBus.Text = "Recorrido/Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bus en rampa:";
            // 
            // tbRegistrarRecorrido
            // 
            this.tbRegistrarRecorrido.Location = new System.Drawing.Point(200, 472);
            this.tbRegistrarRecorrido.Margin = new System.Windows.Forms.Padding(4);
            this.tbRegistrarRecorrido.Name = "tbRegistrarRecorrido";
            this.tbRegistrarRecorrido.Size = new System.Drawing.Size(684, 31);
            this.tbRegistrarRecorrido.TabIndex = 14;
            this.tbRegistrarRecorrido.Text = "Recorrido/RegistrarRecorrido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lista rutas:";
            // 
            // tbListaRuta
            // 
            this.tbListaRuta.Location = new System.Drawing.Point(200, 276);
            this.tbListaRuta.Margin = new System.Windows.Forms.Padding(4);
            this.tbListaRuta.Name = "tbListaRuta";
            this.tbListaRuta.Size = new System.Drawing.Size(684, 31);
            this.tbListaRuta.TabIndex = 12;
            this.tbListaRuta.Text = "Ruta/GetAll";
            // 
            // tbSalida
            // 
            this.tbSalida.Location = new System.Drawing.Point(200, 178);
            this.tbSalida.Margin = new System.Windows.Forms.Padding(4);
            this.tbSalida.Name = "tbSalida";
            this.tbSalida.Size = new System.Drawing.Size(684, 31);
            this.tbSalida.TabIndex = 10;
            this.tbSalida.Text = "ParqueoPublico/RegistrarSalida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salida Parqueo:";
            // 
            // tbApiBaseDev
            // 
            this.tbApiBaseDev.Location = new System.Drawing.Point(200, 31);
            this.tbApiBaseDev.Margin = new System.Windows.Forms.Padding(4);
            this.tbApiBaseDev.Name = "tbApiBaseDev";
            this.tbApiBaseDev.Size = new System.Drawing.Size(684, 31);
            this.tbApiBaseDev.TabIndex = 8;
            this.tbApiBaseDev.Text = "http://api.tubus.local:10105/api/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "API Base Dev:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEnv);
            this.groupBox1.Controls.Add(this.btnTerminal);
            this.groupBox1.Controls.Add(this.nTerminalId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnParqueo);
            this.groupBox1.Location = new System.Drawing.Point(382, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(536, 205);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // btnTerminal
            // 
            this.btnTerminal.Location = new System.Drawing.Point(276, 126);
            this.btnTerminal.Margin = new System.Windows.Forms.Padding(4);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(185, 44);
            this.btnTerminal.TabIndex = 4;
            this.btnTerminal.Text = "Iniciar Terminal";
            this.btnTerminal.UseVisualStyleBackColor = true;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // nTerminalId
            // 
            this.nTerminalId.Location = new System.Drawing.Point(140, 61);
            this.nTerminalId.Margin = new System.Windows.Forms.Padding(4);
            this.nTerminalId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTerminalId.Name = "nTerminalId";
            this.nTerminalId.Size = new System.Drawing.Size(120, 31);
            this.nTerminalId.TabIndex = 3;
            this.nTerminalId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Terminal ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TuBus_SS.Properties.Resources.tubus_login_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tbApiBaseProd
            // 
            this.tbApiBaseProd.Location = new System.Drawing.Point(200, 80);
            this.tbApiBaseProd.Margin = new System.Windows.Forms.Padding(4);
            this.tbApiBaseProd.Name = "tbApiBaseProd";
            this.tbApiBaseProd.Size = new System.Drawing.Size(684, 31);
            this.tbApiBaseProd.TabIndex = 30;
            this.tbApiBaseProd.Text = "https://api.tubus.xicre.com/api/";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 83);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "API Base Prod:";
            // 
            // cbEnv
            // 
            this.cbEnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnv.FormattingEnabled = true;
            this.cbEnv.Items.AddRange(new object[] {
            "Prod",
            "Dev"});
            this.cbEnv.Location = new System.Drawing.Point(276, 60);
            this.cbEnv.Name = "cbEnv";
            this.cbEnv.Size = new System.Drawing.Size(238, 33);
            this.cbEnv.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 984);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.endpoints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "TuBus Simulation Service";
            this.endpoints.ResumeLayout(false);
            this.endpoints.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTerminalId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParqueo;
        private System.Windows.Forms.TextBox tbParqueoEstado;
        private System.Windows.Forms.TextBox tbIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox endpoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nTerminalId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbApiBaseDev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSalida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTerminal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbListaRuta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLlegadaBus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbIngresoPasajero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSalidaBus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRegistrarRecorrido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUpdatePosicion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbListaChofer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbListaBus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbListaTarjetas;
        private System.Windows.Forms.TextBox tbApiBaseProd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbEnv;
    }
}

