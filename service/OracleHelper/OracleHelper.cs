using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace service
{
    public class OracleHelper
    {
        /// <summary>
        /// 创建oracle连接对象
        /// </summary>
        /// <returns></returns>
        public static OracleConnection CreateConn()
        {
          string connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
          OracleConnection oc = new OracleConnection(connectionstring);
          return oc;
        }
        /// <summary>
        /// 增、删、改操作
        /// </summary>
        /// <param name="text">oracle语句</param>
        /// <param name="pars">返回收影响的行数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string text,OracleParameter[] pars)
        {
            using (OracleConnection oc = CreateConn())
            {
                oc.Open();
                OracleCommand ocmd = new OracleCommand(text, oc);
                if (pars != null)
                {
                    ocmd.Parameters.AddRange(pars);
                }
                int count = ocmd.ExecuteNonQuery();
                return count;
            }
        }
        /// <summary>
        /// 单值查询
        /// </summary>
        /// <param name="Text">查询语句</param>
        /// <param name="pars">传递的值</param>
        /// <returns></returns>
        public static object Query(string Text, OracleParameter[] pars)
        {
            using (OracleConnection conn = CreateConn())
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(Text, conn);
                if (pars != null)
                {
                    cmd.Parameters.AddRange(pars);
                }
                object obj = cmd.ExecuteScalar();
                conn.Close();
                return obj;
            }
        }
        /// <summary>
        /// 多值查询:查询一行数据
        /// </summary>
        /// <param name="text">查询语句</param>
        /// <param name="pars">传递的值</param>
        /// <returns></returns>
        public static OracleDataReader QueryMore(string text, OracleParameter[] pars)
        {
            OracleConnection conn = CreateConn();
            conn.Open();
            OracleCommand cmd = new OracleCommand(text, conn);
            //判断pars是否为空
            if (pars != null)
            {
                cmd.Parameters.AddRange(pars);
            }
            OracleDataReader sdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return sdr;
        }
        /// <summary>
        /// 多值查询:返回表集合
        /// </summary>
        /// <param name="text">查询语句</param>
        /// <param name="pars">传递值</param>
        /// <returns></returns>
        public static System.Data.DataTable QueryMoreData(string text, OracleParameter[] pars)
        {
            using (OracleConnection conn = CreateConn())
            {
                OracleDataAdapter sda = new OracleDataAdapter(text, conn);
                if (pars != null)
                {
                    sda.SelectCommand.Parameters.AddRange(pars);
                }
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                return dt;
            }
        }

    }
}