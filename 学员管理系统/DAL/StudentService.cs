using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 学生数据访问类
    /// </summary>
    public class StudentService
    {
        /// <summary>
        /// 判断身份证号是否存在
        /// </summary>
        /// <param name="stuIdNo"></param>
        /// <returns></returns>
        public bool IsIdExisted(string stuIdNo)
        {
            string sql = string.Format("select count(*) from Students where StudentIdNo={0}", stuIdNo);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1) 
                return true;
            else 
                return false;
        }
        /// <summary>
        /// 判断考勤卡号是否存在
        /// </summary>
        /// <param name="stuCardNo"></param>
        /// <returns></returns>
        public bool IsCardExisted(string stuCardNo)
        {
            string sql = string.Format("select count(*) from Students where CardNo='{0}'", stuCardNo);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1)
                return true;
            else
                return false;
        }
    }
}
