namespace WindowsFormsApp2
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Serial_stop = new System.Windows.Forms.Button();
            this.Read_TS = new System.Windows.Forms.Button();
            this.Serial_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Current_Data = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Serial_stop
            // 
            this.Serial_stop.Location = new System.Drawing.Point(370, 62);
            this.Serial_stop.Name = "Serial_stop";
            this.Serial_stop.Size = new System.Drawing.Size(110, 43);
            this.Serial_stop.TabIndex = 1;
            this.Serial_stop.Text = "Serial Stop";
            this.Serial_stop.UseVisualStyleBackColor = true;
            this.Serial_stop.Click += new System.EventHandler(this.Serial_stop_Click);
            // 
            // Read_TS
            // 
            this.Read_TS.Location = new System.Drawing.Point(86, 160);
            this.Read_TS.Name = "Read_TS";
            this.Read_TS.Size = new System.Drawing.Size(110, 43);
            this.Read_TS.TabIndex = 2;
            this.Read_TS.Text = "Read From TS";
            this.Read_TS.UseVisualStyleBackColor = true;
            this.Read_TS.Click += new System.EventHandler(this.Read_TS_Click);
            // 
            // Serial_start
            // 
            this.Serial_start.Location = new System.Drawing.Point(86, 62);
            this.Serial_start.Name = "Serial_start";
            this.Serial_start.Size = new System.Drawing.Size(110, 43);
            this.Serial_start.TabIndex = 3;
            this.Serial_start.Text = "Serial Start";
            this.Serial_start.UseVisualStyleBackColor = true;
            this.Serial_start.Click += new System.EventHandler(this.Serial_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Current_Data
            // 
            this.Current_Data.AutoSize = true;
            this.Current_Data.Location = new System.Drawing.Point(274, 179);
            this.Current_Data.Name = "Current_Data";
            this.Current_Data.Size = new System.Drawing.Size(71, 13);
            this.Current_Data.TabIndex = 5;
            this.Current_Data.Text = "Current Temp";
            this.Current_Data.Click += new System.EventHandler(this.Current_Data_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(370, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(370, 265);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Current Light %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Current Humidity %";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(194, 364);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(91, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(316, 364);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(91, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Current_Data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Serial_start);
            this.Controls.Add(this.Read_TS);
            this.Controls.Add(this.Serial_stop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Serial_stop;
        private System.Windows.Forms.Button Read_TS;
        private System.Windows.Forms.Button Serial_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Current_Data;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

