﻿namespace WinFormHelloWorld
{
    partial class SayHelloForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SayHelloTextBox = new System.Windows.Forms.TextBox();
            this.SayHelloButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SayHelloTextBox
            // 
            this.SayHelloTextBox.Location = new System.Drawing.Point(88, 56);
            this.SayHelloTextBox.Name = "SayHelloTextBox";
            this.SayHelloTextBox.Size = new System.Drawing.Size(100, 21);
            this.SayHelloTextBox.TabIndex = 0;
            // 
            // SayHelloButton
            // 
            this.SayHelloButton.Location = new System.Drawing.Point(100, 101);
            this.SayHelloButton.Name = "SayHelloButton";
            this.SayHelloButton.Size = new System.Drawing.Size(75, 23);
            this.SayHelloButton.TabIndex = 1;
            this.SayHelloButton.Text = "SayHello";
            this.SayHelloButton.UseVisualStyleBackColor = true;
            this.SayHelloButton.Click += new System.EventHandler(this.SayHelloButton_Click);
            // 
            // SayHelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.SayHelloButton);
            this.Controls.Add(this.SayHelloTextBox);
            this.Name = "SayHelloForm";
            this.Text = "SayHelloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SayHelloTextBox;
        private System.Windows.Forms.Button SayHelloButton;
    }
}

