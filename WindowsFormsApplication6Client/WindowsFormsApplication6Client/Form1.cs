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

namespace WindowsFormsApplication6Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client;
        NetworkStream stream;
        Graphics g;
        Bitmap b;
        StreamWriter sw;
        StreamReader sr;
        MemoryStream ms;
        BinaryWriter bw;
        byte[] buffer;
        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(Connect);
            th.Start();
        }
        private void Connect()
        {
            while ( true )
            {
                try
                {
                    client = new TcpClient("192.168.0.199", 1259);
                    stream = client.GetStream();
                    sr = new StreamReader(stream);
                    sw = new StreamWriter(stream);
                    
                    bw = new BinaryWriter(stream, Encoding.ASCII, true); // vezi aici 
                    Thread HandlerThread = new Thread(Handler);
                    HandlerThread.Start();
                    break;
                }
                catch { }
                Thread.Sleep(10);
                UpdateUI("asd");
            }
            
        }
        private void Handler()
        {
            
            string message = null;
            while (true)
            {
              //  try
              //  {
                   // UpdateUI("Refresdsh");
                    message = sr.ReadLine();
                   // UpdateUI("Refresh");
                    UpdateUI("Friend: " + message);
               // }
              //  catch { };    
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
            b = new Bitmap(1366, 768);
            g = Graphics.FromImage(b);
            buffer = new byte[99999];
            ms = new MemoryStream();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            g.CopyFromScreen(0, 0, 0, 0, new Size(1366, 768));
            pictureBox1.Image = b;
            b.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            */
            //Rand(buffer, buffer.Length);
           // buffer = Encoding.ASCII.GetBytes(textBox1.Text);
            //stream.Write(buffer, 0, buffer.Length);
            //listBox1.Items.Add(HabarNuAmCUmSaONumesc(buffer, buffer.Length));
            buffer = Encoding.ASCII.GetBytes(textBox1.Text);
            bw.Write(1); // tipul
            bw.Write(buffer.Length); // lungimea
            bw.Write(buffer); // mesajul
            bw.Flush();
            //listBox1.Items.Add(buffer.Length);

            /*
            sw.Write(textBox1.Text.Length + System.Environment.NewLine);
            sw.Flush();
            sw.Write(textBox1.Text);
            sw.Write(System.Environment.NewLine);
            sw.Flush();
            UpdateUI("You: " + textBox1.Text);
            */
        }
        public string HabarNuAmCUmSaONumesc(byte[] b, int n)
        {
            string s = null;
            for (int i = 0; i < n; ++i)
                s += " " + b[i].ToString();
            return s;
        }
        public void Rand(byte[] b, int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; ++i)
            {
                if (r.Next(2) == 1)
                    b[i] = 1;
                else
                    b[i] = 0;
            }
           // r.NextBytes(b);
        }
        public byte[] imageToByteArray(Bitmap imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // buffer, ms, g, b, listbox
            //byte[] buffer2 = new byte[101];
            using ( MemoryStream ms = new MemoryStream() )
            using (Graphics g = Graphics.FromImage(b) )  
            {         
                g.CopyFromScreen(0, 0, 0, 0, new Size(1366, 768));
                pictureBox1.Image = b;
                b.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg );
                buffer = ms.ToArray();
            }
            bw.Write(2); // tipul
            bw.Write(buffer.Length); // lungimea
            bw.Write(buffer); //mesajul
            bw.Flush();
            listBox1.Items.Add(buffer.Length);
            //sw.Write("100" + System.Environment.NewLine);
            //sw.Flush();
            //sw.Write()
            
           // bw.Write(buffer, 0, 100);
           // bw.Flush();
           // Rand(buffer2, 100);
           // listBox1.Items.Add(buffer2.Length);
           // listBox1.Items.Add(HabarNuAmCUmSaONumesc(buffer2, buffer2.Length));
            //listBox1.Items.Add(Encoding.GetString(buffer2) );
           // bw.Write()
           // bw.Write(buffer, 0, buffer.Length);
            //bw.Flush();
            //sw.Write(
           // Thread tr = new Thread(Upload);
           // tr.Start();
        }
        private void Upload()
        {
            g.CopyFromScreen(0, 0, 0, 0, new Size(1366, 768));
            //pictureBox1.Image = b;
            MemoryStream ms = new MemoryStream();
            b.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            buffer = ms.ToArray();
            stream.Write(buffer, 0, buffer.Length);
           // listBox1.Items.Add(HabarNuAmCUmSaONumesc(buffer, buffer.Length));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int nr = r.Next(1000);
           // buffer = Encoding.ASCII.GetBytes(textBox1.Text);
            bw.Write(nr);
            bw.Flush();
            listBox1.Items.Add(nr);
            /*
            sw.Write(textBox1.Text.Length + System.Environment.NewLine);
            sw.Flush();
            bw.Write(textBox1.Text);
            bw.Write(System.Environment.NewLine);
            bw.Flush();
            UpdateUI("You: " + textBox1.Text);
            */
        }
    }
}
