using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Excel_ClassLibrary1
{
    public class Class1
    {
        /// <summary>
        /// 查询数据库中的数据
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="path">数据库路径</param>
        /// <returns></returns>
        public static DataTable GetDAtatable(string sql, string path)
        {
            string sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + ";" + "Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'";
           
            using ( OleDbConnection ole_cnn = new OleDbConnection(sConnectionString))
            {
                ole_cnn.Open();
                using ( OleDbCommand ole_cmd=ole_cnn.CreateCommand())
                {
                    ole_cmd.CommandText = sql;
                    using (OleDbDataAdapter dapter=new OleDbDataAdapter(ole_cmd))
                    {
                        DataSet dr = new DataSet();
                        dapter.Fill(dr);
                        return dr.Tables[0];
                    }
                }
            }
        }

        /// <summary>
        /// 查询数据库中的数据
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="path">数据库路径</param>
        /// <returns></returns>
        public static DataTable Get(string sql, string path)
        {
            string sConnectionString = "Provider=Microsoft.ACE.OLED.12.0," + "Data Source=" + path + ";" + "Extended ProPerties='Excel 8.0;HDR=Yes;IMEX=0'";
            using (OleDbDataAdapter oda=new OleDbDataAdapter(sql,sConnectionString))
            {
                DataSet dr = new DataSet();
                oda.Fill(dr);
                return dr.Tables[0];
            }
        }

        /// <summary>
        /// 增删改数据库中的语句
        /// </summary>
        /// <param name="sql">增删改语句</param>
        /// <param name="path">数据库路径</param>
        /// <returns></returns>
        public static int SetDAtatable(string sql, string path)
        {
            //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\\fruit.mdb
                                      //Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + filepath + ";" + "Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'
            string sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + ";" + "Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'";
            //Provider=                          Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + ";" + "Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'
            using (OleDbConnection ole_cnn = new OleDbConnection(sConnectionString))
            {
                ole_cnn.Open();
                int c = -1;
                using (OleDbCommand ole_cmd = ole_cnn.CreateCommand())
                {
                    try
                    {
                        ole_cmd.CommandText = sql;
                        c = ole_cmd.ExecuteNonQuery();
                        return c;
                    }
                    catch { return c; }
                }
            }
        }

    }
}
