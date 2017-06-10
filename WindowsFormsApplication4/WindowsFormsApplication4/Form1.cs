using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client;
        NetworkStream stream;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread mThread = new Thread(new ThreadStart(ConnectAsClient));
            mThread.Start();
        }

        private void ConnectAsClient()
        {
            client = new TcpClient();
            client.Connect(IPAddress.Parse("192.168.0.199"), 5004); // ip-ul unde sa trimita
            updateUI("Connected");

        }
        private void updateUI(string s)
        {
            Func<int> del = delegate()
            {
                textBox1.AppendText(s + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread SendThread = new Thread(SendMessage);
            SendThread.Start();
        }
        private void SendMessage()
        {
            stream = client.GetStream();
            byte[] message = Encoding.ASCII.GetBytes(textBox2.Text);
            stream.Write(message, 0, message.Length);
            updateUI("Message send");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void Disconnect()
        {
            stream.Close();
            updateUI("Disconected");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
    }
}
