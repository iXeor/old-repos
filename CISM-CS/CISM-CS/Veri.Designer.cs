namespace CISM_CS
{
    partial class Veri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veri));
            this.VeriCodeInput = new System.Windows.Forms.TextBox();
            this.VeriCode = new System.Windows.Forms.Label();
            this.TickProgressBar = new System.Windows.Forms.ProgressBar();
            this.manualUpdateCode = new System.Windows.Forms.Button();
            this.CodeUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.OK_Button = new System.Windows.Forms.Button();
            this.ProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.Tips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VeriCodeInput
            // 
            this.VeriCodeInput.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VeriCodeInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.VeriCodeInput.Location = new System.Drawing.Point(62, 55);
            this.VeriCodeInput.Name = "VeriCodeInput";
            this.VeriCodeInput.Size = new System.Drawing.Size(155, 33);
            this.VeriCodeInput.TabIndex = 0;
            this.VeriCodeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VeriCodeInput_KeyDown);
            // 
            // VeriCode
            // 
            this.VeriCode.AutoSize = true;
            this.VeriCode.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VeriCode.Location = new System.Drawing.Point(251, 58);
            this.VeriCode.Name = "VeriCode";
            this.VeriCode.Size = new System.Drawing.Size(72, 26);
            this.VeriCode.TabIndex = 1;
            this.VeriCode.Text = "验证码";
            // 
            // TickProgressBar
            // 
            this.TickProgressBar.Location = new System.Drawing.Point(1, 96);
            this.TickProgressBar.Name = "TickProgressBar";
            this.TickProgressBar.Size = new System.Drawing.Size(383, 10);
            this.TickProgressBar.Step = 1;
            this.TickProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TickProgressBar.TabIndex = 3;
            // 
            // manualUpdateCode
            // 
            this.manualUpdateCode.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manualUpdateCode.Location = new System.Drawing.Point(57, 112);
            this.manualUpdateCode.Name = "manualUpdateCode";
            this.manualUpdateCode.Size = new System.Drawing.Size(121, 43);
            this.manualUpdateCode.TabIndex = 2;
            this.manualUpdateCode.Text = "手动刷新验证码";
            this.manualUpdateCode.UseVisualStyleBackColor = true;
            this.manualUpdateCode.Click += new System.EventHandler(this.manualUpdateCode_Click);
            // 
            // CodeUpdateTimer
            // 
            this.CodeUpdateTimer.Enabled = true;
            this.CodeUpdateTimer.Interval = 10000;
            this.CodeUpdateTimer.Tick += new System.EventHandler(this.CodeUpdateTimer_Tick);
            // 
            // OK_Button
            // 
            this.OK_Button.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK_Button.Location = new System.Drawing.Point(206, 112);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(121, 43);
            this.OK_Button.TabIndex = 4;
            this.OK_Button.Text = "确定";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // ProgressBarTimer
            // 
            this.ProgressBarTimer.Enabled = true;
            this.ProgressBarTimer.Interval = 500;
            this.ProgressBarTimer.Tick += new System.EventHandler(this.ProgressBarTimer_Tick);
            // 
            // Tips
            // 
            this.Tips.AutoSize = true;
            this.Tips.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tips.Location = new System.Drawing.Point(116, 9);
            this.Tips.Name = "Tips";
            this.Tips.Size = new System.Drawing.Size(153, 40);
            this.Tips.TabIndex = 5;
            this.Tips.Text = "请输入看到的验证码\r\n(不区分大小写)";
            this.Tips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Veri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.Tips);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.TickProgressBar);
            this.Controls.Add(this.manualUpdateCode);
            this.Controls.Add(this.VeriCode);
            this.Controls.Add(this.VeriCodeInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Veri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录验证程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Veri_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VeriCodeInput;
        private System.Windows.Forms.Label VeriCode;
        private System.Windows.Forms.ProgressBar TickProgressBar;
        private System.Windows.Forms.Button manualUpdateCode;
        private System.Windows.Forms.Timer CodeUpdateTimer;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Timer ProgressBarTimer;
        private System.Windows.Forms.Label Tips;
    }
}