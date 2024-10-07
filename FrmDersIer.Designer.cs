namespace BonusOkul
{
    partial class FrmDersIer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDersIer));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtdersid = new TextBox();
            txtdersad = new TextBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            btnupdate = new Button();
            pictureBox3 = new PictureBox();
            btnlist = new Button();
            pictureBox2 = new PictureBox();
            btndelete = new Button();
            pictureBox1 = new PictureBox();
            btninsert = new Button();
            button5 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(7, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 250);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(646, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 317);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 1;
            label1.Text = "Ders Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 370);
            label2.Name = "label2";
            label2.Size = new Size(107, 27);
            label2.TabIndex = 2;
            label2.Text = "Ders Ad:";
            // 
            // txtdersid
            // 
            txtdersid.Enabled = false;
            txtdersid.Location = new Point(199, 310);
            txtdersid.Name = "txtdersid";
            txtdersid.Size = new Size(379, 34);
            txtdersid.TabIndex = 1;
            // 
            // txtdersad
            // 
            txtdersad.Location = new Point(199, 363);
            txtdersad.Name = "txtdersad";
            txtdersad.Size = new Size(379, 34);
            txtdersad.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(btnupdate);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(btnlist);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btndelete);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btninsert);
            panel2.Location = new Point(10, 414);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 139);
            panel2.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(331, 75);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(75, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.LightSeaGreen;
            btnupdate.Location = new Point(412, 75);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(218, 47);
            btnupdate.TabIndex = 6;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(331, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // btnlist
            // 
            btnlist.BackColor = Color.LightSeaGreen;
            btnlist.Location = new Point(412, 13);
            btnlist.Name = "btnlist";
            btnlist.Size = new Size(218, 47);
            btnlist.TabIndex = 4;
            btnlist.Text = "LIST";
            btnlist.UseVisualStyleBackColor = false;
            btnlist.Click += btnlist_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.LightSeaGreen;
            btndelete.Location = new Point(93, 75);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(212, 47);
            btndelete.TabIndex = 5;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.LightSeaGreen;
            btninsert.Location = new Point(93, 13);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(212, 47);
            btninsert.TabIndex = 3;
            btninsert.Text = "INSERT";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSeaGreen;
            button5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(544, 12);
            button5.Name = "button5";
            button5.Size = new Size(109, 36);
            button5.TabIndex = 6;
            button5.Text = "BACK";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(149, 8);
            label3.Name = "label3";
            label3.Size = new Size(370, 39);
            label3.TabIndex = 7;
            label3.Text = "Ders İşlemleri Paneli";
            // 
            // FrmDersIer
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(665, 552);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(txtdersad);
            Controls.Add(txtdersid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDersIer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ders İşlemleri Menüsü";
            Load += FrmDersIer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtdersid;
        private TextBox txtdersad;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Button btnupdate;
        private PictureBox pictureBox3;
        private Button btnlist;
        private PictureBox pictureBox2;
        private Button btndelete;
        private PictureBox pictureBox1;
        private Button btninsert;
        private Button button5;
        private Label label3;
    }
}