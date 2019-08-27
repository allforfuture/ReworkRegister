using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

//using System.Configuration;

namespace ReworkRegisterAPP
{
    public class GetDataFromXml
    {

        /// <summary>
        /// 取用户的配置信息
        /// </summary>
        /// <param name="path">UserInfo.xml的路径</param>
        /// <param name="users">UserInfo类的引用地址</param>
        public void CGetData(string path,ref List<UserInfo> users)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlNode xNod = xDoc.SelectSingleNode("userinfo");
            foreach(XmlNode n in xNod.ChildNodes)
            {
                UserInfo u = new UserInfo();
                u.user = n.Attributes["user"].Value;
                u.password =u.decode(n.Attributes["password"].Value);
                u.role = n.Attributes["role"].Value;
                users.Add(u);
            }
        }

        public bool AddUser(string path,UserInfo user)
        {
            try
            { 
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path);
                XmlNode xNod = xDoc.SelectSingleNode("userinfo");
                XmlElement newEle = xDoc.CreateElement("item");
                newEle.SetAttribute("user",user.user);
                newEle.SetAttribute("password", user.encode(user.password));
                newEle.SetAttribute("role", user.role);
                xNod.AppendChild(newEle);
                xDoc.Save(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ModifyUser(string path,string pw,UserInfo u)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path);
                XmlNode xNod = xDoc.SelectSingleNode("userinfo");
                foreach (XmlNode n in xNod.ChildNodes)
                {
                    if (u.user == n.Attributes["user"].Value)
                    {
                        XmlElement xlm = (XmlElement)n;
                        xlm.SetAttribute("password", u.encode(pw));
                    }
                }
                xDoc.Save(path);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        /// <summary>
        /// 取Setting.xml的配置信息
        /// </summary>
        /// <param name="path">Setting.xml路径</param>
        /// <param name="strArray">数组的引用地址</param>
        /// <param name="type">取Setting.xml的哪类信息</param>
        public string[] iniGetData(string path,string type)
        {
            string[] strArray;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlNode nod = xDoc.SelectSingleNode("root");
            #region
            switch (type)
            {

                case "line":
                    //XmlNode xNode = nod.SelectSingleNode("line");
                    //strArray = xNode.Attributes["value"].Value.Split(',');
                    //string fNum = ((XmlElement)xNode).Attributes["display"].Value;
                    //strArray = Ssort(fNum, strArray);

                    //更新NgCodeSetting.xml是要和Setting.xml配对的，所以两个要一起更新节点
                    //而更新Setting.xml时，要保留下拉框显示线别不变的话，将它写在其他位置，不然会被更新覆盖                    
                    strArray = System.Configuration.ConfigurationManager.AppSettings["ComboBox_line"].Split(',');
                    string fNum = System.Configuration.ConfigurationManager.AppSettings["ComboBox_lineDisplay"];
                    strArray = Ssort(fNum, strArray);
                    break;
                case "process":
                    XmlNode xNode = nod.SelectSingleNode("process");
                    strArray = xNode.Attributes["value"].Value.Split(',');
                    fNum = xNode.Attributes["display"].Value;
                    strArray = Ssort(fNum, strArray);
                    break;
                case "processDetail":
                    xNode = nod.SelectSingleNode("processDetail");
                    strArray = xNode.Attributes["value"].Value.Split(',');
                    //fNum = xNode.Attributes["display"].Value;
                    //strArray = Ssort(fNum, strArray);
                    break;
                case "time":
                    xNode = nod.SelectSingleNode("time");
                    strArray = xNode.Attributes["value"].Value.Split(',');
                    fNum = xNode.Attributes["display"].Value;
                    strArray = Ssort(fNum, strArray);
                    break;
                case "date":
                    xNode = nod.SelectSingleNode("date");
                    strArray = xNode.Attributes["value"].Value.Split(',');
                    fNum = xNode.Attributes["display"].Value;
                    strArray = Ssort(fNum, strArray);
                    break;
                case "filepath":
                    xNode = nod.SelectSingleNode("filepath");
                    strArray = new string[1];
                    strArray[0] = xNode.Attributes["path"].Value;
                    break;
                case "ftp":
                    xNode = nod.SelectSingleNode("ftp");
                    strArray = new string[4];
                    strArray[0] = xNode.Attributes["ip"].Value;
                    strArray[1] = xNode.Attributes["user"].Value;
                    strArray[2] = xNode.Attributes["password"].Value;
                    strArray[3] = xNode.Attributes["status"].Value;
                    break;
                case "validation":
                    xNode = nod.SelectSingleNode("validation");
                    strArray = new string[3];
                    strArray[0] = xNode.Attributes["char"].Value;
                    strArray[1] = xNode.Attributes["length"].Value;
                    strArray[2] = xNode.Attributes["substring"].Value;
                    break;
                default:
                    strArray = null;
                    break;
            }
            
            #endregion
            return strArray;
        }
        
        /// <summary>
        /// 使用泛型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public T CGetData<T>(string path,T num)
        {
            T obj = default(T);
            Type type = num.GetType();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlNode nod= xDoc.SelectSingleNode("userinfo");
            XmlNodeList nodes = nod.ChildNodes;
            foreach(XmlNode n in nodes)
            {
                //num = "aa";
            }
            
            return obj;
        }

        /// <summary>
        /// 对数组进行排序，将fNum放在第一位
        /// </summary>
        /// <param name="fNum"></param>
        /// <param name="tmp"></param>
        /// <returns></returns>
        private string[] Ssort(string fNum,string[] tmp)
        {
            for(int i=0;i<tmp.Length;i++)
            {
                //找到fNum后，与第一位的进行互换
                if (tmp[i] == fNum)
                {
                    string a = tmp[0];
                    tmp[0] = tmp[i];
                    tmp[i] = a;
                }
            }
            return tmp;
        }

    }
}
