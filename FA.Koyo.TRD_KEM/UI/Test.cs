using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA.Koyo.TRD_KEM.UI
{
    public partial class Test : Form
    {
        private CancellationTokenSource _CancellationTokenSource_WriteCheck; //第一步task取消标志
        private CancellationTokenSource _CancellationTokenSource_WriteUser; //第二步task取消标志
        private string STLINK_EXE_Address = "ST-LINK_CLI.exe -c SWD UR ";
        public Test()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //非线程安全

            this.Lab_Status.Text = "准备就绪";
            this.Lab_Status.BackColor = Color.Lime;
        }



     

        private void Button_WriteCheck_Click(object sender, EventArgs e)
        {
            this.Button_WriteCheck.BackColor = Color.LightGray;
            this.Button_WriteUser.BackColor = Color.LightGray;
            _CancellationTokenSource_WriteCheck = new CancellationTokenSource();
            Task.Factory.StartNew(() => {
                try
                {

                    this.Button_WriteCheck.Enabled = false;
                    this.Button_WriteUser.Enabled = false;
                    this.Button_WriteCheck.BackColor = Color.Yellow;

                    this.Lab_Status.Text = "初始化..";
                    this.Lab_Status.BackColor = Color.Lime;
                    int returnCode = Common.CmdCommand(STLINK_EXE_Address,this.TextBox_Init.Text.Trim());
                    if (returnCode == 0)
                    {
                        this.Lab_Status.Text = "初始化完成";
                        this.Lab_Status.BackColor = Color.Lime;
                    }
                    else
                    {
                        string error = SwitchReturnCode(returnCode);
                        this.Lab_Status.Text = "初始化:"+ error;
                        this.Lab_Status.BackColor = Color.Red;
                        this.Button_WriteCheck.BackColor = Color.Red;
                        this.Button_WriteCheck.Enabled = true;
                        this.Button_WriteUser.Enabled = true;
                        _CancellationTokenSource_WriteCheck.Cancel();
                        return;
                    }
                    Thread.Sleep(200);

                    this.Lab_Status.Text = "写入校准文件..";
                    this.Lab_Status.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_Write_Calibration.Text.Trim());
                    if (returnCode == 0)
                    {
                        this.Lab_Status.Text = "写入校准文件完成";
                        this.Lab_Status.BackColor = Color.Lime;
                    }
                    else
                    {
                        string error = SwitchReturnCode(returnCode);
                        this.Lab_Status.Text = "写入校准文件:" + error;
                        this.Lab_Status.BackColor = Color.Red;
                        this.Button_WriteCheck.BackColor = Color.Red;
                        this.Button_WriteCheck.Enabled = true;
                        this.Button_WriteUser.Enabled = true;
                        _CancellationTokenSource_WriteCheck.Cancel();
                        return;
                    }
                    Thread.Sleep(200);

                    this.Lab_Status.Text = "全部擦除..";
                    this.Lab_Status.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_ErasureAll.Text.Trim());
                    if (returnCode == 0)
                    {
                        this.Lab_Status.Text = "全部擦除完成";
                        this.Lab_Status.BackColor = Color.Lime;
                    }
                    else
                    {
                        string error = SwitchReturnCode(returnCode);
                        this.Lab_Status.Text = "全部擦除:" + error;
                        this.Lab_Status.BackColor = Color.Red;
                        this.Button_WriteCheck.BackColor = Color.Red;
                        this.Button_WriteCheck.Enabled = true;
                        this.Button_WriteUser.Enabled = true;
                        _CancellationTokenSource_WriteCheck.Cancel();
                        return;
                    }
                    Thread.Sleep(200);

                    this.Lab_Status.Text = "写入校准文件..";
                    this.Lab_Status.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_Write_Calibration.Text.Trim());
                    if (returnCode == 0)
                    {
                        this.Lab_Status.Text = "写入校准文件完成";
                        this.Lab_Status.BackColor = Color.Lime;
                    }
                    else
                    {
                        string error = SwitchReturnCode(returnCode);
                        this.Lab_Status.Text = "写入校准文件:" + error;
                        this.Lab_Status.BackColor = Color.Red;
                        this.Button_WriteCheck.BackColor = Color.Red;
                        this.Button_WriteCheck.Enabled = true;
                        this.Button_WriteUser.Enabled = true;
                        _CancellationTokenSource_WriteCheck.Cancel();
                        return;
                    }
                    Thread.Sleep(200);

                    this.Lab_Status.Text = "初始化..";
                    this.Lab_Status.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_Init.Text.Trim());
                    if (returnCode == 0)
                    {
                        this.Lab_Status.Text = "初始化完成";
                        this.Lab_Status.BackColor = Color.Lime;
                    }
                    else
                    {
                        string error = SwitchReturnCode(returnCode);
                        this.Lab_Status.Text = "初始化:" + error;
                        this.Lab_Status.BackColor = Color.Red;
                        this.Button_WriteCheck.BackColor = Color.Red;
                        this.Button_WriteCheck.Enabled = true;
                        this.Button_WriteUser.Enabled = true;
                        _CancellationTokenSource_WriteCheck.Cancel();
                        return;
                    }
                    Thread.Sleep(100);

                    this.Lab_Status.Text = "第一步完成";
                    this.Lab_Status.BackColor = Color.Lime;

                    this.Button_WriteCheck.Enabled = true;
                    this.Button_WriteUser.Enabled = true;
                    this.Button_WriteCheck.BackColor = Color.LightGray;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            }, _CancellationTokenSource_WriteCheck.Token, TaskCreationOptions.None, TaskScheduler.Current);
          
        }

        private void Button_WriteUser_Click(object sender, EventArgs e)
        {
            this.Button_WriteCheck.BackColor = Color.LightGray;
            this.Button_WriteUser.BackColor = Color.LightGray;
            _CancellationTokenSource_WriteUser = new CancellationTokenSource();
            Task.Factory.StartNew(() => {
                try
                {
                    this.Button_WriteCheck.Enabled = false;
                    this.Button_WriteUser.Enabled = false;
                    this.Button_WriteUser.BackColor = Color.Yellow;

                    this.Lab_Status.Text = "部分擦除..";
                    this.Lab_Status.BackColor = Color.Lime;
                    int returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_ErasurePart.Text.Trim());
                    if (returnCode == 0)
                    {
                        this.Lab_Status.Text = "部分擦除完成";
                        this.Lab_Status.BackColor = Color.Lime;
                    }
                    else
                    {
                        string error = SwitchReturnCode(returnCode);
                        this.Lab_Status.Text = "部分擦除:" + error;
                        this.Lab_Status.BackColor = Color.Red;
                        this.Button_WriteUser.BackColor = Color.Red;
                        this.Button_WriteCheck.Enabled = true;
                        this.Button_WriteUser.Enabled = true;
                        _CancellationTokenSource_WriteUser.Cancel();
                        return;
                    }
                    Thread.Sleep(200);


                    this.Lab_Status.Text = "写入用户程序..";
                    this.Lab_Status.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_Write_User_Procedure.Text.Trim());
                    if (returnCode == 0)
                    {
                        this.Lab_Status.Text = "写入用户程序完成";
                        this.Lab_Status.BackColor = Color.Lime;
                    }
                    else
                    {
                        string error = SwitchReturnCode(returnCode);
                        this.Lab_Status.Text = "写入用户程序:" + error;
                        this.Lab_Status.BackColor = Color.Red;
                        this.Button_WriteUser.BackColor = Color.Red;
                        this.Button_WriteCheck.Enabled = true;
                        this.Button_WriteUser.Enabled = true;
                        _CancellationTokenSource_WriteUser.Cancel();
                        return;
                    }
                    Thread.Sleep(200);

                    this.Lab_Status.Text = "初始化..";
                    this.Lab_Status.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_Init.Text.Trim());
                    if (returnCode == 0)
                    {
                        this.Lab_Status.Text = "初始化完成";
                        this.Lab_Status.BackColor = Color.Lime;
                    }
                    else
                    {
                        string error = SwitchReturnCode(returnCode);
                        this.Lab_Status.Text = "初始化:" + error;
                        this.Lab_Status.BackColor = Color.Red;
                        this.Button_WriteUser.BackColor = Color.Red;
                        this.Button_WriteCheck.Enabled = true;
                        this.Button_WriteUser.Enabled = true;
                        _CancellationTokenSource_WriteUser.Cancel();
                        return;
                    }
                    Thread.Sleep(200);


                    this.Lab_Status.Text = "读保护..";
                    this.Lab_Status.BackColor = Color.Lime;
                    returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_Read_Protect.Text.Trim());
                    if (returnCode == 0)
                    {
                        this.Lab_Status.Text = "读保护完成";
                        this.Lab_Status.BackColor = Color.Lime;
                    }
                    else
                    {
                        string error = SwitchReturnCode(returnCode);
                        this.Lab_Status.Text = "读保护:" + error;
                        this.Lab_Status.BackColor = Color.Red;
                        this.Button_WriteUser.BackColor = Color.Red;
                        this.Button_WriteCheck.Enabled = true;
                        this.Button_WriteUser.Enabled = true;
                        _CancellationTokenSource_WriteUser.Cancel();
                        return;
                    }
                    Thread.Sleep(100);

                    this.Lab_Status.Text = "第二步完成";
                    this.Lab_Status.BackColor = Color.Lime;

                    this.Button_WriteCheck.Enabled = true;
                    this.Button_WriteUser.Enabled = true;
                    this.Button_WriteUser.BackColor = Color.LightGray;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }, _CancellationTokenSource_WriteUser.Token, TaskCreationOptions.None, TaskScheduler.Current);
        }

        private void ButtonEnableFalse_ALL()
        {
            this.Button_Init.Enabled = false;
            this.Button_ErasureAll.Enabled = false;
            this.Button_Write_Calibration.Enabled = false;
            this.Button_Init2.Enabled = false;
            this.Button_ErasurePart.Enabled = false;
            this.Button_Write_User_Procedure.Enabled = false;
            this.Button_Init3.Enabled = false;
            this.Button_Read_Protect.Enabled = false;
         
        }
        private void ButtonEnableTrue_ALL()
        {
            this.Button_Init.Enabled = true;
            this.Button_ErasureAll.Enabled = true;
            this.Button_Write_Calibration.Enabled = true;
            this.Button_Init2.Enabled = true;
            this.Button_ErasurePart.Enabled = true;
            this.Button_Write_User_Procedure.Enabled = true;
            this.Button_Init3.Enabled = true;
            this.Button_Read_Protect.Enabled = true;
        }
        private void TextBoxReadOnlyFalse_ALL()
        {
            this.TextBox_Init.ReadOnly = false;
            this.TextBox_ErasureAll.ReadOnly = false;
            this.TextBox_Write_Calibration.ReadOnly = false;
            this.textBox_Init2.ReadOnly = false;
            this.TextBox_ErasurePart.ReadOnly = false;
            this.TextBox_Write_User_Procedure.ReadOnly = false;
            this.textBox_Init3.ReadOnly = false;
            this.TextBox_Read_Protect.ReadOnly = false;

        }
        private void TextBoxReadOnlyTrue_ALL()
        {
            this.TextBox_Init.ReadOnly = true;
            this.TextBox_ErasureAll.ReadOnly = true;
            this.TextBox_Write_Calibration.ReadOnly = true;
            this.textBox_Init2.ReadOnly = true;
            this.TextBox_ErasurePart.ReadOnly = true;
            this.TextBox_Write_User_Procedure.ReadOnly = true;
            this.textBox_Init3.ReadOnly = true;
            this.TextBox_Read_Protect.ReadOnly = true;

        }
        private string SwitchReturnCode(int recode)
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

        private void Button_Init_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxReadOnlyTrue_ALL();
                ButtonEnableFalse_ALL();

                this.Button_Init.BackColor = Color.Yellow;          

                int returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_Init.Text.Trim());
                if (returnCode == 0)
                {
                    this.Button_Init.BackColor = Color.Lime;
                }
                else
                {
                    this.Button_Init.BackColor = Color.Red;
                    string error = SwitchReturnCode(returnCode);
                    MessageBox.Show(error);
                }
                TextBoxReadOnlyFalse_ALL();
                ButtonEnableTrue_ALL();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Erasure_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxReadOnlyTrue_ALL();
                ButtonEnableFalse_ALL();

                this.Button_ErasureAll.BackColor = Color.Yellow;

                int returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_ErasureAll.Text.Trim());
                if (returnCode == 0)
                {
                    this.Button_ErasureAll.BackColor = Color.Lime;
                }
                else
                {
                    this.Button_ErasureAll.BackColor = Color.Red;
                    string error = SwitchReturnCode(returnCode);
                    MessageBox.Show(error);
                }
                TextBoxReadOnlyFalse_ALL();
                ButtonEnableTrue_ALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Write_Calibration_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxReadOnlyTrue_ALL();
                ButtonEnableFalse_ALL();

                this.Button_Write_Calibration.BackColor = Color.Yellow;

                int returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_Write_Calibration.Text.Trim());
                if (returnCode == 0)
                {
                    this.Button_Write_Calibration.BackColor = Color.Lime;
                }
                else
                {
                    this.Button_Write_Calibration.BackColor = Color.Red;
                    string error = SwitchReturnCode(returnCode);
                    MessageBox.Show(error);
                }
                TextBoxReadOnlyFalse_ALL();
                ButtonEnableTrue_ALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Write_User_Procedure_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxReadOnlyTrue_ALL();
                ButtonEnableFalse_ALL();

                this.Button_Write_User_Procedure.BackColor = Color.Yellow;

                int returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_Write_User_Procedure.Text.Trim());
                if (returnCode == 0)
                {
                    this.Button_Write_User_Procedure.BackColor = Color.Lime;
                }
                else
                {
                    this.Button_Write_User_Procedure.BackColor = Color.Red;
                    string error = SwitchReturnCode(returnCode);
                    MessageBox.Show(error);
                }
                TextBoxReadOnlyFalse_ALL();
                ButtonEnableTrue_ALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Read_Protect_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxReadOnlyTrue_ALL();
                ButtonEnableFalse_ALL();

                this.Button_Read_Protect.BackColor = Color.Yellow;

                int returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_Read_Protect.Text.Trim());
                if (returnCode == 0)
                {
                    this.Button_Read_Protect.BackColor = Color.Lime;
                }
                else
                {
                    this.Button_Read_Protect.BackColor = Color.Red;
                    string error = SwitchReturnCode(returnCode);
                    MessageBox.Show(error);
                }
                TextBoxReadOnlyFalse_ALL();
                ButtonEnableTrue_ALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_ErasurePart_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxReadOnlyTrue_ALL();
                ButtonEnableFalse_ALL();

                this.Button_ErasurePart.BackColor = Color.Yellow;

                int returnCode = Common.CmdCommand(STLINK_EXE_Address, this.TextBox_ErasurePart.Text.Trim());
                if (returnCode == 0)
                {
                    this.Button_ErasurePart.BackColor = Color.Lime;
                }
                else
                {
                    this.Button_ErasurePart.BackColor = Color.Red;
                    string error = SwitchReturnCode(returnCode);
                    MessageBox.Show(error);
                }
                TextBoxReadOnlyFalse_ALL();
                ButtonEnableTrue_ALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxReadOnlyTrue_ALL();
                ButtonEnableFalse_ALL();

                this.Button_Init2.BackColor = Color.Yellow;

                int returnCode = Common.CmdCommand(STLINK_EXE_Address, this.textBox_Init2.Text.Trim());
                if (returnCode == 0)
                {
                    this.Button_Init2.BackColor = Color.Lime;
                }
                else
                {
                    this.Button_Init2.BackColor = Color.Red;
                    string error = SwitchReturnCode(returnCode);
                    MessageBox.Show(error);
                }
                TextBoxReadOnlyFalse_ALL();
                ButtonEnableTrue_ALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxReadOnlyTrue_ALL();
                ButtonEnableFalse_ALL();

                this.Button_Init3.BackColor = Color.Yellow;

                int returnCode = Common.CmdCommand(STLINK_EXE_Address, this.textBox_Init3.Text.Trim());
                if (returnCode == 0)
                {
                    this.Button_Init3.BackColor = Color.Lime;
                }
                else
                {
                    this.Button_Init3.BackColor = Color.Red;
                    string error = SwitchReturnCode(returnCode);
                    MessageBox.Show(error);
                }
                TextBoxReadOnlyFalse_ALL();
                ButtonEnableTrue_ALL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
