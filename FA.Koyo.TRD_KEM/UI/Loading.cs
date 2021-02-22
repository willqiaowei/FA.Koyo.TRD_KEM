using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA.Koyo.TRD_KEM.UI
{
    public partial class Loading : Form
    {

        private readonly PLC_NK1 NK1; //PLC对象
        public Loading()
        {
            InitializeComponent();
            NK1 = new PLC_NK1();
        }

 
        /// <summary>
        /// Loading界面呈现后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loading_Shown(object sender, EventArgs e)
        {
            //先检测运动板卡连接及初始化，再检测PLC连接及初始化
            try
            {
                this.richTextBox_Load.AppendText("欢迎使用TRD-KEM试验器" + "\n");
                this.progressBar_Load.Value = 0;
                this.progressBar_Load.Minimum = 0;
                this.progressBar_Load.Maximum = 100;             

                //开始检测数据库连接
                this.richTextBox_Load.AppendText(DateTime.Now + " 数据库连接..." + "\n");
                ChangeProgressBar(2);
                if (CheackDBLink())
                {
                    this.richTextBox_Load.AppendText(DateTime.Now + " 数据库连接成功。" + "\n");
                    //以上数据库检测通过，以下开始PLC检测
                    this.richTextBox_Load.AppendText(DateTime.Now + " PLC连接..." + "\n");
                    ChangeProgressBar(1.5);

                    NK1.PLCInitil(1, MainForm.PLC_IP);
                    if (PLC_NK1.ShRet != 0)
                    {
                        switch (PLC_NK1.ShRet)
                        {
                            case 1001:
                                this.richTextBox_Load.AppendText(DateTime.Now + " 1001，通信时间溢出！" + "\n");
                                break;
                            case 1002:
                                this.richTextBox_Load.AppendText(DateTime.Now + " 1002，PLC寄存器类型错误！" + "\n");
                                break;
                            case 1003:
                                this.richTextBox_Load.AppendText(DateTime.Now + " 1003, PLC寄存器地址错误！" + "\n");
                                break;
                            case 1009:
                                this.richTextBox_Load.AppendText(DateTime.Now + " 1009, 从PLC接收到错误的功能码！" + "\n");
                                break;
                            case 1011:
                                this.richTextBox_Load.AppendText(DateTime.Now + " 1011, 通信内部参数错误！" + "\n");
                                break;
                            case 1014:
                                this.richTextBox_Load.AppendText(DateTime.Now + " 1014, 通信内部传送ID错误！" + "\n");
                                break;
                            case 1016:
                                this.richTextBox_Load.AppendText(DateTime.Now + " 1016, 通信数据长度错误！" + "\n");
                                break;
                            case -1:
                                this.richTextBox_Load.AppendText(DateTime.Now + " PLC连接异常，请联系管理员！" + "\n");
                                break;
                        }
                        this.richTextBox_Load.ScrollToCaret();
                        MessageBox.Show("关闭程序");
                        this.Close();
                    }
                    else
                    {
                        this.richTextBox_Load.AppendText(DateTime.Now + " PLC连接成功。" + "\n");
                        ChangeProgressBar(1.5);
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }
                else
                {
                    this.richTextBox_Load.AppendText(DateTime.Now + " 数据库连接失败！" + "\n");
                    this.richTextBox_Load.ScrollToCaret();
                    MessageBox.Show("关闭程序");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            
        }

        //检查数据库连接异常
        private bool CheackDBLink()
        {
            try
            {             
                MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();

                DataTable dt = new DataTable();
                string sql = "select * from tk_plc";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                dt = mySqlConnectionHelp.GetDataSet(mySqlCommand).Tables[0];
             
                MainForm.PLC_IP = dt.Rows[0]["PLC_IP"].ToString();                


                mySqlConnectionHelp.CloseConn(mySqlConnection);
                return true;
            }
            catch (Exception ex)
            {
                this.richTextBox_Load.AppendText(DateTime.Now + " "+ex.Message + "\n");
                return false;
            }
        }
     
        private void ChangeProgressBar(double num)
        {
            for (int i = 0; i < 10* num; i++)
            {
                if (this.progressBar_Load.Value <100)
                {
                    this.progressBar_Load.Value++;
                    Thread.Sleep(5);
                }
            
            }
        }

    }
}
