namespace BonusOkul
{
    partial class FrmOgretmenislemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenislemleri));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnback = new Button();
            panel1 = new Panel();
            btnupdate = new Button();
            pictureBox4 = new PictureBox();
            btnlist = new Button();
            pictureBox3 = new PictureBox();
            btndelete = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtogretmenId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            cmbbrans = new ComboBox();
            cmbadsoyad = new ComboBox();
            label3 = new Label();
            btninsert = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(4, 7);
            label3.Name = "label3";
            label3.Size = new Size(453, 39);
            label3.TabIndex = 14;
            label3.Text = "Öğretmen İşlemleri Paneli";
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.FromArgb(192, 255, 192);
            btninsert.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            btninsert.Location = new Point(110, 20);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(159, 52);
            btninsert.TabIndex = 4;
            btninsert.Text = "INSERT";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // btnback
            // 
            btnback.BackColor = Color.FromArgb(192, 255, 192);
            btnback.CausesValidation = false;
            btnback.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(460, 5);
            btnback.Name = "btnback";
            btnback.Size = new Size(122, 38);
            btnback.TabIndex = 8;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
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
            panel1.Location = new Point(12, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 168);
            panel1.TabIndex = 13;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(192, 255, 192);
            btnupdate.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            btnupdate.Location = new Point(391, 99);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(154, 52);
            btnupdate.TabIndex = 7;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(290, 99);
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
            btnlist.Location = new Point(391, 20);
            btnlist.Name = "btnlist";
            btnlist.Size = new Size(154, 52);
            btnlist.TabIndex = 5;
            btnlist.Text = "LIST";
            btnlist.UseVisualStyleBackColor = false;
            btnlist.Click += btnlist_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(290, 20);
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
            btndelete.Size = new Size(159, 52);
            btndelete.TabIndex = 6;
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
            // txtogretmenId
            // 
            txtogretmenId.Enabled = false;
            txtogretmenId.Location = new Point(207, 313);
            txtogretmenId.Name = "txtogretmenId";
            txtogretmenId.Size = new Size(363, 34);
            txtogretmenId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(76, 363);
            label2.Name = "label2";
            label2.Size = new Size(108, 29);
            label2.TabIndex = 12;
            label2.Text = "Branş :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(1, 316);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 10;
            label1.Text = "Öğretmen Id:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(581, 242);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(39, 413);
            label4.Name = "label4";
            label4.Size = new Size(145, 29);
            label4.TabIndex = 17;
            label4.Text = "Ad Soyad:";
            // 
            // cmbbrans
            // 
            cmbbrans.FormattingEnabled = true;
            cmbbrans.Location = new Point(207, 363);
            cmbbrans.Name = "cmbbrans";
            cmbbrans.Size = new Size(363, 35);
            cmbbrans.TabIndex = 2;
            cmbbrans.SelectedIndexChanged += cmbbrans_SelectedIndexChanged;
            // 
            // cmbadsoyad
            // 
            cmbadsoyad.FormattingEnabled = true;
            cmbadsoyad.Location = new Point(207, 409);
            cmbadsoyad.Name = "cmbadsoyad";
            cmbadsoyad.Size = new Size(363, 35);
            cmbadsoyad.TabIndex = 3;
            // 
            // FrmOgretmenislemleri
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(586, 630);
            Controls.Add(cmbadsoyad);
            Controls.Add(cmbbrans);
            Controls.Add(label4);
            Controls.Add(btnback);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txtogretmenId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOgretmenislemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOgretmenislemleri";
            Load += FrmOgretmenislemleri_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private Panel panel1;
        private Button btnupdate;
        private PictureBox pictureBox4;
        private Button btnlist;
        private PictureBox pictureBox3;
        private Button btndelete;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtogretmenId;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label4;
        private ComboBox cmbbrans;
        private ComboBox cmbadsoyad;
    }
}