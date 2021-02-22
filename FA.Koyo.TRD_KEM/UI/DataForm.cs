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
    public partial class DataForm : UserControl
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void btn_Query_Data_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dateTimePick_Start_Data.Value > this.dateTimePick_End_Data.Value)
                {
                    MessageBox.Show("查询截止日期不可早于起始日期");
                    return;
                }
                string dateTime_s = dateTimePick_Start_Data.Value.ToString("yyyy/MM/dd");
                string dateTime_e = dateTimePick_End_Data.Value.ToString("yyyy/MM/dd");

                //DataTable DT_Temp = new DataTable();
                //MySqlConnectionHelp mySqlConnectionHelp = new MySqlConnectionHelp();
                //MySqlConnection mySqlConnection = mySqlConnectionHelp.GetMySqlCon();
                //string sql = "";
                //int templet_ID = (int)this.comboBox_selectProduct.SelectedValue;
                //if (templet_ID == 0)
                //{                                  
                //     sql = "select * from sp_templet_statistics_info  where Work_Date BETWEEN cast('" + dateTime_s + "'  as DATE) and cast('" + dateTime_e + "'  as DATE)";
                //}
                //else
                //{
                //    sql = "select * from sp_templet_statistics_info  where Work_Date BETWEEN cast('" + dateTime_s + "'  as DATE) and cast('" + dateTime_e + "'  as DATE) and  Templet_ID = " + templet_ID;
                //}
                //MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                //DT_Temp = mySqlConnectionHelp.GetDataSet(mySqlCommand).Tables[0];
                //mySqlConnectionHelp.CloseConn(mySqlConnection);

                //long totalTime = 0;
                //int totalNum = 0;
                //for (int i = 0; i < DT_Temp.Rows.Count; i++)
                //{
                //    totalTime += (long)DT_Temp.Rows[i]["Total_Paint_Time"];
                //    totalNum += (int)DT_Temp.Rows[i]["Output_Quantity"];
                //}
                //int hour = 0;
                //int minute = 0;
                //int second = 0;
                //second = (int)totalTime;

                //if (second > 60)
                //{
                //    minute = second / 60;
                //    second = second % 60;
                //}
                //if (minute > 60)
                //{
                //    hour = minute / 60;
                //    minute = minute % 60;
                //}
               
                //this.dataGridView_Data.DataSource = ChangeDataTable_Total_Paint_Time(DT_Temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void InitDGV_Data()
        {
            try
            {
                //添加9列文本
                for (int i = 0; i < 9; i++)
                {
                    this.dataGridView_Data.Columns.Add(new DataGridViewTextBoxColumn());
                }

                Common.SetDataGridViewStyle(this.dataGridView_Data);

                //禁用排序
                for (int i = 0; i < this.dataGridView_Data.Columns.Count; i++)
                {
                    this.dataGridView_Data.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
                    this.dataGridView_Data.Columns[i].ReadOnly = true;
                    if (i == 0)
                    {
                        this.dataGridView_Data.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }

                this.dataGridView_Data.Columns[0].HeaderText = "数据ID";
                this.dataGridView_Data.Columns[0].Name = "Statistics_ID";
                this.dataGridView_Data.Columns[0].DataPropertyName = "Statistics_ID";
                this.dataGridView_Data.Columns[0].Width = 60;

                this.dataGridView_Data.Columns[1].HeaderText = "产品名称";
                this.dataGridView_Data.Columns[1].Name = "Templet_Name";
                this.dataGridView_Data.Columns[1].DataPropertyName = "Templet_Name";
                this.dataGridView_Data.Columns[1].Width = 140;

                this.dataGridView_Data.Columns[2].HeaderText = "日期";
                this.dataGridView_Data.Columns[2].Name = "Work_Date";
                this.dataGridView_Data.Columns[2].DataPropertyName = "Work_Date";
                this.dataGridView_Data.Columns[2].Width = 100;
                this.dataGridView_Data.Columns[2].Visible = false;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                      
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            //查询数据库，获取基板数据

        

            //InitDGV_Data();
        }
        private DataTable ChangeDataTable_TempletSelect(DataTable dataTable)
        {
            try
            {
                if (dataTable != null )
                {                  

                    DataTable DT = new DataTable();
                    //克隆表结构
                    DT = dataTable.Clone();

                    DataRow dr = DT.NewRow();
                    dr["Templet_ID"] = 0;
                    dr["Templet_Name"] = "全部";
                    DT.Rows.Add(dr);
                    //表填充数据
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow dataRow = DT.NewRow();
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            dataRow[j] = dataTable.Rows[i][j];
                        }
                        DT.Rows.Add(dataRow);
                    }

                    dataTable.Clear();
                    dataTable = DT;
                }
                return dataTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private DataTable ChangeDataTable_Total_Paint_Time(DataTable dataTable)
        {
            try
            {
                if (dataTable.Rows.Count > 0)
                {               

                    //改datatable中相关列的值
                    string[] option_val = new string[dataTable.Rows.Count];
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        int totalTime = Convert.ToInt32(dataTable.Rows[i]["Total_Paint_Time"]);

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
                        option_val[i] = hour + " : " + minute + " : " + second;

                    }

                    DataTable DT = new DataTable();
                    //克隆表结构
                    DT = dataTable.Clone();
                    DT.Columns["Total_Paint_Time"].DataType = typeof(String);

                    //表填充数据
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow dr = DT.NewRow();
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            if (dataTable.Columns[j].Caption == "Total_Paint_Time")
                            {
                                dr[j] = option_val[i];
                                continue;
                            }
                            dr[j] = dataTable.Rows[i][j];
                        }
                        DT.Rows.Add(dr);
                    }
                    dataTable.Clear();
                    dataTable = DT;
                }
                return dataTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                //if (this.dataGridView_Data.DataSource != null && (this.dataGridView_Data.DataSource as DataTable).Rows.Count > 0)
                //{
                //}
                //else
                //{
                //    MessageBox.Show("没有数据");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
    }
}
