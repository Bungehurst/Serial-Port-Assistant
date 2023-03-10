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
using System.IO;
namespace Serial_Port
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        private DateTime datetime;
        private List<byte> buffer = new List<byte>(4096);
        private byte[] ReceiveBytes = new byte[30];
        private const int BUFFER_LENTH = 28;
        private byte[] buffer_temp = new byte[BUFFER_LENTH];
        private byte[] buffer_inorder = new byte[BUFFER_LENTH];
        int temperature = 0;
        int humidity = 0;
        double wind_degree = 0;
        double wind_vel = 0;
        int pressure = 0;
        double SO2 = 0;
        double O3 = 0;
        double NO2 = 0;
        double CO = 0;
        int Pm2 = 0;
        int Pm10 = 0;

        public Form1()
        {
            InitializeComponent();
            stop_btn.Enabled = false;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            try
            {
                myport.BaudRate = 9600;
                myport.PortName = port_name_tb.Text;//"COM28";
                myport.Parity = Parity.None;
                myport.DataBits = 8;
                myport.StopBits = StopBits.One;
                myport.DataReceived += myport_DataReceived;
                myport.ReadBufferSize = 4096;
                myport.ReceivedBytesThreshold = 56;
            }
            catch 
            {
                //MessageBox.Show(ex6.Message, "Error");
            }
            try
            {
                myport.Open();
                if (myport.IsOpen)
                {
                    //MessageBox.Show(port_name_tb.Text + " has been opened!");
                    start_btn.Enabled = false;
                    stop_btn.Enabled = true;
                }
                else
                {
                    MessageBox.Show(port_name_tb.Text + " can not be opened!");
                }
                data_tb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int n = 28;
                byte[] buf = new byte[n];
                myport.Read(buf, 0, n);
                //for (int i = 0; i < 1000; i++) ;
                //1.缓存数据
                buffer.AddRange(buf);//不断地将接收到的数据加入到buffer链表中
                if (buffer.Count > 28)   //前四个包含基本信息
                {
                    if (buffer[0] == 0x7E && buffer[27] == 0xE7)
                    {
                        for (int u = 0; u < BUFFER_LENTH; u++) buffer_inorder[u] = buffer[u];
                        DataProgress();
                        buffer.RemoveRange(0, 28);
                    }
                    else
                    {
                        int bit = 0;
                        if (buffer_temp[BUFFER_LENTH - 1] == 0x7E)
                        {
                            bit = BUFFER_LENTH - 1;
                        }
                        else
                        {
                            for (int i = 0; i < BUFFER_LENTH; i++)
                            {
                                if (buffer_temp[i] == 0x7E && buffer_temp[i + 1] == 0x00) bit = i;
                            }
                        }
                        for (int j = 0; j < BUFFER_LENTH - bit; j++)
                        {
                            buffer_inorder[j] = buffer_temp[j + bit];
                        }
                        for (int k = 0; k < bit; k++)
                        {
                            buffer_inorder[k + BUFFER_LENTH - bit] = buffer[k];
                        }
                        for (int m = 0; m < BUFFER_LENTH; m++)
                        {
                            buffer_temp[m] = buffer[m];
                        }
                        DataProgress();
                        buffer.RemoveRange(0, 28);
                    }
                    
                    
                }

                datetime = DateTime.Now;
                string time = "[" + datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second + "]";
                Control.CheckForIllegalCrossThreadCalls = false;
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < n; i++)
                {
                    string s;
                    if (buf[i] < 16)
                    {
                        s = "0" + Convert.ToString(buf[i], 16).ToUpper() + " ";
                    }
                    else
                    {
                        s = Convert.ToString(buf[i], 16).ToUpper() + " ";
                    }
                    sb.Append(s);
                }
                data_tb.AppendText (time+"\n"+sb.ToString() + "\n");

            }
            catch (Exception ex4)
            {
                MessageBox.Show(ex4.Message, "Error");
            }
        }
        private void DataProgress()
        {
            UInt16 sum = 0;
            for(int i = 0;i < 26;i++)
            {
                sum += buffer_inorder[i];
            }
            if ((sum&0xff) == (buffer_inorder[26]&0xff))
            {
                temperature = (int)((buffer_inorder[4] << 8 | buffer_inorder[5]));
                if (temperature > 200) temperature = temperature - 256;
                humidity = buffer_inorder[6] << 8 | buffer_inorder[7];
                wind_degree = (buffer_inorder[8] << 8 | buffer_inorder[9]);
                wind_vel = (double)((buffer_inorder[10] << 8 | buffer_inorder[11]) / 10.0);
                pressure = buffer_inorder[12] << 8 | buffer_inorder[13];
                SO2 = (double)((buffer_inorder[14] << 8 | buffer_inorder[15]) / 100.0);
                O3 = (double)((buffer_inorder[16] << 8 | buffer_inorder[17]) / 100.0);
                NO2 = (double)((buffer_inorder[18] << 8 | buffer_inorder[19]) / 100.0);
                CO = (double)((buffer_inorder[20] << 8 | buffer_inorder[21]) / 100.0);
                Pm2 = buffer_inorder[22] << 8 | buffer_inorder[23];
                Pm10 = buffer_inorder[24] << 8 | buffer_inorder[25];
                
                Write();
                this.BeginInvoke(new EventHandler(display_data));
            }
        }

        private void display_data(object sender, EventArgs e)
        {
            int start = Environment.TickCount;
            temp_box.Text = temperature.ToString();
            temp_box.BackColor = Color.White;
            hum_box.Text = humidity.ToString();
            hum_box.BackColor = Color.White;
            press_box.Text = pressure.ToString();
            press_box.BackColor = Color.White;
            so2_box.Text = SO2.ToString();
            so2_box.BackColor = Color.White;
            o3_box.Text = O3.ToString();
            o3_box.BackColor = Color.White;
            no2_box.Text = NO2.ToString();
            no2_box.BackColor = Color.White;
            co_box.Text = CO.ToString();
            co_box.BackColor = Color.White;
            pm2_box.Text = Pm2.ToString();
            pm2_box.BackColor = Color.White;
            pm10_box.Text = Pm10.ToString();
            pm10_box.BackColor = Color.White;
            wd_box.Text = wind_degree.ToString();
            wd_box.BackColor = Color.White;
            ws_box.Text = wind_vel.ToString();
           
            
            if (Math.Abs(Environment.TickCount - start) <= 1000)//毫秒
            {
                Application.DoEvents();
                temp_box.BackColor = Color.LimeGreen;
                hum_box.BackColor = Color.LimeGreen;
                press_box.BackColor = Color.LimeGreen;
                so2_box.BackColor = Color.LimeGreen;
                no2_box.BackColor = Color.LimeGreen;
                wd_box.BackColor = Color.LimeGreen;
                ws_box.BackColor = Color.LimeGreen;
                o3_box.BackColor = Color.LimeGreen;
                co_box.BackColor = Color.LimeGreen;
                pm2_box.BackColor = Color.LimeGreen;
                pm10_box.BackColor = Color.LimeGreen;
            }
            else if (Math.Abs(Environment.TickCount - start) > 1000)//毫秒
            {
                    Application.DoEvents();
                    temp_box.BackColor = Color.White;
                    hum_box.BackColor = Color.White;
                    press_box.BackColor = Color.White;
                    so2_box.BackColor = Color.White;
                    no2_box.BackColor = Color.White;
                    wd_box.BackColor = Color.White;
                    ws_box.BackColor = Color.White;
                    o3_box.BackColor = Color.White;
                    co_box.BackColor = Color.White;
                    pm2_box.BackColor = Color.White;
                    pm10_box.BackColor = Color.White;
             }
            else if (Math.Abs(Environment.TickCount - start) > 2000)
            {
                start = Environment.TickCount;
            }
            
            
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myport.Close();
                if (myport.IsOpen == false)
                {
                    start_btn.Enabled = true;
                    stop_btn.Enabled = false;
                    //MessageBox.Show("Port has been closed!");
                }
                else
                {
                    MessageBox.Show("Close Port Failed!");
                }
            }
            catch(Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error");

            }
        }
        public void Write()
        {
            try
            {
                StreamWriter fs = new StreamWriter("DATA.txt", true);
                datetime = DateTime.Now;
                string time = "[" + datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second + "]";
                //获得字节数组
                string data = "SO2 " + SO2 + " NO2 " + NO2 + " O3 " + O3 + " CO " + CO + " PM2.5 " + Pm2 + " PM10 " + Pm10 + " TEMP " + temperature + " HUM " + humidity + " PRESS " + pressure + " WD " + wind_degree + " WS " + wind_vel;
                //开始写入
                fs.WriteLine(time + data);
                //清空缓冲区、关闭流
                fs.Flush();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Save Fail");
            }
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter fs2 = new StreamWriter("DATA_RAW.txt", true);
                fs2.WriteLine(data_tb.Text);
                MessageBox.Show("Data has been saved!");
            }
            catch(Exception ex3)
            {
                MessageBox.Show(ex3.Message, "Error");
            }
        }
    }
}
