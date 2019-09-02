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
using System.Threading;
using System.Xml;

namespace ReworkRegisterAPP
{

    public partial class Main2 : Form
    {
        //利用win32.api监控界面尺寸
        public const int WM_NCLBUTTONDBLCLK = 0xA3;

        NgCodeCreator Ngcodes = new NgCodeCreator();
        GetDataFromXml getDataFromXml = new GetDataFromXml();
        UserInfo _user=new UserInfo();
        string radNum;
        bool Flag=false;            //定义一个提交开关
        string user = string.Empty;
        List<SnClass> serials = new List<SnClass>();

        public Main2()
        {
            InitializeComponent();
            Text += "_" + Application.ProductVersion.ToString();
            barcode_txt.Enabled = false;
            user_txt.Enabled = true;

            Ngcodes.LoadConfig(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\NgCodeSetting.xml");
            LoadLine();
            LoadProcess();
            LoadTime();
            user_txt.Select();
            //this.Text = "COSM" + "--Ver(" + Assembly.GetExecutingAssembly().GetName().Version + ")";
            //this.WindowState = FormWindowState.Maximized;
        }
        
        private void user_txt_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (user_txt.Text != "")
            {
                /*
                if(!LoadUser(user_txt.Text)) return;
                user_txt.Text = _user.user;
                user_txt.PasswordChar='\0'; //移除密码字符
                */
                if (user_txt.TextLength != 11) return;
                //防止输入"２０１９０３０６０４１"做成的乱码
                try { Convert.ToUInt64(user_txt.Text); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ID异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                user = user_txt.Text.ToUpper();
                user_txt.Enabled = false;
                barcode_txt.Enabled = true;
                barcode_txt.Select();
                if (_user.role == "super")
                {
                    UserForm form = new UserForm();
                    form.Show();
                }
            }
        }

        /// <summary>
        /// 加载user信息
        /// </summary>
        /// <param name="pw"></param>
        /// <returns></returns>
        private bool LoadUser(string pw)
        {
            if (user_txt.Text == "") return false;
            List<UserInfo> users = new List<UserInfo>();
            string fPath=System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"\\UserInfo.xml";
            
            getDataFromXml.CGetData(fPath, ref users);
            foreach(UserInfo u in users)
            {
                if (pw == u.password.ToUpper())
                {
                    this._user = u;
                    return true;
                }
            }
            return false;
        }

        private void ftpUpLoad()
        {
            string fPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Setting.xml";
            string[] tmp = getDataFromXml.iniGetData(fPath, "ftp");
            string[] fromPathArray = getDataFromXml.iniGetData(fPath, "filepath");
            FtpCsv ftpcsv = new FtpCsv(tmp, fromPathArray[0]);
            ftpcsv.UpLoad();
            if(ftpcsv.Flag==false)
            {
                ftp_lbl.Text = "数据上传有误!";
            }
        }
        
        /// <summary>
        /// 加载线别信息
        /// </summary>
        private void LoadLine()
        {
            #region
            line_cbx.Items.Add("L01");
            line_cbx.Items.Add("L02");
            line_cbx.Items.Add("L03");
            line_cbx.Items.Add("L04");
            line_cbx.Items.Add("L05");
            line_cbx.Items.Add("L06");
            line_cbx.Items.Add("L07");
            line_cbx.Items.Add("L08");
            line_cbx.Items.Add("L09");
            line_cbx.Items.Add("L10");
            line_cbx.Items.Add("L11");
            line_cbx.Items.Add("L12");
            line_cbx.Items.Add("L13");

            cmbx_type.Items.Add("17");
            cmbx_type.Items.Add("24");
            cmbx_type.SelectedIndex = 0;
            Font f = new Font("宋体", 15);
            error_msg.Font = f;

            #endregion
            string fPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Setting.xml";
            string[] tmp= getDataFromXml.iniGetData(fPath, "line");
            line_cbx.DataSource = tmp;
            line_cbx.SelectedIndex = 0;
            error_msg.Text = "";
        }
        private void LoadTime()
        {
            string fPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Setting.xml";
            string[] tmp = getDataFromXml.iniGetData(fPath, "time");
            cmbx_time.DataSource = tmp;
            cmbx_time.SelectedIndex = 0;

            tmp = getDataFromXml.iniGetData(fPath, "date");
            cmbx_date.DataSource = tmp;
            cmbx_date.SelectedIndex = 0;



        }
        /// <summary>
        /// 加载工位信息
        /// </summary>
        private void LoadProcess()
        {
            #region
            process_cbx.Items.Add("RE-16_00BE");
            process_cbx.Items.Add("RE-16_00CI");
            process_cbx.Items.Add("RE-1");
            process_cbx.Items.Add("RE-4");
            process_cbx.Items.Add("RE-7");
            process_cbx.Items.Add("RE-16_20HB");
            process_cbx.Items.Add("RE-16_20CB");
            #endregion
            string fPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Setting.xml";
            string[] tmp = getDataFromXml.iniGetData(fPath, "process");
            process_cbx.DataSource = tmp;
            process_cbx.SelectedIndex = 0;

            tmp = getDataFromXml.iniGetData(fPath, "processDetail");
            processDetail_cbx.DataSource = tmp;
            processDetail_cbx.SelectedIndex = 0;

            label1.Text =line_cbx.SelectedItem.ToString()+" --> "+ process_cbx.SelectedItem.ToString();
        }

        /// <summary>
        /// 加载NG Code RadioButton的列表
        /// </summary>
        /// <param name="line"></param>
        /// <param name="process"></param>
        private void GetNgCode(string line, string process)
        {
            //NgType ngType = Ngcodes.GetNgCodes(process);
            panel1.Controls.Clear();
            NgType ngType = Ngcodes.GetNgCodes(process_cbx.SelectedItem.ToString());
            if (ngType == null) return;
            RadioButton[] rads = new RadioButton[ngType.m_Item.Count];
            int i = 0;
            int n = 0;
            int top = 6;
            int var =(int)panel1.Height / 40;
            foreach (NgCode cod in ngType.m_Item)
            {
                //分4行显示
                if (i % var == 0 && i != 0)
                {
                    top=6;
                    n++;
                }
                rads[i] = new RadioButton();
                rads[i].Width = 270;
                rads[i].Height = 30;
                Font f = new Font("宋体",16,FontStyle.Bold);
                rads[i].Font = f;
                rads[i].ForeColor = Color.Blue;
                rads[i].Name =cod.code;
                rads[i].Text = "("+ cod.num+")"+ cod.name;
                rads[i].Visible = true;
                rads[i].Top = top-10;
                //控件左上角相对于容器的左上角坐标
                rads[i].Location = new Point(n * 270, top);
                rads[i].Click += new EventHandler(panel1_Click);
                panel1.Controls.Add(rads[i]);
                top += 40;
                i++;
                //n=0;
            }
            
        }

        private void GetNgCode2(string line,string process)
        {
			panel1.Controls.Clear();
			NgType ngType = Ngcodes.GetNgCodes(process_cbx.SelectedItem.ToString());
			if (ngType == null) return;
			RadioButton[] rads = new RadioButton[ngType.m_Item.Count];
			int i = 0;
			int n = 0;
			int top = 6;
			int var = (int)panel1.Width / 450;
			foreach (NgCode cod in ngType.m_Item)
			{
				//分4行显示
				if (i % var == 0 && i != 0)
				{
					top += 40;
					n = 0;
				}
				rads[i] = new RadioButton();
				rads[i].Width = 440;
				rads[i].Height = 30;
				Font f = new Font("宋体", 16, FontStyle.Bold);
				rads[i].Font = f;
				rads[i].ForeColor = Color.Blue;
				rads[i].Name = cod.code;
				rads[i].Text = "(" + cod.num + ")" + cod.name;
				rads[i].Visible = true;
				rads[i].Top = top - 10;
				//控件左上角相对于容器的左上角坐标
				rads[i].Location = new Point(n * 440, top);
				rads[i].Click += new EventHandler(panel1_Click);
				panel1.Controls.Add(rads[i]);
				n++;
				i++;
				//n=0;
			}
		}

        /// <summary>
        /// 对Panel控件的RadioButtons重新排序
        /// </summary>
        /// <param name="line"></param>
        /// <param name="process"></param>
        private void ReFixNgCode()
        {
            //NgType ngType = Ngcodes.GetNgCodes(process);
            NgType ngType = Ngcodes.GetNgCodes(process_cbx.SelectedItem.ToString());
            if (ngType == null) return;
            int i = 0;
            int n = 0;
            int top = 6;
            int var = (int)panel1.Height / 40;
            foreach (RadioButton rad in panel1.Controls)
            {
                //分4行显示
                if (i % var == 0 && i != 0)
                {
                    top = 6;
                    n++;
                }
                rad.Top = top - 10;
                //控件左上角相对于容器的左上角坐标
                rad.Location = new Point(n * 270, top);
                rad.Click += new EventHandler(panel1_Click);
                top += 40;
                i++;
                //n=0;
            }

        }

        private void ReFixNgCode2()
        {
            //NgType ngType = Ngcodes.GetNgCodes(process);
            NgType ngType = Ngcodes.GetNgCodes(process_cbx.SelectedItem.ToString());
            if (ngType == null) return;
            int i = 0;
            int n = 0;
            int top = 6;
            int var = (int)panel1.Width / 450;
            foreach (RadioButton rad in panel1.Controls)
            {
                //分4行显示
                if (i % var == 0 && i != 0)
                {
                    top += 40;
                    n = 0;
                }
                rad.Top = top - 10;
                //控件左上角相对于容器的左上角坐标
                rad.Location = new Point(n * 440, top);
                rad.Click += new EventHandler(panel1_Click);
                n++;
                i++;
                //n=0;
            }

        }

        private void process_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNgCode2(line_cbx.Text, process_cbx.SelectedItem.ToString());
            label1.Text = line_cbx.SelectedItem.ToString() + " --> " + process_cbx.SelectedItem.ToString();
            barcode_txt.Select();
        }

