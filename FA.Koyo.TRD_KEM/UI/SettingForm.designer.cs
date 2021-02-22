namespace FA.Koyo.TRD_KEM.UI
{
    partial class SettingForm
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
            this.backgroundWorker_UpdateSetting = new System.ComponentModel.BackgroundWorker();
            this.tabParameter = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_STLink = new System.Windows.Forms.TextBox();
            this.btn_Command_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_ErasurePart = new System.Windows.Forms.TextBox();
            this.TextBox_Read_Protect = new System.Windows.Forms.TextBox();
            this.TextBox_Write_User_Procedure = new System.Windows.Forms.TextBox();
            this.TextBox_Write_Calibration = new System.Windows.Forms.TextBox();
            this.TextBox_ErasureAll = new System.Windows.Forms.TextBox();
            this.TextBox_Init = new System.Windows.Forms.TextBox();
            this.tabPLC_IO = new System.Windows.Forms.TabPage();
            this.led_Down = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Up = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Rear = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Front = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Motor_Reverse = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Motor_Positive = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Stop = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Start = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Underdraught = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Clamp = new FA.Koyo.TRD_KEM.UI.LED();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.btn_Underdraught = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Motor_Reverse = new System.Windows.Forms.Button();
            this.btn_Motor_Positive = new System.Windows.Forms.Button();
            this.btn_Clamp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabParameter.SuspendLayout();
            this.tabPLC_IO.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker_UpdateSetting
            // 
            this.backgroundWorker_UpdateSetting.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_UpdateSetting_DoWork);
            // 
            // tabParameter
            // 
            this.tabParameter.Controls.Add(this.label4);
            this.tabParameter.Controls.Add(this.TextBox_STLink);
            this.tabParameter.Controls.Add(this.btn_Command_Save);
            this.tabParameter.Controls.Add(this.label8);
            this.tabParameter.Controls.Add(this.label6);
            this.tabParameter.Controls.Add(this.label5);
            this.tabParameter.Controls.Add(this.label3);
            this.tabParameter.Controls.Add(this.label2);
            this.tabParameter.Controls.Add(this.label1);
            this.tabParameter.Controls.Add(this.TextBox_ErasurePart);
            this.tabParameter.Controls.Add(this.TextBox_Read_Protect);
            this.tabParameter.Controls.Add(this.TextBox_Write_User_Procedure);
            this.tabParameter.Controls.Add(this.TextBox_Write_Calibration);
            this.tabParameter.Controls.Add(this.TextBox_ErasureAll);
            this.tabParameter.Controls.Add(this.TextBox_Init);
            this.tabParameter.Location = new System.Drawing.Point(4, 29);
            this.tabParameter.Name = "tabParameter";
            this.tabParameter.Size = new System.Drawing.Size(994, 521);
            this.tabParameter.TabIndex = 5;
            this.tabParameter.Text = "指令设定";
            this.tabParameter.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.Location = new System.Drawing.Point(287, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 75;
            this.label4.Text = "ST-Link：";
            // 
            // TextBox_STLink
            // 
            this.TextBox_STLink.Location = new System.Drawing.Point(368, 23);
            this.TextBox_STLink.Name = "TextBox_STLink";
            this.TextBox_STLink.Size = new System.Drawing.Size(369, 21);
            this.TextBox_STLink.TabIndex = 74;
            // 
            // btn_Command_Save
            // 
            this.btn_Command_Save.Location = new System.Drawing.Point(447, 387);
            this.btn_Command_Save.Name = "btn_Command_Save";
            this.btn_Command_Save.Size = new System.Drawing.Size(100, 40);
            this.btn_Command_Save.TabIndex = 73;
            this.btn_Command_Save.Text = "保存";
            this.btn_Command_Save.UseVisualStyleBackColor = true;
            this.btn_Command_Save.Click += new System.EventHandler(this.btn_Command_Save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F);
            this.label8.Location = new System.Drawing.Point(293, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 72;
            this.label8.Text = "读保护：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F);
            this.label6.Location = new System.Drawing.Point(257, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 70;
            this.label6.Text = "写入用户程序：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(281, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 69;
            this.label5.Text = "部分擦除：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(257, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 67;
            this.label3.Text = "写入校准文件：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(281, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 66;
            this.label2.Text = "全部擦除：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(293, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 65;
            this.label1.Text = "初始化：";
            // 
            // TextBox_ErasurePart
            // 
            this.TextBox_ErasurePart.Location = new System.Drawing.Point(369, 203);
            this.TextBox_ErasurePart.Name = "TextBox_ErasurePart";
            this.TextBox_ErasurePart.Size = new System.Drawing.Size(368, 21);
            this.TextBox_ErasurePart.TabIndex = 61;
            // 
            // TextBox_Read_Protect
            // 
            this.TextBox_Read_Protect.Location = new System.Drawing.Point(368, 293);
            this.TextBox_Read_Protect.Name = "TextBox_Read_Protect";
            this.TextBox_Read_Protect.Size = new System.Drawing.Size(368, 21);
            this.TextBox_Read_Protect.TabIndex = 64;
            // 
            // TextBox_Write_User_Procedure
            // 
            this.TextBox_Write_User_Procedure.Location = new System.Drawing.Point(368, 248);
            this.TextBox_Write_User_Procedure.Name = "TextBox_Write_User_Procedure";
            this.TextBox_Write_User_Procedure.Size = new System.Drawing.Size(368, 21);
            this.TextBox_Write_User_Procedure.TabIndex = 62;
            // 
            // TextBox_Write_Calibration
            // 
            this.TextBox_Write_Calibration.Location = new System.Drawing.Point(368, 158);
            this.TextBox_Write_Calibration.Name = "TextBox_Write_Calibration";
            this.TextBox_Write_Calibration.Size = new System.Drawing.Size(368, 21);
            this.TextBox_Write_Calibration.TabIndex = 59;
            // 
            // TextBox_ErasureAll
            // 
            this.TextBox_ErasureAll.Location = new System.Drawing.Point(369, 113);
            this.TextBox_ErasureAll.Name = "TextBox_ErasureAll";
            this.TextBox_ErasureAll.Size = new System.Drawing.Size(368, 21);
            this.TextBox_ErasureAll.TabIndex = 58;
            // 
            // TextBox_Init
            // 
            this.TextBox_Init.Location = new System.Drawing.Point(368, 68);
            this.TextBox_Init.Name = "TextBox_Init";
            this.TextBox_Init.Size = new System.Drawing.Size(369, 21);
            this.TextBox_Init.TabIndex = 57;
            // 
            // tabPLC_IO
            // 
            this.tabPLC_IO.BackColor = System.Drawing.SystemColors.Control;
            this.tabPLC_IO.Controls.Add(this.led_Down);
            this.tabPLC_IO.Controls.Add(this.led_Up);
            this.tabPLC_IO.Controls.Add(this.led_Rear);
            this.tabPLC_IO.Controls.Add(this.led_Front);
            this.tabPLC_IO.Controls.Add(this.led_Motor_Reverse);
            this.tabPLC_IO.Controls.Add(this.led_Motor_Positive);
            this.tabPLC_IO.Controls.Add(this.led_Stop);
            this.tabPLC_IO.Controls.Add(this.led_Start);
            this.tabPLC_IO.Controls.Add(this.led_Underdraught);
            this.tabPLC_IO.Controls.Add(this.led_Clamp);
            this.tabPLC_IO.Controls.Add(this.label59);
            this.tabPLC_IO.Controls.Add(this.label60);
            this.tabPLC_IO.Controls.Add(this.label66);
            this.tabPLC_IO.Controls.Add(this.label68);
            this.tabPLC_IO.Controls.Add(this.btn_Underdraught);
            this.tabPLC_IO.Controls.Add(this.btn_Start);
            this.tabPLC_IO.Controls.Add(this.btn_Stop);
            this.tabPLC_IO.Controls.Add(this.btn_Motor_Reverse);
            this.tabPLC_IO.Controls.Add(this.btn_Motor_Positive);
            this.tabPLC_IO.Controls.Add(this.btn_Clamp);
            this.tabPLC_IO.Location = new System.Drawing.Point(4, 29);
            this.tabPLC_IO.Margin = new System.Windows.Forms.Padding(2);
            this.tabPLC_IO.Name = "tabPLC_IO";
            this.tabPLC_IO.Size = new System.Drawing.Size(994, 521);
            this.tabPLC_IO.TabIndex = 3;
            this.tabPLC_IO.Text = "PLC输入/输出";
            // 
            // led_Down
            // 
            this.led_Down.BackColor = System.Drawing.SystemColors.Control;
            this.led_Down.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Down.BorderWidth = 2;
            this.led_Down.CenterColor = System.Drawing.SystemColors.Control;
            this.led_Down.Distance = 4;
            this.led_Down.GridentColor = System.Drawing.Color.Black;
            this.led_Down.Location = new System.Drawing.Point(377, 176);
            this.led_Down.Name = "led_Down";
            this.led_Down.Size = new System.Drawing.Size(30, 30);
            this.led_Down.TabIndex = 169;
            // 
            // led_Up
            // 
            this.led_Up.BackColor = System.Drawing.SystemColors.Control;
            this.led_Up.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Up.BorderWidth = 2;
            this.led_Up.CenterColor = System.Drawing.SystemColors.Control;
            this.led_Up.Distance = 4;
            this.led_Up.GridentColor = System.Drawing.Color.Black;
            this.led_Up.Location = new System.Drawing.Point(377, 150);
            this.led_Up.Name = "led_Up";
            this.led_Up.Size = new System.Drawing.Size(30, 30);
            this.led_Up.TabIndex = 168;
            // 
            // led_Rear
            // 
            this.led_Rear.BackColor = System.Drawing.SystemColors.Control;
            this.led_Rear.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Rear.BorderWidth = 2;
            this.led_Rear.CenterColor = System.Drawing.SystemColors.Control;
            this.led_Rear.Distance = 4;
            this.led_Rear.GridentColor = System.Drawing.Color.Black;
            this.led_Rear.Location = new System.Drawing.Point(377, 106);
            this.led_Rear.Name = "led_Rear";
            this.led_Rear.Size = new System.Drawing.Size(30, 30);
            this.led_Rear.TabIndex = 167;
            // 
            // led_Front
            // 
            this.led_Front.BackColor = System.Drawing.SystemColors.Control;
            this.led_Front.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Front.BorderWidth = 2;
            this.led_Front.CenterColor = System.Drawing.SystemColors.Control;
            this.led_Front.Distance = 4;
            this.led_Front.GridentColor = System.Drawing.Color.Black;
            this.led_Front.Location = new System.Drawing.Point(377, 79);
            this.led_Front.Name = "led_Front";
            this.led_Front.Size = new System.Drawing.Size(30, 30);
            this.led_Front.TabIndex = 166;
            // 
            // led_Motor_Reverse
            // 
            this.led_Motor_Reverse.BackColor = System.Drawing.SystemColors.Control;
            this.led_Motor_Reverse.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Motor_Reverse.BorderWidth = 2;
            this.led_Motor_Reverse.CenterColor = System.Drawing.SystemColors.Control;
            this.led_Motor_Reverse.Distance = 4;
            this.led_Motor_Reverse.GridentColor = System.Drawing.Color.Black;
            this.led_Motor_Reverse.Location = new System.Drawing.Point(751, 164);
            this.led_Motor_Reverse.Name = "led_Motor_Reverse";
            this.led_Motor_Reverse.Size = new System.Drawing.Size(30, 30);
            this.led_Motor_Reverse.TabIndex = 165;
            // 
            // led_Motor_Positive
            // 
            this.led_Motor_Positive.BackColor = System.Drawing.SystemColors.Control;
            this.led_Motor_Positive.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Motor_Positive.BorderWidth = 2;
            this.led_Motor_Positive.CenterColor = System.Drawing.SystemColors.Control;
            this.led_Motor_Positive.Distance = 4;
            this.led_Motor_Positive.GridentColor = System.Drawing.Color.Black;
            this.led_Motor_Positive.Location = new System.Drawing.Point(751, 92);
            this.led_Motor_Positive.Name = "led_Motor_Positive";
            this.led_Motor_Positive.Size = new System.Drawing.Size(30, 30);
            this.led_Motor_Positive.TabIndex = 164;
            // 
            // led_Stop
            // 
            this.led_Stop.BackColor = System.Drawing.SystemColors.Control;
            this.led_Stop.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Stop.BorderWidth = 2;
            this.led_Stop.CenterColor = System.Drawing.SystemColors.Control;
            this.led_Stop.Distance = 4;
            this.led_Stop.GridentColor = System.Drawing.Color.Black;
            this.led_Stop.Location = new System.Drawing.Point(547, 164);
            this.led_Stop.Name = "led_Stop";
            this.led_Stop.Size = new System.Drawing.Size(30, 30);
            this.led_Stop.TabIndex = 163;
            // 
            // led_Start
            // 
            this.led_Start.BackColor = System.Drawing.SystemColors.Control;
            this.led_Start.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Start.BorderWidth = 2;
            this.led_Start.CenterColor = System.Drawing.SystemColors.Control;
            this.led_Start.Distance = 4;
            this.led_Start.GridentColor = System.Drawing.Color.Black;
            this.led_Start.Location = new System.Drawing.Point(545, 92);
            this.led_Start.Name = "led_Start";
            this.led_Start.Size = new System.Drawing.Size(30, 30);
            this.led_Start.TabIndex = 162;
            // 
            // led_Underdraught
            // 
            this.led_Underdraught.BackColor = System.Drawing.SystemColors.Control;
            this.led_Underdraught.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Underdraught.BorderWidth = 2;
            this.led_Underdraught.CenterColor = System.Drawing.SystemColors.Control;
            this.led_Underdraught.Distance = 4;
            this.led_Underdraught.GridentColor = System.Drawing.Color.Black;
            this.led_Underdraught.Location = new System.Drawing.Point(304, 164);
            this.led_Underdraught.Name = "led_Underdraught";
            this.led_Underdraught.Size = new System.Drawing.Size(30, 30);
            this.led_Underdraught.TabIndex = 161;
            // 
            // led_Clamp
            // 
            this.led_Clamp.BackColor = System.Drawing.SystemColors.Control;
            this.led_Clamp.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Clamp.BorderWidth = 2;
            this.led_Clamp.CenterColor = System.Drawing.SystemColors.Control;
            this.led_Clamp.Distance = 4;
            this.led_Clamp.GridentColor = System.Drawing.Color.Black;
            this.led_Clamp.Location = new System.Drawing.Point(304, 92);
            this.led_Clamp.Name = "led_Clamp";
            this.led_Clamp.Size = new System.Drawing.Size(30, 30);
            this.led_Clamp.TabIndex = 160;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(351, 115);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(29, 12);
            this.label59.TabIndex = 107;
            this.label59.Text = "后位";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(351, 88);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(29, 12);
            this.label60.TabIndex = 106;
            this.label60.Text = "前位";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(351, 185);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(29, 12);
            this.label66.TabIndex = 103;
            this.label66.Text = "下位";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(351, 159);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(29, 12);
            this.label68.TabIndex = 102;
            this.label68.Text = "上位";
            // 
            // btn_Underdraught
            // 
            this.btn_Underdraught.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Underdraught.Location = new System.Drawing.Point(205, 159);
            this.btn_Underdraught.Name = "btn_Underdraught";
            this.btn_Underdraught.Size = new System.Drawing.Size(135, 40);
            this.btn_Underdraught.TabIndex = 100;
            this.btn_Underdraught.Text = " 探针下压气缸";
            this.btn_Underdraught.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Underdraught.UseVisualStyleBackColor = false;
            this.btn_Underdraught.Click += new System.EventHandler(this.btn_Underdraught_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Start.Location = new System.Drawing.Point(494, 87);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(90, 40);
            this.btn_Start.TabIndex = 154;
            this.btn_Start.Text = "  开始";
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Stop.Location = new System.Drawing.Point(494, 159);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(90, 40);
            this.btn_Stop.TabIndex = 155;
            this.btn_Stop.Text = "  停止";
            this.btn_Stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Motor_Reverse
            // 
            this.btn_Motor_Reverse.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Motor_Reverse.Location = new System.Drawing.Point(679, 159);
            this.btn_Motor_Reverse.Name = "btn_Motor_Reverse";
            this.btn_Motor_Reverse.Size = new System.Drawing.Size(110, 40);
            this.btn_Motor_Reverse.TabIndex = 113;
            this.btn_Motor_Reverse.Text = " 马达反转";
            this.btn_Motor_Reverse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Motor_Reverse.UseVisualStyleBackColor = false;
            this.btn_Motor_Reverse.Click += new System.EventHandler(this.btn_Motor_Reverse_Click);
            // 
            // btn_Motor_Positive
            // 
            this.btn_Motor_Positive.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Motor_Positive.Location = new System.Drawing.Point(679, 87);
            this.btn_Motor_Positive.Name = "btn_Motor_Positive";
            this.btn_Motor_Positive.Size = new System.Drawing.Size(110, 40);
            this.btn_Motor_Positive.TabIndex = 112;
            this.btn_Motor_Positive.Text = " 马达正转";
            this.btn_Motor_Positive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Motor_Positive.UseVisualStyleBackColor = false;
            this.btn_Motor_Positive.Click += new System.EventHandler(this.btn_Assembly_Line_Start_Click);
            // 
            // btn_Clamp
            // 
            this.btn_Clamp.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Clamp.Location = new System.Drawing.Point(205, 87);
            this.btn_Clamp.Name = "btn_Clamp";
            this.btn_Clamp.Size = new System.Drawing.Size(135, 40);
            this.btn_Clamp.TabIndex = 99;
            this.btn_Clamp.Text = " 产品夹紧气缸";
            this.btn_Clamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clamp.UseVisualStyleBackColor = false;
            this.btn_Clamp.Click += new System.EventHandler(this.btn_Clamp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabParameter);
            this.tabControl1.Controls.Add(this.tabPLC_IO);
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 25);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 554);
            this.tabControl1.TabIndex = 16;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingForm";
            this.Size = new System.Drawing.Size(1008, 593);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tabParameter.ResumeLayout(false);
            this.tabParameter.PerformLayout();
            this.tabPLC_IO.ResumeLayout(false);
            this.tabPLC_IO.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private LED Press1_LED;
        private LED Press2_LED;
        private LED CatchCylinder2_In_LED;
        private LED CatchCylinder1_In_LED;
        private LED EMO_LED;
        private LED Front_Door_Secure_LED;
        private LED Stop_LED;
        private LED Fool_Proof_LED;
        private LED Start_LED;
        private LED Liquid_Level_Monitor_LED;
        private LED Z_LED;
        private LED Green_LED;
        private LED Yellow_LED;
        private LED Red_LED;
        private LED Nebulization2_LED;
        private LED Start2_LED;
        private LED Start1_LED;
        private LED CatchCylinder2_Back_LED;
        private LED CatchCylinder2_Front_LED;
        private LED CatchCylinder1_Back_LED;
        private LED CatchCylinder1_Front_LED;
        private LED CatchCylinder2_Out_LED;
        private LED CatchCylinder1_Out_LED;
        private LED Cylinder2_DOWN_LED;
        private LED Cylinder2_UP_LED;
        private LED Cylinder1_DOWN_LED;
        private LED Cylinder1_UP_LED;
        private LED Cylinder2_In_LED;
        private LED Cylinder2_Out_LED;
        private LED Cylinder1_In_LED;
        private LED Cylinder1_Out_LED;
        private LED Buzzing_LED;
        private LED Liquid_Waste_Valve_LED;
        private LED Assembly_Line_Back_LED;
        private LED Assembly_Line_Middle_LED;
        private LED Stop_Indicate_LED;
        private LED Start_Indicate_LED;
        private LED PLC_EMO_LED;
        private LED PLC_Front_Door_Secure_LED;
        private LED PLC_Stop_LED;
        private LED Assembly_Line_Send_Front_LED;
        private LED PLC_Start_LED;
        private LED Assembly_Line_Ask_Back_LED;
        private LED Splint_Cylinder_LED;
        private LED Assembly_Line_Ask_LED;
        private LED Assembly_Line_Send_LED;
        private LED Assembly_Line_Start_LED;
        private LED Soak_Cylinder_Back_LED;
        private LED Soak_Cylinder_Front_LED;
        private LED Stop_Cylinder_Back_LED;
        private LED Stop_Cylinder_Front_LED;
        private LED Soak_Cylinder_LED;
        private LED Stop_Cylinder_LED;
        private LED Splint_Cylinder_DOWN_LED;
        private LED Splint_Cylinder_UP_LED;
        public LED Assembly_Line_Front_LED;
        private System.ComponentModel.BackgroundWorker backgroundWorker_UpdateSetting;
        private System.Windows.Forms.TabPage tabParameter;
        private System.Windows.Forms.TabPage tabPLC_IO;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Button btn_Underdraught;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Motor_Reverse;
        private System.Windows.Forms.Button btn_Motor_Positive;
        private System.Windows.Forms.Button btn_Clamp;
        private System.Windows.Forms.TabControl tabControl1;
        private LED led_Underdraught;
        private LED led_Clamp;
        private LED led_Down;
        private LED led_Up;
        private LED led_Rear;
        private LED led_Front;
        private LED led_Motor_Reverse;
        private LED led_Motor_Positive;
        private LED led_Stop;
        private LED led_Start;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox TextBox_ErasurePart;
        internal System.Windows.Forms.TextBox TextBox_Read_Protect;
        internal System.Windows.Forms.TextBox TextBox_Write_User_Procedure;
        internal System.Windows.Forms.TextBox TextBox_Write_Calibration;
        internal System.Windows.Forms.TextBox TextBox_ErasureAll;
        internal System.Windows.Forms.TextBox TextBox_Init;
        private System.Windows.Forms.Button btn_Command_Save;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox TextBox_STLink;
    }
}
