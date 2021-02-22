using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using EasyModbus;
using MySql.Data.MySqlClient;
using System.Collections;

namespace FA.Koyo.TRD_KEM.UI
{
    public partial class SettingForm : System.Windows.Forms.UserControl
    {

        private int SelectAxis; //选择轴

        string CurrentSelectParameter;//当前选中的参数项
        public SettingForm()
        {
            InitializeComponent();
        }
      
        private void SettingForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //非线程安全

            backgroundWorker_UpdateSetting.RunWorkerAsync();
               //加载时初始化控件状态
               Task task = new Task(() =>
            {
                DataTable dataTable = Common.GetCommandInfo();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (dataTable.Rows[i]["Command_Name"].ToString() == "STLlink_EXE_Address")
                    {
                        TextBox_STLink.Text = dataTable.Rows[i]["Command_Info"].ToString();
                    }
                    if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_Init")
                    {
                        TextBox_Init.Text = dataTable.Rows[i]["Command_Info"].ToString();
                    }
                    if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_Erasure_All")
                    {
                        TextBox_ErasureAll.Text = dataTable.Rows[i]["Command_Info"].ToString();
                    }
                    if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_WriteCheckFile")
                    {
                        TextBox_Write_Calibration.Text = dataTable.Rows[i]["Command_Info"].ToString();
                    }
                    if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_Erasure_Part")
                    {
                        TextBox_ErasurePart.Text = dataTable.Rows[i]["Command_Info"].ToString();
                    }
                    if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_WriteUserFile")
                    {
                        TextBox_Write_User_Procedure.Text = dataTable.Rows[i]["Command_Info"].ToString();
                    }
                    if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_ReadProtection")
                    {
                        TextBox_Read_Protect.Text = dataTable.Rows[i]["Command_Info"].ToString();
                    }
                }
            });
            task.Start();
            

        }
       
        /// <summary>
        /// easymodbus连接PLC
        /// </summary>
        /// <returns></returns>
        //private bool ModbusConnect()
        //{
        //    try
        //    {
        //        string ip = "192.168.10.7";
        //        PLC_ModbusClient = new ModbusClient(ip, 502);
        //        PLC_ModbusClient.Connect();

        //        if (PLC_ModbusClient.Connected)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //      
        //        return false;
        //    }
        //}




        private DataTable GetHomingAxisInfoByAxisID(int axisID)
        {
            DataTable DT_Temp = new DataTable();
            MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
            MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
            string sql = "select * from sp_axis_homing_info where Axis_ID = " + axisID;
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            DT_Temp = mySqlConnectionHelp.GetDataSet(mySqlCommand).Tables[0];
            mySqlConnectionHelp.CloseConn(mySqlConnection);

            return DT_Temp;
        }

       


        /// <summary>
        /// 启动指示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                ModbusClient modbusClient = Common.ModbusConnect();
                if (modbusClient != null)
                {
                    int start = 2056;  //启动对应Q10--2056

                    if (this.led_Start.GridentColor == Color.Green)
                    {
                        modbusClient.WriteSingleCoil(start, false);
                    }
                    else
                    {
                        modbusClient.WriteSingleCoil(start, true);
                    }
                    //关闭连接
                    modbusClient.Disconnect();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
         
        }

        /// <summary>
        /// 停止指示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            ModbusClient modbusClient = Common.ModbusConnect();
            if (modbusClient != null)
            {
                int start = 2056;  //停止指示对应Q10--2056 false

                if (this.led_Stop.GridentColor == Color.Green)
                {
                    modbusClient.WriteSingleCoil(start, false);
                }
                else
                {
                    modbusClient.WriteSingleCoil(start, true);
                }
                //关闭连接
                modbusClient.Disconnect();
            }
       
        }

        /// <summary>
        /// 流水线启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Assembly_Line_Start_Click(object sender, EventArgs e)
        {
            ModbusClient modbusClient = Common.ModbusConnect();
            if (modbusClient != null)
            {
                int start = 2056;  //流水线启动信号对应Q10--2056

                if (this.led_Motor_Positive.GridentColor == Color.Green)
                {
                    modbusClient.WriteSingleCoil(start, false);
                }
                else
                {
                    modbusClient.WriteSingleCoil(start, true);
                }
                //关闭连接
                modbusClient.Disconnect();
            }
          
        }
      
      
      



       
       
      
      

        private void btn_Clamp_Click(object sender, EventArgs e)
        {
            ModbusClient modbusClient = Common.ModbusConnect();
            if (modbusClient != null)
            {
                int start = 2054;  //启动指示对应Q06--2054

                if (this.led_Clamp.GridentColor == Color.Green)
                {
                    modbusClient.WriteSingleCoil(start, false);
                }
                else
                {
                    modbusClient.WriteSingleCoil(start, true);
                }
                //关闭连接
                modbusClient.Disconnect();
            }
        }

        private void btn_Underdraught_Click(object sender, EventArgs e)
        {
            ModbusClient modbusClient = Common.ModbusConnect();
            if (modbusClient != null)
            {
                int start = 2055;  //探针下压对应Q07--2055

                if (this.led_Underdraught.GridentColor == Color.Green)
                {
                    modbusClient.WriteSingleCoil(start, false);
                }
                else
                {
                    modbusClient.WriteSingleCoil(start, true);
                }
                //关闭连接
                modbusClient.Disconnect();
            }
        }

        private void btn_Motor_Reverse_Click(object sender, EventArgs e)
        {
            ModbusClient modbusClient = Common.ModbusConnect();
            if (modbusClient != null)
            {
                int start = 2054;  //启动指示对应Q06--2054

                if (this.led_Motor_Reverse.GridentColor == Color.Green)
                {
                    modbusClient.WriteSingleCoil(start, false);
                }
                else
                {
                    modbusClient.WriteSingleCoil(start, true);
                }
                //关闭连接
                modbusClient.Disconnect();
            }
        }

        private void backgroundWorker_UpdateSetting_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (true)
                {
                    if (this.Disposing)
                    {
                        break;
                    }

                    try
                    {  
                        //输出信号
                        PLC_NK1 NK1_UpdateTabPLC_IO = new PLC_NK1();
                        if (NK1_UpdateTabPLC_IO.PLCInitil(8, MainForm.PLC_IP))
                        {
                           
                            ushort[] buf_Read_DO = new ushort[1024];
                            string strRegAdr_DO = "40500";
                            NK1_UpdateTabPLC_IO.SetRegAdr('R', strRegAdr_DO);
                            short shRet = ECOMModbusTCP.emtRead_PLC(ref NK1_UpdateTabPLC_IO.PParam, buf_Read_DO, 8);
                            if (shRet == 0)
                            {
                                if ((buf_Read_DO[0] & (1 << 0)) != 0)  // Q0
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DO[0] & (1 << 1)) != 0)  // Q1
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DO[0] & (1 << 2)) != 0)  // Q2
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DO[0] & (1 << 3)) != 0)  // Q3
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DO[0] & (1 << 4)) != 0)  // Q4
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DO[0] & (1 << 5)) != 0)  // Q5
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DO[0] & (1 << 6)) != 0)  // 夹紧气缸Q6
                                {
                                    this.led_Clamp.GridentColor = Color.Green;
                                }
                                else
                                {
                                    this.led_Clamp.GridentColor = Color.Black;
                                }

                                if ((buf_Read_DO[0] & (1 << 7)) != 0)  // 探针下压气缸Q7
                                {
                                    this.led_Underdraught.GridentColor = Color.Green;
                                }
                                else
                                {
                                    this.led_Underdraught.GridentColor = Color.Black;
                                }

                                if ((buf_Read_DO[0] & (1 << 8)) != 0)  // Q10
                                {
                                    this.led_Start.GridentColor = Color.Green;
                                    this.led_Stop.GridentColor = Color.Black;
                                }
                                else
                                {
                                    this.led_Start.GridentColor = Color.Black;
                                    this.led_Stop.GridentColor = Color.Green;
                                }

                                if ((buf_Read_DO[0] & (1 << 9)) != 0)  // Q11
                                {
                                    

                                }
                                else
                                {

                                }

                                if ((buf_Read_DO[0] & (1 << 10)) != 0)  // Q12 正转
                                {
                                    led_Motor_Positive.GridentColor = Color.Green;
                                }
                                else
                                {
                                    led_Motor_Positive.GridentColor = Color.Black;

                                }

                                if ((buf_Read_DO[0] & (1 << 11)) != 0)  // Q13  反转
                                {
                                    led_Motor_Reverse.GridentColor = Color.Green;
                                }
                                else
                                {
                                    led_Motor_Reverse.GridentColor = Color.Black;
                                }

                                if ((buf_Read_DO[0] & (1 << 12)) != 0)  // Q14
                                {

                                }
                                else
                                {
                                }

                                if ((buf_Read_DO[0] & (1 << 13)) != 0)  // Q15
                                {

                                }
                                else
                                {
                                }

                                if ((buf_Read_DO[0] & (1 << 14)) != 0)  // Q16
                                {

                                }
                                else
                                {
                                }

                                if ((buf_Read_DO[0] & (1 << 15)) != 0)  // Q17
                                {

                                }
                                else
                                {
                                }
                            }


                        }
                        ECOMModbusTCP.emtClose(ref NK1_UpdateTabPLC_IO.PParam);


                        //输入信号
                        PLC_NK1 NK1_UpdateTabPLC_IO3 = new PLC_NK1();
                        if (NK1_UpdateTabPLC_IO3.PLCInitil(20, MainForm.PLC_IP))
                        {
                          
                            ushort[] buf_Read_DI = new ushort[1024];
                            string strRegAdr_DI = "40400";//I0-I17
                            NK1_UpdateTabPLC_IO3.SetRegAdr('R', strRegAdr_DI);
                            short shRet1 = ECOMModbusTCP.emtRead_PLC(ref NK1_UpdateTabPLC_IO3.PParam, buf_Read_DI, 10);
                            if (shRet1 == 0)
                            {
                                if ((buf_Read_DI[0] & (1 << 0)) != 0) //I0
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI[0] & (1 << 1)) != 0) //I1
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI[0] & (1 << 2)) != 0) //I2
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI[0] & (1 << 3)) != 0) //I3
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI[0] & (1 << 4)) != 0) //I4
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI[0] & (1 << 5)) != 0) //I5
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI[0] & (1 << 6)) != 0) //I6
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI[0] & (1 << 7)) != 0) //I7
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI[0] & (1 << 8)) != 0) //开始按钮灯I10
                                {
                                }
                                else
                                {
                                }

                                if ((buf_Read_DI[0] & (1 << 9)) != 0) //停止按钮灯I11
                                {
                                }
                                else
                                {
                                }

                                if ((buf_Read_DI[0] & (1 << 10)) != 0) //I12
                                {
                                }
                                else
                                {
                                }

                                if ((buf_Read_DI[0] & (1 << 11)) != 0) //I13
                                {
                                }
                                else
                                {
                                }

                                if ((buf_Read_DI[0] & (1 << 12)) != 0) //夹紧气缸前位I14
                                {
                                    this.led_Front.GridentColor = Color.Black;
                                }
                                else
                                {
                                    this.led_Front.GridentColor = Color.Green;
                                }

                                if ((buf_Read_DI[0] & (1 << 13)) != 0) //夹紧气缸后位I15
                                {
                                    this.led_Rear.GridentColor = Color.Black;
                                }
                                else
                                {
                                    this.led_Rear.GridentColor = Color.Green;

                                }

                                if ((buf_Read_DI[0] & (1 << 14)) != 0) //探针气缸上位I16
                                {
                                    this.led_Down.GridentColor = Color.Black;

                                }
                                else
                                {
                                    this.led_Down.GridentColor = Color.Green;

                                }

                                if ((buf_Read_DI[0] & (1 << 15)) != 0) //探针气缸下位I17
                                {
                                    this.led_Up.GridentColor = Color.Black;
                                }
                                else
                                {
                                    this.led_Up.GridentColor = Color.Green;
                                }
                            }
                        }
                        ECOMModbusTCP.emtClose(ref NK1_UpdateTabPLC_IO3.PParam);


                        PLC_NK1 NK1_UpdateTabPLC_IO2 = new PLC_NK1();
                        if (NK1_UpdateTabPLC_IO2.PLCInitil(9, MainForm.PLC_IP))
                        {
                            ushort[] buf_Read_DI2 = new ushort[1024];
                            string strRegAdr_DI2 = "40401";//I20-I27
                            NK1_UpdateTabPLC_IO2.SetRegAdr('R', strRegAdr_DI2);
                            short shRet2 = ECOMModbusTCP.emtRead_PLC(ref NK1_UpdateTabPLC_IO2.PParam, buf_Read_DI2, 4);
                            if (shRet2 == 0)
                            {

                                if ((buf_Read_DI2[0] & (1 << 0)) != 0) //I20
                                {                                    

                                }
                                else
                                {                            

                                }

                                if ((buf_Read_DI2[0] & (1 << 1)) != 0) //I21
                                {                                 

                                }
                                else
                                {                                   

                                }

                                if ((buf_Read_DI2[0] & (1 << 2)) != 0) //I22
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI2[0] & (1 << 3)) != 0) //I23
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI2[0] & (1 << 4)) != 0) //I24
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI2[0] & (1 << 5)) != 0) //I25
                                {

                                }
                                else
                                {

                                }
                            }
                        }
                        ECOMModbusTCP.emtClose(ref NK1_UpdateTabPLC_IO2.PParam);
                    }
                    catch (Exception)
                    {

                    }

                    Thread.Sleep(2000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Command_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TextBox_Init.Text.Trim() == "" || this.TextBox_ErasureAll.Text.Trim() == "" || this.TextBox_Write_Calibration.Text.Trim() == "" || this.TextBox_ErasurePart.Text.Trim() == "" || this.TextBox_Write_User_Procedure.Text.Trim() == "" || this.TextBox_Read_Protect.Text.Trim() == "")
                {
                    MessageBox.Show("请填写完整");
                }
                else
                {
                    bool modify_flag = false;
                    string STLlink_EXE_Address = TextBox_STLink.Text.Trim();//ST-LINK本机安装地址
                    string Directive_Init = TextBox_Init.Text.Trim(); //初始化指令
                    string Directive_Erasure_All = TextBox_ErasureAll.Text.Trim(); //全部擦除指令
                    string Directive_WriteCheckFile = TextBox_Write_Calibration.Text.Trim(); //写入校准程序指令
                    string Directive_Erasure_Part = TextBox_ErasurePart.Text.Trim(); //部分擦除指令
                    string Directive_WriteUserFile = TextBox_Write_User_Procedure.Text.Trim(); //写入用户程序指令
                    string Directive_ReadProtection = TextBox_Read_Protect.Text.Trim(); //读保护指令

                    MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                    MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                    string sql;
                    //修改
                    sql = "update tk_command set Command_Info='" + STLlink_EXE_Address + "',Create_Time ='" + DateTime.Now + "'  where Command_Name = 'STLlink_EXE_Address' ";

                    MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                    int returnCode_Mysql = mySqlCommand.ExecuteNonQuery();//3.执行插入、删除、更改语句。执行成功返回受影响的数据的
                    if (returnCode_Mysql <= 0)
                    {
                        modify_flag = true;
                    }
                    sql = "update tk_command set Command_Info='" + Directive_Init + "',Create_Time ='" + DateTime.Now + "' where Command_Name = 'Directive_Init' ";

                     mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                     returnCode_Mysql = mySqlCommand.ExecuteNonQuery();//3.执行插入、删除、更改语句。执行成功返回受影响的数据的
                    if (returnCode_Mysql <= 0)
                    {
                        modify_flag = true;
                    }
                    sql = "update tk_command set Command_Info='" + Directive_Erasure_All + "',Create_Time ='" + DateTime.Now + "' where Command_Name = 'Directive_Erasure_All' ";

                     mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                     returnCode_Mysql = mySqlCommand.ExecuteNonQuery();//3.执行插入、删除、更改语句。执行成功返回受影响的数据的
                    if (returnCode_Mysql <= 0)
                    {
                        modify_flag = true;
                    }
                    sql = "update tk_command set Command_Info='" + Directive_WriteCheckFile + "',Create_Time ='" + DateTime.Now + "' where Command_Name = 'Directive_WriteCheckFile' ";

                     mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                     returnCode_Mysql = mySqlCommand.ExecuteNonQuery();//3.执行插入、删除、更改语句。执行成功返回受影响的数据的
                    if (returnCode_Mysql <= 0)
                    {
                        modify_flag = true;
                    }
                    sql = "update tk_command set Command_Info='" + Directive_Erasure_Part + "',Create_Time ='" + DateTime.Now + "' where Command_Name = 'Directive_Erasure_Part' ";

                     mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                     returnCode_Mysql = mySqlCommand.ExecuteNonQuery();//3.执行插入、删除、更改语句。执行成功返回受影响的数据的
                    if (returnCode_Mysql <= 0)
                    {
                        modify_flag = true;
                    }
                    sql = "update tk_command set Command_Info='" + Directive_WriteUserFile + "',Create_Time ='" + DateTime.Now + "' where Command_Name = 'Directive_WriteUserFile' ";

                     mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                     returnCode_Mysql = mySqlCommand.ExecuteNonQuery();//3.执行插入、删除、更改语句。执行成功返回受影响的数据的
                    if (returnCode_Mysql <= 0)
                    {
                        modify_flag = true;
                    }
                    sql = "update tk_command set Command_Info='" + Directive_ReadProtection + "',Create_Time ='" + DateTime.Now + "' where Command_Name = 'Directive_ReadProtection' ";

                     mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                     returnCode_Mysql = mySqlCommand.ExecuteNonQuery();//3.执行插入、删除、更改语句。执行成功返回受影响的数据的
                    if (returnCode_Mysql <= 0)
                    {
                        modify_flag = true;
                    }
                    if (modify_flag)
                    {
                        MessageBox.Show("修改失败");
                    }
                    else
                    {
                        MessageBox.Show("修改成功");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
