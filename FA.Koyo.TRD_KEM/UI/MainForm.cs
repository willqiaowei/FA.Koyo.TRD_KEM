using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA.Koyo.TRD_KEM.UI
{
    public partial class MainForm : Form
    {
        public static int Status; //当前系统状态：0代表停止，1代表运行
        public static bool HasCheckedHoming; //是否已经回零点：false代表没有，true代表已回

        public static string PLC_IP; //PLC IP地址

        //X轴回零运动的参数
        public static int X_ACC;  
        public static int X_VM;
        public static int X_VO;
        public static int X_VS;

 

      

        UserControl UserControl = null;  //用户控件
        OperationForm OperationForm = null;
        SettingForm SettingForm = null;
        DataForm DataForm = null;
        AlarmForm AlarmForm = null;

        public MainForm()
        {
            InitializeComponent();
            //启动自动加载操作界面
            OperationForm = new OperationForm();
            UserControl = OperationForm;
            this.panel_mainArea.Controls.Add(UserControl);

            Status = 0;
        }
       

        private void btn_operation_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status != 0)
                {
                    MessageBox.Show("作业中不可切换界面");
                    return;
                }

                this.panel_mainArea.Controls.Remove(UserControl);
                if (OperationForm == null)
                {
                    OperationForm = new OperationForm();
                }
                if (UserControl != null && UserControl.Name != "OperationForm")
                {
                    UserControl.Dispose();
                }
                UserControl = OperationForm;
                this.panel_mainArea.Controls.Add(UserControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            try
            {
           
                this.panel_mainArea.Controls.Remove(UserControl);
                SettingForm = new SettingForm();
                UserControl = SettingForm;
                this.panel_mainArea.Controls.Add(UserControl);
                MainForm.HasCheckedHoming = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

   
       

        private void btn_data_Click(object sender, EventArgs e)
        {
            try
            {
              
                this.panel_mainArea.Controls.Remove(UserControl);
                DataForm = new DataForm();
                UserControl = DataForm;
                this.panel_mainArea.Controls.Add(UserControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void btn_alarm_Click(object sender, EventArgs e)
        {
            try
            {
              
                this.panel_mainArea.Controls.Remove(UserControl);
                AlarmForm = new AlarmForm();
                UserControl = AlarmForm;
                this.panel_mainArea.Controls.Add(UserControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Status != 0)
                {
                    MessageBox.Show("作业中不可关闭");
                    e.Cancel = true;
                    return;
                }
                if (MessageBox.Show("确认关闭吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
         
        }

        private int GetTempletIDByTempletName(string templetName)
        {
            try
            {
                DataTable dataTable = new DataTable();
                MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                string sql = "select * from sp_templet_info where Templet_Name =  '" + templetName + "'"; 
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                dataTable = mySqlConnectionHelp.GetDataSet(mySqlCommand).Tables[0];
                mySqlConnectionHelp.CloseConn(mySqlConnection);

                return (int)dataTable.Rows[0]["Templet_ID"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private DataTable GetHomingAxisInfoByAxisID()
        {
            try
            {
                DataTable DT_Temp = new DataTable();
                MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                string sql = " select * from sp_axis_homing_info  ";
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
        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
