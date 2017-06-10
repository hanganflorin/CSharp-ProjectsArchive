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
using System.Threading;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpListener tcpListener;
        TcpClient client;
        NetworkStream stream;
        private void button1_Click(object sender, EventArgs e) // conecteaza-te la ip si portul respectiv
        {
            
            Thread SearchConnectionThread = new Thread(SearchConnection);
            Thread ClientConnectionThread = new Thread(ClientConnection);
            SearchConnectionThread.Start();
            ClientConnectionThread.Start();
        }
        private void ClientConnection()
        {
            meClient = new TcpClient(textBox1.Text, Convert.ToInt32(textBox2.Text));
            UpdateUI("Connected");
        }
        private void SearchConnection()
        {
            tcpListener = new TcpListener(IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
            tcpListener.Start();
            UpdateUI("Listening");
            client = tcpListener.AcceptTcpClient();
            UpdateUI("Connected");
            Thread tcpHandlerThread = new Thread(tcpHandler);

        }
        private void tcpHandler()
        {
            stream = client.GetStream();
            byte[] message = new byte[1024];
            while ( stream.Read(message, 0, message.Length) != 0 )
            {
                UpdateUI("Friend: " + Encoding.ASCII.GetString(message));
            }
        }
        private void UpdateUI(string s)
        {
            Func<int> del = delegate()
            {
                listBox1.Items.Add(s);
                return 0;
            };
            Invoke(del);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.ASCII.GetBytes(textBox3.Text);
            stream.Write(message, 0, message.Length);
            UpdateUI("Me: " + textBox3.Text);
        }
    }
}
