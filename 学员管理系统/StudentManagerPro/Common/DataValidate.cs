using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentManagerPro.Common
{
    class DataValidate
    {
        /// <summary>
        /// 验证身份证
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsIdentityCard(string txt)
        {
            Regex regex = new Regex(@"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
            return regex.IsMatch(txt);
        }
    }
}
