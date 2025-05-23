﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

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

        /// <summary>
        /// 保存学员对象到数据库
        /// </summary>
        /// <param name="stu"></param>
        /// <returns>返回新学员ID学号</returns>
        public int AddStudent(Student stu)
        {
            StringBuilder sqlBuilder = new StringBuilder("insert into Students ");
            sqlBuilder.Append("(StudentName, Birthday, Gender, StudentIdNo, Age, PhoneNumber, StudentAddress, CardNo, ClassId, StuImage) ");
            sqlBuilder.Append("values('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', {8}, '{9}');select @@identity");
            string sql = string.Format(sqlBuilder.ToString(), stu.StudentName, stu.Birthday.ToString("yyyy-MM-dd"), stu.Gender, stu.StudentIdNo,
                            stu.Age, stu.PhoneNumber, stu.StudentAddress, stu.CardNo, stu.ClassId, stu.StuImage);
            try
            {
                return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            }
            catch (Exception ex)
            {

                throw new Exception("添加学员时发生数据库异常：" + ex.Message);
            }
        }

        public List<Student> GetStudent(int classId, string classname)
        {
            string sql = string.Format("select StudentId, StudentName, Gender, Birthday, StudentIdNo, PhoneNumber " +
                "from Students where ClassId = {0}", classId);
            List<Student> list = new List<Student>();
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                while (objReader.Read())
                {
                    list.Add(new Student()
                    {
                        StudentId = Convert.ToInt32(objReader["StudentId"]),
                        StudentName = objReader["StudentName"].ToString(),
                        Gender = objReader["Gender"].ToString(),
                        Birthday = Convert.ToDateTime(objReader["Birthday"]),
                        StudentIdNo = objReader["StudentIdNo"].ToString(),
                        PhoneNumber = objReader["PhoneNumber"].ToString(),
                        ClassName = classname
                    }); ;
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
