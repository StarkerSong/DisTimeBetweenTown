namespace DisTimeBetweenTown
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_file_browse = new System.Windows.Forms.Button();
            this.txb_filename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_origin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_destination = new System.Windows.Forms.ComboBox();
            this.txb_zone = new System.Windows.Forms.TextBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_basic = new System.Windows.Forms.GroupBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.dgv_errorData = new System.Windows.Forms.DataGridView();
            this.txb_output = new System.Windows.Forms.TextBox();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_cost_time = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_deal_data_count = new System.Windows.Forms.Label();
            this.lbl_all_data__count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer_deal_data = new System.Windows.Forms.Timer(this.components);
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_basic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_errorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(439, 32);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(55, 44);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_file_browse
            // 
            this.btn_file_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_file_browse.Location = new System.Drawing.Point(491, 44);
            this.btn_file_browse.Name = "btn_file_browse";
            this.btn_file_browse.Size = new System.Drawing.Size(78, 26);
            this.btn_file_browse.TabIndex = 4;
            this.btn_file_browse.Text = "浏览";
            this.btn_file_browse.UseVisualStyleBackColor = true;
            this.btn_file_browse.Click += new System.EventHandler(this.btn_File_Browse_Click);
            // 
            // txb_filename
            // 
            this.txb_filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_filename.Location = new System.Drawing.Point(20, 44);
            this.txb_filename.Name = "txb_filename";
            this.txb_filename.Size = new System.Drawing.Size(458, 21);
            this.txb_filename.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "选择文件:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_file_browse);
            this.groupBox1.Controls.Add(this.txb_filename);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 76);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "批量查询";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "目的地:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "城市名:";
            // 
            // cmb_origin
            // 
            this.cmb_origin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_origin.FormattingEnabled = true;
            this.cmb_origin.Location = new System.Drawing.Point(20, 48);
            this.cmb_origin.Name = "cmb_origin";
            this.cmb_origin.Size = new System.Drawing.Size(180, 20);
            this.cmb_origin.TabIndex = 13;
            this.cmb_origin.SelectedIndexChanged += new System.EventHandler(this.cmb_origin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "出发点:";
            // 
            // cmb_destination
            // 
            this.cmb_destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_destination.FormattingEnabled = true;
            this.cmb_destination.Location = new System.Drawing.Point(234, 48);
            this.cmb_destination.Name = "cmb_destination";
            this.cmb_destination.Size = new System.Drawing.Size(180, 20);
            this.cmb_destination.TabIndex = 14;
            this.cmb_destination.SelectedIndexChanged += new System.EventHandler(this.cmb_destination_SelectedIndexChanged);
            // 
            // txb_zone
            // 
            this.txb_zone.Location = new System.Drawing.Point(234, 93);
            this.txb_zone.Name = "txb_zone";
            this.txb_zone.Size = new System.Drawing.Size(180, 21);
            this.txb_zone.TabIndex = 7;
            // 
            // cmb_city
            // 
            this.cmb_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(20, 96);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(180, 20);
            this.cmb_city.TabIndex = 15;
            this.cmb_city.SelectedIndexChanged += new System.EventHandler(this.cmb_city_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "地区后缀:";
            // 
            // gb_basic
            // 
            this.gb_basic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_basic.Controls.Add(this.btn_cancel);
            this.gb_basic.Controls.Add(this.btn_resume);
            this.gb_basic.Controls.Add(this.btn_stop);
            this.gb_basic.Controls.Add(this.btn_start);
            this.gb_basic.Controls.Add(this.label5);
            this.gb_basic.Controls.Add(this.cmb_city);
            this.gb_basic.Controls.Add(this.txb_zone);
            this.gb_basic.Controls.Add(this.cmb_destination);
            this.gb_basic.Controls.Add(this.label1);
            this.gb_basic.Controls.Add(this.cmb_origin);
            this.gb_basic.Controls.Add(this.label3);
            this.gb_basic.Controls.Add(this.label2);
            this.gb_basic.Location = new System.Drawing.Point(4, 91);
            this.gb_basic.Name = "gb_basic";
            this.gb_basic.Size = new System.Drawing.Size(574, 147);
            this.gb_basic.TabIndex = 14;
            this.gb_basic.TabStop = false;
            this.gb_basic.Text = "地区设置";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(439, 80);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(55, 44);
            this.btn_stop.TabIndex = 16;
            this.btn_stop.Text = "暂停";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // dgv_errorData
            // 
            this.dgv_errorData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_errorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_errorData.Location = new System.Drawing.Point(4, 244);
            this.dgv_errorData.Name = "dgv_errorData";
            this.dgv_errorData.RowTemplate.Height = 23;
            this.dgv_errorData.Size = new System.Drawing.Size(574, 108);
            this.dgv_errorData.TabIndex = 12;
            // 
            // txb_output
            // 
            this.txb_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_output.Location = new System.Drawing.Point(4, 411);
            this.txb_output.Multiline = true;
            this.txb_output.Name = "txb_output";
            this.txb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_output.Size = new System.Drawing.Size(574, 76);
            this.txb_output.TabIndex = 15;
            // 
            // pbar
            // 
            this.pbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbar.Location = new System.Drawing.Point(0, 487);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(580, 23);
            this.pbar.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbl_cost_time);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbl_deal_data_count);
            this.groupBox2.Controls.Add(this.lbl_all_data__count);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(4, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 47);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息显示";
            // 
            // lbl_cost_time
            // 
            this.lbl_cost_time.AutoSize = true;
            this.lbl_cost_time.Location = new System.Drawing.Point(384, 21);
            this.lbl_cost_time.Name = "lbl_cost_time";
            this.lbl_cost_time.Size = new System.Drawing.Size(11, 12);
            this.lbl_cost_time.TabIndex = 6;
            this.lbl_cost_time.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "处理时间：";
            // 
            // lbl_deal_data_count
            // 
            this.lbl_deal_data_count.AutoSize = true;
            this.lbl_deal_data_count.Location = new System.Drawing.Point(238, 21);
            this.lbl_deal_data_count.Name = "lbl_deal_data_count";
            this.lbl_deal_data_count.Size = new System.Drawing.Size(11, 12);
            this.lbl_deal_data_count.TabIndex = 4;
            this.lbl_deal_data_count.Text = "0";
            // 
            // lbl_all_data__count
            // 
            this.lbl_all_data__count.AutoSize = true;
            this.lbl_all_data__count.Location = new System.Drawing.Point(86, 21);
            this.lbl_all_data__count.Name = "lbl_all_data__count";
            this.lbl_all_data__count.Size = new System.Drawing.Size(11, 12);
            this.lbl_all_data__count.TabIndex = 3;
            this.lbl_all_data__count.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "处理数据：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "总数据量：";
            // 
            // timer_deal_data
            // 
            this.timer_deal_data.Interval = 10;
            this.timer_deal_data.Tick += new System.EventHandler(this.timer_deal_data_Tick);
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(510, 80);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(55, 44);
            this.btn_resume.TabIndex = 17;
            this.btn_resume.Text = "继续";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(510, 32);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(55, 44);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.txb_output);
            this.Controls.Add(this.gb_basic);
            this.Controls.Add(this.dgv_errorData);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_basic.ResumeLayout(false);
            this.gb_basic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_errorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_file_browse;
        private System.Windows.Forms.TextBox txb_filename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_origin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_destination;
        private System.Windows.Forms.TextBox txb_zone;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_basic;
        private System.Windows.Forms.DataGridView dgv_errorData;
        private System.Windows.Forms.TextBox txb_output;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_cost_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_deal_data_count;
        private System.Windows.Forms.Label lbl_all_data__count;
        private System.Windows.Forms.Timer timer_deal_data;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_cancel;
    }
}