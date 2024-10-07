namespace BonusOkul
{
    partial class Frmogrenciislemleri
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
            Button btninsert;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmogrenciislemleri));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtogrid = new TextBox();
            txtad = new TextBox();
            txtsoyad = new TextBox();
            cmbcinsiyet = new ComboBox();
            panel1 = new Panel();
            btnupdate = new Button();
            pictureBox4 = new PictureBox();
            btnlist = new Button();
            pictureBox3 = new PictureBox();
            btndelete = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            cmbkulup = new ComboBox();
            btninsert = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.FromArgb(192, 255, 192);
            btninsert.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            btninsert.Location = new Point(129, 13);
            btninsert.Margin = new Padding(4);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(186, 63);
            btninsert.TabIndex = 6;
            btninsert.Text = "INSERT";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 1);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(670, 271);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold);
            label1.Location = new Point(127, 297);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 29);
            label1.TabIndex = 1;
            label1.Text = "OgrId:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold);
            label2.Location = new Point(111, 362);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 29);
            label2.TabIndex = 2;
            label2.Text = "Ogr Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold);
            label3.Location = new Point(70, 434);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 29);
            label3.TabIndex = 3;
            label3.Text = "Ogr Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F, FontStyle.Bold);
            label4.Location = new Point(73, 498);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 29);
            label4.TabIndex = 4;
            label4.Text = "Ogr Kulup:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14F, FontStyle.Bold);
            label5.Location = new Point(49, 562);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 29);
            label5.TabIndex = 5;
            label5.Text = "Ogr Cinsiyet:";
            // 
            // txtogrid
            // 
            txtogrid.Enabled = false;
            txtogrid.Location = new Point(217, 292);
            txtogrid.Margin = new Padding(4);
            txtogrid.Name = "txtogrid";
            txtogrid.Size = new Size(445, 38);
            txtogrid.TabIndex = 1;
            // 
            // txtad
            // 
            txtad.Location = new Point(217, 357);
            txtad.Margin = new Padding(4);
            txtad.Name = "txtad";
            txtad.Size = new Size(445, 38);
            txtad.TabIndex = 2;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(217, 429);
            txtsoyad.Margin = new Padding(4);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(445, 38);
            txtsoyad.TabIndex = 3;
            // 
            // cmbcinsiyet
            // 
            cmbcinsiyet.FormattingEnabled = true;
            cmbcinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbcinsiyet.Location = new Point(217, 557);
            cmbcinsiyet.Margin = new Padding(4);
            cmbcinsiyet.Name = "cmbcinsiyet";
            cmbcinsiyet.Size = new Size(445, 40);
            cmbcinsiyet.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btninsert);
            panel1.Controls.Add(btnupdate);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnlist);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btndelete);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(8, 619);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 180);
            panel1.TabIndex = 11;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(192, 255, 192);
            btnupdate.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            btnupdate.Location = new Point(469, 107);
            btnupdate.Margin = new Padding(4);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(178, 63);
            btnupdate.TabIndex = 9;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(347, 107);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(107, 63);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // btnlist
            // 
            btnlist.BackColor = Color.FromArgb(192, 255, 192);
            btnlist.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            btnlist.Location = new Point(469, 13);
            btnlist.Margin = new Padding(4);
            btnlist.Name = "btnlist";
            btnlist.Size = new Size(178, 63);
            btnlist.TabIndex = 7;
            btnlist.Text = "LIST";
            btnlist.UseVisualStyleBackColor = false;
            btnlist.Click += btnlist_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(347, 13);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(192, 255, 192);
            btndelete.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            btndelete.Location = new Point(129, 107);
            btndelete.Margin = new Padding(4);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(186, 63);
            btndelete.TabIndex = 8;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 107);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 13);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // cmbkulup
            // 
            cmbkulup.FormattingEnabled = true;
            cmbkulup.Location = new Point(217, 493);
            cmbkulup.Name = "cmbkulup";
            cmbkulup.Size = new Size(445, 40);
            cmbkulup.TabIndex = 4;
            // 
            // Frmogrenciislemleri
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(670, 807);
            Controls.Add(cmbkulup);
            Controls.Add(panel1);
            Controls.Add(cmbcinsiyet);
            Controls.Add(txtsoyad);
            Controls.Add(txtad);
            Controls.Add(txtogrid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 16F, FontStyle.Bold);
            Margin = new Padding(7, 5, 7, 5);
            Name = "Frmogrenciislemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci İşlemleri";
            Load += Frmogrenciislemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtogrid;
        private TextBox txtad;
        private TextBox txtsoyad;
        private ComboBox cmbcinsiyet;
        private Panel panel1;
        private Button btnupdate;
        private PictureBox pictureBox4;
        private Button btnlist;
        private PictureBox pictureBox3;
        private Button btndelete;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox cmbkulup;
    }
}