        /// <summary>
        /// 提交数据，写入csv档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_btn_Click(object sender, EventArgs e)
        {
            //检查barcode是否已经检查
            if (Flag == false)
            {

                error_msg.Text = "条码格式有误，请重新输入!";
                Output_lbl.ForeColor = Color.Red;
                barcode_txt.SelectAll();
                return;
            }
            else {
                error_msg.Text = "";
            }
            //检查是否有选中的NG CODE项
            string ngCode = sNgCode();
            if (ngCode == null)
            {
                error_msg.Text = "请选择不良原因!";
                Output_lbl.ForeColor = Color.Red;
                panel1.Select();
                return;
            }
            else {
                error_msg.Text = "";
            }

            CsvFile csv = new CsvFile();
            string path= System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            #region
            csv.Model = "KK07";
            csv.Site = "NSTD";

            string fPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Setting.xml";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fPath);
            XmlNode nod = xDoc.SelectSingleNode("root");
                  
            XmlNode xNode = nod.SelectSingleNode("factory");
            string factory = xNode.Attributes["value"].Value;

            csv.Factory = factory;
            csv.Line = line_cbx.SelectedItem.ToString();
            csv.Process = process_cbx.SelectedItem.ToString();
            csv.Module = barcode_txt.Text.ToUpper();
            csv.Module2 = "";
            csv.x2 = "";
            DateTime t1 = System.DateTime.Now;
            csv.Year = int.Parse(t1.Year.ToString().Substring(2, 2));
            csv.Month = int.Parse(t1.Month.ToString());
            csv.Day = int.Parse(t1.Day.ToString());
            csv.Hour = int.Parse(t1.Hour.ToString());
            csv.Minute = int.Parse(t1.Minute.ToString());
            csv.Second = int.Parse(t1.Second.ToString());
            csv.Faci_num = 1;
            //csv.Faci = "PLC";
            csv.Faci = ngCode;
            csv.faci_value = 0;
            csv.Item_result = 1;
            csv.All_result = 1;
            csv.Item_num = 1;
            //csv.Op_user = _user.user;
            csv.Op_type = "OPERATOR";
            csv.Op_value = this.user;
            #endregion
            csv.OutPutCsv(path);
            Output_lbl.ForeColor = Color.Lime;
            Output_lbl.Text = "Output " + csv.Filename + " completed.";
            Flag = false;
            barErr_lbl.Text = "";
            /*
            panel1.Click -= new EventHandler(panel1_Click);
            foreach (RadioButton rad in panel1.Controls)
            {
                rad.Checked = false;
            }
            panel1.Click += new EventHandler(panel1_Click);
            */
            barcode_txt.SelectAll();
            barcode_txt.Focus();
            serials = new List<SnClass>();
            LoadserialsDGV();
            //后台ftp上传线程启动
            //ftpUpLoad();
        }

