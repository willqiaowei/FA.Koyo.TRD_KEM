
namespace FA.Koyo.TRD_KEM.UI
{
    partial class Test
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Button_WriteUser = new System.Windows.Forms.Button();
            this.Button_WriteCheck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lab_Status = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Init2 = new System.Windows.Forms.TextBox();
            this.Button_Init2 = new System.Windows.Forms.Button();
            this.textBox_Init3 = new System.Windows.Forms.TextBox();
            this.Button_Init3 = new System.Windows.Forms.Button();
            this.TextBox_ErasurePart = new System.Windows.Forms.TextBox();
            this.Button_ErasurePart = new System.Windows.Forms.Button();
            this.TextBox_Read_Protect = new System.Windows.Forms.TextBox();
            this.TextBox_Write_User_Procedure = new System.Windows.Forms.TextBox();
            this.TextBox_Write_Calibration = new System.Windows.Forms.TextBox();
            this.TextBox_ErasureAll = new System.Windows.Forms.TextBox();
            this.TextBox_Init = new System.Windows.Forms.TextBox();
            this.Button_Read_Protect = new System.Windows.Forms.Button();
            this.Button_Write_User_Procedure = new System.Windows.Forms.Button();
            this.Button_Write_Calibration = new System.Windows.Forms.Button();
            this.Button_ErasureAll = new System.Windows.Forms.Button();
            this.Button_Init = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Button_WriteUser);
            this.tabPage1.Controls.Add(this.Button_WriteCheck);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "自动";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Button_WriteUser
            // 
            this.Button_WriteUser.BackColor = System.Drawing.Color.LightGray;
            this.Button_WriteUser.Font = new System.Drawing.Font("宋体", 10F);
            this.Button_WriteUser.Location = new System.Drawing.Point(332, 157);
            this.Button_WriteUser.Name = "Button_WriteUser";
            this.Button_WriteUser.Size = new System.Drawing.Size(175, 80);
            this.Button_WriteUser.TabIndex = 2;
            this.Button_WriteUser.Text = "第二步：写入用户程序";
            this.Button_WriteUser.UseVisualStyleBackColor = false;
            this.Button_WriteUser.Click += new System.EventHandler(this.Button_WriteUser_Click);
            // 
            // Button_WriteCheck
            // 
            this.Button_WriteCheck.BackColor = System.Drawing.Color.LightGray;
            this.Button_WriteCheck.Font = new System.Drawing.Font("宋体", 10F);
            this.Button_WriteCheck.Location = new System.Drawing.Point(67, 157);
            this.Button_WriteCheck.Name = "Button_WriteCheck";
            this.Button_WriteCheck.Size = new System.Drawing.Size(175, 80);
            this.Button_WriteCheck.TabIndex = 1;
            this.Button_WriteCheck.Text = "第一步：写入校准文件";
            this.Button_WriteCheck.UseVisualStyleBackColor = false;
            this.Button_WriteCheck.Click += new System.EventHandler(this.Button_WriteCheck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lab_Status);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 104);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "流程状态";
            // 
            // Lab_Status
            // 
            this.Lab_Status.BackColor = System.Drawing.SystemColors.Control;
            this.Lab_Status.Font = new System.Drawing.Font("宋体", 12.5F, System.Drawing.FontStyle.Bold);
            this.Lab_Status.Location = new System.Drawing.Point(6, 32);
            this.Lab_Status.Name = "Lab_Status";
            this.Lab_Status.Size = new System.Drawing.Size(538, 49);
            this.Lab_Status.TabIndex = 22;
            this.Lab_Status.Text = "状态";
            this.Lab_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox_Init2);
            this.tabPage2.Controls.Add(this.Button_Init2);
            this.tabPage2.Controls.Add(this.textBox_Init3);
            this.tabPage2.Controls.Add(this.Button_Init3);
            this.tabPage2.Controls.Add(this.TextBox_ErasurePart);
            this.tabPage2.Controls.Add(this.Button_ErasurePart);
            this.tabPage2.Controls.Add(this.TextBox_Read_Protect);
            this.tabPage2.Controls.Add(this.TextBox_Write_User_Procedure);
            this.tabPage2.Controls.Add(this.TextBox_Write_Calibration);
            this.tabPage2.Controls.Add(this.TextBox_ErasureAll);
            this.tabPage2.Controls.Add(this.TextBox_Init);
            this.tabPage2.Controls.Add(this.Button_Read_Protect);
            this.tabPage2.Controls.Add(this.Button_Write_User_Procedure);
            this.tabPage2.Controls.Add(this.Button_Write_Calibration);
            this.tabPage2.Controls.Add(this.Button_ErasureAll);
            this.tabPage2.Controls.Add(this.Button_Init);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "手动";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F);
            this.label8.Location = new System.Drawing.Point(23, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 48;
            this.label8.Text = "8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(23, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 47;
            this.label7.Text = "7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F);
            this.label6.Location = new System.Drawing.Point(23, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 46;
            this.label6.Text = "6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(23, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 45;
            this.label5.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.Location = new System.Drawing.Point(23, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 44;
            this.label4.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 43;
            this.label3.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "1";
            // 
            // textBox_Init2
            // 
            this.textBox_Init2.Location = new System.Drawing.Point(45, 158);
            this.textBox_Init2.Name = "textBox_Init2";
            this.textBox_Init2.Size = new System.Drawing.Size(369, 21);
            this.textBox_Init2.TabIndex = 33;
            this.textBox_Init2.Text = "-RST";
            // 
            // Button_Init2
            // 
            this.Button_Init2.Location = new System.Drawing.Point(438, 153);
            this.Button_Init2.Name = "Button_Init2";
            this.Button_Init2.Size = new System.Drawing.Size(100, 30);
            this.Button_Init2.TabIndex = 13;
            this.Button_Init2.Text = "初始化";
            this.Button_Init2.UseVisualStyleBackColor = true;
            this.Button_Init2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Init3
            // 
            this.textBox_Init3.Location = new System.Drawing.Point(46, 290);
            this.textBox_Init3.Name = "textBox_Init3";
            this.textBox_Init3.Size = new System.Drawing.Size(369, 21);
            this.textBox_Init3.TabIndex = 36;
            this.textBox_Init3.Text = "-RST";
            // 
            // Button_Init3
            // 
            this.Button_Init3.Location = new System.Drawing.Point(439, 285);
            this.Button_Init3.Name = "Button_Init3";
            this.Button_Init3.Size = new System.Drawing.Size(100, 30);
            this.Button_Init3.TabIndex = 16;
            this.Button_Init3.Text = "初始化";
            this.Button_Init3.UseVisualStyleBackColor = true;
            this.Button_Init3.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_ErasurePart
            // 
            this.TextBox_ErasurePart.Location = new System.Drawing.Point(47, 202);
            this.TextBox_ErasurePart.Name = "TextBox_ErasurePart";
            this.TextBox_ErasurePart.Size = new System.Drawing.Size(368, 21);
            this.TextBox_ErasurePart.TabIndex = 34;
            this.TextBox_ErasurePart.Text = "-SE 0 2";
            // 
            // Button_ErasurePart
            // 
            this.Button_ErasurePart.Location = new System.Drawing.Point(439, 197);
            this.Button_ErasurePart.Name = "Button_ErasurePart";
            this.Button_ErasurePart.Size = new System.Drawing.Size(100, 30);
            this.Button_ErasurePart.TabIndex = 14;
            this.Button_ErasurePart.Text = "部分擦除";
            this.Button_ErasurePart.UseVisualStyleBackColor = true;
            this.Button_ErasurePart.Click += new System.EventHandler(this.Button_ErasurePart_Click);
            // 
            // TextBox_Read_Protect
            // 
            this.TextBox_Read_Protect.Location = new System.Drawing.Point(46, 334);
            this.TextBox_Read_Protect.Name = "TextBox_Read_Protect";
            this.TextBox_Read_Protect.Size = new System.Drawing.Size(368, 21);
            this.TextBox_Read_Protect.TabIndex = 37;
            this.TextBox_Read_Protect.Text = "-OB RDP = 1";
            // 
            // TextBox_Write_User_Procedure
            // 
            this.TextBox_Write_User_Procedure.Location = new System.Drawing.Point(46, 246);
            this.TextBox_Write_User_Procedure.Name = "TextBox_Write_User_Procedure";
            this.TextBox_Write_User_Procedure.Size = new System.Drawing.Size(368, 21);
            this.TextBox_Write_User_Procedure.TabIndex = 35;
            this.TextBox_Write_User_Procedure.Text = "-P User-2.bin 0x08000000";
            // 
            // TextBox_Write_Calibration
            // 
            this.TextBox_Write_Calibration.Location = new System.Drawing.Point(46, 114);
            this.TextBox_Write_Calibration.Name = "TextBox_Write_Calibration";
            this.TextBox_Write_Calibration.Size = new System.Drawing.Size(368, 21);
            this.TextBox_Write_Calibration.TabIndex = 32;
            this.TextBox_Write_Calibration.Text = "-P Check-1.bin 0x08000000";
            // 
            // TextBox_ErasureAll
            // 
            this.TextBox_ErasureAll.Location = new System.Drawing.Point(47, 69);
            this.TextBox_ErasureAll.Name = "TextBox_ErasureAll";
            this.TextBox_ErasureAll.Size = new System.Drawing.Size(368, 21);
            this.TextBox_ErasureAll.TabIndex = 31;
            this.TextBox_ErasureAll.Text = "-ME";
            // 
            // TextBox_Init
            // 
            this.TextBox_Init.Location = new System.Drawing.Point(46, 25);
            this.TextBox_Init.Name = "TextBox_Init";
            this.TextBox_Init.Size = new System.Drawing.Size(369, 21);
            this.TextBox_Init.TabIndex = 30;
            this.TextBox_Init.Text = "-RST";
            // 
            // Button_Read_Protect
            // 
            this.Button_Read_Protect.Location = new System.Drawing.Point(439, 329);
            this.Button_Read_Protect.Name = "Button_Read_Protect";
            this.Button_Read_Protect.Size = new System.Drawing.Size(100, 30);
            this.Button_Read_Protect.TabIndex = 17;
            this.Button_Read_Protect.Text = "读保护";
            this.Button_Read_Protect.UseVisualStyleBackColor = true;
            this.Button_Read_Protect.Click += new System.EventHandler(this.Button_Read_Protect_Click);
            // 
            // Button_Write_User_Procedure
            // 
            this.Button_Write_User_Procedure.Location = new System.Drawing.Point(439, 241);
            this.Button_Write_User_Procedure.Name = "Button_Write_User_Procedure";
            this.Button_Write_User_Procedure.Size = new System.Drawing.Size(100, 30);
            this.Button_Write_User_Procedure.TabIndex = 15;
            this.Button_Write_User_Procedure.Text = "写入用户程序";
            this.Button_Write_User_Procedure.UseVisualStyleBackColor = true;
            this.Button_Write_User_Procedure.Click += new System.EventHandler(this.Button_Write_User_Procedure_Click);
            // 
            // Button_Write_Calibration
            // 
            this.Button_Write_Calibration.Location = new System.Drawing.Point(439, 109);
            this.Button_Write_Calibration.Name = "Button_Write_Calibration";
            this.Button_Write_Calibration.Size = new System.Drawing.Size(100, 30);
            this.Button_Write_Calibration.TabIndex = 12;
            this.Button_Write_Calibration.Text = "写入校准文件";
            this.Button_Write_Calibration.UseVisualStyleBackColor = true;
            this.Button_Write_Calibration.Click += new System.EventHandler(this.Button_Write_Calibration_Click);
            // 
            // Button_ErasureAll
            // 
            this.Button_ErasureAll.Location = new System.Drawing.Point(439, 64);
            this.Button_ErasureAll.Name = "Button_ErasureAll";
            this.Button_ErasureAll.Size = new System.Drawing.Size(100, 30);
            this.Button_ErasureAll.TabIndex = 11;
            this.Button_ErasureAll.Text = "全部擦除";
            this.Button_ErasureAll.UseVisualStyleBackColor = true;
            this.Button_ErasureAll.Click += new System.EventHandler(this.Button_Erasure_Click);
            // 
            // Button_Init
            // 
            this.Button_Init.Location = new System.Drawing.Point(439, 20);
            this.Button_Init.Name = "Button_Init";
            this.Button_Init.Size = new System.Drawing.Size(100, 30);
            this.Button_Init.TabIndex = 10;
            this.Button_Init.Text = "初始化";
            this.Button_Init.UseVisualStyleBackColor = true;
            this.Button_Init.Click += new System.EventHandler(this.Button_Init_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 421);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KEM试验器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.TextBox TextBox_Read_Protect;
        internal System.Windows.Forms.TextBox TextBox_Write_User_Procedure;
        internal System.Windows.Forms.TextBox TextBox_Write_Calibration;
        internal System.Windows.Forms.TextBox TextBox_ErasureAll;
        internal System.Windows.Forms.TextBox TextBox_Init;
        internal System.Windows.Forms.Button Button_Read_Protect;
        internal System.Windows.Forms.Button Button_Write_User_Procedure;
        internal System.Windows.Forms.Button Button_Write_Calibration;
        internal System.Windows.Forms.Button Button_ErasureAll;
        internal System.Windows.Forms.Button Button_Init;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lab_Status;
        internal System.Windows.Forms.Button Button_WriteUser;
        internal System.Windows.Forms.Button Button_WriteCheck;
        internal System.Windows.Forms.TextBox TextBox_ErasurePart;
        internal System.Windows.Forms.Button Button_ErasurePart;
        internal System.Windows.Forms.TextBox textBox_Init2;
        internal System.Windows.Forms.Button Button_Init2;
        internal System.Windows.Forms.TextBox textBox_Init3;
        internal System.Windows.Forms.Button Button_Init3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

