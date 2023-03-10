namespace Serial_Port
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.data_tb = new System.Windows.Forms.TextBox();
            this.port_name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.temp_box = new System.Windows.Forms.TextBox();
            this.hum_box = new System.Windows.Forms.TextBox();
            this.press_box = new System.Windows.Forms.TextBox();
            this.so2_box = new System.Windows.Forms.TextBox();
            this.no2_box = new System.Windows.Forms.TextBox();
            this.co_box = new System.Windows.Forms.TextBox();
            this.o3_box = new System.Windows.Forms.TextBox();
            this.pm2_box = new System.Windows.Forms.TextBox();
            this.pm10_box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.wd_box = new System.Windows.Forms.TextBox();
            this.ws_box = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // data_tb
            // 
            this.data_tb.Location = new System.Drawing.Point(15, 75);
            this.data_tb.Multiline = true;
            this.data_tb.Name = "data_tb";
            this.data_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.data_tb.Size = new System.Drawing.Size(798, 180);
            this.data_tb.TabIndex = 0;
            // 
            // port_name_tb
            // 
            this.port_name_tb.Location = new System.Drawing.Point(728, 269);
            this.port_name_tb.Name = "port_name_tb";
            this.port_name_tb.Size = new System.Drawing.Size(85, 25);
            this.port_name_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(663, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "接收缓冲区";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(677, 309);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(136, 49);
            this.start_btn.TabIndex = 4;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(677, 380);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(136, 49);
            this.stop_btn.TabIndex = 4;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(677, 454);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(136, 49);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(257, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z18B 串口调试助手";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "温度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "湿度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "压强";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "SO2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "NO2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "CO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "O3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "PM2.5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "PM10";
            // 
            // temp_box
            // 
            this.temp_box.Location = new System.Drawing.Point(68, 272);
            this.temp_box.Name = "temp_box";
            this.temp_box.Size = new System.Drawing.Size(75, 25);
            this.temp_box.TabIndex = 8;
            // 
            // hum_box
            // 
            this.hum_box.Location = new System.Drawing.Point(68, 309);
            this.hum_box.Name = "hum_box";
            this.hum_box.Size = new System.Drawing.Size(75, 25);
            this.hum_box.TabIndex = 8;
            // 
            // press_box
            // 
            this.press_box.Location = new System.Drawing.Point(68, 339);
            this.press_box.Name = "press_box";
            this.press_box.Size = new System.Drawing.Size(75, 25);
            this.press_box.TabIndex = 8;
            // 
            // so2_box
            // 
            this.so2_box.Location = new System.Drawing.Point(68, 369);
            this.so2_box.Name = "so2_box";
            this.so2_box.Size = new System.Drawing.Size(75, 25);
            this.so2_box.TabIndex = 8;
            // 
            // no2_box
            // 
            this.no2_box.Location = new System.Drawing.Point(68, 399);
            this.no2_box.Name = "no2_box";
            this.no2_box.Size = new System.Drawing.Size(75, 25);
            this.no2_box.TabIndex = 8;
            // 
            // co_box
            // 
            this.co_box.Location = new System.Drawing.Point(232, 272);
            this.co_box.Name = "co_box";
            this.co_box.Size = new System.Drawing.Size(75, 25);
            this.co_box.TabIndex = 8;
            // 
            // o3_box
            // 
            this.o3_box.Location = new System.Drawing.Point(232, 312);
            this.o3_box.Name = "o3_box";
            this.o3_box.Size = new System.Drawing.Size(75, 25);
            this.o3_box.TabIndex = 8;
            // 
            // pm2_box
            // 
            this.pm2_box.Location = new System.Drawing.Point(232, 352);
            this.pm2_box.Name = "pm2_box";
            this.pm2_box.Size = new System.Drawing.Size(75, 25);
            this.pm2_box.TabIndex = 8;
            // 
            // pm10_box
            // 
            this.pm10_box.Location = new System.Drawing.Point(232, 392);
            this.pm10_box.Name = "pm10_box";
            this.pm10_box.Size = new System.Drawing.Size(75, 25);
            this.pm10_box.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(377, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "WD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(377, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "WS";
            // 
            // wd_box
            // 
            this.wd_box.Location = new System.Drawing.Point(420, 273);
            this.wd_box.Name = "wd_box";
            this.wd_box.Size = new System.Drawing.Size(75, 25);
            this.wd_box.TabIndex = 8;
            // 
            // ws_box
            // 
            this.ws_box.Location = new System.Drawing.Point(420, 305);
            this.ws_box.Name = "ws_box";
            this.ws_box.Size = new System.Drawing.Size(75, 25);
            this.ws_box.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SWGothi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 486);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(424, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "Author ： DPL    2018/12/20  Version 0.0.2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(832, 515);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pm10_box);
            this.Controls.Add(this.pm2_box);
            this.Controls.Add(this.o3_box);
            this.Controls.Add(this.ws_box);
            this.Controls.Add(this.wd_box);
            this.Controls.Add(this.co_box);
            this.Controls.Add(this.no2_box);
            this.Controls.Add(this.so2_box);
            this.Controls.Add(this.press_box);
            this.Controls.Add(this.hum_box);
            this.Controls.Add(this.temp_box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_name_tb);
            this.Controls.Add(this.data_tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Z18B串口助手";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data_tb;
        private System.Windows.Forms.TextBox port_name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox temp_box;
        private System.Windows.Forms.TextBox hum_box;
        private System.Windows.Forms.TextBox press_box;
        private System.Windows.Forms.TextBox so2_box;
        private System.Windows.Forms.TextBox no2_box;
        private System.Windows.Forms.TextBox co_box;
        private System.Windows.Forms.TextBox o3_box;
        private System.Windows.Forms.TextBox pm2_box;
        private System.Windows.Forms.TextBox pm10_box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox wd_box;
        private System.Windows.Forms.TextBox ws_box;
        private System.Windows.Forms.Label label15;
    }
}

