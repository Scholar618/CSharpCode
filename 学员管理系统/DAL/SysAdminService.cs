using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace DAL
{
    /// <summary>
    /// 管理员数据访问类
    /// </summary>
    public class SysAdminService
    {
        /// <summary>
        /// 根据账号和密码登录
        /// </summary>
        /// <param name="objAdmin">包含账号和密码的管理员对象</param>
        /// <returns>SysAdmin</returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            // 1、执行sql语句
            // 2、调用数据通用访问类SQLHelper
            // 3、返回值
            string sql = "select AdminName from Admins where LoginId = {0} and LoginPwd = '{1}'";
            sql = string.Format(sql, objAdmin.LoginId, objAdmin.LoginPwd);
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                if (objReader.Read())
                {
                    objAdmin.AdminName = objReader["AdminName"].ToString();
                }
                else
                {
                    objAdmin = null;
                }
                objReader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("应用程序和数据库连接出现问题：" + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objAdmin;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="objAdmin"></param>
        public int ModifyPwd(SysAdmin objAdmin)
        {
            string sql = "update Admins set LoginPwd = '{0}' where LoginId = {1}";
            sql = string.Format(sql, objAdmin.LoginPwd, objAdmin.LoginId);
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("修改密码出现数据访问错误：" + ex.Message);
            }
        }
    }
}
