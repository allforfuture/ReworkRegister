using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReworkRegisterAPP
{
    public partial class UserForm : Form
    {
        List<UserInfo> users = new List<UserInfo>();
        GetDataFromXml getDataFromXml = new GetDataFromXml();
        public UserForm()
        {
            InitializeComponent();
            LoadAllUsers(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\UserInfo.xml");
        }

        private void LoadAllUsers(string fPath)
        {
            getDataFromXml.CGetData(fPath, ref users);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sel_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "") return;
            foreach(UserInfo u in users)
            {
                if(u.user==id_txt.Text)
                {
                    pw_txt.Text = u.password;
                }
            }
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == ""|| pw_txt.Text=="") return;
            UserInfo user = new UserInfo();
            user.user = id_txt.Text;
            user.password = id_txt.Text;
            user.role = "normal";
            //定义一个开关
            bool Flag = false;
            foreach(UserInfo u in users)
            {
                if(object.Equals(user,u)==true)
                {
                    Flag = true;
                    break;
                }
            }
            if (Flag == true) return;
            //增加
            bool a=getDataFromXml.AddUser(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\UserInfo.xml", user);
            if(a==true)
            {
                MessageBox.Show("添加成功!");
            }
        }

        private void Modify_btn_Click(object sender, EventArgs e)
        {
            if(id_txt.Text=="" || pw_txt.Text=="")
            {
                MessageBox.Show("ID,Password is empty!");
                return ;
            }
            foreach (UserInfo u in users)
            {
                if (u.user == id_txt.Text)
                {
                    bool a = getDataFromXml.ModifyUser(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\UserInfo.xml", pw_txt.Text, u);
                    if (a == true)
                    {
                        MessageBox.Show("修改成功!");
                    }
                    break;
                }
            }
        }
    }
}
