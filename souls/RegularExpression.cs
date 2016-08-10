using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Souls
{
    public class RegularExpression
    {
        //检查是否为浮点型数据
        public static bool IsDouble(string txt)
        {
            Regex rg = new Regex(@"^[-]?[0-9]+([.]{1}[0-9]+){0,1}$");
            return rg.IsMatch(txt);
        }

        //是否为正浮点型数据
        public static bool IsPositiveDouble(string txt)
        {
            Regex rg = new Regex(@"^?[0-9]+([.]{1}[0-9]+){0,1}$");
            return rg.IsMatch(txt);
        }

        //简单的Email地址格式判断
        public static bool IsEmail(string txt)
        {
            string emailStr =
                            @"([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,5})+";
            Regex rg = new Regex(emailStr);
            bool result = rg.IsMatch(txt);
            return result;
        }

        //检查是否为正整数
        public static bool IsPositiveInt(string txt)
        {
            Regex rg = new Regex(@"^[1-9]\d*$");
            return rg.IsMatch(txt);
        }
    }
}
