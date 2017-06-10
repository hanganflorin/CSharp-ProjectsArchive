using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread tcpServerRunThread = new Thread(TcpServerRun);
            tcpServerRunThread.Start();
        }
        private void TcpServerRun()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 5004); //pot sa il schimb??
            tcpListener.Start();
            updateUI("Listening");
            while ( true )
            {
                TcpClient client = tcpListener.AcceptTcpClient(); // habar nu am
                updateUI("Connected");
                Thread tcpHandlerThread = new Thread(tcpHandler);
                tcpHandlerThread.Start(client);
            }
        }
        private void tcpHandler(object client)
        {
            TcpClient mClient = (TcpClient)client;
            NetworkStream stream = mClient.GetStream();
            byte[] mess = new byte[1024];
            stream.Read(mess, 0, mess.Length);
            updateUI("New Message = " + Encoding.ASCII.GetString(mess));
            stream.Close();
            mClient.Close();
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
    }
}
