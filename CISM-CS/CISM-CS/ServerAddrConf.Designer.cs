﻿namespace CISM_CS
{
    partial class ServerAddrConf
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddrArray = new System.Windows.Forms.TextBox();
            this.Checked = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库服务器所在IP地址：";
            // 
            // AddrArray
            // 
            this.AddrArray.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddrArray.Location = new System.Drawing.Point(63, 74);
            this.AddrArray.Name = "AddrArray";
            this.AddrArray.Size = new System.Drawing.Size(202, 26);
            this.AddrArray.TabIndex = 1;
            this.AddrArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddrArray.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddrArray_KeyDown);
            // 
            // Checked
            // 
            this.Checked.Location = new System.Drawing.Point(63, 114);
            this.Checked.Name = "Checked";
            this.Checked.Size = new System.Drawing.Size(75, 23);
            this.Checked.TabIndex = 2;
            this.Checked.Text = "确认";
            this.Checked.UseVisualStyleBackColor = true;
            this.Checked.Click += new System.EventHandler(this.Checked_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(190, 114);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ServerAddrConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 149);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Checked);
            this.Controls.Add(this.AddrArray);
            this.Controls.Add(this.label1);
            this.Name = "ServerAddrConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置服务器位置助手";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerAddrConf_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Checked;
        protected internal System.Windows.Forms.TextBox AddrArray;
        private new System.Windows.Forms.Button CancelButton;
    }
}