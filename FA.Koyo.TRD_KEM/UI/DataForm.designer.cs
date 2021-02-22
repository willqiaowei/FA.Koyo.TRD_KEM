namespace FA.Koyo.TRD_KEM.UI
{
    partial class DataForm
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
            this.tab_Data = new System.Windows.Forms.TabPage();
            this.btn_Export = new System.Windows.Forms.Button();
            this.comboBox_selectProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Query_Data = new System.Windows.Forms.Button();
            this.dateTimePick_Start_Data = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePick_End_Data = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_Data = new System.Windows.Forms.DataGridView();
            this.label88 = new System.Windows.Forms.Label();
            this.tabControl_Maintain.SuspendLayout();
            this.tab_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Maintain
            // 
            this.tabControl_Maintain.Controls.Add(this.tab_Data);
            this.tabControl_Maintain.ItemSize = new System.Drawing.Size(60, 25);
            this.tabControl_Maintain.Location = new System.Drawing.Point(3, 9);
            this.tabControl_Maintain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Maintain.Name = "tabControl_Maintain";
            this.tabControl_Maintain.SelectedIndex = 0;
            this.tabControl_Maintain.Size = new System.Drawing.Size(1002, 575);
            this.tabControl_Maintain.TabIndex = 17;
            // 
            // tab_Data
            // 
            this.tab_Data.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Data.Controls.Add(this.btn_Export);
            this.tab_Data.Controls.Add(this.comboBox_selectProduct);
            this.tab_Data.Controls.Add(this.label2);
            this.tab_Data.Controls.Add(this.btn_Query_Data);
            this.tab_Data.Controls.Add(this.dateTimePick_Start_Data);
            this.tab_Data.Controls.Add(this.label11);
            this.tab_Data.Controls.Add(this.dateTimePick_End_Data);
            this.tab_Data.Controls.Add(this.dataGridView_Data);
            this.tab_Data.Controls.Add(this.label88);
            this.tab_Data.Location = new System.Drawing.Point(4, 29);
            this.tab_Data.Name = "tab_Data";
            this.tab_Data.Size = new System.Drawing.Size(994, 542);
            this.tab_Data.TabIndex = 7;
            this.tab_Data.Text = "数据";
            // 
            // btn_Export
            // 
            this.btn_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btn_Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Export.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Export.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Export.Location = new System.Drawing.Point(870, 24);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(101, 30);
            this.btn_Export.TabIndex = 216;
            this.btn_Export.Text = "导出";
            this.btn_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // comboBox_selectProduct
            // 
            this.comboBox_selectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_selectProduct.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_selectProduct.FormattingEnabled = true;
            this.comboBox_selectProduct.Location = new System.Drawing.Point(91, 27);
            this.comboBox_selectProduct.Name = "comboBox_selectProduct";
            this.comboBox_selectProduct.Size = new System.Drawing.Size(185, 24);
            this.comboBox_selectProduct.TabIndex = 215;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 214;
            this.label2.Text = "产品筛选：";
            // 
            // btn_Query_Data
            // 
            this.btn_Query_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Query_Data.FlatAppearance.BorderSize = 0;
            this.btn_Query_Data.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btn_Query_Data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Query_Data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Query_Data.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Query_Data.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Query_Data.Location = new System.Drawing.Point(740, 24);
            this.btn_Query_Data.Name = "btn_Query_Data";
            this.btn_Query_Data.Size = new System.Drawing.Size(101, 30);
            this.btn_Query_Data.TabIndex = 213;
            this.btn_Query_Data.Text = "查询";
            this.btn_Query_Data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Query_Data.UseVisualStyleBackColor = true;
            this.btn_Query_Data.Click += new System.EventHandler(this.btn_Query_Data_Click);
            // 
            // dateTimePick_Start_Data
            // 
            this.dateTimePick_Start_Data.Checked = false;
            this.dateTimePick_Start_Data.CustomFormat = "yyyy/MM/dd";
            this.dateTimePick_Start_Data.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.dateTimePick_Start_Data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePick_Start_Data.Location = new System.Drawing.Point(364, 28);
            this.dateTimePick_Start_Data.Name = "dateTimePick_Start_Data";
            this.dateTimePick_Start_Data.Size = new System.Drawing.Size(150, 23);
            this.dateTimePick_Start_Data.TabIndex = 210;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(521, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 212;
            this.label11.Text = "至";
            // 
            // dateTimePick_End_Data
            // 
            this.dateTimePick_End_Data.CalendarFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePick_End_Data.CustomFormat = "yyyy/MM/dd";
            this.dateTimePick_End_Data.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.dateTimePick_End_Data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePick_End_Data.Location = new System.Drawing.Point(544, 28);
            this.dateTimePick_End_Data.Name = "dateTimePick_End_Data";
            this.dateTimePick_End_Data.Size = new System.Drawing.Size(150, 23);
            this.dateTimePick_End_Data.TabIndex = 211;
            // 
            // dataGridView_Data
            // 
            this.dataGridView_Data.AllowUserToAddRows = false;
            this.dataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data.Location = new System.Drawing.Point(3, 75);
            this.dataGridView_Data.Name = "dataGridView_Data";
            this.dataGridView_Data.RowTemplate.Height = 23;
            this.dataGridView_Data.Size = new System.Drawing.Size(988, 365);
            this.dataGridView_Data.TabIndex = 43;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(320, 33);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(41, 12);
            this.label88.TabIndex = 41;
            this.label88.Text = "日期：";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_Maintain);
            this.Name = "DataForm";
            this.Size = new System.Drawing.Size(1008, 593);
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.tabControl_Maintain.ResumeLayout(false);
            this.tab_Data.ResumeLayout(false);
            this.tab_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Maintain;
        private System.Windows.Forms.TabPage tab_Data;
        private System.Windows.Forms.DataGridView dataGridView_Data;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Button btn_Query_Data;
        private System.Windows.Forms.DateTimePicker dateTimePick_Start_Data;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePick_End_Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_selectProduct;
        private System.Windows.Forms.Button btn_Export;
    }
}
