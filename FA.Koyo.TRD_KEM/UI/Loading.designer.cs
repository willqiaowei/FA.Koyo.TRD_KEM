namespace FA.Koyo.TRD_KEM.UI
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar_Load = new System.Windows.Forms.ProgressBar();
            this.richTextBox_Load = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar_Load
            // 
            this.progressBar_Load.Location = new System.Drawing.Point(2, 125);
            this.progressBar_Load.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_Load.Name = "progressBar_Load";
            this.progressBar_Load.Size = new System.Drawing.Size(265, 18);
            this.progressBar_Load.TabIndex = 1;
            // 
            // richTextBox_Load
            // 
            this.richTextBox_Load.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Load.Location = new System.Drawing.Point(3, 145);
            this.richTextBox_Load.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_Load.Name = "richTextBox_Load";
            this.richTextBox_Load.ReadOnly = true;
            this.richTextBox_Load.Size = new System.Drawing.Size(265, 164);
            this.richTextBox_Load.TabIndex = 2;
            this.richTextBox_Load.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FA.Koyo.TRD_KEM.Properties.Resources.KEM;
            this.pictureBox1.Location = new System.Drawing.Point(41, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 310);
            this.Controls.Add(this.richTextBox_Load);
            this.Controls.Add(this.progressBar_Load);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Shown += new System.EventHandler(this.Loading_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar_Load;
        private System.Windows.Forms.RichTextBox richTextBox_Load;
    }
}