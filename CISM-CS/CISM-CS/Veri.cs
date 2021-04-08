using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISM_CS
{
    public partial class Veri : Form
    {
        public Veri()
        {
            InitializeComponent();
            VeriCode.Text = GenerateCheckCode();
        }
        private string GenerateCheckCode()
        {
            TickProgressBar.Value = 0;
            int number;
            char code;
            string checkCode = String.Empty;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                number = random.Next();

                if (number % 2 == 0)
                    code = (char)('0' + (char)(number % 10));
                else
                    code = (char)('A' + (char)(number % 26));

                checkCode += code.ToString();
            }
            return checkCode;
        }
        private void manualUpdateCode_Click(object sender, EventArgs e)
        {
            VeriCode.Text = GenerateCheckCode();
            CodeUpdateTimer.Stop();
            CodeUpdateTimer.Start();
        }

        private void CodeUpdateTimer_Tick(object sender, EventArgs e)
        {

            VeriCode.Text = GenerateCheckCode();
        }
        private void OK_Button_Click(object sender, EventArgs e)
        {
            String veristr = VeriCodeInput.Text;
            if (veristr == VeriCode.Text || veristr.ToUpper() == VeriCode.Text)
            {
                TickProgressBar.Visible = false;
                //MessageBox.Show("验证成功");//测试用
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else {
                MessageBox.Show("对不起，您输入的验证码有误！");
            }
        }
        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            TickProgressBar.Value += 5; 
        }
        private void Veri_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Abort;
            }
        }
        private void VeriCodeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OK_Button_Click(OK_Button, e);
            }
        }
    }
}