        /// <summary>
        /// 检查barcode是否合法
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        private bool bCCode(string code)
        {
            //用正则表达式判断只能包含字母和数字
            if (!IsNatural_Number(code)) return false;
            string fPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Setting.xml";
            string[] tmp = getDataFromXml.iniGetData(fPath, "validation");
            if (tmp == null) return true;
            //长度判断
            if (code.Length != int.Parse(tmp[1])) return false;
            //截取某几个字符进行判断
            string[] tmp2 = tmp[2].Split(',');
            if(code.Substring(int.Parse(tmp2[0]),int.Parse(tmp2[1]))!=tmp[0]) return false;

            Flag = true;
            return true;
        }

        /// <summary>
        /// 检查是否有选中的NG Code
        /// </summary>
        /// <returns></returns>
        private string sNgCode()
        {
            if(panel1.Controls.Count>0)
            {
                for(int i=0;i< panel1.Controls.Count;i++)
                {
                    RadioButton rad = (RadioButton)panel1.Controls[i];
                    if (rad.Checked)
                    {
                        return rad.Name;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 正则表达式验证只能输入数字或字母
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsNatural_Number(string str)
        {
            System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9+]+$");
            return reg1.IsMatch(str);
        }

        /// <summary>
        /// 显示错误的信息，将用于委托
        /// </summary>
        /// <param name="str"></param>
        public void ShowErrMessage(string str)
        {
            if(ftp_lbl.InvokeRequired)
            {
                MessageShowHandle meseageShowHandle = new MessageShowHandle(ShowErrMessage);
                ftp_lbl.Invoke(meseageShowHandle);
            }
            else
            {
                ftp_lbl.Text = str;
            }
            
        }

        private void panel1_Click(object sender,EventArgs e)
        {
            //RadioButton rad = (RadioButton)sender;
            //radNum = rad.Text;
            //Register_btn.Select();
            //UpLoadData();
            //serials = new List<SnClass>();
            //LoadserialsDGV();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcode_txt_KeyDown(object sender, KeyEventArgs e)
        {
            // modify date 20180613 modify by fyh
            if (e.KeyCode == Keys.Enter && barcode_txt.Text != "")
            {

                //检查barcode是否合法
                string sn = barcode_txt.Text;
                string cmbxType = cmbx_type.SelectedItem.ToString();
              
                if (sn.Substring(0, 1) == "F" || sn.Substring(0, 1) == "G")
                {
                    error_msg.Text = "";
                }
                else
                {
                    error_msg.Text = "";
                    error_msg.Text = "条形码格式不正确，首字母为G,F开头!";
                    error_msg.ForeColor = Color.Red;
                    barcode_txt.SelectAll();
                    return;
                }
                if (cmbxType == "17")
                {
                    if (barcode_txt.Text.Length != 17)
                    {
                        error_msg.Text = "";
                        error_msg.Text = "输入的SN与SN位数不匹配!";
                        error_msg.ForeColor = Color.Red;
                        barcode_txt.SelectAll();
                        return;
                    }
                    else {
                        error_msg.Text = "";
                    }
                    
                }
                else if (cmbxType == "24")
                {
                    if (barcode_txt.Text.Length != 24)
                    {
                        error_msg.Text = "";
                        error_msg.Text = "输入的SN与SN位数不匹配!";
                        error_msg.ForeColor = Color.Red;
                        barcode_txt.SelectAll();
                        return;
                    }
                    else {
                        error_msg.Text = "";
                    }
                }else
                {

                    error_msg.Text = "";
                }

              
                if (serials.Where(s => s.sn == barcode_txt.Text.Trim()).Count() > 0)
                {
                    error_msg.Text = "";
                    error_msg.Text = "条码重复";
                    error_msg.ForeColor = Color.Red;
                   
                    //do
                    //{
                    //    DialogResult = MessageBox.Show("条码重复", "notice", MessageBoxButtons.RetryCancel);
                    //}
                    //while (DialogResult == DialogResult.Retry);
                    //barcode_txt.Text = string.Empty;
                    return;
                }

                error_msg.Text = "OK!";
                 
                error_msg.ForeColor = Color.GreenYellow;
                    Flag = true;
                    serials.Add(new SnClass() { sn = barcode_txt.Text.Trim() });
                    LoadserialsDGV();
                    barcode_txt.SelectAll();
                    barcode_txt.Text = string.Empty;
                }
          
           
                Output_lbl.Text = "";
            //        if (bCCode(barcode_txt.Text) == false)
            //    {
            //        error_msg.Text = "条码格式有误，请重新输入!";
            //        barcode_txt.SelectAll();
            //        return;
            //    }
            //    else
            //    {
            //        if (serials.Where(s => s.sn == barcode_txt.Text.Trim()).Count() > 0)
            //        {
            //            error_msg.Text = "条码重复";
            //            do
            //            {
            //                DialogResult = MessageBox.Show("条码重复", "notice", MessageBoxButtons.RetryCancel);
            //            }
            //            while (DialogResult == DialogResult.Retry);
            //            barcode_txt.Text = string.Empty;
            //            return;
            //        }

            //        error_msg.Text = "OK2!";
            //        Font f = new Font("宋体",20);
            //        error_msg.Font =f;
            //        error_msg.ForeColor = Color.GreenYellow;
            //        Flag = true;
            //        serials.Add(new SnClass() { sn = barcode_txt.Text.Trim() });
            //        LoadserialsDGV();
            //        barcode_txt.SelectAll();
            //        barcode_txt.Text = string.Empty;
            //    }
            //}
            //else
            //{ 
            //    error_msg.Text = "";
            //}
            //Output_lbl.Text = "";
        }

        private void Main_Resize(object sender,EventArgs e)
        {
            FormResizeEvent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if( m.Msg== 0x112)
            {
                if(m.WParam.ToInt32()== 0xF030)
                {
                    FormResizeEvent();
                }
            }
            if(m.Msg== WM_NCLBUTTONDBLCLK)
            {
                FormResizeEvent();
            }
        }

        private void FormResizeEvent()
        {
            Size s = this.Size;
            s.Height -= 250;
            s.Width -= 35;
            //panel1.Height = s.Height;
            //panel1.Width = s.Width-155;
            //panel1.Height = s.Height;
            //GetNgCode(line_cbx.Text, process_cbx.SelectedItem.ToString());
            ReFixNgCode2();
        }

        private void UpLoadData()
        {
            //检查barcode是否已经检查
            if (Flag == false)
            {
                error_msg.Text = "SN List 是空，不能做上传操作!";
                error_msg.ForeColor = Color.Red;
                barcode_txt.SelectAll();
                return;
            }
            //检查是否有选中的NG CODE项
            string ngCode = sNgCode();
            if (ngCode == null)
            {
                error_msg.Text = "请选择不良原因!";
                error_msg.ForeColor = Color.Red;
                panel1.Select();
                return;
            }
            CsvFile csvFile = new CsvFile();
            List<CsvFile> csvs = new List<CsvFile>();
            string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (SnClass s in serials)
            {

                CsvFile csv = new CsvFile();
                #region
                csv.Model = System.Configuration.ConfigurationManager.AppSettings["Model"];//原来固定"KK07";
                csv.Site = "NSTD";

                string fPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Setting.xml";
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(fPath);
                XmlNode nod = xDoc.SelectSingleNode("root");

                XmlNode xNode = nod.SelectSingleNode("factory");
                string factory = xNode.Attributes["value"].Value;

                csv.Factory = factory;
                //csv.Factory = "E-1";
                csv.Line = line_cbx.SelectedItem.ToString();
                csv.Process = process_cbx.SelectedItem.ToString();
                csv.Module = s.sn;
                csv.Module2 = "";
                csv.x2 = "";
                DateTime t1 = DateTime.Now;
                
                //csv.Day = int.Parse(t1.Day.ToString());
                //csv.Hour = int.Parse(t1.Hour.ToString());
                //csv.Minute = int.Parse(t1.Minute.ToString());
                //csv.Second = int.Parse(t1.Second.ToString());

                // modify date 20180615 by fyh
                string cmbDate = cmbx_date.SelectedItem.ToString();
                string cmbTime = cmbx_time.SelectedItem.ToString();
                string[] timeArr = cmbTime.Split(':');
                if (cmbDate == "现在")
                {
                    csv.Year = int.Parse(t1.Year.ToString().Substring(2, 2));
                    csv.Month = int.Parse(t1.Month.ToString());
                    csv.Day = int.Parse(t1.Day.ToString());
                    csv.Hour = int.Parse(t1.Hour.ToString());
                    csv.Minute = int.Parse(t1.Minute.ToString());
                    csv.Second = int.Parse(t1.Second.ToString());
                }
                else if (cmbDate == "昨天")
                {
                    csv.Year = int.Parse(t1.AddDays(-1).Year.ToString().Substring(2, 2));
                    csv.Month = int.Parse(t1.AddDays(-1).Month.ToString());
                    csv.Day = int.Parse(t1.AddDays(-1).Day.ToString());
                    csv.Hour = int.Parse(timeArr[0].ToString());
                    csv.Minute = int.Parse(timeArr[1].ToString());
                    csv.Second = int.Parse(timeArr[2].ToString());
                }
                else if (cmbDate == "今天")
                {
                    csv.Year = int.Parse(t1.Year.ToString().Substring(2, 2));
                    csv.Month = int.Parse(t1.Month.ToString());
                    csv.Day = int.Parse(t1.Day.ToString());
                    csv.Hour = int.Parse(timeArr[0].ToString());
                    csv.Minute = int.Parse(timeArr[1].ToString());
                    csv.Second = int.Parse(timeArr[2].ToString());
                }


                csv.Faci_num = 1;
                //csv.Faci = "PLC";
                csv.Faci = ngCode;
                csv.faci_value = 0;
                csv.Item_result = 1;
                csv.All_result = 1;
                csv.Item_num = 1;
                //csv.Op_user = _user.user;
                csv.Op_type = "OPERATOR";
                csv.Op_value = this.user;
                csvs.Add(csv);
                #endregion
            }
            if(!csvFile.OutPutCsvLot(path,csvs))
            {
               
                error_msg.Text = "提交失败，请重新刷入并提交！";
                error_msg.ForeColor = Color.Red;
                return;
            }
            
            error_msg.Text = "Output " + csvFile.Filename + " completed.";
            error_msg.ForeColor = Color.GreenYellow;
            Flag = false;
            //error_msg.Text = "";
            /*
            panel1.Click -= new EventHandler(panel1_Click);
            foreach (RadioButton rad in panel1.Controls)
            {
                rad.Checked = false;
            }
            panel1.Click += new EventHandler(panel1_Click);
            */
            barcode_txt.Text = "";
            barcode_txt.SelectAll();
            barcode_txt.Focus();
            //后台ftp上传线程启动
            //ftpUpLoad();
        }

        /// <summary>
        /// 组别改变时，显示该组别的ng code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assy_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNgCode2(line_cbx.SelectedItem.ToString(), process_cbx.SelectedItem.ToString());
        }

        private void LoadserialsDGV()
        {
            var source = new BindingSource();
            source.DataSource = serials;
            serialsDGV.DataSource = source;
            qtyLbl.Text = serials.Count.ToString();
            serialsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            serialsDGV.ClearSelection();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            serials = new List<SnClass>();
            
            LoadserialsDGV();
            if(error_msg.Text == "OK!")
            {
                error_msg.Text = "";
            }
        }

        private void sn_change(object sender, EventArgs e)
        {
    
            //检查barcode是否合法
            string sn = barcode_txt.Text;
            string cmbxType = cmbx_type.SelectedItem.ToString();
            if (sn == "")
            {
                error_msg.Text = "";
                return;
            }
            if (sn.Substring(0, 1) == "F" || sn.Substring(0, 1) == "G")
            {
                error_msg.Text = "";
            }
            else
            {
                error_msg.Text = "";
                error_msg.Text = "条形码格式不正确，首字母为G,F开头!";
                error_msg.ForeColor = Color.Red;
                //barcode_txt.SelectAll();
                return;
            }
            if (cmbxType == "17")
            {
                if (barcode_txt.Text.Length != 17)
                {
                    error_msg.Text = "";
                    error_msg.Text = "输入的SN与SN位数不匹配!";
                    error_msg.ForeColor = Color.Red;
                    //barcode_txt.SelectAll();
                    return;
                }
                else {
                    error_msg.Text = "";
                }


            }
            else if (cmbxType == "24")
            {
                if (barcode_txt.Text.Length != 24)
                {
                    error_msg.Text = "";
                    error_msg.Text = "输入的SN与SN位数不匹配!";
                    error_msg.ForeColor = Color.Red;
                    //barcode_txt.SelectAll();
                    return;
                }
                else
                {

                    error_msg.Text = "";
                }
            }
            else
            {

                error_msg.Text = "";
            }


            if (serials.Where(s => s.sn == barcode_txt.Text.Trim()).Count() > 0)
            {
                error_msg.Text = "";
                error_msg.Text = "条码重复";
                error_msg.ForeColor = Color.Red;
                //do
                //{
                //    DialogResult = MessageBox.Show("条码重复", "notice", MessageBoxButtons.RetryCancel);
                //}
                //while (DialogResult == DialogResult.Retry);
                //barcode_txt.Text = string.Empty;
                return;
            }
        }

        private void dateChange(object sender, EventArgs e)
        {
            string date = cmbx_date.SelectedItem.ToString();
            if (date == "现在")
            {
                cmbx_time.Enabled = false;
            }
            else {
                cmbx_time.Enabled = true;
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadBtn_click(object sender, EventArgs e)
        {
            //RadioButton rad = (RadioButton)sender;
            //radNum = rad.Text;
            Register_btn.Select();
            UpLoadData();
            serials = new List<SnClass>();
            LoadserialsDGV();
        }

        private void processDetail_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            process_cbx.SelectedIndex = processDetail_cbx.SelectedIndex;
        }
    }

    public class SnClass
    {
        public string sn { get; set; }
    }
}
