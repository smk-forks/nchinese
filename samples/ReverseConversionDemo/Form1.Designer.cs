﻿namespace ReverseConversionDemo
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ZhuyinFromBuiltInDict_TextBox = new System.Windows.Forms.TextBox();
            this.PinyinFromImmApi_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ZhuyinFromPinyin_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(177, 26);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(424, 32);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "便宜又方便得不得了";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(625, 26);
            this.GoButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(93, 37);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "查字根";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸入一些中文：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "使用內建詞庫所查詢的注音字根：";
            // 
            // ZhuyinFromBuiltInDict_TextBox
            // 
            this.ZhuyinFromBuiltInDict_TextBox.Location = new System.Drawing.Point(334, 95);
            this.ZhuyinFromBuiltInDict_TextBox.Name = "ZhuyinFromBuiltInDict_TextBox";
            this.ZhuyinFromBuiltInDict_TextBox.Size = new System.Drawing.Size(494, 32);
            this.ZhuyinFromBuiltInDict_TextBox.TabIndex = 5;
            // 
            // PinyinFromImmApi_TextBox
            // 
            this.PinyinFromImmApi_TextBox.Location = new System.Drawing.Point(334, 146);
            this.PinyinFromImmApi_TextBox.Name = "PinyinFromImmApi_TextBox";
            this.PinyinFromImmApi_TextBox.Size = new System.Drawing.Size(494, 32);
            this.PinyinFromImmApi_TextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "使用微軟輸入法 API 反查的拼音：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "將上面查到的拼音轉換成注音：";
            // 
            // ZhuyinFromPinyin_TextBox
            // 
            this.ZhuyinFromPinyin_TextBox.Location = new System.Drawing.Point(334, 199);
            this.ZhuyinFromPinyin_TextBox.Name = "ZhuyinFromPinyin_TextBox";
            this.ZhuyinFromPinyin_TextBox.Size = new System.Drawing.Size(494, 32);
            this.ZhuyinFromPinyin_TextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 264);
            this.Controls.Add(this.ZhuyinFromPinyin_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PinyinFromImmApi_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZhuyinFromBuiltInDict_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.InputTextBox);
            this.Font = new System.Drawing.Font("KaiGen Gothic TW Regular", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "反查注音／拼音字根";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ZhuyinFromBuiltInDict_TextBox;
        private System.Windows.Forms.TextBox PinyinFromImmApi_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ZhuyinFromPinyin_TextBox;
    }
}

