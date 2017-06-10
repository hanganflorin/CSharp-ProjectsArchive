namespace contex_menu_strip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urmatorulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.micaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foarteMareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulDeAfisareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inchideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.urmatorulToolStripMenuItem,
            this.anteriorToolStripMenuItem,
            this.vitezaToolStripMenuItem,
            this.modulDeAfisareToolStripMenuItem,
            this.toolStripSeparator1,
            this.inchideToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 164);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // urmatorulToolStripMenuItem
            // 
            this.urmatorulToolStripMenuItem.Name = "urmatorulToolStripMenuItem";
            this.urmatorulToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.urmatorulToolStripMenuItem.Text = "Urmatorul";
            this.urmatorulToolStripMenuItem.Click += new System.EventHandler(this.urmatorulToolStripMenuItem_Click);
            // 
            // anteriorToolStripMenuItem
            // 
            this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.anteriorToolStripMenuItem.Text = "Anterior";
            this.anteriorToolStripMenuItem.Click += new System.EventHandler(this.anteriorToolStripMenuItem_Click);
            // 
            // vitezaToolStripMenuItem
            // 
            this.vitezaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.micaToolStripMenuItem,
            this.medieToolStripMenuItem,
            this.mareToolStripMenuItem,
            this.foarteMareToolStripMenuItem});
            this.vitezaToolStripMenuItem.Name = "vitezaToolStripMenuItem";
            this.vitezaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.vitezaToolStripMenuItem.Text = "Viteza";
            // 
            // micaToolStripMenuItem
            // 
            this.micaToolStripMenuItem.Checked = true;
            this.micaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.micaToolStripMenuItem.Name = "micaToolStripMenuItem";
            this.micaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.micaToolStripMenuItem.Text = "Mica";
            this.micaToolStripMenuItem.Click += new System.EventHandler(this.micaToolStripMenuItem_Click);
            // 
            // medieToolStripMenuItem
            // 
            this.medieToolStripMenuItem.Name = "medieToolStripMenuItem";
            this.medieToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.medieToolStripMenuItem.Text = "Medie";
            this.medieToolStripMenuItem.Click += new System.EventHandler(this.medieToolStripMenuItem_Click);
            // 
            // mareToolStripMenuItem
            // 
            this.mareToolStripMenuItem.Name = "mareToolStripMenuItem";
            this.mareToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mareToolStripMenuItem.Text = "Mare";
            this.mareToolStripMenuItem.Click += new System.EventHandler(this.mareToolStripMenuItem_Click);
            // 
            // foarteMareToolStripMenuItem
            // 
            this.foarteMareToolStripMenuItem.Name = "foarteMareToolStripMenuItem";
            this.foarteMareToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.foarteMareToolStripMenuItem.Text = "Foarte mare";
            this.foarteMareToolStripMenuItem.Click += new System.EventHandler(this.foarteMareToolStripMenuItem_Click);
            // 
            // modulDeAfisareToolStripMenuItem
            // 
            this.modulDeAfisareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoToolStripMenuItem,
            this.centruToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.strechToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.modulDeAfisareToolStripMenuItem.Name = "modulDeAfisareToolStripMenuItem";
            this.modulDeAfisareToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.modulDeAfisareToolStripMenuItem.Text = "Modul de afisare";
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.autoToolStripMenuItem.Text = "Auto";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // centruToolStripMenuItem
            // 
            this.centruToolStripMenuItem.Name = "centruToolStripMenuItem";
            this.centruToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.centruToolStripMenuItem.Text = "Centru";
            this.centruToolStripMenuItem.Click += new System.EventHandler(this.centruToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // strechToolStripMenuItem
            // 
            this.strechToolStripMenuItem.Name = "strechToolStripMenuItem";
            this.strechToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.strechToolStripMenuItem.Text = "Strech";
            this.strechToolStripMenuItem.Click += new System.EventHandler(this.strechToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Checked = true;
            this.zoomToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // inchideToolStripMenuItem
            // 
            this.inchideToolStripMenuItem.Name = "inchideToolStripMenuItem";
            this.inchideToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.inchideToolStripMenuItem.Text = "Inchide";
            this.inchideToolStripMenuItem.Click += new System.EventHandler(this.inchideToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 6500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 1024);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem inchideToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem urmatorulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteriorToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem vitezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem micaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foarteMareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulDeAfisareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
    }
}

