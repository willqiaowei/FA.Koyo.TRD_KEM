namespace FA.Koyo.TRD_KEM.UI
{
    partial class AlarmForm
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Maintain = new System.Windows.Forms.TabControl();
            this.tab_Alarm = new System.Windows.Forms.TabPage();
            this.btn_Query_Alarm = new System.Windows.Forms.Button();
            this.dateTimePick_Start_Alarm = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_AnotherAlarmNum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_DBAlarmNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_PLCAlarmNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_CardAlarmNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TotalAlarmNum = new System.Windows.Forms.Label();
            this.dateTimePick_End_Alarm = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_Alarm = new System.Windows.Forms.DataGridView();
            this.label88 = new System.Windows.Forms.Label();
            this.tabControl_Maintain.SuspendLayout();
            this.tab_Alarm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Alarm)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Maintain
            // 
            this.tabControl_Maintain.Controls.Add(this.tab_Alarm);
            this.tabControl_Maintain.ItemSize = new System.Drawing.Size(60, 25);
            this.tabControl_Maintain.Location = new System.Drawing.Point(3, 9);
            this.tabControl_Maintain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Maintain.Name = "tabControl_Maintain";
            this.tabControl_Maintain.SelectedIndex = 0;
            this.tabControl_Maintain.Size = new System.Drawing.Size(1002, 575);
            this.tabControl_Maintain.TabIndex = 18;
            // 
            // tab_Alarm
            // 
            this.tab_Alarm.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Alarm.Controls.Add(this.btn_Query_Alarm);
            this.tab_Alarm.Controls.Add(this.dateTimePick_Start_Alarm);
            this.tab_Alarm.Controls.Add(this.label11);
            this.tab_Alarm.Controls.Add(this.groupBox1);
            this.tab_Alarm.Controls.Add(this.dateTimePick_End_Alarm);
            this.tab_Alarm.Controls.Add(this.dataGridView_Alarm);
            this.tab_Alarm.Controls.Add(this.label88);
            this.tab_Alarm.Location = new System.Drawing.Point(4, 29);
            this.tab_Alarm.Name = "tab_Alarm";
            this.tab_Alarm.Size = new System.Drawing.Size(994, 542);
            this.tab_Alarm.TabIndex = 7;
            this.tab_Alarm.Text = "报警";
            // 
            // btn_Query_Alarm
            // 
            this.btn_Query_Alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Query_Alarm.FlatAppearance.BorderSize = 0;
            this.btn_Query_Alarm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btn_Query_Alarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Query_Alarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Query_Alarm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Query_Alarm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Query_Alarm.Location = new System.Drawing.Point(674, 27);
            this.btn_Query_Alarm.Name = "btn_Query_Alarm";
            this.btn_Query_Alarm.Size = new System.Drawing.Size(101, 30);
            this.btn_Query_Alarm.TabIndex = 209;
            this.btn_Query_Alarm.Text = "查询";
            this.btn_Query_Alarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Query_Alarm.UseVisualStyleBackColor = true;
            this.btn_Query_Alarm.Click += new System.EventHandler(this.btn_Query_Alarm_Click);
            // 
            // dateTimePick_Start_Alarm
            // 
            this.dateTimePick_Start_Alarm.Checked = false;
            this.dateTimePick_Start_Alarm.CustomFormat = "yyyy/MM/dd";
            this.dateTimePick_Start_Alarm.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.dateTimePick_Start_Alarm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePick_Start_Alarm.Location = new System.Drawing.Point(291, 31);
            this.dateTimePick_Start_Alarm.Name = "dateTimePick_Start_Alarm";
            this.dateTimePick_Start_Alarm.Size = new System.Drawing.Size(150, 23);
            this.dateTimePick_Start_Alarm.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(448, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 80;
            this.label11.Text = "至";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_AnotherAlarmNum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label_DBAlarmNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_PLCAlarmNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_CardAlarmNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_TotalAlarmNum);
            this.groupBox1.Location = new System.Drawing.Point(3, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 83);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "每日汇总";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(800, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 54;
            this.label7.Text = "其他报警数量：";
            // 
            // label_AnotherAlarmNum
            // 
            this.label_AnotherAlarmNum.AutoSize = true;
            this.label_AnotherAlarmNum.Location = new System.Drawing.Point(895, 35);
            this.label_AnotherAlarmNum.Name = "label_AnotherAlarmNum";
            this.label_AnotherAlarmNum.Size = new System.Drawing.Size(11, 12);
            this.label_AnotherAlarmNum.TabIndex = 55;
            this.label_AnotherAlarmNum.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 52;
            this.label9.Text = "数据库报警数量：";
            // 
            // label_DBAlarmNum
            // 
            this.label_DBAlarmNum.AutoSize = true;
            this.label_DBAlarmNum.Location = new System.Drawing.Point(720, 35);
            this.label_DBAlarmNum.Name = "label_DBAlarmNum";
            this.label_DBAlarmNum.Size = new System.Drawing.Size(11, 12);
            this.label_DBAlarmNum.TabIndex = 53;
            this.label_DBAlarmNum.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "PLC报警数量：";
            // 
            // label_PLCAlarmNum
            // 
            this.label_PLCAlarmNum.AutoSize = true;
            this.label_PLCAlarmNum.Location = new System.Drawing.Point(533, 35);
            this.label_PLCAlarmNum.Name = "label_PLCAlarmNum";
            this.label_PLCAlarmNum.Size = new System.Drawing.Size(11, 12);
            this.label_PLCAlarmNum.TabIndex = 49;
            this.label_PLCAlarmNum.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "单片机报警数量：";
            // 
            // label_CardAlarmNum
            // 
            this.label_CardAlarmNum.AutoSize = true;
            this.label_CardAlarmNum.Location = new System.Drawing.Point(364, 35);
            this.label_CardAlarmNum.Name = "label_CardAlarmNum";
            this.label_CardAlarmNum.Size = new System.Drawing.Size(11, 12);
            this.label_CardAlarmNum.TabIndex = 47;
            this.label_CardAlarmNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "报警总数量：";
            // 
            // label_TotalAlarmNum
            // 
            this.label_TotalAlarmNum.AutoSize = true;
            this.label_TotalAlarmNum.Location = new System.Drawing.Point(165, 35);
            this.label_TotalAlarmNum.Name = "label_TotalAlarmNum";
            this.label_TotalAlarmNum.Size = new System.Drawing.Size(11, 12);
            this.label_TotalAlarmNum.TabIndex = 45;
            this.label_TotalAlarmNum.Text = "0";
            // 
            // dateTimePick_End_Alarm
            // 
            this.dateTimePick_End_Alarm.CalendarFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePick_End_Alarm.CustomFormat = "yyyy/MM/dd";
            this.dateTimePick_End_Alarm.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.dateTimePick_End_Alarm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePick_End_Alarm.Location = new System.Drawing.Point(471, 31);
            this.dateTimePick_End_Alarm.Name = "dateTimePick_End_Alarm";
            this.dateTimePick_End_Alarm.Size = new System.Drawing.Size(150, 23);
            this.dateTimePick_End_Alarm.TabIndex = 79;
            // 
            // dataGridView_Alarm
            // 
            this.dataGridView_Alarm.AllowUserToAddRows = false;
            this.dataGridView_Alarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Alarm.Location = new System.Drawing.Point(3, 75);
            this.dataGridView_Alarm.Name = "dataGridView_Alarm";
            this.dataGridView_Alarm.RowTemplate.Height = 23;
            this.dataGridView_Alarm.Size = new System.Drawing.Size(988, 365);
            this.dataGridView_Alarm.TabIndex = 43;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(220, 36);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(65, 12);
            this.label88.TabIndex = 41;
            this.label88.Text = "选择日期：";
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_Maintain);
            this.Name = "AlarmForm";
            this.Size = new System.Drawing.Size(1008, 593);
            this.Load += new System.EventHandler(this.AlarmForm_Load);
            this.tabControl_Maintain.ResumeLayout(false);
            this.tab_Alarm.ResumeLayout(false);
            this.tab_Alarm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Alarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Maintain;
        private System.Windows.Forms.TabPage tab_Alarm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_PLCAlarmNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_CardAlarmNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TotalAlarmNum;
        private System.Windows.Forms.DataGridView dataGridView_Alarm;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_DBAlarmNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_AnotherAlarmNum;
        private System.Windows.Forms.DateTimePicker dateTimePick_Start_Alarm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePick_End_Alarm;
        private System.Windows.Forms.Button btn_Query_Alarm;
    }
}
