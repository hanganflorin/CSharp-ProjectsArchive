using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ok = false;
        bool hor = true, vert = true;
        float Xmin, Xmax, Ymin, Ymax, Xzero, Yzero, Xdim, Ydim, W, H, Xstep = 1, Ystep = 1;
        float Xcursor, Ycursor, Xcursor2, Ycursor2;
        const float resolution = 0.01F;
        float Xmin_aux;
        float Xmax_aux;
        float Ymin_aux;
        float Ymax_aux;
        Color Color_Background = Color.Black;
        Color Color_Axis = Color.White;
        Color Color_Function = Color.Red;
        Expression E = new Expression('n', 0);
        private void Form1_Load(object sender, EventArgs e)
        {
            W = pictureBox1.Width;
            H = pictureBox1.Height;
            comboBox1.SelectedIndex = 2;
            comboBox2.SelectedIndex = 0;
            button1.PerformClick();
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Size = pictureBox1.Size;
            this.DoubleBuffered = true;

            button7.BackColor = Color_Background;
            button8.BackColor = Color_Axis;
            button9.BackColor = Color_Function;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Xmin = Convert.ToSingle(textBox1.Text);
                Xmax = Convert.ToSingle(textBox3.Text);
                Ymin = Convert.ToSingle(textBox2.Text);
                Ymax = Convert.ToSingle(textBox4.Text);
               // Xstep = Convert.ToSingle(textBox5.Text);
              //  Ystep = Convert.ToSingle(textBox6.Text);
                trackBar1.Maximum = Convert.ToInt32(textBox9.Text);
                trackBar1.Minimum = Convert.ToInt32(textBox8.Text);
                trackBar1.Maximum *= 10;
                trackBar1.Minimum *= 10;
                trackBar1.SmallChange = Convert.ToInt32(Convert.ToSingle(textBox11.Text)*10);
                pictureBox1.Refresh();
            }
            catch
            {
                MessageBox.Show("Incorrect data");
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 1: e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; break;
                case 2: e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default; break;
                case 3: e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; break;
                // case 4: e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Invalid; break;
                case 5: e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None; break;
            }
           // e.Graphics.CopyFromScreen(0, 0, 0, 0, new Size(1366, 768));
            label17.Text = "true";
            Xdim = W / (Xmax - Xmin);
            Ydim = H / (Ymax - Ymin);
            Xzero = -Xmin * Xdim;
            Yzero = Ymax * Ydim;
            Check_Steps();
            if (comboBox1.SelectedIndex != 0)
            {
                if (Xmin <= 0 && Xmax >= 0)
                    e.Graphics.DrawLine(new Pen(Color_Axis, 1), Xzero, 0, Xzero, H);
                if (Ymin <= 0 && Ymax >= 0)
                    e.Graphics.DrawLine(new Pen(Color_Axis, 1), 0, Yzero, W, Yzero);
                if (comboBox1.SelectedIndex != 1)
                {
                    for (float i = Xstep; i <= Xmax; i += Xstep)
                        e.Graphics.DrawLine(new Pen(Color_Axis, 1), Xzero + i * Xdim, Yzero - 5, Xzero + i * Xdim, Yzero + 5);
                    for (float i = -Xstep; i >= Xmin; i -= Xstep)
                        e.Graphics.DrawLine(new Pen(Color_Axis, 1), Xzero + i * Xdim, Yzero - 5, Xzero + i * Xdim, Yzero + 5);
                    for (float i = Ystep; i <= Ymax; i += Ystep)
                        e.Graphics.DrawLine(new Pen(Color_Axis, 1), Xzero - 5, Yzero - i * Ydim, Xzero + 5, Yzero - i * Ydim);
                    for (float i = -Ystep; i >= Ymin; i -= Ystep)
                        e.Graphics.DrawLine(new Pen(Color_Axis, 1), Xzero - 5, Yzero - i * Ydim, Xzero + 5, Yzero - i * Ydim);
               
                    if (comboBox1.SelectedIndex != 2)
                    {
                        StringFormat str = new StringFormat();
                        str.Alignment = StringAlignment.Center;
                        for (float i = Xstep; i <= Xmax; i += Xstep)
                            e.Graphics.DrawString(String.Format("{0}", i), new Font("Microsoft Sans Serif", 7), new SolidBrush(Color_Axis), Xzero + i * Xdim, Yzero - 20, str);
                        for (float i = -Xstep; i >= Xmin; i -= Xstep)
                            e.Graphics.DrawString(String.Format("{0}", i), new Font("Microsoft Sans Serif", 7), new SolidBrush(Color_Axis), Xzero + i * Xdim, Yzero - 20, str);
                        str.Alignment = StringAlignment.Near;
                        for (float i = Ystep; i <= Ymax; i += Ystep)
                            e.Graphics.DrawString(String.Format("{0}", i), new Font("Microsoft Sans Serif", 7), new SolidBrush(Color_Axis), Xzero + 10, Yzero - i * Ydim - 7, str);
                        for (float i = -Ystep; i >= Ymin; i -= Ystep)
                            e.Graphics.DrawString(String.Format("{0}", i), new Font("Microsoft Sans Serif", 7), new SolidBrush(Color_Axis), Xzero + 10, Yzero - i * Ydim - 7, str);
                    }
                }
            }
            
            float x1, y1, x2, y2;
            x1 = Xmin;
            y1 = Calculate(x1);
            for (float i = Xmin + resolution; i <= Xmax; i += resolution )
            {
                x2 = i;
                y2 = Calculate(x2);
                if (y1 >= Ymin-100 && y1 <= Ymax+100 && y2 >= Ymin-100 && y2 <= Ymax+100)
                try
                {
                    e.Graphics.DrawLine(new Pen(Color_Function, 2), Xzero + x1 * Xdim, Yzero - y1 * Ydim, Xzero + x2 * Xdim, Yzero - y2 * Ydim);
                }
                catch { }
                x1 = x2;
                y1 = y2;
            } 
            /*
            float x1, y1, x2, y2;
            x1 = Xmin;
            y1 = Calculate(x1);
            y1 = Yzero - y1 * Ydim;
            for ( int i = 1; i <= W; i++ )
            {
                x2 = (i - Xzero) / Xdim;
                y2 = Calculate(x2);
                y2 = Yzero - y2 * Ydim;
                try
                {
                    e.Graphics.DrawLine(new Pen(Color.Red, 1), i, y2, i-1, y1);
                }
                catch { }
                x1 = x2;
                y1 = y2;

            }
            */
            e.Graphics.DrawImage()
        }
        float Calculate(float x)
        {
           // return Convert.ToSingle(Math.Pow(x, 3));
           // return x;
          //  return Convert.ToSingle(Math.Sin(x));
            return E.Calculate(x, (float)(trackBar1.Value * 0.1));
            //return 2;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            float X = Xcursor - Cursor.Position.X;
            float Y = Ycursor - Cursor.Position.Y;
            Xmax = Xmax_aux + X/Xdim;
            Xmin = Xmin_aux + X/Xdim;
            Ymax = Ymax_aux - Y/Ydim;
            Ymin = Ymin_aux - Y/Ydim;

            label11.Text = X.ToString();
            label12.Text = Y.ToString();   
            textBox1.Text = Xmin.ToString();
            textBox3.Text = Xmax.ToString();
            textBox2.Text = Ymin.ToString();
            textBox4.Text = Ymax.ToString();
            pictureBox1.Invalidate(false);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Focus();
            //abc = e.Delta;
            ok = false;
            label13.Text = ok.ToString();
            Xcursor = Cursor.Position.X;
            Ycursor = Cursor.Position.Y;
            Xmin_aux = Xmin;
            Xmax_aux = Xmax;
            Ymin_aux = Ymin;
            Ymax_aux = Ymax;
            label9.Text = Xcursor.ToString();
            label10.Text = Ycursor.ToString();
            timer1.Start();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //abc = e.Delta;
            timer1.Stop();
            ok = true;
            label13.Text = ok.ToString();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            //pictureBox1.Focus();
            ok = true;
            label13.Text = ok.ToString();
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ok = false;
            label13.Text = ok.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ok)
            {
                Xcursor2 = e.X;
                Ycursor2 = e.Y;
                pictureBox2.Invalidate(false);
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {/*
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            label18.Text = "true";
            float x, y;
            if (ok)
            {
                x = (Xcursor2 - Xzero) / Xdim;
                y = Calculate(x);
                label15.Text = x.ToString();
                label16.Text = y.ToString();
                e.Graphics.FillEllipse(new SolidBrush(Color.Blue), Xzero + x * Xdim - 3, Yzero - y * Ydim - 3, 6, 6);
            }
          */
        }
        int abc;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //label19.Text = abc.ToString();
            label17.Text = "false";
            label18.Text = Convert.ToString(Xdim * Xstep);
            label21.Text = Convert.ToString(Ydim * Ystep);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //abc = e.Delta;
        }
        private void pictureBox2_MouseWheel(object sender, MouseEventArgs e)
        {
            if ( ok  )
            {
                const int proc = 4;
                float Xval = 0;
                float Yval = 0;
                if ( hor )
                    Xval = (float)(Xmax - Xmin) * proc / 100;
                if ( vert )
                    Yval = (float)(Ymax - Ymin) * proc / 100;
                if ( e.Delta < 0 )
                {
                    Xmax += Xval;
                    Xmin -= Xval;
                    Ymax += Yval;
                    Ymin -= Yval;
                }
                else if (((Xmax - Xmin) > 0.1) && (Ymax - Ymin) > 0.1)
                {
                    Xmax -= Xval;
                    Xmin += Xval;
                    Ymax -= Yval;
                    Ymin += Yval;
                }
                textBox1.Text = Xmin.ToString();
                textBox3.Text = Xmax.ToString();
                textBox2.Text = Ymin.ToString();
                textBox4.Text = Ymax.ToString();
                this.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.FlatStyle = FlatStyle.Standard;
            button3.FlatStyle = FlatStyle.System;
            button4.FlatStyle = FlatStyle.System;
            hor = true;
            vert = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.FlatStyle = FlatStyle.Standard;
            button2.FlatStyle = FlatStyle.System;
            button4.FlatStyle = FlatStyle.System;
            hor = true;
            vert = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.FlatStyle = FlatStyle.Standard;
            button3.FlatStyle = FlatStyle.System;
            button2.FlatStyle = FlatStyle.System;
            hor = false;
            vert = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                E = E.FromString(textBox7.Text);
                this.Refresh();
            }
            catch
            {
                MessageBox.Show("error");
            }   
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label20.Text = Convert.ToString(trackBar1.Value * 0.1);
            this.Refresh();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float aux = (Xmax - Xmin);
            Xmax = aux / 2;
            Xmin = -aux / 2;
            aux = (Ymax - Ymin);
            Ymax = aux / 2;
            Ymin = -aux / 2;
            this.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color_Background;
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Color_Background = colorDialog1.Color;
            pictureBox1.BackColor = Color_Background;
            button7.BackColor = Color_Background;
            if (button7.BackColor == Color.Black)
                button7.ForeColor = Color.White;
            else
                button7.ForeColor = Color.Black;
          //  button7.ForeColor = Color.FromArgb(255 - Color_Background.R, 255 - Color_Background.G, 255 - Color_Background.B);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color_Axis;
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Color_Axis = colorDialog1.Color;
            this.Refresh();
            button8.BackColor = Color_Axis;
           // Color.FromArgb()
        }

        private void button9_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color_Function;
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Color_Function = colorDialog1.Color;
            this.Refresh();
            button9.BackColor = Color_Function;
        }
        private void Check_Steps()
        {
            const float aux = 0.5F;
            const int min = 40;
            const int max = 50;
            while (Xdim * Xstep <= min && Xstep + aux > 0)
                Xstep += aux;
            while (Xdim * Xstep >= max && Xstep - aux > 0)
                Xstep -= aux;
            while (Ydim * Ystep <= min && Ystep + aux > 0)
                Ystep += aux;
            while (Ydim * Ystep >= max && Ystep - aux > 0)
                Ystep -= aux;
        }
    }
}
