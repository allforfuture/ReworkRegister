using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Xml;

namespace ReworkRegisterAPP
{
    public class UserInfo
    {
        static string encryptKey = "VavicApp";

        public string user { get; set; }
        public string password {get;set;}
        public string role { get; set; }

        public bool AddUser(string user,string pw)
        {
            return false;
        }

        public bool ModifyUser(string user,string pw)
        {
            return false;
        }
        /// <summary>
        /// 对字符串进行加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Encrypt(string str)
        {
            if (str == "" || str == null) return "";
            //实例化一个DESCryptoServiceProvider对象
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();
            //定义一个字节数组储存加密key code
            byte[] key = Encoding.Unicode.GetBytes(encryptKey);
            //定义一个字节数组储存字符串
            byte[] data = Encoding.Unicode.GetBytes(str);

            //实例化一个内存流对象
            MemoryStream MStream = new MemoryStream();
            //使用内存流实例化一个加密流对象（加密desc.createEncrypt)
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateEncryptor(key, key), CryptoStreamMode.Write);
            CStream.Write(data, 0, data.Length);
            //用缓冲区的当前信息更新储存后，消除缓冲区
            CStream.FlushFinalBlock();
            //返回加密后的字符串
            return Convert.ToBase64String(MStream.ToArray());
        }

        /// <summary>
        /// 对加密字符串进行解密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Decrypt(string str)
        {
            if (str == "" || str == null) return "";
            //实例化DESCrytoServiceProvider对象
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();
            //定义key的字节数组
            byte[] key = Encoding.Unicode.GetBytes(encryptKey);
            byte[] data = Convert.FromBase64String(str);
            MemoryStream MStream = new MemoryStream();
            //使用内存流实例化一个加密流对象（解密desc.createDecrypt)
            CryptoStream CStream = new CryptoStream(MStream,descsp.CreateDecryptor(key,key),CryptoStreamMode.Write);
            CStream.Write(data, 0, data.Length);
            
            CStream.FlushFinalBlock();
            return Encoding.Unicode.GetString(MStream.ToArray());
            
        }

        public string encode(string str)
        {
            string htext = "";

            for (int i = 0; i < str.Length; i++)
            {
                htext = htext + (char)(str[i] + 10 - 1 * 2);
            }
            return htext;
        }

        public string decode(string str)
        {
            string dtext = "";

            for (int i = 0; i < str.Length; i++)
            {
                dtext = dtext + (char)(str[i] - 10 + 1 * 2);
            }
            return dtext;
        }
    }
}
