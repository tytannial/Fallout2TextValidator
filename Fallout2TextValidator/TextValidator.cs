using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fallout2TextValidator
{

    class TextValidator
    {
        string token;

        public void ValidateFiles(string root, string[] files, string encoding, string token)
        {
            this.token = token;
            int totalrows = 0;
            int totalcount = 0;
            foreach (var file in files)
            {
                if (FrmMain.frmMain.ckbFullLog.Checked)
                {
                    WriteLog(string.Format("Check {0}", file), token);
                }
                int line = 0;
                int rows = 0;
                int count = 0;
                HashSet<string> lst = new HashSet<string>();
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(encoding)))
                    {
                        string text;
                        string text2 = string.Empty;
                        bool endline = true;
                        int block = 0;
                        while ((text = sr.ReadLine()) != null)
                        {
                            ++line;
                            if (text.Equals(string.Empty) || text[0].Equals('#'))
                            {
                                continue;
                            }

                            try
                            {
                                if (text[0].Equals('{') || !endline)
                                {
                                    block += (text.Length - text.Replace("}", "").Length) / "}".Length;
                                    text2 += text.Replace("\r\n", "");
                                    //WriteLog(text2, token);
                                    if (block == 3)
                                    {
                                        endline = true;
                                        count += (text2.Length - text2.Replace("}{", "").Length) / "}{".Length;
                                        Regex regex = new Regex(@"\{(.*?)\}");
                                        int p = lst.Count;
                                        string head = regex.Matches(text2.ToString())[0].Groups[1].ToString();
                                        lst.Add(head);
                                        if (lst.Count == p)
                                        {
                                            WriteLog(string.Format("Duplicate Line in head:{0}, Line:{1}.", head, line), token);
                                        }
                                        ++rows;
                                        block = 0;
                                        text2 = string.Empty;
                                        continue;
                                    }
                                    endline = false;
                                }
                            }
                            catch (Exception e)
                            {
                                continue;
                            }
                        }
                    }
                }
                totalrows += rows;
                totalcount += count;
                if (rows == count / 2 && rows == lst.Count)
                {
                    if (FrmMain.frmMain.ckbFullLog.Checked)
                    {
                        WriteLog(string.Format("validate complate. It has {1} text lines.", file, rows), token);
                    }
                }
                else
                {
                    string text = string.Format("There may be some problems in {0}. Block Check: {1}/{2}, the text count is {3}", file.Replace(root, string.Empty), rows, count / 2, lst.Count);
                    WriteLog(text, token);
                    FrmMain.frmMain.ListBoxError.Items.Add(text);
                }
            }
            WriteLog(string.Format("All files validate complate. Tatal rows:{0}, Actrally rows:{1}.", totalrows, totalcount / 2), token);
        }
        private void WriteLog(string text, string token)
        {
            //Console.WriteLine(text);
            LogHelper.Write(text, token);
        }
    }
}
