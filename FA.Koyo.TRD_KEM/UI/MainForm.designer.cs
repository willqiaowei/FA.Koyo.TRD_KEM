namespace FA.Koyo.TRD_KEM.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_productType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_alarm = new System.Windows.Forms.Button();
            this.btn_data = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_operation = new System.Windows.Forms.Button();
            this.panel_mainArea = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label_productType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 70);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(873, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version: 1.0.0.0";
            // 
            // label_productType
            // 
            this.label_productType.AutoSize = true;
            this.label_productType.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_productType.ForeColor = System.Drawing.SystemColors.Control;
            this.label_productType.Location = new System.Drawing.Point(421, 22);
            this.label_productType.Name = "label_productType";
            this.label_productType.Size = new System.Drawing.Size(165, 33);
            this.label_productType.TabIndex = 0;
            this.label_productType.Text = "KEM试验器";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_alarm);
            this.panel1.Controls.Add(this.btn_data);
            this.panel1.Controls.Add(this.btn_setting);
            this.panel1.Controls.Add(this.btn_operation);
            this.panel1.Location = new System.Drawing.Point(0, 657);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 46);
            this.panel1.TabIndex = 8;
            // 
            // btn_alarm
            // 
            this.btn_alarm.BackColor = System.Drawing.Color.White;
            this.btn_alarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_alarm.Image = ((System.Drawing.Image)(resources.GetObject("btn_alarm.Image")));
            this.btn_alarm.Location = new System.Drawing.Point(772, 3);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(122, 36);
            this.btn_alarm.TabIndex = 9;
            this.btn_alarm.Text = "报警";
            this.btn_alarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alarm.UseVisualStyleBackColor = false;
            this.btn_alarm.Click += new System.EventHandler(this.btn_alarm_Click);
            // 
            // btn_data
            // 
            this.btn_data.BackColor = System.Drawing.Color.White;
            this.btn_data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_data.Image = ((System.Drawing.Image)(resources.GetObject("btn_data.Image")));
            this.btn_data.Location = new System.Drawing.Point(553, 3);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(122, 36);
            this.btn_data.TabIndex = 9;
            this.btn_data.Text = "数据";
            this.btn_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_data.UseVisualStyleBackColor = false;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.White;
            this.btn_setting.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_setting.Image")));
            this.btn_setting.Location = new System.Drawing.Point(334, 3);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(122, 36);
            this.btn_setting.TabIndex = 9;
            this.btn_setting.Text = "设置";
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_operation
            // 
            this.btn_operation.BackColor = System.Drawing.Color.White;
            this.btn_operation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_operation.Image = ((System.Drawing.Image)(resources.GetObject("btn_operation.Image")));
            this.btn_operation.Location = new System.Drawing.Point(115, 3);
            this.btn_operation.Name = "btn_operation";
            this.btn_operation.Size = new System.Drawing.Size(122, 36);
            this.btn_operation.TabIndex = 0;
            this.btn_operation.Text = "操作";
            this.btn_operation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_operation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_operation.UseVisualStyleBackColor = false;
            this.btn_operation.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // panel_mainArea
            // 
            this.panel_mainArea.Location = new System.Drawing.Point(0, 71);
            this.panel_mainArea.Name = "panel_mainArea";
            this.panel_mainArea.Size = new System.Drawing.Size(1008, 583);
            this.panel_mainArea.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1006, 715);
            this.Controls.Add(this.panel_mainArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1022, 726);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_productType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_operation;
        private System.Windows.Forms.Panel panel_mainArea;
    }
}

