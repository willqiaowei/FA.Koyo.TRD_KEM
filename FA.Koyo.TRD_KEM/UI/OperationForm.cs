using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using EasyModbus;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace FA.Koyo.TRD_KEM.UI
{
    public partial class OperationForm : UserControl
    {
        string STLINK_EXE_Address;//ST-LINK本机安装地址
        string Directive_Init; //初始化指令
        string Directive_Erasure_All; //全部擦除指令
        string Directive_WriteCheckFile; //写入校准程序指令
        string Directive_Erasure_Part; //部分擦除指令
        string Directive_WriteUserFile; //写入用户程序指令
        string Directive_ReadProtection; //读保护指令

        bool Alarm = false;

        double Seconds_CurrentProduct_Time; //当前产品涂覆时间秒
        public List<Dictionary<string, double>> TotalProductTime = new List<Dictionary<string, double>>();//累计涂覆时间集合秒
        public List<Dictionary<string, int>> BatchNumber = new List<Dictionary<string, int>>(); // 批次产品计数
        bool IsStartCurrentProduct_Time = false;//当前产品是否开始

        private CancellationTokenSource _CancellationTokenSource_Begin; //开始按钮task取消标志
        public OperationForm()
        {
            InitializeComponent();
        }
        ~OperationForm()
        {
            //销毁非托管
            Dispose(false);
        }
        private void OperationForm_Load(object sender, EventArgs e)
        {
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false; //非线程安全

                backgroundWorker_CheckPLC.RunWorkerAsync();
                //查询数据库，获取
                Task task = new Task(() =>
                {
                    DataTable dataTable = Common.GetCommandInfo();
                    if (dataTable != null)
                    {
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            if (dataTable.Rows[i]["Command_Name"].ToString() == "STLlink_EXE_Address")
                            {
                                STLINK_EXE_Address = dataTable.Rows[i]["Command_Info"].ToString() + " ";
                            }
                            if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_Init")
                            {
                                Directive_Init = dataTable.Rows[i]["Command_Info"].ToString();
                            }
                            if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_Erasure_All")
                            {
                                Directive_Erasure_All = dataTable.Rows[i]["Command_Info"].ToString();
                            }
                            if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_WriteCheckFile")
                            {
                                Directive_WriteCheckFile = dataTable.Rows[i]["Command_Info"].ToString();
                            }
                            if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_Erasure_Part")
                            {
                                Directive_Erasure_Part = dataTable.Rows[i]["Command_Info"].ToString();
                            }
                            if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_WriteUserFile")
                            {
                                Directive_WriteUserFile = dataTable.Rows[i]["Command_Info"].ToString();
                            }
                            if (dataTable.Rows[i]["Command_Name"].ToString() == "Directive_ReadProtection")
                            {
                                Directive_ReadProtection = dataTable.Rows[i]["Command_Info"].ToString();
                            }
                        }
                    }
                  
                });
                task.Start();           

                this.label_Result.Text = "";
         

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

     

        /// <summary>
        /// 开始按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {            
                if (this.comboBox_selectProduct.SelectedIndex > -1)
                {                                     

                    if (MessageBox.Show("确认开始吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.btn_Start.Enabled = false;
                        this.progressBar_Total.Value = 0;
                        _CancellationTokenSource_Begin = new CancellationTokenSource();
                        Task.Factory.StartNew(() =>
                        {
                            LEDColorGray_ALL();
                            this.label_Result.Text = "";
                            Thread.Sleep(100);
                            Alarm = false;
                            MainForm.Status = 1;
                            //当前产品作业时间计时开始
                            Stopwatch stopwatch = new Stopwatch();
                            stopwatch.Start();
                            Seconds_CurrentProduct_Time = 1;
                            IsStartCurrentProduct_Time = true;

                           
                            Task t = Unit_One();
                            t.Start();
                            t.Wait();
                            if (Alarm)
                            {
                                this.btn_Start.Enabled = true;
                                MainForm.Status = 0;
                                return;
                            }
                            t = Unit_Two();
                            t.Start();
                            t.Wait();
                            if (Alarm)
                            {
                                this.btn_Start.Enabled = true;
                                MainForm.Status = 0;
                                return;
                            }
                            this.progressBar_Total.Value = 100;                          
                            this.btn_Start.Enabled = true;
                            MainForm.Status = 0;
                            this.label_Result.Text = "OK";

                            stopwatch.Stop();
                            TimeSpan timeSpan = stopwatch.Elapsed;
                            double time = Math.Round(timeSpan.TotalSeconds, 0);
                            Dictionary<string, double> dictionary = new Dictionary<string, double>();
                            dictionary.Add(this.comboBox_selectProduct.Text, time);
                            TotalProductTime.Add(dictionary);
                            IsStartCurrentProduct_Time = false;


                        }, _CancellationTokenSource_Begin.Token, TaskCreationOptions.LongRunning, TaskScheduler.Current);
                      
                    }
                }
                else
                {
                    MessageBox.Show("请先选择产品");
                }
                            
            }
            catch (Exception ex)
            {
                this.lab_flowStatus.Text = "系统异常！";
                RedLEDOn();
                AlarmRecord(true, "其他", ex.Message);
                MessageBox.Show(ex.Message);
            }           
        }

        private Task Unit_One()
        {

            Task task = new Task(() => {
                try
                {
                    ChangeProgressBar(8);
                    this.lab_flowStatus.Text = "初始化..";
                    this.lab_flowStatus.BackColor = Color.Lime;
                    int returnCode = Common.CmdCommand(STLINK_EXE_Address,Directive_Init);
                    if (returnCode == 0)
                    {
                        this.lab_flowStatus.Text = "初始化完成";
                        this.lab_flowStatus.BackColor = Color.Lime;               
                        this.led_Init.GridentColor = Color.Green;
                        this.led_Init.CenterColor = Color.Green;
                    }
                    else
                    {
                        string error = Common.SwitchReturnCode(returnCode);
                        this.lab_flowStatus.Text = error;
                        this.lab_flowStatus.BackColor = Color.Red;
                        this.led_Init.GridentColor = Color.Red;
                        this.led_Init.CenterColor = Color.Red;
                        this.label_Result.Text = "NG";
                        Alarm = true;
                        return;
                    }
                    Thread.Sleep(100);
                    ChangeProgressBar(8);

                    this.lab_flowStatus.Text = "写入校准文件..";
                    this.lab_flowStatus.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, Directive_WriteCheckFile);
                    if (returnCode == 0)
                    {
                        this.lab_flowStatus.Text = "写入校准文件完成";
                        this.lab_flowStatus.BackColor = Color.Lime;
                        this.led_Write_Calibration.GridentColor = Color.Green;
                        this.led_Write_Calibration.CenterColor = Color.Green;
                    }
                    else
                    {
                        string error = Common.SwitchReturnCode(returnCode);
                        this.lab_flowStatus.Text =  error;
                        this.lab_flowStatus.BackColor = Color.Red;
                        this.led_Write_Calibration.GridentColor = Color.Red;
                        this.led_Write_Calibration.CenterColor = Color.Red;
                        this.label_Result.Text = "NG";
                        Alarm = true;
                        return;
                    }
                    Thread.Sleep(100);
                    ChangeProgressBar(8);

                    this.lab_flowStatus.Text = "全部擦除..";
                    this.lab_flowStatus.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, Directive_Erasure_All);
                    if (returnCode == 0)
                    {
                        this.lab_flowStatus.Text = "全部擦除完成";
                        this.lab_flowStatus.BackColor = Color.Lime;
                        this.led_ErasureAll.GridentColor = Color.Green;
                        this.led_ErasureAll.CenterColor = Color.Green;
                    }
                    else
                    {
                        string error = Common.SwitchReturnCode(returnCode);
                        this.lab_flowStatus.Text = error;
                        this.lab_flowStatus.BackColor = Color.Red;
                        this.led_ErasureAll.GridentColor = Color.Red;
                        this.led_ErasureAll.CenterColor = Color.Red;
                        this.label_Result.Text = "NG";
                        Alarm = true;
                        return;
                    }
                    Thread.Sleep(100);
                    ChangeProgressBar(8);

                    this.lab_flowStatus.Text = "写入校准文件..";
                    this.lab_flowStatus.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, Directive_WriteCheckFile);
                    if (returnCode == 0)
                    {
                        this.lab_flowStatus.Text = "写入校准文件完成";
                        this.lab_flowStatus.BackColor = Color.Lime;
                        this.led_Write_Calibration2.GridentColor = Color.Green;
                        this.led_Write_Calibration2.CenterColor = Color.Green;
                    }
                    else
                    {
                        string error = Common.SwitchReturnCode(returnCode);
                        this.lab_flowStatus.Text =  error;
                        this.lab_flowStatus.BackColor = Color.Red;
                        this.led_Write_Calibration2.GridentColor = Color.Red;
                        this.led_Write_Calibration2.CenterColor = Color.Red;
                        this.label_Result.Text = "NG";
                        Alarm = true;
                        return;
                    }
                    Thread.Sleep(100);
                    ChangeProgressBar(8);

                    this.lab_flowStatus.Text = "初始化..";
                    this.lab_flowStatus.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, Directive_Init);
                    if (returnCode == 0)
                    {
                        this.lab_flowStatus.Text = "初始化完成";
                        this.lab_flowStatus.BackColor = Color.Lime;
                        this.led_Init2.GridentColor = Color.Green;
                        this.led_Init2.CenterColor = Color.Green;
                    }
                    else
                    {
                        string error = Common.SwitchReturnCode(returnCode);
                        this.lab_flowStatus.Text =  error;
                        this.lab_flowStatus.BackColor = Color.Red;
                        this.led_Init2.GridentColor = Color.Red;
                        this.led_Init2.CenterColor = Color.Red;
                        this.label_Result.Text = "NG";
                        Alarm = true;
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
            return task;
        }


        private Task Unit_Two()
        {

            Task task = new Task(() => {
                try
                {

                    ChangeProgressBar(8);

                    this.lab_flowStatus.Text = "部分擦除..";
                    this.lab_flowStatus.BackColor = Color.Lime;
                    int returnCode = Common.CmdCommand(STLINK_EXE_Address, Directive_Erasure_Part);
                    if (returnCode == 0)
                    {
                        this.lab_flowStatus.Text = "部分擦除完成";
                        this.lab_flowStatus.BackColor = Color.Lime;
                        this.led_ErasurePart.GridentColor = Color.Green;
                        this.led_ErasurePart.CenterColor = Color.Green;
                    }
                    else
                    {
                        string error = Common.SwitchReturnCode(returnCode);
                        this.lab_flowStatus.Text =  error;
                        this.lab_flowStatus.BackColor = Color.Red;
                        this.led_ErasurePart.GridentColor = Color.Red;
                        this.led_ErasurePart.CenterColor = Color.Red;
                        this.label_Result.Text = "NG";
                        Alarm = true;
                        return;
                    }
                    Thread.Sleep(100);
                    ChangeProgressBar(8);

                    this.lab_flowStatus.Text = "写入用户程序..";
                    this.lab_flowStatus.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, Directive_WriteUserFile);
                    if (returnCode == 0)
                    {
                        this.lab_flowStatus.Text = "写入用户程序完成";
                        this.lab_flowStatus.BackColor = Color.Lime;
                        this.led_Write_User_Procedure.GridentColor = Color.Green;
                        this.led_Write_User_Procedure.CenterColor = Color.Green;
                    }
                    else
                    {
                        string error = Common.SwitchReturnCode(returnCode);
                        this.lab_flowStatus.Text = error;
                        this.lab_flowStatus.BackColor = Color.Red;
                        this.led_Write_User_Procedure.GridentColor = Color.Red;
                        this.led_Write_User_Procedure.CenterColor = Color.Red;
                        this.label_Result.Text = "NG";
                        Alarm = true;
                        return;
                    }
                    Thread.Sleep(100);
                    ChangeProgressBar(8);

                    this.lab_flowStatus.Text = "初始化..";
                    this.lab_flowStatus.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, Directive_Init);
                    if (returnCode == 0)
                    {
                        this.lab_flowStatus.Text = "初始化完成";
                        this.lab_flowStatus.BackColor = Color.Lime;
                        this.led_Init3.GridentColor = Color.Green;
                        this.led_Init3.CenterColor = Color.Green;
                    }
                    else
                    {
                        string error = Common.SwitchReturnCode(returnCode);
                        this.lab_flowStatus.Text =  error;
                        this.lab_flowStatus.BackColor = Color.Red;
                        this.led_Init3.GridentColor = Color.Red;
                        this.led_Init3.CenterColor = Color.Red;
                        this.label_Result.Text = "NG";
                        Alarm = true;
                        return;
                    }
                    Thread.Sleep(100);
                    ChangeProgressBar(8);

                    this.lab_flowStatus.Text = "读保护..";
                    this.lab_flowStatus.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, Directive_ReadProtection);
                    if (returnCode == 0)
                    {
                        this.lab_flowStatus.Text = "读保护完成";
                        this.lab_flowStatus.BackColor = Color.Lime;
                        this.led_Read_Protect.GridentColor = Color.Green;
                        this.led_Read_Protect.CenterColor = Color.Green;

                    }
                    else
                    {
                        string error = Common.SwitchReturnCode(returnCode);
                        this.lab_flowStatus.Text =  error;
                        this.lab_flowStatus.BackColor = Color.Red;
                        this.led_Read_Protect.GridentColor = Color.Red;
                        this.led_Read_Protect.CenterColor = Color.Red;
                        this.label_Result.Text = "NG";
                        Alarm = true;
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
            return task;
        }
        private void LEDColorGray_ALL()
        {
            this.led_Init.GridentColor = Color.Gray;
            this.led_Init.CenterColor = Color.Gray;
            this.led_Write_Calibration.GridentColor = Color.Gray;
            this.led_Write_Calibration.CenterColor = Color.Gray;
            this.led_ErasureAll.GridentColor = Color.Gray;
            this.led_ErasureAll.CenterColor = Color.Gray;
            this.led_Write_Calibration2.GridentColor = Color.Gray;
            this.led_Write_Calibration2.CenterColor = Color.Gray;
            this.led_Init2.GridentColor = Color.Gray;
            this.led_Init2.CenterColor = Color.Gray;
            this.led_ErasurePart.GridentColor = Color.Gray;
            this.led_ErasurePart.CenterColor = Color.Gray;
            this.led_Write_User_Procedure.GridentColor = Color.Gray;
            this.led_Write_User_Procedure.CenterColor = Color.Gray;
            this.led_Init3.GridentColor = Color.Gray;
            this.led_Init3.CenterColor = Color.Gray;
            this.led_Read_Protect.GridentColor = Color.Gray;
            this.led_Read_Protect.CenterColor = Color.Gray;

        }
        private void ChangeProgressBar(int num)
        {
            for (int i = 0; i <  num; i++)
            {
                if (this.progressBar_Total.Value < 100)
                {
                    this.progressBar_Total.Value++;
                    Thread.Sleep(10);
                }

            }
        }
        /// <summary>
        /// 停止按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)//非立即停止
        {
           
            try
            {   
                if (MainForm.Status == 2)
                {
                    //复位中
                    MessageBox.Show("复位中，不可操作");
                    return;
                }
           
                if (MessageBox.Show("确认停止吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   
                }                                         
            }
            catch (Exception ex)
            {
                AlarmRecord(true, "其他", ex.Message);
                MessageBox.Show(ex.Message);
            }           
        }
       
       

      
        /// <summary>
        /// 读PLC输入信号
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        private bool GetPLCInStatus_I0ToI17(string position)
        {
            try
            {
                PLC_NK1 NK1 = new PLC_NK1();
                if (NK1.PLCInitil(2, MainForm.PLC_IP))
                {
                    //输入信号
                    ushort[] buf_Read_DI = new ushort[1024];
                    string strRegAdr_DI = "40400";//I0-I17
                    NK1.SetRegAdr('R', strRegAdr_DI);
                    short shRet = ECOMModbusTCP.emtRead_PLC(ref NK1.PParam, buf_Read_DI, 4);
                    if (shRet == 0)
                    {
                        switch (position)
                        {
                            case "流水线前位":
                                if ((buf_Read_DI[0] & (1 << 0)) != 0) //流水线前位I0
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;
                            case "流水线中位":
                                if ((buf_Read_DI[0] & (1 << 1)) != 0) //流水线中位I1
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;
                            case "流水线后位":
                                if ((buf_Read_DI[0] & (1 << 2)) != 0) //流水线后位I2
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;
                            case "阻挡气缸后位":
                                if ((buf_Read_DI[0] & (1 << 3)) != 0) //阻挡气缸后位I3
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;
                            case "阻挡气缸前位":
                                if ((buf_Read_DI[0] & (1 << 4)) != 0) //阻挡气缸前位I4
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;
                            case "夹板气缸下位":
                                if ((buf_Read_DI[0] & (1 << 5)) != 0) //夹板气缸下位I5
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;
                            case "夹板气缸上位":
                                if ((buf_Read_DI[0] & (1 << 6)) != 0) //夹板气缸上位I6
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;
                            case "浸泡气缸前位":
                                if ((buf_Read_DI[0] & (1 << 12)) == 0) //浸泡气缸前位I14
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;
                            case "浸泡气缸后位":
                                if ((buf_Read_DI[0] & (1 << 13)) == 0) //浸泡气缸后位I15
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;

                            default:
                                ECOMModbusTCP.emtClose(ref NK1.PParam);
                                return false;
                        }

                    }
                }
                ECOMModbusTCP.emtClose(ref NK1.PParam);
                return false;
            }
            catch (Exception ex)
            {
                AlarmRecord(true, "其他", ex.Message);
                return false;
            }
           
        }

        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        private bool GetPLCInStatus_I20ToI27(string position)
        {
            try
            {
                PLC_NK1 NK1 = new PLC_NK1();
                if (NK1.PLCInitil(3, MainForm.PLC_IP))
                {
                    //输入信号
                    ushort[] buf_Read_DI = new ushort[1024];
                    string strRegAdr_DI = "40401";//I20-I27
                    NK1.SetRegAdr('R', strRegAdr_DI);
                    short shRet = ECOMModbusTCP.emtRead_PLC(ref NK1.PParam, buf_Read_DI, 4);
                    if (shRet == 0)
                    {
                        switch (position)
                        {
                            case "流水线前段送板":
                                if ((buf_Read_DI[0] & (1 << 0)) != 0) //流水线前段送板
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;
                            case "流水线后段要板":
                                if ((buf_Read_DI[0] & (1 << 1)) != 0) //流水线后段要板
                                {
                                    ECOMModbusTCP.emtClose(ref NK1.PParam);
                                    return true;
                                }
                                break;

                            default:
                                ECOMModbusTCP.emtClose(ref NK1.PParam);
                                return false;
                        }

                    }
                }
                ECOMModbusTCP.emtClose(ref NK1.PParam);
                return false;
            }
            catch (Exception ex)
            {
                AlarmRecord(true, "其他", ex.Message);
                return false;
            }           
        }

        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        /// <summary>
        /// 比例阀1设定
        /// </summary>
        /// <param name="val"></param>
        public  bool ProportionalVal1Set(float val)
        {
            try
            {
                PLC_NK1 NK1 = new PLC_NK1();
                if (NK1.PLCInitil(4, MainForm.PLC_IP))
                {
                    int proportionalVal1 = (int)(val * 4096 / 10);
                    ushort[] buf_Write_DO = new ushort[1];
                    buf_Write_DO[0] = Convert.ToUInt16(proportionalVal1);

                    string strRegAdr_DO = "37010";
                    NK1.SetRegAdr('R', strRegAdr_DO);
                    short shRet = ECOMModbusTCP.emtWrite_PLC(ref NK1.PParam, buf_Write_DO, 1);
                    if (shRet == 0)
                    {
                        ECOMModbusTCP.emtClose(ref NK1.PParam);
                        return true;
                    }                 
                }
                ECOMModbusTCP.emtClose(ref NK1.PParam);
                return false;
            }
            catch (Exception ex)
            {
                AlarmRecord(true, "其他", ex.Message);
                return false;
            }
        }

        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        /// <summary>
        /// 比例阀2设定
        /// </summary>
        /// <param name="val"></param>
        public  bool ProportionalVal2Set(float val)
        {
            try
            {
                PLC_NK1 NK1 = new PLC_NK1();
                if (NK1.PLCInitil(5, MainForm.PLC_IP))
                {
                    int proportionalVal2 = (int)(val * 4096 / 10);
                    ushort[] buf_Write_DO = new ushort[1];
                    buf_Write_DO[0] = Convert.ToUInt16(proportionalVal2);
                    string strRegAdr_DO = "37011";
                    NK1.SetRegAdr('R', strRegAdr_DO);
                    short shRet = ECOMModbusTCP.emtWrite_PLC(ref NK1.PParam, buf_Write_DO, 1);
                    if (shRet == 0)
                    {
                        ECOMModbusTCP.emtClose(ref NK1.PParam);
                        return true;
                    }
                }
                ECOMModbusTCP.emtClose(ref NK1.PParam);
                return false;
            }
            catch (Exception ex)
            {
                AlarmRecord(true, "其他", ex.Message);
                return false;
            }
        }
       

       
        /// <summary>
        /// 产品选择下拉选变动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_selectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBox_selectProduct.SelectedIndex > -1  && this.comboBox_selectProduct.Text != "System.Data.DataRowView")
                {
                  
                }
            }
            catch (Exception ex)
            {
                AlarmRecord(true, "其他", ex.Message);
                MessageBox.Show(ex.Message);
            }            
        }
        
     

     

        private void backgroundWorker_currentProduct_Time_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                   
                }
                catch (Exception ex)
                {
                    AlarmRecord(true, "其他", ex.Message);
                    MessageBox.Show("backgroundWorker_currentProduct_Time " + ex.Message);
                }

            }
        }

      
        private void AlarmRecord(bool hasTemplet, string alarmType, string alarmInfo)
        {
            MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
            MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
            string sql;
            if (hasTemplet)
            {
                if (this.comboBox_selectProduct.SelectedIndex > -1 && this.comboBox_selectProduct.Text != "System.Data.DataRowView")
                {
                    int templetId;
                    string templetName = "";
                    bool isNum = int.TryParse(this.comboBox_selectProduct.SelectedValue.ToString(), out templetId);
                    templetName = this.comboBox_selectProduct.Text;
                    if (isNum)
                    {
                        sql = "insert into sp_alarm_info(Templet_ID,Templet_Name,Alarm_Type,Alarm_Info,Alarm_Time,Alarm_Date)" +
                      " values( '" + templetId + "' , '" + templetName + "' ,'" + alarmType + "' ,'" + alarmInfo + "' ,'" + DateTime.Now + "' ,'" + DateTime.Now.Date + "' )";
                    }
                    else
                    {
                        sql = "insert into sp_alarm_info(Alarm_Type,Alarm_Info,Alarm_Time,Alarm_Date)" +
                      " values( '" + alarmType + "' ,'" + alarmInfo + "' ,'" + DateTime.Now + "' ,'" + DateTime.Now.Date + "' )";
                    }

                }
                else
                {
                    sql = "insert into sp_alarm_info(Alarm_Type,Alarm_Info,Alarm_Time,Alarm_Date)" +
                  " values( '" + alarmType + "' ,'" + alarmInfo + "' ,'" + DateTime.Now + "' ,'" + DateTime.Now.Date + "' )";
                }

            }
            else
            {
                sql = "insert into sp_alarm_info(Alarm_Type,Alarm_Info,Alarm_Time,Alarm_Date)" +
               " values( '" + alarmType + "' ,'" + alarmInfo + "' ,'" + DateTime.Now + "' ,'" + DateTime.Now.Date + "' )";
            }


            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            int returnCode_Mysql = mySqlCommand.ExecuteNonQuery();//3.执行插入、删除、更改语句。执行成功返回受影响的数据的
            mySqlConnectionHelp.CloseConn(mySqlConnection);
            if (returnCode_Mysql <= 0)
            {
                MessageBox.Show("报警信息保存失败");
                return;
            }
        }

        /// <summary>
        /// 红灯亮
        /// </summary>
        private void RedLEDOn()
        {
            this.lab_flowStatus.BackColor = Color.Red;
            Common.GreenLEDAction(false);//绿灯关
            Common.YellowLEDAction(false);//黄灯
            Common.RedLEDAction(true);//红灯
        }
        /// <summary>
        /// 黄灯亮
        /// </summary>
        private void YellowLEDOn()
        {
            this.lab_flowStatus.BackColor = Color.Yellow;
            Common.GreenLEDAction(false);//绿灯关
            Common.YellowLEDAction(true);//黄灯
            Common.RedLEDAction(false);//红灯
        }
        /// <summary>
        /// 绿灯亮
        /// </summary>
        private void GreenLEDOn()
        {
            this.lab_flowStatus.BackColor = Color.Lime;
            Common.GreenLEDAction(true);//绿灯关
            Common.YellowLEDAction(false);//黄灯
            Common.RedLEDAction(false);//红灯
        }

        private void backgroundWorker_CurrentProduct_Time_DoWork_1(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    if (IsStartCurrentProduct_Time && MainForm.Status != 0)
                    {
                        Seconds_CurrentProduct_Time++;
                    }
                    int totalProduct = 0;
                    foreach (var item in BatchNumber)
                    {
                        totalProduct += item.First().Value;
                    }
                    long totalTime = 0;
                    foreach (var item in TotalProductTime)
                    {
                        totalTime += (long)item.First().Value;
                    }
                    if (IsStartCurrentProduct_Time)
                    {
                        totalTime = (long)(Seconds_CurrentProduct_Time - 1 + totalTime);
                        int hour = 0;
                        int minute = 0;
                        int second = 0;
                        second = (int)totalTime;

                        if (second > 60)
                        {
                            minute = second / 60;
                            second = second % 60;
                        }
                        if (minute > 60)
                        {
                            hour = minute / 60;
                            minute = minute % 60;
                        }
                    }
                    else
                    {
                        int hour = 0;
                        int minute = 0;
                        int second = 0;
                        second = (int)totalTime;

                        if (second > 60)
                        {
                            minute = second / 60;
                            second = second % 60;
                        }
                        if (minute > 60)
                        {
                            hour = minute / 60;
                            minute = minute % 60;
                        }
                    }
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    AlarmRecord(true, "其他", ex.Message);
                    MessageBox.Show("backgroundWorker_currentProduct_Time " + ex.Message);
                }
            }
        }

        private void backgroundWorker_CheckPLC_DoWork(object sender, DoWorkEventArgs e)
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
                                }
                                else
                                {
                                }

                                if ((buf_Read_DO[0] & (1 << 7)) != 0)  // 探针下压气缸Q7
                                {
                                }
                                else
                                {
                                }

                                if ((buf_Read_DO[0] & (1 << 8)) != 0)  // Q10
                                {
                                 
                                }
                                else
                                {
                                    
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
                                    led_Motor_Positive.GridentColor = Color.Gray;

                                }

                                if ((buf_Read_DO[0] & (1 << 11)) != 0)  // Q13  反转
                                {
                                    led_Motor_Reverse.GridentColor = Color.Green;
                                }
                                else
                                {
                                    led_Motor_Reverse.GridentColor = Color.Gray;
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
                                }
                                else
                                {
                                }

                                if ((buf_Read_DI[0] & (1 << 13)) != 0) //夹紧气缸后位I15
                                {
                                }
                                else
                                {

                                }

                                if ((buf_Read_DI[0] & (1 << 14)) != 0) //探针气缸上位I16
                                {

                                }
                                else
                                {

                                }

                                if ((buf_Read_DI[0] & (1 << 15)) != 0) //探针气缸下位I17
                                {
                                }
                                else
                                {
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
    }
}
