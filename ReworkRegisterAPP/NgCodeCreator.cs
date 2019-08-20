using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace ReworkRegisterAPP
{
    public class NgCodeCreator
    {
        protected Dictionary<string, NgType> m_NgList = new Dictionary<string, NgType>();
        public Dictionary<string, NgType> NgCodes
        {
            get { return m_NgList; }
        }

        protected string[] m_AssyList;
        public string[] AssayList
        {
            get { return m_AssyList; }
        }

        public bool LoadConfig(string config)
        {
            if (!File.Exists(config))
                return false;

            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(config);
                XmlNodeList nodList = xDoc.SelectSingleNode("NGCODE").ChildNodes;
                int n = 0;
                m_AssyList = new string[nodList.Count];
                foreach (XmlNode nod in nodList)
                {
                    NgType ngType = new NgType();
                    ngType.NgTypeName = nod.Name;
                    m_AssyList[n] = nod.Name;
                    XmlNodeList nodItems = nod.ChildNodes;
                    int i = 1;
                    foreach (XmlNode nodItem in nodItems)
                    {
                        NgCode ngCode = new NgCode();
                        ngCode.num = i;
                        ngCode.code = nodItem.Attributes["code"].Value;
                        ngCode.name = nodItem.Attributes["name"].Value;
                        ngType.m_Item.Add(ngCode);
                        i++;
                    }
                    n++;
                    m_NgList.Add(ngType.NgTypeName, ngType);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public NgType GetNgCodes(string ngType)
        {
            if (m_NgList.ContainsKey(ngType))
            {
                return m_NgList[ngType];
            }
            return null;
        }
    }
}
