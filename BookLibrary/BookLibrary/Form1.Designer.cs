namespace BookLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_Autor = new System.Windows.Forms.RadioButton();
            this.button_Sorteaza = new System.Windows.Forms.Button();
            this.radioButton2_NrPag = new System.Windows.Forms.RadioButton();
            this.radioButton_Nota = new System.Windows.Forms.RadioButton();
            this.numericUpDown_Nota = new System.Windows.Forms.NumericUpDown();
            this.button_Adauga = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Pret = new System.Windows.Forms.TextBox();
            this.textBox_NrPag = new System.Windows.Forms.TextBox();
            this.textBox_AnAp = new System.Windows.Forms.TextBox();
            this.textBox_Autor = new System.Windows.Forms.TextBox();
            this.textBox_Titlu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Iesire = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anApDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCarti = new BookLibrary.DataSetCarti();
            this.cartiTableAdapter = new BookLibrary.DataSetCartiTableAdapters.CartiTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCarti)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Iesire, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 478);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.anApDataGridViewTextBoxColumn,
            this.nrPagDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(483, 167);
            this.dataGridView1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.radioButton_Autor);
            this.panel1.Controls.Add(this.button_Sorteaza);
            this.panel1.Controls.Add(this.radioButton2_NrPag);
            this.panel1.Controls.Add(this.radioButton_Nota);
            this.panel1.Controls.Add(this.numericUpDown_Nota);
            this.panel1.Controls.Add(this.button_Adauga);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_Pret);
            this.panel1.Controls.Add(this.textBox_NrPag);
            this.panel1.Controls.Add(this.textBox_AnAp);
            this.panel1.Controls.Add(this.textBox_Autor);
            this.panel1.Controls.Add(this.textBox_Titlu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 244);
            this.panel1.TabIndex = 0;
            // 
            // radioButton_Autor
            // 
            this.radioButton_Autor.AutoSize = true;
            this.radioButton_Autor.Checked = true;
            this.radioButton_Autor.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Autor.Location = new System.Drawing.Point(350, 158);
            this.radioButton_Autor.Name = "radioButton_Autor";
            this.radioButton_Autor.Size = new System.Drawing.Size(64, 25);
            this.radioButton_Autor.TabIndex = 41;
            this.radioButton_Autor.TabStop = true;
            this.radioButton_Autor.Text = "Autor";
            this.radioButton_Autor.UseVisualStyleBackColor = true;
            // 
            // button_Sorteaza
            // 
            this.button_Sorteaza.AutoSize = true;
            this.button_Sorteaza.Font = new System.Drawing.Font("Pristina", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sorteaza.ForeColor = System.Drawing.Color.Purple;
            this.button_Sorteaza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Sorteaza.ImageKey = "(none)";
            this.button_Sorteaza.Location = new System.Drawing.Point(155, 194);
            this.button_Sorteaza.Name = "button_Sorteaza";
            this.button_Sorteaza.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Sorteaza.Size = new System.Drawing.Size(110, 42);
            this.button_Sorteaza.TabIndex = 40;
            this.button_Sorteaza.Text = "Sortează";
            this.button_Sorteaza.UseVisualStyleBackColor = true;
            this.button_Sorteaza.Click += new System.EventHandler(this.button_Sorteaza_Click);
            // 
            // radioButton2_NrPag
            // 
            this.radioButton2_NrPag.AutoSize = true;
            this.radioButton2_NrPag.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2_NrPag.Location = new System.Drawing.Point(232, 159);
            this.radioButton2_NrPag.Name = "radioButton2_NrPag";
            this.radioButton2_NrPag.Size = new System.Drawing.Size(93, 25);
            this.radioButton2_NrPag.TabIndex = 39;
            this.radioButton2_NrPag.Text = "Nr. pagini";
            this.radioButton2_NrPag.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nota
            // 
            this.radioButton_Nota.AutoSize = true;
            this.radioButton_Nota.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Nota.Location = new System.Drawing.Point(147, 159);
            this.radioButton_Nota.Name = "radioButton_Nota";
            this.radioButton_Nota.Size = new System.Drawing.Size(61, 25);
            this.radioButton_Nota.TabIndex = 38;
            this.radioButton_Nota.Text = "Notă";
            this.radioButton_Nota.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Nota
            // 
            this.numericUpDown_Nota.Location = new System.Drawing.Point(147, 133);
            this.numericUpDown_Nota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Nota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Nota.Name = "numericUpDown_Nota";
            this.numericUpDown_Nota.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_Nota.TabIndex = 37;
            this.numericUpDown_Nota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_Adauga
            // 
            this.button_Adauga.AutoSize = true;
            this.button_Adauga.Font = new System.Drawing.Font("Pristina", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Adauga.ForeColor = System.Drawing.Color.Purple;
            this.button_Adauga.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Adauga.ImageKey = "(none)";
            this.button_Adauga.Location = new System.Drawing.Point(9, 194);
            this.button_Adauga.Name = "button_Adauga";
            this.button_Adauga.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Adauga.Size = new System.Drawing.Size(110, 42);
            this.button_Adauga.TabIndex = 36;
            this.button_Adauga.Text = "Adaugă";
            this.button_Adauga.UseVisualStyleBackColor = true;
            this.button_Adauga.Click += new System.EventHandler(this.button_Adauga_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(227, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = "lei";
            // 
            // textBox_Pret
            // 
            this.textBox_Pret.Location = new System.Drawing.Point(119, 110);
            this.textBox_Pret.Name = "textBox_Pret";
            this.textBox_Pret.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pret.TabIndex = 34;
            // 
            // textBox_NrPag
            // 
            this.textBox_NrPag.Location = new System.Drawing.Point(119, 84);
            this.textBox_NrPag.Name = "textBox_NrPag";
            this.textBox_NrPag.Size = new System.Drawing.Size(100, 20);
            this.textBox_NrPag.TabIndex = 33;
            // 
            // textBox_AnAp
            // 
            this.textBox_AnAp.Location = new System.Drawing.Point(119, 58);
            this.textBox_AnAp.Name = "textBox_AnAp";
            this.textBox_AnAp.Size = new System.Drawing.Size(101, 20);
            this.textBox_AnAp.TabIndex = 32;
            // 
            // textBox_Autor
            // 
            this.textBox_Autor.Location = new System.Drawing.Point(120, 32);
            this.textBox_Autor.Name = "textBox_Autor";
            this.textBox_Autor.Size = new System.Drawing.Size(207, 20);
            this.textBox_Autor.TabIndex = 31;
            // 
            // textBox_Titlu
            // 
            this.textBox_Titlu.Location = new System.Drawing.Point(120, 6);
            this.textBox_Titlu.Name = "textBox_Titlu";
            this.textBox_Titlu.Size = new System.Drawing.Size(207, 20);
            this.textBox_Titlu.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Sortează după:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Acordă o notă:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Preț:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nr. pagini:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "An apariție:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Titlu:";
            this.label1.UseWaitCursor = true;
            // 
            // button_Iesire
            // 
            this.button_Iesire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Iesire.AutoSize = true;
            this.button_Iesire.Font = new System.Drawing.Font("Pristina", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Iesire.ForeColor = System.Drawing.Color.Purple;
            this.button_Iesire.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Iesire.ImageKey = "(none)";
            this.button_Iesire.Location = new System.Drawing.Point(352, 426);
            this.button_Iesire.Name = "button_Iesire";
            this.button_Iesire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Iesire.Size = new System.Drawing.Size(134, 49);
            this.button_Iesire.TabIndex = 20;
            this.button_Iesire.Text = "Ieșire";
            this.button_Iesire.UseVisualStyleBackColor = true;
            this.button_Iesire.Click += new System.EventHandler(this.button_Iesire_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anApDataGridViewTextBoxColumn
            // 
            this.anApDataGridViewTextBoxColumn.DataPropertyName = "An_Ap";
            this.anApDataGridViewTextBoxColumn.HeaderText = "An_Ap";
            this.anApDataGridViewTextBoxColumn.Name = "anApDataGridViewTextBoxColumn";
            this.anApDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrPagDataGridViewTextBoxColumn
            // 
            this.nrPagDataGridViewTextBoxColumn.DataPropertyName = "Nr_Pag";
            this.nrPagDataGridViewTextBoxColumn.HeaderText = "Nr_Pag";
            this.nrPagDataGridViewTextBoxColumn.Name = "nrPagDataGridViewTextBoxColumn";
            this.nrPagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartiBindingSource
            // 
            this.cartiBindingSource.DataMember = "Carti";
            this.cartiBindingSource.DataSource = this.dataSetCarti;
            // 
            // dataSetCarti
            // 
            this.dataSetCarti.DataSetName = "DataSetCarti";
            this.dataSetCarti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartiTableAdapter
            // 
            this.cartiTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(505, 516);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookLibrary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCarti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_Autor;
        private System.Windows.Forms.Button button_Sorteaza;
        private System.Windows.Forms.RadioButton radioButton2_NrPag;
        private System.Windows.Forms.RadioButton radioButton_Nota;
        private System.Windows.Forms.NumericUpDown numericUpDown_Nota;
        private System.Windows.Forms.Button button_Adauga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Pret;
        private System.Windows.Forms.TextBox textBox_NrPag;
        private System.Windows.Forms.TextBox textBox_AnAp;
        private System.Windows.Forms.TextBox textBox_Autor;
        private System.Windows.Forms.TextBox textBox_Titlu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Iesire;
        private DataSetCarti dataSetCarti;
        private System.Windows.Forms.BindingSource cartiBindingSource;
        private DataSetCartiTableAdapters.CartiTableAdapter cartiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anApDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
    }
}

