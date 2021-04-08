namespace CISM_CS
{
    partial class Login_UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_UI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.AuthClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.LogoDisp = new System.Windows.Forms.Timer(this.components);
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.OptionToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerConfItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(145, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "密 码：";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserNameBox.Location = new System.Drawing.Point(263, 154);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(216, 33);
            this.UserNameBox.TabIndex = 3;
            this.UserNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameBox_KeyDown);
            // 
            // pwdBox
            // 
            this.pwdBox.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pwdBox.Location = new System.Drawing.Point(263, 213);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '*';
            this.pwdBox.Size = new System.Drawing.Size(216, 33);
            this.pwdBox.TabIndex = 4;
            this.pwdBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwdBox_KeyDown);
            // 
            // AuthClass
            // 
            this.AuthClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthClass.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthClass.FormattingEnabled = true;
            this.AuthClass.Location = new System.Drawing.Point(263, 272);
            this.AuthClass.Name = "AuthClass";
            this.AuthClass.Size = new System.Drawing.Size(216, 34);
            this.AuthClass.TabIndex = 5;
            this.AuthClass.SelectedIndexChanged += new System.EventHandler(this.AuthClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(145, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "登陆身份：";
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("特创易新恒LOGO美黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login_button.Location = new System.Drawing.Point(251, 344);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(127, 54);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "登录";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // LogoDisp
            // 
            this.LogoDisp.Enabled = true;
            this.LogoDisp.Interval = 3000;
            this.LogoDisp.Tick += new System.EventHandler(this.LogoDisp_Tick);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionToolStrip,
            this.About});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(624, 25);
            this.MenuBar.TabIndex = 8;
            this.MenuBar.Text = "Bar";
            // 
            // OptionToolStrip
            // 
            this.OptionToolStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OptionToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerConfItem,
            this.ExitButton});
            this.OptionToolStrip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OptionToolStrip.Name = "OptionToolStrip";
            this.OptionToolStrip.Size = new System.Drawing.Size(44, 21);
            this.OptionToolStrip.Text = "选项";
            // 
            // ServerConfItem
            // 
            this.ServerConfItem.Name = "ServerConfItem";
            this.ServerConfItem.Size = new System.Drawing.Size(180, 22);
            this.ServerConfItem.Text = "配置服务器位置";
            this.ServerConfItem.Click += new System.EventHandler(this.ServerConfItem_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 22);
            this.ExitButton.Text = "退出";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // About
            // 
            this.About.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(44, 21);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Login_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AuthClass);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Login_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录-学生竞赛管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_UI_FormClosing);
            this.Load += new System.EventHandler(this.Login_UI_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.ComboBox AuthClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer LogoDisp;
        protected internal System.Windows.Forms.Button login_button;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem OptionToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ServerConfItem;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem About;
    }
}

