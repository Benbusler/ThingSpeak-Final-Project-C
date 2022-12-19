using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int startflag = 0;
        int flag_sensor;
        string RxString;
        string temp = "0";
        string light = "0";
        string humidity = "0";
        char charb = 'B';
        public Form1()
        {
            InitializeComponent();
        }

        private void Serial_start_Click(object sender, EventArgs e)
        {   
            serialPort1.PortName = "COM7";
            serialPort1.BaudRate = 115200;
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {

                textBox1.ReadOnly = false;
            }
        }

        private void Serial_stop_Click(object sender, EventArgs e)
        {
            serialPort1.Close();

            textBox1.ReadOnly = true;
        }

        private void Read_TS_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            label1.Text = client.DownloadString("http://api.thingspeak.com/channels/1563508/field/field1/last.text");//use your channel id

            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Current_Data_Click(object sender, EventArgs e) //Recieving data from the text box
        {
            textBox1.ResetText();
            temp = temp;
            textBox1.AppendText(temp);

            textBox2.ResetText();
            light = light;
            textBox2.AppendText(light);


            textBox3.ResetText();
            textBox3.AppendText(humidity);


            textBox4.ResetText();
            textBox4.AppendText("" + RxString.IndexOf('B'));
            textBox5.ResetText();
            textBox5.AppendText("" + (RxString.IndexOf('B') + 2));


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            serialPort1.PortName = "COM7";
            serialPort1.BaudRate = 115200;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.Equals(textBox1.Text, ""))
            {
                if (serialPort1.IsOpen) serialPort1.Close();
                try
                {
                    if (1 == 1)
                    {
                        flag_sensor = 11;
                    }
                    const string WRITEKEY = "V0WUME6TSZGTVJWV"; ////use your channel API keys
                    string strUpdateBase = "http://api.thingspeak.com/update";
                    string strUpdateURI = strUpdateBase + "?key=" + WRITEKEY;
                    string strField1 = RxString;
                    
                    HttpWebRequest ThingsSpeakReq;
                    HttpWebResponse ThingsSpeakResp;

                    if (flag_sensor == 11)
                    {
                        strUpdateURI += "&field1=" + temp + "&field2=" + light + "&field3=" + humidity;
                        //strUpdateURI += "&field1=" + strField1 + "&field2=" + strField1 + "&field3=" + strField1;
                    }
                   
                    else
                    {
                    }
                    flag_sensor++;
                    ThingsSpeakReq = (HttpWebRequest)WebRequest.Create(strUpdateURI);
                    ThingsSpeakResp = (HttpWebResponse)ThingsSpeakReq.GetResponse();
                    ThingsSpeakResp.Close();
                    if (!(string.Equals(ThingsSpeakResp.StatusDescription,"OK")))
                    {
                        Exception exData = new Exception(ThingsSpeakResp.StatusDescription);
                        throw exData;
                    }
                }
                catch (Exception ex)
                {
                }
              //textBox1.Text = "";
                serialPort1.Open();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SerialPort1_DataReceived(object sender,System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("Data Received");
            RxString = serialPort1.ReadExisting();
            int BPlace = RxString.LastIndexOf('B');
            RxString = RxString.Substring(0,RxString.LastIndexOf('B')-1);
            
            //B10aB10bB10c
            if(RxString.IndexOf('a') - 2 > 0)
            {
                temp = RxString.Substring(RxString.IndexOf('a') - 2, 2);
            }
            if (RxString.IndexOf('b') - 3 > 0)
            {
                light = RxString.Substring(RxString.IndexOf('b') - 2, 2);
            }
            
            humidity = "50";

            

            this.Invoke(new EventHandler(Current_Data_Click));
        }
    }
}
