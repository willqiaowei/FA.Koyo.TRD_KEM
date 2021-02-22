using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA.Koyo.TRD_KEM
{
    public class MySqlConnectionHelp
    {

        /// <summary>
        /// 建立mysql数据库链接
        /// </summary>
        /// <returns></returns>
        public  MySqlConnection GetMySqlCon()
        {
            try
            {
                string mysqlStr = "Database=trdkem_db;Data Source=127.0.0.1;User Id=root;Password=kew123456;pooling=false;CharSet=utf8;port=3306";
                MySqlConnection conn = new MySqlConnection(mysqlStr);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                Common.AlarmRecord("数据库", ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }
           
        }


        /// <summary>
        /// 创建一个DataSet对象
        /// </summary>
        /// <param name="sqlStr">SQL语句</param>
        /// <param name="tableName">表名</param>
        /// <returns>返回DataSet对象</returns>
        public DataSet GetDataSet(MySqlCommand mySqlCommand)
        {
            try
            {
                MySqlDataAdapter SQLda = new MySqlDataAdapter(mySqlCommand);  //创建一个SqlDataAdapter对象，并获取指定数据表的信息
                DataSet myDataSet = new DataSet(); //创建DataSet对象
                SQLda.Fill(myDataSet);  //通过MySqlDataAdapter对象的Fill()方法，将数据表信息添加到DataSet对象中
                return myDataSet;  //返回DataSet对象的信息
            }
            catch (Exception ex)
            {
                Common.AlarmRecord("数据库", ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        /// <summary>
        /// 关闭数据库
        /// </summary>
        public void CloseConn(MySqlConnection mySqlConnection)
        {
            try
            {
                if (mySqlConnection.State == ConnectionState.Open)   //判断是否打开与数据库的连接
                {
                    mySqlConnection.Close();   //关闭数据库的连接
                    mySqlConnection.Dispose();   //释放My_con变量的所有空间
                }
            }
            catch (Exception ex)
            {
                Common.AlarmRecord("数据库", ex.Message);
                MessageBox.Show(ex.Message);
            }

        }
    }
}
