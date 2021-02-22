
using EasyModbus;
using FA.Koyo.TRD_KEM.UI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA.Koyo.TRD_KEM
{
    public class Common
    {
        //public static ModbusClient PLC_ModbusClient;
        public static string  STLINK_EXE_Address = "ST-LINK_CLI.exe -c SWD UR ";

        public static void SetDataGridViewStyle(DataGridView dataGridView)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;
            //禁止自动生成列
            dataGridView.AutoGenerateColumns = false;
            //设置标题文本居中
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //设置单元格内容居中
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            // dataGridView.RowsDefaultCellStyle.BackColor = Color.Ivory;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            // dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Green;
            dataGridView.DefaultCellStyle.Font = new Font("微软雅黑", 8);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 9);
            dataGridView.RowHeadersDefaultCellStyle.Font = new Font("微软雅黑", 8, FontStyle.Bold);
        }
        public static DataTable GetCommandInfo()
        {
            try
            {
                DataTable DT_Temp = new DataTable();

                MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                string sql = "select * from tk_command";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                DT_Temp = mySqlConnectionHelp.GetDataSet(mySqlCommand).Tables[0];
                mySqlConnectionHelp.CloseConn(mySqlConnection);
                return DT_Temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public static DataTable GetAlreadyTempletSelect()
        {
            try
            {
                DataTable DT_Temp = new DataTable();

                MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                string sql = "select Templet_ID ,Templet_Name from sp_templet_info";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                DT_Temp = mySqlConnectionHelp.GetDataSet(mySqlCommand).Tables[0];
                mySqlConnectionHelp.CloseConn(mySqlConnection);
                return DT_Temp;
            }
            catch (Exception ex)
            {
                AlarmRecord("数据库", ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public static DataTable GetTempletInfoByTemplet_ID(int templet_ID)
        {
            try
            {
                DataTable DT_Temp = new DataTable();
                MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                string sql = "select * from sp_templet_info where Templet_ID = " + templet_ID;
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                DT_Temp = mySqlConnectionHelp.GetDataSet(mySqlCommand).Tables[0];
                mySqlConnectionHelp.CloseConn(mySqlConnection);
                return DT_Temp;
            }
            catch (Exception ex)
            {
                AlarmRecord("数据库", ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public static DataTable GetPaintPathPointsByTemplet_ID(int templet_ID)
        {
            try
            {
                DataTable DT_Temp = new DataTable();
                MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                string sql = "select * from sp_paint_path_points_info where Templet_ID = " + templet_ID;
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                DT_Temp = mySqlConnectionHelp.GetDataSet(mySqlCommand).Tables[0];
                mySqlConnectionHelp.CloseConn(mySqlConnection);
                return DT_Temp;
            }
            catch (Exception ex)
            {
                AlarmRecord("数据库", ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable GetPaintPathPositionByTemplet_ID(int templet_ID)
        {
            try
            {
                DataTable DT_Temp = new DataTable();
                MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                //string sql = "select * from sp_paint_path_position_info where Templet_ID = " + templet_ID + " ORDER BY  Start_Position_X DESC";
                string sql = "select * from sp_paint_path_position_info where Templet_ID = " + templet_ID ;

                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                DT_Temp = mySqlConnectionHelp.GetDataSet(mySqlCommand).Tables[0];
                mySqlConnectionHelp.CloseConn(mySqlConnection);
                return DT_Temp;
            }
            catch (Exception ex)
            {
                AlarmRecord("数据库", ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }
        }
       
        /// <summary>
        /// 绿灯动作
        /// </summary>
        /// <param name="startOrStop"></param>
        public static void GreenLEDAction(bool startOrStop)
        {
            if (startOrStop)
            {
                
            }
            else
            {
               
            }
        }
        /// <summary>
        /// 黄灯动作
        /// </summary>
        /// <param name="startOrStop"></param>
        public static void YellowLEDAction(bool startOrStop)
        {
            if (startOrStop)
            {
                
            }
            else
            {
                
            }
        }
        /// <summary>
        /// 红灯动作
        /// </summary>
        /// <param name="startOrStop"></param>
        public static void RedLEDAction(bool startOrStop)
        {
            if (startOrStop)
            {
               
            }
            else
            {
               
            }
        }
        /// <summary>
        /// 浸泡气缸动作
        /// </summary>
        /// <param name="inOrOut"></param>
        public static void SoakCylinderAction(bool inOrOut)
        {
            try
            {
                ModbusClient modbusClient = ModbusConnect();
                if (modbusClient != null)
                {
                    int start = 2050;  //浸泡气缸Q02--2050

                    modbusClient.WriteSingleCoil(start, inOrOut);
                    //关闭连接
                    modbusClient.Disconnect();
                }
         
            }
            catch (Exception)
            {

            }
           
        }

        /// <summary>
        /// 夹板气缸动作
        /// </summary>
        /// <param name="inOrOut"></param>
        public static void SplintCylinderAction(bool inOrOut)
        {
            try
            {
                ModbusClient modbusClient = ModbusConnect();
                if (modbusClient != null)
                {
                    int start = 2052;  //夹板气缸对应Q04--2052
                    modbusClient.WriteSingleCoil(start, inOrOut);
                    //关闭连接
                    modbusClient.Disconnect();
                }
             
            }
            catch (Exception)
            {

            }
            
        }
        /// <summary>
        /// 阻挡气缸动作
        /// </summary>
        /// <param name="inOrOut"></param>
        public static void StopCylinderAction(bool inOrOut)
        {
            try
            {
                ModbusClient modbusClient = ModbusConnect();
                if (modbusClient != null)
                {
                    int start = 2053;  //阻挡气缸对应Q05--2053
                    modbusClient.WriteSingleCoil(start, inOrOut);
                    //关闭连接
                    modbusClient.Disconnect();
                }

           
            }
            catch (Exception)
            {

            }
      
        }
        /// <summary>
        /// 流水线要板动作
        /// </summary>
        /// <param name="inOrOut"></param>
        public static void AssemblyLineAskAction(bool inOrOut)
        {
            try
            {
                ModbusClient modbusClient = ModbusConnect();
                if (modbusClient != null)
                {
                    int start = 2057;  //流水线要板信号对应Q11--2057

                    modbusClient.WriteSingleCoil(start, inOrOut);

                    //关闭连接
                    modbusClient.Disconnect();
                }
               
            }
            catch (Exception)
            {

                
            }
        
        }
        /// <summary>
        /// 流水线送板动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void AssemblyLineSendAction(bool inOrOut)
        {
            try
            {
                ModbusClient modbusClient = ModbusConnect();
                if (modbusClient != null)
                {
                    int start = 2058;  //流水线送板信号对应Q12--2058

                    modbusClient.WriteSingleCoil(start, inOrOut);
                    //关闭连接
                    modbusClient.Disconnect();
                }
            
            }
            catch (Exception)
            {

            }
         
        }
        /// <summary>
        /// 流水线动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Assembly_Line_Start(bool startOrStop)
        {
            try
            {
                ModbusClient modbusClient = ModbusConnect();
                if (modbusClient != null)
                {
                    int start = 2056;  //流水线启动信号对应Q10--2056

                    modbusClient.WriteSingleCoil(start, startOrStop);
                    //关闭连接
                    modbusClient.Disconnect();
                }
              
            }
            catch (Exception)
            {

            }
      
        }

       
        /// <summary>
        /// 连接PLC
        /// </summary>
        /// <returns></returns>
        public  static ModbusClient ModbusConnect()
        {
            try
            {
                string ip = MainForm.PLC_IP;
                ModbusClient modbusClient = new ModbusClient(ip, 502);
                modbusClient.Connect();

                if (modbusClient.Connected)
                {
                    return modbusClient;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void AlarmRecord( string alarmType, string alarmInfo)
        {
            try
            {
                MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                string sql;
                sql = "insert into sp_alarm_info(Alarm_Type,Alarm_Info,Alarm_Time,Alarm_Date)" +
                  " values( '" + alarmType + "' ,'" + alarmInfo + "' ,'" + DateTime.Now + "' ,'" + DateTime.Now.Date + "' )";

                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                int returnCode_Mysql = mySqlCommand.ExecuteNonQuery();//3.执行插入、删除、更改语句。执行成功返回受影响的数据的
                mySqlConnectionHelp.CloseConn(mySqlConnection);
                if (returnCode_Mysql <= 0)
                {
                    MessageBox.Show("报警信息保存失败");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        public static int CmdCommand(string cmd, string commands)
        {
            try
            {
                //创建一个进程
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;//是否使用操作系统shell启动
                process.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                process.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                process.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                process.StartInfo.CreateNoWindow = true;//不显示程序窗口
                process.Start();//启动程序

                string strCMD = cmd + commands;

                //向cmd窗口发送输入信息
                process.StandardInput.WriteLine(strCMD + "&exit");
                process.StandardInput.AutoFlush = true;
                             
                //等待程序执行完退出进程
                process.WaitForExit();    
                //获取进程的返回值
                int returnCode = process.ExitCode;
                //释放进程
                process.Close();

                return returnCode;             
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string SwitchReturnCode(int recode)
        {
            string returnCode = string.Empty;
            switch (recode)
            {
                case 1:
                    returnCode = "命令参数错误";
                    break;
                case 2:
                    returnCode = "连接问题";
                    break;
                case 3:
                    returnCode = "命令对连接的目标不可用";
                    break;
                case 4:
                    returnCode = "向指定的内存地址写入数据时发生错误";
                    break;
                case 5:
                    returnCode = "无法从指定的内存地址读取内存";
                    break;
                case 6:
                    returnCode = "无法复位";
                    break;
                case 7:
                    returnCode = "运行应用程序失败";
                    break;
                case 8:
                    returnCode = "未能停止内核";
                    break;
                case 9:
                    returnCode = "未能执行单个指令步骤";
                    break;
                case 10:
                    returnCode = "设置/清除断点失败";
                    break;
                case 11:
                    returnCode = "无法擦除一个或多个闪存扇区";
                    break;
                case 12:
                    returnCode = "Flash编程/验证错误";
                    break;
                case 13:
                    returnCode = "选项字节编程错误";
                    break;
                default:
                    break;
            }
            return returnCode;
        }
    }
}
