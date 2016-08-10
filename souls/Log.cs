using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Souls
{
    public class Log
    {
        public static bool NoTime = false;
        //输出日志
        public static void ErrorLog(string str)
        {
            string logStr = "";

            if (NoTime)
            {
                logStr = str;
            }
            else
            {
                logStr = DateTime.Now.ToString() + "  " + str;
            }


            FileStream fs = new FileStream("err.log", FileMode.Append, FileAccess.Write);
            StreamWriter sm = new StreamWriter(fs);
            sm.WriteLine(logStr);
            sm.Close();
            fs.Close();
        }
    }
}
