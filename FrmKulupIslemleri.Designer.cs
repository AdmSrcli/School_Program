namespace BonusOkul
{
    partial class FrmKulupIslemleri
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
            Label label3;
            Button btninsert;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKulupIslemleri));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtkulupid = new TextBox();
            txtkulupad = new TextBox();
            panel1 = new Panel();
            btnupdate = new Button();
            pictureBox4 = new PictureBox();
            btnlist = new Button();
            pictureBox3 = new PictureBox();
            btndelete = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnback = new Button();
            label3 = new Label();
            btninsert = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(14, 11);
            label3.Name = "label3";
            label3.Size = new Size(397, 39);
            label3.TabIndex = 6;
            label3.Text = "Kulüp İşlemleri Paneli";
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.FromArgb(192, 255, 192);
            btninsert.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            btninsert.Location = new Point(110, 20);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(144, 52);
            btninsert.TabIndex = 7;
            btninsert.Text = "INSERT";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(529, 230);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(21, 327);
            label1.Name = "label1";
            label1.Size = new Size(139, 29);
            label1.TabIndex = 1;
            label1.Text = "Kulup Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(10, 374);
            label2.Name = "label2";
            label2.Size = new Size(151, 29);
            label2.TabIndex = 2;
            label2.Text = "Kulup Ad:";
            // 
            // txtkulupid
            // 
            txtkulupid.Enabled = false;
            txtkulupid.Location = new Point(172, 320);
            txtkulupid.Name = "txtkulupid";
            txtkulupid.Size = new Size(363, 34);
            txtkulupid.TabIndex = 1;
            // 
            // txtkulupad
            // 
            txtkulupad.Location = new Point(172, 367);
            txtkulupad.Name = "txtkulupad";
            txtkulupad.Size = new Size(363, 34);
            txtkulupad.TabIndex = 2;
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
            panel1.Location = new Point(10, 431);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 180);
            panel1.TabIndex = 5;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(192, 255, 192);
            btnupdate.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            btnupdate.Location = new Point(379, 99);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(144, 52);
            btnupdate.TabIndex = 6;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(278, 99);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(95, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // btnlist
            // 
            btnlist.BackColor = Color.FromArgb(192, 255, 192);
            btnlist.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            btnlist.Location = new Point(379, 20);
            btnlist.Name = "btnlist";
            btnlist.Size = new Size(144, 52);
            btnlist.TabIndex = 4;
            btnlist.Text = "LIST";
            btnlist.UseVisualStyleBackColor = false;
            btnlist.Click += btnlist_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(278, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(192, 255, 192);
            btndelete.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            btndelete.Location = new Point(110, 99);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(144, 52);
            btndelete.TabIndex = 5;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnback
            // 
            btnback.BackColor = Color.FromArgb(192, 255, 192);
            btnback.CausesValidation = false;
            btnback.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(417, 12);
            btnback.Name = "btnback";
            btnback.Size = new Size(122, 38);
            btnback.TabIndex = 7;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += button1_Click;
            // 
            // FrmKulupIslemleri
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(545, 623);
            Controls.Add(btnback);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txtkulupad);
            Controls.Add(txtkulupid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmKulupIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kulup İşlemleri";
            Load += FrmKulupIslemleri_Load;
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
        private TextBox txtkulupid;
        private TextBox txtkulupad;
        private Panel panel1;
        private Button btnupdate;
        private PictureBox pictureBox4;
        private Button btnlist;
        private PictureBox pictureBox3;
        private Button btndelete;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnback;
        private Button btninsert;
    }
}