using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CISM_CS
{
    public partial class Login_UI : Form
    {
        String tmppwd,tmpusr;
        bool flag = false;
        Encryptor encryptor = new Encryptor();
        Load load = new Load();
        string ServerAddr;
        public Login_UI()
        {
            encryptor.ResetKey();
            load.Show();
            InitializeComponent();
        }
        private void Login_UI_Load(object sender, EventArgs e) {
            AuthClass.Items.Add("以管理员身份登录");
            AuthClass.Items.Add("以教师身份登录");
            AuthClass.SelectedIndex = 1;
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            if (UserNameBox.Text != "" && pwdBox.Text != "")
            {
                tmpusr = encryptor.Encrypt(UserNameBox.Text);
                tmppwd = encryptor.Encrypt(pwdBox.Text);
                //pwdBox.Text = tmppwd;//测试加密是否生效
                flag = true;
            }
            else
            {
                MessageBox.Show("账户名或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (flag == true)
            {
                Veri veri = new Veri();
                login_button.Visible = false;
                veri.ShowDialog();
                if (veri.DialogResult == DialogResult.OK)
                {
                    login_button.Visible = true; //用于测试
                    switch (AuthClass.SelectedIndex)
                    {
                        case 0:
                            {
                                if (encryptor.Decrypt(tmppwd) == "admin" && encryptor.Decrypt(tmpusr) == "admin")
                                {
                                    pwdBox.Text = null;
                                    UserNameBox.Text = null;
                                    Main main = new Main();
                                    main.Show();
                                    Hide();
                                    //MessageBox.Show("登录成功！");//测试校验
                                }
                                else
                                {
                                    MessageBox.Show("用户名或密码错误");//测试校验
                                    encryptor.ResetKey();
                                }
                                break;
                            }
                        case 1:
                            {
                                if (encryptor.Decrypt(tmppwd) == pwd && encryptor.Decrypt(tmpusr) == usrname)
                                {
                                    pwdBox.Text = null;
                                    UserNameBox.Text = null;
                                    Main main = new Main();
                                    main.Show();
                                    Hide();
                                    //MessageBox.Show("登录成功！");//测试校验
                                }
                                else
                                {
                                    MessageBox.Show("用户名或密码错误");//测试校验
                                    encryptor.ResetKey();
                                }
                                break;
                            }
                    }
                }
                else if (veri.DialogResult == DialogResult.Abort)
                {
                    MessageBox.Show("验证过程被中止，请重新操作。");
                    encryptor.ResetKey();
                    login_button.Visible = true;
                    UserNameBox.Text = null;
                    pwdBox.Text = null;
                }
            }
        }
        //用于测试的本地属性
        string usrname = "user";
        string pwd = "abcdef";
        private void AuthClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(AuthClass.SelectedIndex) {
                case 0:
                    {
                        UserNameBox.Enabled = true;
                        pwdBox.Enabled = true;
                        break;
                    }
                case 1: 
                    {
                        UserNameBox.Enabled = true;
                        pwdBox.Enabled = true;
                        break;
                    }
            }
        }

        private void UserNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) {
                pwdBox.Focus();
            }
        }

        private void pwdBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) {
                login_button_Click(login_button, e);
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            Load load2 = new Load();
            load2.CloseAbout.Visible = true;
            load2.Show();
        }

        private void ServerConfItem_Click(object sender, EventArgs e)
        {
            ServerAddrConf conf = new ServerAddrConf();
            conf.ShowDialog();
            ServerAddr = conf.AddrArray.Text;
            if(conf.DialogResult == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("当前设定地址为： " + ServerAddr + "\n是否正确？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result != DialogResult.Yes)
                {
                    ServerConfItem_Click(sender, e);
                }
            }  
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？","提示",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes) {
                Close();
            }
        }

        private void Login_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("即将关闭本管理系统", "提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void LogoDisp_Tick(object sender, EventArgs e)
        {
            load.Close();
        }
    }
}
