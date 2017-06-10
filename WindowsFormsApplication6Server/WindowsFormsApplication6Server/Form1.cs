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

namespace WindowsFormsApplication6Server
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
        StreamReader sr;
        StreamWriter sw;
        BinaryReader br;
        BinaryWriter bw;
        bool EnableKeys = false;
        byte[] buffer = new byte[999999];
        private void button1_Click(object sender, EventArgs e)
        {
            Thread SearchConnectionThread = new Thread(SearchConnection);
            SearchConnectionThread.Start();
        }
        private void SearchConnection()
        {
            tcpListener = new TcpListener(IPAddress.Any, 1259);
            tcpListener.Start();
            UpdateUI("S");
            while ( true )
            {
                client = tcpListener.AcceptTcpClient();
                UpdateUI("C");
                Thread HandlerThread = new Thread(Handler);
                HandlerThread.Start();
            }
        }
        private void Handler()
        {
            stream = client.GetStream();
            sr = new StreamReader(stream);
            sw = new StreamWriter(stream);
            bw = new BinaryWriter(stream);
            br = new BinaryReader(stream);
            string message = null;
            string message2 = null;
            int length = 0, type = 0;

            while ( true )
            {
                /*
                try
                {
                    message = br.ReadString();
                    UpdateUI2("Friend: " + message);
                }
                catch { }
                try
                {
                    length = br.ReadInt32();
                    UpdateUI2("Friend NR: " + length);
                }
                catch { }
                */
                type = br.ReadInt32();
                
               // UpdateUI("Type: " + type.ToString() + " Lenght: " +  length.ToString());
                
                if ( type == 1 ) 
                {
                    length = br.ReadInt32();
                    buffer = br.ReadBytes(length);
                    message = Encoding.ASCII.GetString(buffer);
                    UpdateUI2("Friend: " + message);
                }
                if ( type == 2 ) // picture
                {
                    length = br.ReadInt32();
                    buffer = br.ReadBytes(length);

                    using (MemoryStream ms = new MemoryStream(buffer))
                    {
                        try
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                        catch { }
                    }
                    //UpdateUI(HabarNuAmCUmSaONumesc(buffer, 100));
                   // UpdateUI(length.ToString());
                   // using (MemoryStream ms = new MemoryStream(buffer))
                   // {
                       // try
                       // {
                            //pictureBox1.Image = Image.FromStream(stream);
                      //  }
                      //  catch { }
                      //  finally
                      //  {
                      //      stream.Flush();
                      //  }
                        
                   // }
                }
                
            }
            

            /*
            while (true)
            {
                //UpdateUI("Refresdsh");
                message = br.ReadString();
                length = br.ReadInt32();
               // length = Convert.ToInt32( sr.ReadLine() );
               // UpdateUI(length.ToString());
               // message = "";
               // while ( message.Length < length )
              //      message += sr.ReadLine();
                //UpdateUI("Refresh");
               // if ( sr.EndOfStream == true )
                UpdateUI2("Friend: " + message);
                UpdateUI2("Friend NR: " + length);
                // UpdateUI(sr.Peek().ToString());
            }
             */
           // while (true)
           // {
          //      lenght = stream.Read(buffer, 0, buffer.Length); // se blocheaza??
               // UpdateUI("Refresh");
               // UpdateUI("Lenght" + lenght.ToString());
                
                //UpdateUI2(HabarNuAmCUmSaONumesc(buffer, lenght));
                //Thread.Sleep(1000);   
           // }
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
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            try
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch { }
            return null;
        }
        private void UpdateUI(string s)
        {
            Func<int> del = delegate()
            {
                listBox1.Items.Add(s + " " + System.DateTime.Now.ToString());
                return 0;
            };
            Invoke(del);
        }
        private void UpdateUI2(string s)
        {
            Func<int> del = delegate()
            {
                textBox1.AppendText(s +  System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buffer = new byte[999999999];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( timer1.Enabled )
                button6.PerformClick();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox1.Dock == DockStyle.None)
            {
                pictureBox1.Dock = DockStyle.Fill;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                pictureBox1.Dock = DockStyle.None;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            sw.Write(textBox2.Text);
            sw.Write(System.Environment.NewLine);
            sw.Flush();
            UpdateUI2("You: " + textBox2.Text);
            */
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buffer = Encoding.ASCII.GetBytes(textBox3.Text + System.Environment.NewLine + textBox4.Text);
            bw.Write(1);
            bw.Write(buffer.Length);
            bw.Write(buffer);
            bw.Flush();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bw.Write(2);
            bw.Flush();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true )
            {
                button7.Text = "Start Timer";
                timer1.Stop();
            }
            else
            {
                try
                {
                    timer1.Interval = Convert.ToInt32(textBox5.Text);
                    button7.Text = "Stop Timer";
                    timer1.Start();
                }
                catch { }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ( EnableKeys )
            {
                string message = null;
                //listBox1.Items.Add(keyData.ToString());
                switch ( keyData )
                {
                    case Keys.Back: message = "{BS}"; break;
                    case Keys.CapsLock: message = "{CAPSLOCK}"; break;
                    case Keys.Delete: message = "{DEL}"; break;
                    case Keys.Down: message = "{DOWN}"; break;
                    case Keys.Up: message = "{UP}"; break;
                    case Keys.Left: message = "{LEFT}"; break;
                    case Keys.Right: message = "{RIGHT}"; break;
                    case Keys.Enter: message = "{ENTER}"; break;
                    case Keys.Escape: message = "{ESC}"; break;
                    case Keys.NumLock: message = "{NUMLOCK}"; break;
                    case Keys.Tab: message = "{TAB}"; break;
                    case Keys.Shift: message = "{SHIFT}"; break;
                    case Keys.Control: message = "{CONTROL}"; break;
                    case Keys.ControlKey: message = "{CONTROL KEY}"; break;
                    case Keys.Alt: message = "{ALT}"; break;
                    default: message = "{}"; break;
                }
                if (keyData == (Keys.Control | Keys.F ))
                    message = "control";
                listBox1.Items.Add(message);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EnableKeys = !EnableKeys;
        }
    }
}
