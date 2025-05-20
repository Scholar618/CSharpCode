using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 学生班级数据访问类
    /// </summary>
    public class StudentClassService
    {
        /// <summary>
        /// 查询所有班级名称
        /// </summary>
        /// <returns></returns>
        public List<StudentClass> GetStudentClasses()
        {
            string sql = "select ClassName, ClassId from StudentClass";
            List<StudentClass> list = new List<StudentClass>();
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                while (objReader.Read())
                {
                    list.Add(new StudentClass()
                    {
                        ClassId = Convert.ToInt32(objReader["ClassId"]),
                        ClassName = objReader["ClassName"].ToString()
                    });
                }
                objReader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("应用程序和数据库连接出现问题：" + ex.Message);
            }
            return list;
        }
    }
}
