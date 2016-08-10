using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Souls
{
    public class File
    {
        //将字节流转为文件
        public static void WriteBinaryToFile(byte[] by, string strPath)
        {
            FileStream fs = new FileStream(strPath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(by);
            bw.Close();
            fs.Close();
        }

        //将文件转换成字节流
        public static byte[] ReadBinaryFormFile(string strPath)
        {
            FileStream fs = new FileStream(strPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            byte[] by = new byte[fs.Length];
            fs.Read(by, 0, by.Length);
            fs.Close();
            return by;
        }

        //判断文件是否超过指定大小
        public static bool IsFileTooLarge(string filePath, int largeSize)
        {
            FileInfo f = new FileInfo(filePath);
            double size = (f.Length / (1024 * 1024));
            return size > largeSize;
        }

        //获取文件的MD5值
        public static string GetMD5HashFromFile(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
            }
        }
    }
}
