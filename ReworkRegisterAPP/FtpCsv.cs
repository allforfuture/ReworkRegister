using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ReworkRegisterAPP
{
    public class FtpCsv
    {
        Timer ftpTimer = new Timer();

        string ftpIp;
        string ftpPath;
        string ftpUser;
        string ftpPW;
        string fromPath;
        public bool Flag = false;

        public FtpCsv(string[] ftpArray,string FormPath)
        {
            ftpIp = ftpArray[0];
            ftpPath = ftpArray[0];
            ftpUser = ftpArray[1];
            ftpPW = ftpArray[2];
            fromPath = FormPath;
        }

        public void UpLoad()
        {
            if (ftpIp == null|| ftpIp == "" || fromPath == "" || fromPath==null) return;
            if (!ConnectState(ftpIp, ftpPath, ftpUser, ftpPW)) return;

            ftpTimer.Interval = 30000;
            ftpTimer.Elapsed += FtpTimer_Elapsed;
            ftpTimer.Start();
        }

        private void FtpTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(fromPath);
            if (!dirInfo.Exists)
            {
                ftpTimer.Stop();
                ftpTimer.Dispose();
                return;
            }
            else
            {
                FileInfo[] fileInfos = dirInfo.GetFiles();
                foreach (FileInfo file1 in fileInfos)
                {
                    if (file1.CreationTime <= DateTime.Now.AddSeconds(5))
                    {
                        //将文件复制到ftp目录内
                        try
                        {
                            file1.CopyTo(ftpPath + file1.Name);
                            Flag = true;
                        }
                        catch
                        {
                            Flag = false;
                        }
                    }
                }
                ftpTimer.Stop();
                ftpTimer.Dispose();
            }
        }

        /// <summary>
        /// 判断是否连线成功
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="username">用户名</param>
        /// <param name="passwork">密码</param>
        /// <returns></returns>
        private bool ConnectState(string ftpIp, string path, string username, string password)
        {

            bool Flag = false;

            //use sharedtool class connect ftp server
            ShareTool tool = new ShareTool(username, password, ftpIp);
            if (tool.isExists == true)
            {
                Flag = true;
            }
            return Flag;
        }
    }
}
