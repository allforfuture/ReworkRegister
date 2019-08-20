using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReworkRegisterAPP
{
    public class CsvFile
    {
        GetDataFromXml getDataFromXml = new GetDataFromXml();
        public string Filename { get; set; }
        #region 实体属性名
        public string Model { get; set; }
        public string Site { get; set; }
        public string Factory { get; set; }
        public String Line { get; set; }
        public string Process { get; set; }
        public string Module { get; set; }
        public string Module2 { get; set; }
        public string x2 { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public int Faci_num { get; set; }
        public string Faci { get; set; }
        public int faci_value { get; set; }
        public int Item_result { get; set; }
        public int All_result { get; set; }
        public int Item_num { get; set; }
        public string Op_type { get; set; }
        public string Op_value { get; set; }
        #endregion

        /// <summary>
        /// 将数据导出csv文档
        /// </summary>
        public void OutPutCsv(string fPath)
        {
            string[] F_path=getDataFromXml.iniGetData(fPath + "\\Setting.xml", "filepath");
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(F_path[0]);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                string filename = Model+ Site+"-"+ Line+ Process+"-"+ Module.Substring(Module.Length-3,3) + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
                if (!File.Exists(F_path + filename))
                {
                    /*
                    FileStream fs = File.Create(F_path[0] + filename);
                    fs.Close();
                    TextWriter strw = new StreamWriter(F_path[0] + filename);
                    string str = Model + "," + Site + "," + Factory + "," + Line + "," + Process + "," +
                            Module + "," + Module2 + "," + x2 + "," + Year + "," + Month + "," + Day + "," + Hour + "," + Minute + "," +
                            Second + "," + Faci_num + "," + Faci + "," + faci_value + "," + Item_result + "," + All_result + "," + Item_num + "," + Op_type + "," + Op_value;
                    strw.WriteLine(str);
                    */
                    
                    using (FileStream fs = File.Create(F_path[0] + filename))
                    {
                        fs.Lock(0, fs.Length);
                        string str = Model + "," + Site + "," + Factory + ","+ Line+"," + Process + "," +
                            Module + "," + Module2 + "," + x2 + "," + Year + "," + Month + "," + Day + "," + Hour + "," + Minute + "," +
                            Second + "," + Faci_num + "," + Faci + "," + faci_value + "," + Item_result + "," + All_result + "," + Item_num + ","+ Op_type +","+ Op_value;
                        StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                        sw.Write(str);
                        fs.Unlock(0, fs.Length);
                        sw.Flush();
                    }
                    
                    this.Filename = filename;
                }
                System.Windows.Forms.MessageBox.Show("成功提交!");
            }
            catch(Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show("数据有误，请检查!");
            }
        }

        /// <summary>
        /// 将数据导出csv文档
        /// </summary>
        public bool OutPutCsvLot(string fPath,List<CsvFile> files)
        {
            string[] F_path = getDataFromXml.iniGetData(fPath + "\\Setting.xml", "filepath");
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(F_path[0]);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                string filename = files[0].Model + files[0].Site + "-" + files[0].Line + files[0].Process + "-" + files[0].Module.Substring(files[0].Module.Length - 3, 3) + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
                if (!File.Exists(F_path + filename))
                {
                    /*
                    FileStream fs = File.Create(F_path[0] + filename);
                    fs.Close();
                    TextWriter strw = new StreamWriter(F_path[0] + filename);
                    string str = Model + "," + Site + "," + Factory + "," + Line + "," + Process + "," +
                            Module + "," + Module2 + "," + x2 + "," + Year + "," + Month + "," + Day + "," + Hour + "," + Minute + "," +
                            Second + "," + Faci_num + "," + Faci + "," + faci_value + "," + Item_result + "," + All_result + "," + Item_num + "," + Op_type + "," + Op_value;
                    strw.WriteLine(str);
                    */

                    using (FileStream fs = new FileStream(F_path[0] + filename, FileMode.Append, FileAccess.Write))
                    {
                        string str = string.Empty;
                        using (StreamWriter sw = new StreamWriter(fs,Encoding.Default))
                        {
                            foreach (CsvFile c in files)
                            {
                                str = str + c.Model + "," + c.Site + "," + c.Factory + "," + c.Line + "," + c.Process + "," +
                                    c.Module + "," + c.Module2 + "," + c.x2 + "," + c.Year + "," + c.Month + "," + c.Day + "," + c.Hour + "," + c.Minute + "," +
                                    c.Second + "," + c.Faci_num + "," + c.Faci + "," + c.faci_value + "," + c.Item_result + "," + c.All_result + "," + c.Item_num + "," + c.Op_type + "," + c.Op_value + "\r\n";

                            }

                            sw.Write(str);
                            sw.Flush();
                        }
                    }

                    this.Filename = filename;
                }
                return true;
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
