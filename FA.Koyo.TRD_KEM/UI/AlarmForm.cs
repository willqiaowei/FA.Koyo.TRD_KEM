using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FA.Koyo.TRD_KEM.UI
{
    public partial class AlarmForm : UserControl
    {
        public AlarmForm()
        {
            InitializeComponent();
        }

        private void btn_Query_Alarm_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dateTimePick_Start_Alarm.Value > this.dateTimePick_End_Alarm.Value)
                {
                    MessageBox.Show("查询截止日期不可早于起始日期");
                    return;
                }
                string dateTime_s = dateTimePick_Start_Alarm.Value.ToString("yyyy/MM/dd");
                string dateTime_e = dateTimePick_End_Alarm.Value.ToString("yyyy/MM/dd");

                //DataTable DT_Temp = new DataTable();
                //MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                //MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                //string sql = "select * from sp_alarm_info  where Alarm_Date BETWEEN cast('" + dateTime_s + "'  as DATE) and cast('" + dateTime_e + "'  as DATE)";
                //MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                //DT_Temp = mySqlConnectionHelp.GetDataSet(mySqlCommand).Tables[0];
                //mySqlConnectionHelp.CloseConn(mySqlConnection);
                //this.dataGridView_Alarm.DataSource = DT_Temp;

                //if (DT_Temp != null  && DT_Temp.Rows.Count > 0)
                //{
                //    this.label_TotalAlarmNum.Text = DT_Temp.Rows.Count.ToString();
                //    int cardAlarmNum = 0;
                //    int plcAlarmNum = 0;
                //    int dbAlarmNum = 0;
                //    int anotherAlarmNum = 0;
                //    for (int i = 0; i < DT_Temp.Rows.Count; i++)
                //    {
                //        if (DT_Temp.Rows[i]["Alarm_Type"].ToString() == "运动板卡")
                //        {
                //            cardAlarmNum++;
                //        }
                //        if (DT_Temp.Rows[i]["Alarm_Type"].ToString() == "PLC")
                //        {
                //            plcAlarmNum++;
                //        }
                //        if (DT_Temp.Rows[i]["Alarm_Type"].ToString() == "数据库")
                //        {
                //            dbAlarmNum++;
                //        }
                //        if (DT_Temp.Rows[i]["Alarm_Type"].ToString() == "其他")
                //        {
                //            anotherAlarmNum++;
                //        }
                //    }
                //    this.label_CardAlarmNum.Text = cardAlarmNum.ToString();
                //    this.label_PLCAlarmNum.Text = plcAlarmNum.ToString();
                //    this.label_DBAlarmNum.Text = dbAlarmNum.ToString();
                //    this.label_AnotherAlarmNum.Text = anotherAlarmNum.ToString();
                //}
                //else
                //{
                //    this.label_TotalAlarmNum.Text = "0";
                //    this.label_CardAlarmNum.Text = "0";
                //    this.label_PLCAlarmNum.Text = "0";
                //    this.label_DBAlarmNum.Text = "0";
                //    this.label_AnotherAlarmNum.Text = "0";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InitDGV_Alarm()
        {
            try
            {
                //添加9列文本
                for (int i = 0; i <6; i++)
                {
                    this.dataGridView_Alarm.Columns.Add(new DataGridViewTextBoxColumn());
                }

                Common.SetDataGridViewStyle(this.dataGridView_Alarm);

                //禁用排序
                for (int i = 0; i < this.dataGridView_Alarm.Columns.Count; i++)
                {
                    this.dataGridView_Alarm.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
                    this.dataGridView_Alarm.Columns[i].ReadOnly = true;
                    if (i == 0)
                    {
                        this.dataGridView_Alarm.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }

                this.dataGridView_Alarm.Columns[0].HeaderText = "报警ID";
                this.dataGridView_Alarm.Columns[0].Name = "Alarm_ID";
                this.dataGridView_Alarm.Columns[0].DataPropertyName = "Alarm_ID";
                this.dataGridView_Alarm.Columns[0].Width = 100;

                this.dataGridView_Alarm.Columns[1].HeaderText = "产品ID";
                this.dataGridView_Alarm.Columns[1].Name = "Templet_ID";
                this.dataGridView_Alarm.Columns[1].DataPropertyName = "Templet_ID";
                this.dataGridView_Alarm.Columns[1].Width = 100;

                this.dataGridView_Alarm.Columns[2].HeaderText = "产品名称";
                this.dataGridView_Alarm.Columns[2].Name = "Templet_Name";
                this.dataGridView_Alarm.Columns[2].DataPropertyName = "Templet_Name";
                this.dataGridView_Alarm.Columns[2].Width = 163;
               
                this.dataGridView_Alarm.Columns[3].HeaderText = "报警类型";
                this.dataGridView_Alarm.Columns[3].Name = "Alarm_Type";
                this.dataGridView_Alarm.Columns[3].DataPropertyName = "Alarm_Type";
                this.dataGridView_Alarm.Columns[3].Width = 140;

                this.dataGridView_Alarm.Columns[4].HeaderText = "报警信息";
                this.dataGridView_Alarm.Columns[4].Name = "Alarm_Info";
                this.dataGridView_Alarm.Columns[4].DataPropertyName = "Alarm_Info";
                this.dataGridView_Alarm.Columns[4].Width = 300;            

                this.dataGridView_Alarm.Columns[5].HeaderText = "报警时间";
                this.dataGridView_Alarm.Columns[5].Name = "Alarm_Time";
                this.dataGridView_Alarm.Columns[5].DataPropertyName = "Alarm_Time";
                this.dataGridView_Alarm.Columns[5].Width = 165;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            //InitDGV_Alarm();
        }
    }
}
