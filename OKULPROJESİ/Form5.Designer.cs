﻿namespace OKULPROJESİ
{
    partial class Form5
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 323);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(259, 446);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Giriş yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 203);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 326);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            label2.Click += label2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 644);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form5";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}