namespace TuBus_SS
{
    partial class ParqueoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParqueoForm));
            this.btnCamera = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.pbWebCam = new System.Windows.Forms.PictureBox();
            this.tmRead = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTarjeta = new System.Windows.Forms.TextBox();
            this.lbTarjeta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoParqueo = new System.Windows.Forms.ComboBox();
            this.btnManualCard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(168, 636);
            this.btnCamera.Margin = new System.Windows.Forms.Padding(4);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(242, 60);
            this.btnCamera.TabIndex = 1;
            this.btnCamera.Text = "Iniciar";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDevices);
            this.groupBox1.Controls.Add(this.pbWebCam);
            this.groupBox1.Controls.Add(this.btnCamera);
            this.groupBox1.Location = new System.Drawing.Point(683, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(660, 746);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebCam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dispositivo:";
            // 
            // cbDevices
            // 
            this.cbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(168, 38);
            this.cbDevices.Margin = new System.Windows.Forms.Padding(4);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(360, 33);
            this.cbDevices.TabIndex = 1;
            // 
            // pbWebCam
            // 
            this.pbWebCam.Location = new System.Drawing.Point(28, 88);
            this.pbWebCam.Margin = new System.Windows.Forms.Padding(4);
            this.pbWebCam.Name = "pbWebCam";
            this.pbWebCam.Size = new System.Drawing.Size(609, 500);
            this.pbWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWebCam.TabIndex = 0;
            this.pbWebCam.TabStop = false;
            // 
            // tmRead
            // 
            this.tmRead.Interval = 2000;
            this.tmRead.Tick += new System.EventHandler(this.tmRead_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTarjeta);
            this.groupBox2.Controls.Add(this.lbTarjeta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbTipoParqueo);
            this.groupBox2.Controls.Add(this.btnManualCard);
            this.groupBox2.Location = new System.Drawing.Point(23, 555);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(652, 204);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual";
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.Location = new System.Drawing.Point(98, 27);
            this.tbTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.tbTarjeta.Name = "tbTarjeta";
            this.tbTarjeta.Size = new System.Drawing.Size(536, 31);
            this.tbTarjeta.TabIndex = 9;
            this.tbTarjeta.Text = "7b976db5-dc43-1e37-4721-0ec8d1c2826e";
            // 
            // lbTarjeta
            // 
            this.lbTarjeta.AutoSize = true;
            this.lbTarjeta.Location = new System.Drawing.Point(6, 27);
            this.lbTarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTarjeta.Name = "lbTarjeta";
            this.lbTarjeta.Size = new System.Drawing.Size(85, 25);
            this.lbTarjeta.TabIndex = 8;
            this.lbTarjeta.Text = "Tarjeta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo:";
            // 
            // cbTipoParqueo
            // 
            this.cbTipoParqueo.DisplayMember = "Entrada";
            this.cbTipoParqueo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoParqueo.FormattingEnabled = true;
            this.cbTipoParqueo.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cbTipoParqueo.Location = new System.Drawing.Point(98, 73);
            this.cbTipoParqueo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoParqueo.Name = "cbTipoParqueo";
            this.cbTipoParqueo.Size = new System.Drawing.Size(536, 33);
            this.cbTipoParqueo.TabIndex = 6;
            this.cbTipoParqueo.ValueMember = "Entrada";
            // 
            // btnManualCard
            // 
            this.btnManualCard.Location = new System.Drawing.Point(212, 125);
            this.btnManualCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnManualCard.Name = "btnManualCard";
            this.btnManualCard.Size = new System.Drawing.Size(242, 60);
            this.btnManualCard.TabIndex = 5;
            this.btnManualCard.Text = "Registrar";
            this.btnManualCard.UseVisualStyleBackColor = true;
            this.btnManualCard.Click += new System.EventHandler(this.btnManualCard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TuBus_SS.Properties.Resources.index_parking;
            this.pictureBox1.Location = new System.Drawing.Point(43, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ParqueoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1363, 777);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ParqueoForm";
            this.Text = "Parqueo publico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParqueoForm_FormClosing);
            this.Load += new System.EventHandler(this.ParqueoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDevices;
        private System.Windows.Forms.PictureBox pbWebCam;
        private System.Windows.Forms.Timer tmRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoParqueo;
        private System.Windows.Forms.Button btnManualCard;
        private System.Windows.Forms.TextBox tbTarjeta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}