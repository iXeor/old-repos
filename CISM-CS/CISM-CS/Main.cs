using CISM_CS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CISM_CS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MessageBox.Show("本版本为Freeware版本，仅作功能展示与软件工程大作业使用。\n并不包含实际数据库。\n2020.11.1 \n肖佳煜", "Freeware版本提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateDisp_Click(object sender, EventArgs e)
        {
            string con, sql;//定义了两个变量

            con = "Server=.;Database=CIMS;Trusted_Connection=SSPI"; //这个语句是用来连接本地数据库的，"Server=.;Database=数据库名字;Trusted_Connection=SSPI"

            //如果服务不是通过windows身份登陆，而是SQL用户密码登陆则可以使用以下语句"Server=服务器名字或IP;Database=数据库名字;uid=用户名;pwd=密码"

            sql = "select * from op";  //select * from 数据中需要查询的表格名称

            SqlConnection mycon = new SqlConnection(con);  //建立数据新连接

            mycon.Open();  //打开数据库

            SqlDataAdapter myda = new SqlDataAdapter(sql, con);

            DataSet myds = new DataSet();  //建立适配器

            myda.Fill(myds, "Table");

            dataGridView1.DataSource = myds.Tables["Table"];  //让dataGridView1控件显示数据库里的内容

            mycon.Close();  //关闭数据库
        }
    }
}
