using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddresList
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            string nameAcount = AccountText.Text;
            string passwordAcount = PasswordText.Text;

            //ADO.NET框架提供数据库访问模块

            //建立连接

            string connectionName = "server=DESKTOP-QOPBTTQ;database=AddressList;Integrated Security=true";//连接方式

            SqlConnection connection = new SqlConnection(connectionName);
            connection.Open();//打开数据库
            if(connection.State == ConnectionState.Open)
            {
                //访问数据
                string sql = "select * from Login where loginName = '"+nameAcount+"' and password = '"+passwordAcount+"' ";//要执行的命令
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    LinkForm linkForm = new LinkForm();
                    linkForm.Show();
                }
                else
                {
                    MessageBox.Show("密码或账号错误");
                }
            }

            //关闭连接
            connection.Close();
        }
    }
}
