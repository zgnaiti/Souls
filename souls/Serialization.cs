using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Souls
{
    public class Serialization
    {
        #region 序列化
        /// <summary>
        /// 序列化为byte[]
        /// </summary>
        /// <param name="tempdouble"></param>
        /// <returns></returns>
        public static byte[] SerializeObject(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, obj);
            //byte[] mybytetemp = streamtemp.GetBuffer();
            //return mybytetemp;
            return stream.ToArray();
        }
        #endregion

        #region 反序列化
        /// <summary>
        /// 反序列化为MyBlockTable
        /// </summary>
        /// <param name="tempbyte"></param>
        /// <returns></returns>
        public static object DeserialzeObject(byte[] tempbyte)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream streamtemp = new MemoryStream(tempbyte);
            return bf.Deserialize(streamtemp);
        }
        #endregion 
    }
}
