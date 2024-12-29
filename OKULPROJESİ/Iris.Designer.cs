namespace OKULPROJESİ
{
    partial class Iris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iris));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label4 = new Label();
            button3 = new Button();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(220, 79);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Seç";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 50);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(198, 141);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 2;
            button2.Text = "Seç";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 50);
            label4.Name = "label4";
            label4.Size = new Size(81, 30);
            label4.TabIndex = 5;
            label4.Text = "Ücret:";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(759, 75);
            button3.Name = "button3";
            button3.Size = new Size(205, 46);
            button3.TabIndex = 6;
            button3.Text = "Ana Sayfaya git";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Microsoft JhengHei UI", 9F);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(37, 441);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 315);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üç Kart Yayılımı";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(339, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(button2);
            groupBox2.Font = new Font("Microsoft JhengHei UI", 9F);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(512, 441);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 315);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tek Kart Yayılımı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 50);
            label3.Name = "label3";
            label3.Size = new Size(129, 30);
            label3.TabIndex = 9;
            label3.Text = "Ücret: 250";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(34, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(129, 185);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(37, 19);
            label10.Name = "label10";
            label10.Size = new Size(153, 41);
            label10.TabIndex = 27;
            label10.Text = "Kahin İris";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 318);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("French Script MT", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(292, 150);
            label7.Name = "label7";
            label7.Size = new Size(421, 46);
            label7.TabIndex = 29;
            label7.Text = "Kehanet seni bekliyor. Cesur ol...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(299, 211);
            label8.Name = "label8";
            label8.Size = new Size(92, 30);
            label8.TabIndex = 30;
            label8.Text = "Yaş: 27";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(299, 89);
            label9.Name = "label9";
            label9.Size = new Size(152, 32);
            label9.TabIndex = 31;
            label9.Text = "★★★★☆ 4.1";
            // 
            // Iris
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1013, 791);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Iris";
            Text = "Iris";
            Load += Iris_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label4;
        private Button button3;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}