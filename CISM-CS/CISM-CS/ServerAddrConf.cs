using CISM_CS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISM_CS
{
    public partial class ServerAddrConf : Form
    {
        public static string serverAddr;
        IPAddress address;
        public ServerAddrConf()
        {
            InitializeComponent();
            AddrArray.Text = Settings.Default.ServerAddr;
        }
        private void ServerAddrConf_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.DialogResult == DialogResult.OK)
            {
                Settings.Default.ServerAddr = serverAddr;
                Settings.Default.Save();
            }
        }

        private void Checked_Click(object sender, EventArgs e)
        {
            if (IPAddress.TryParse(AddrArray.Text, out address))
            {
                serverAddr = address.ToString();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else { 
                MessageBox.Show("输入的IP地址格式无效!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.Abort;
                ServerAddrConf server = new ServerAddrConf();
                server.ShowDialog();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddrArray_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Checked_Click(Checked, e);
            }
        }
    }
}
