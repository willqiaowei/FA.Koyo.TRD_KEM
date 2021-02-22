namespace FA.Koyo.TRD_KEM.UI
{
    partial class OperationForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Start = new System.Windows.Forms.Button();
            this.Tab_OpMain = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_flowStatus = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.led_Status = new FA.Koyo.TRD_KEM.UI.LED();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.led_ErasureAll = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Write_Calibration = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Init = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Read_Protect = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Write_Calibration2 = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Init3 = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Init2 = new FA.Koyo.TRD_KEM.UI.LED();
            this.led_Write_User_Procedure = new FA.Koyo.TRD_KEM.UI.LED();
            this.label16 = new System.Windows.Forms.Label();
            this.led_ErasurePart = new FA.Koyo.TRD_KEM.UI.LED();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.led_Motor_Positive = new FA.Koyo.TRD_KEM.UI.LED();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.led_Motor_Reverse = new FA.Koyo.TRD_KEM.UI.LED();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar_Total = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_selectProduct = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tabControlOperation = new System.Windows.Forms.TabControl();
            this.backgroundWorker_CheckPLC = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.Tab_OpMain.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btn_Start);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(773, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 593);
            this.panel2.TabIndex = 16;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Start.Font = new System.Drawing.Font("宋体", 19F, System.Drawing.FontStyle.Bold);
            this.btn_Start.Image = global::FA.Koyo.TRD_KEM.Properties.Resources.start;
            this.btn_Start.Location = new System.Drawing.Point(30, 29);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(170, 100);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "开始";
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Tab_OpMain
            // 
            this.Tab_OpMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_OpMain.Controls.Add(this.groupBox9);
            this.Tab_OpMain.Controls.Add(this.panel3);
            this.Tab_OpMain.Controls.Add(this.panel1);
            this.Tab_OpMain.Location = new System.Drawing.Point(4, 29);
            this.Tab_OpMain.Name = "Tab_OpMain";
            this.Tab_OpMain.Size = new System.Drawing.Size(769, 530);
            this.Tab_OpMain.TabIndex = 0;
            this.Tab_OpMain.Text = "主界面";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label_Result);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(483, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(276, 211);
            this.groupBox9.TabIndex = 34;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "结果";
            // 
            // label_Result
            // 
            this.label_Result.BackColor = System.Drawing.SystemColors.Control;
            this.label_Result.Font = new System.Drawing.Font("宋体", 122F, System.Drawing.FontStyle.Bold);
            this.label_Result.Location = new System.Drawing.Point(8, 16);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(262, 192);
            this.label_Result.TabIndex = 23;
            this.label_Result.Text = "OK";
            this.label_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.progressBar_Total);
            this.panel3.Location = new System.Drawing.Point(3, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 453);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.9776F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.0224F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 405);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(477, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 389);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_flowStatus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 121);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态";
            // 
            // lab_flowStatus
            // 
            this.lab_flowStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lab_flowStatus.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_flowStatus.Location = new System.Drawing.Point(8, 49);
            this.lab_flowStatus.Name = "lab_flowStatus";
            this.lab_flowStatus.Size = new System.Drawing.Size(262, 32);
            this.lab_flowStatus.TabIndex = 22;
            this.lab_flowStatus.Text = "label7";
            this.lab_flowStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.led_Status);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 111);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LED";
            // 
            // led_Status
            // 
            this.led_Status.BackColor = System.Drawing.SystemColors.Control;
            this.led_Status.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Status.BorderWidth = 2;
            this.led_Status.CenterColor = System.Drawing.Color.Gray;
            this.led_Status.Distance = 4;
            this.led_Status.GridentColor = System.Drawing.Color.Gray;
            this.led_Status.Location = new System.Drawing.Point(139, 41);
            this.led_Status.Name = "led_Status";
            this.led_Status.Size = new System.Drawing.Size(30, 30);
            this.led_Status.TabIndex = 151;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 150;
            this.label1.Text = "产品LED状态：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 383);
            this.panel4.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.led_ErasureAll);
            this.groupBox2.Controls.Add(this.led_Write_Calibration);
            this.groupBox2.Controls.Add(this.led_Init);
            this.groupBox2.Controls.Add(this.led_Read_Protect);
            this.groupBox2.Controls.Add(this.led_Write_Calibration2);
            this.groupBox2.Controls.Add(this.led_Init3);
            this.groupBox2.Controls.Add(this.led_Init2);
            this.groupBox2.Controls.Add(this.led_Write_User_Procedure);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.led_ErasurePart);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.led_Motor_Positive);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.led_Motor_Reverse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 382);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试单元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 128;
            this.label7.Text = "初始化：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 148;
            this.label2.Text = "写入校准文件：";
            // 
            // led_ErasureAll
            // 
            this.led_ErasureAll.BackColor = System.Drawing.SystemColors.Control;
            this.led_ErasureAll.BordeColor = System.Drawing.SystemColors.Control;
            this.led_ErasureAll.BorderWidth = 2;
            this.led_ErasureAll.CenterColor = System.Drawing.Color.Gray;
            this.led_ErasureAll.Distance = 4;
            this.led_ErasureAll.GridentColor = System.Drawing.Color.Gray;
            this.led_ErasureAll.Location = new System.Drawing.Point(169, 75);
            this.led_ErasureAll.Name = "led_ErasureAll";
            this.led_ErasureAll.Size = new System.Drawing.Size(30, 30);
            this.led_ErasureAll.TabIndex = 133;
            // 
            // led_Write_Calibration
            // 
            this.led_Write_Calibration.BackColor = System.Drawing.SystemColors.Control;
            this.led_Write_Calibration.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Write_Calibration.BorderWidth = 2;
            this.led_Write_Calibration.CenterColor = System.Drawing.Color.Gray;
            this.led_Write_Calibration.Distance = 4;
            this.led_Write_Calibration.GridentColor = System.Drawing.Color.Gray;
            this.led_Write_Calibration.Location = new System.Drawing.Point(169, 41);
            this.led_Write_Calibration.Name = "led_Write_Calibration";
            this.led_Write_Calibration.Size = new System.Drawing.Size(30, 30);
            this.led_Write_Calibration.TabIndex = 149;
            // 
            // led_Init
            // 
            this.led_Init.BackColor = System.Drawing.SystemColors.Control;
            this.led_Init.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Init.BorderWidth = 2;
            this.led_Init.CenterColor = System.Drawing.Color.Gray;
            this.led_Init.Distance = 4;
            this.led_Init.GridentColor = System.Drawing.Color.Gray;
            this.led_Init.Location = new System.Drawing.Point(169, 8);
            this.led_Init.Name = "led_Init";
            this.led_Init.Size = new System.Drawing.Size(30, 30);
            this.led_Init.TabIndex = 132;
            // 
            // led_Read_Protect
            // 
            this.led_Read_Protect.BackColor = System.Drawing.SystemColors.Control;
            this.led_Read_Protect.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Read_Protect.BorderWidth = 2;
            this.led_Read_Protect.CenterColor = System.Drawing.Color.Gray;
            this.led_Read_Protect.Distance = 4;
            this.led_Read_Protect.GridentColor = System.Drawing.Color.Gray;
            this.led_Read_Protect.Location = new System.Drawing.Point(169, 350);
            this.led_Read_Protect.Name = "led_Read_Protect";
            this.led_Read_Protect.Size = new System.Drawing.Size(30, 30);
            this.led_Read_Protect.TabIndex = 147;
            // 
            // led_Write_Calibration2
            // 
            this.led_Write_Calibration2.BackColor = System.Drawing.SystemColors.Control;
            this.led_Write_Calibration2.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Write_Calibration2.BorderWidth = 2;
            this.led_Write_Calibration2.CenterColor = System.Drawing.Color.Gray;
            this.led_Write_Calibration2.Distance = 4;
            this.led_Write_Calibration2.GridentColor = System.Drawing.Color.Gray;
            this.led_Write_Calibration2.Location = new System.Drawing.Point(169, 110);
            this.led_Write_Calibration2.Name = "led_Write_Calibration2";
            this.led_Write_Calibration2.Size = new System.Drawing.Size(30, 30);
            this.led_Write_Calibration2.TabIndex = 134;
            // 
            // led_Init3
            // 
            this.led_Init3.BackColor = System.Drawing.SystemColors.Control;
            this.led_Init3.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Init3.BorderWidth = 2;
            this.led_Init3.CenterColor = System.Drawing.Color.Gray;
            this.led_Init3.Distance = 4;
            this.led_Init3.GridentColor = System.Drawing.Color.Gray;
            this.led_Init3.Location = new System.Drawing.Point(169, 315);
            this.led_Init3.Name = "led_Init3";
            this.led_Init3.Size = new System.Drawing.Size(30, 30);
            this.led_Init3.TabIndex = 146;
            // 
            // led_Init2
            // 
            this.led_Init2.BackColor = System.Drawing.SystemColors.Control;
            this.led_Init2.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Init2.BorderWidth = 2;
            this.led_Init2.CenterColor = System.Drawing.Color.Gray;
            this.led_Init2.Distance = 4;
            this.led_Init2.GridentColor = System.Drawing.Color.Gray;
            this.led_Init2.Location = new System.Drawing.Point(169, 145);
            this.led_Init2.Name = "led_Init2";
            this.led_Init2.Size = new System.Drawing.Size(30, 30);
            this.led_Init2.TabIndex = 135;
            // 
            // led_Write_User_Procedure
            // 
            this.led_Write_User_Procedure.BackColor = System.Drawing.SystemColors.Control;
            this.led_Write_User_Procedure.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Write_User_Procedure.BorderWidth = 2;
            this.led_Write_User_Procedure.CenterColor = System.Drawing.Color.Gray;
            this.led_Write_User_Procedure.Distance = 4;
            this.led_Write_User_Procedure.GridentColor = System.Drawing.Color.Gray;
            this.led_Write_User_Procedure.Location = new System.Drawing.Point(169, 281);
            this.led_Write_User_Procedure.Name = "led_Write_User_Procedure";
            this.led_Write_User_Procedure.Size = new System.Drawing.Size(30, 30);
            this.led_Write_User_Procedure.TabIndex = 145;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(93, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 131;
            this.label16.Text = "初始化：";
            // 
            // led_ErasurePart
            // 
            this.led_ErasurePart.BackColor = System.Drawing.SystemColors.Control;
            this.led_ErasurePart.BordeColor = System.Drawing.SystemColors.Control;
            this.led_ErasurePart.BorderWidth = 2;
            this.led_ErasurePart.CenterColor = System.Drawing.Color.Gray;
            this.led_ErasurePart.Distance = 4;
            this.led_ErasurePart.GridentColor = System.Drawing.Color.Gray;
            this.led_ErasurePart.Location = new System.Drawing.Point(169, 248);
            this.led_ErasurePart.Name = "led_ErasurePart";
            this.led_ErasurePart.Size = new System.Drawing.Size(30, 30);
            this.led_ErasurePart.TabIndex = 144;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 130;
            this.label15.Text = "写入校准文件：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 140;
            this.label11.Text = "部分擦除：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 129;
            this.label10.Text = "全部擦除：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 141;
            this.label12.Text = "写入用户程序：";
            // 
            // led_Motor_Positive
            // 
            this.led_Motor_Positive.BackColor = System.Drawing.SystemColors.Control;
            this.led_Motor_Positive.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Motor_Positive.BorderWidth = 2;
            this.led_Motor_Positive.CenterColor = System.Drawing.Color.Gray;
            this.led_Motor_Positive.Distance = 4;
            this.led_Motor_Positive.GridentColor = System.Drawing.Color.Gray;
            this.led_Motor_Positive.Location = new System.Drawing.Point(169, 178);
            this.led_Motor_Positive.Name = "led_Motor_Positive";
            this.led_Motor_Positive.Size = new System.Drawing.Size(30, 30);
            this.led_Motor_Positive.TabIndex = 137;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 142;
            this.label13.Text = "初始化：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 136;
            this.label6.Text = "电机正转：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(93, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 143;
            this.label14.Text = "读保护：";
            // 
            // led_Motor_Reverse
            // 
            this.led_Motor_Reverse.BackColor = System.Drawing.SystemColors.Control;
            this.led_Motor_Reverse.BordeColor = System.Drawing.SystemColors.Control;
            this.led_Motor_Reverse.BorderWidth = 2;
            this.led_Motor_Reverse.CenterColor = System.Drawing.Color.Gray;
            this.led_Motor_Reverse.Distance = 4;
            this.led_Motor_Reverse.GridentColor = System.Drawing.Color.Gray;
            this.led_Motor_Reverse.Location = new System.Drawing.Point(169, 212);
            this.led_Motor_Reverse.Name = "led_Motor_Reverse";
            this.led_Motor_Reverse.Size = new System.Drawing.Size(30, 30);
            this.led_Motor_Reverse.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 138;
            this.label4.Text = "电机反转：";
            // 
            // progressBar_Total
            // 
            this.progressBar_Total.Location = new System.Drawing.Point(4, 406);
            this.progressBar_Total.Name = "progressBar_Total";
            this.progressBar_Total.Size = new System.Drawing.Size(753, 25);
            this.progressBar_Total.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.comboBox_selectProduct);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 52);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_selectProduct
            // 
            this.comboBox_selectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_selectProduct.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_selectProduct.FormattingEnabled = true;
            this.comboBox_selectProduct.Items.AddRange(new object[] {
            "KEM40"});
            this.comboBox_selectProduct.Location = new System.Drawing.Point(174, 10);
            this.comboBox_selectProduct.Name = "comboBox_selectProduct";
            this.comboBox_selectProduct.Size = new System.Drawing.Size(294, 28);
            this.comboBox_selectProduct.TabIndex = 63;
            this.comboBox_selectProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectProduct_SelectedIndexChanged);
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label37.Location = new System.Drawing.Point(55, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(85, 16);
            this.label37.TabIndex = 62;
            this.label37.Text = "产品选择:";
            // 
            // tabControlOperation
            // 
            this.tabControlOperation.Controls.Add(this.Tab_OpMain);
            this.tabControlOperation.Font = new System.Drawing.Font("宋体", 9F);
            this.tabControlOperation.ItemSize = new System.Drawing.Size(60, 25);
            this.tabControlOperation.Location = new System.Drawing.Point(0, 0);
            this.tabControlOperation.Name = "tabControlOperation";
            this.tabControlOperation.SelectedIndex = 0;
            this.tabControlOperation.Size = new System.Drawing.Size(777, 563);
            this.tabControlOperation.TabIndex = 15;
            // 
            // backgroundWorker_CheckPLC
            // 
            this.backgroundWorker_CheckPLC.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_CheckPLC_DoWork);
            // 
            // OperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControlOperation);
            this.Name = "OperationForm";
            this.Size = new System.Drawing.Size(1008, 593);
            this.Load += new System.EventHandler(this.OperationForm_Load);
            this.panel2.ResumeLayout(false);
            this.Tab_OpMain.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage Tab_OpMain;
        private System.Windows.Forms.TabControl tabControlOperation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_selectProduct;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_flowStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.ProgressBar progressBar_Total;
        private System.Windows.Forms.Panel panel4;
        private LED led_Read_Protect;
        private LED led_Init3;
        private LED led_Write_User_Procedure;
        private LED led_ErasurePart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private LED led_Motor_Reverse;
        private System.Windows.Forms.Label label6;
        private LED led_Motor_Positive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private LED led_Init2;
        private LED led_Write_Calibration2;
        private LED led_Init;
        private LED led_ErasureAll;
        private System.Windows.Forms.Label label2;
        private LED led_Write_Calibration;
        private System.Windows.Forms.GroupBox groupBox2;
        private LED led_Status;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_CheckPLC;
    }
}
