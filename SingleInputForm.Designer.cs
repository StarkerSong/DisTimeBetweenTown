namespace DisTimeBetweenTown
{
    partial class SingleInputForm
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
            this.gb_basic = new System.Windows.Forms.GroupBox();
            this.lab_single_output = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_city = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_origin = new System.Windows.Forms.TextBox();
            this.txb_destination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_basic.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_basic
            // 
            this.gb_basic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_basic.Controls.Add(this.lab_single_output);
            this.gb_basic.Controls.Add(this.btn_submit);
            this.gb_basic.Controls.Add(this.label1);
            this.gb_basic.Controls.Add(this.txb_city);
            this.gb_basic.Controls.Add(this.label3);
            this.gb_basic.Controls.Add(this.txb_origin);
            this.gb_basic.Controls.Add(this.txb_destination);
            this.gb_basic.Controls.Add(this.label2);
            this.gb_basic.Location = new System.Drawing.Point(6, 5);
            this.gb_basic.Name = "gb_basic";
            this.gb_basic.Size = new System.Drawing.Size(634, 244);
            this.gb_basic.TabIndex = 9;
            this.gb_basic.TabStop = false;
            this.gb_basic.Text = "单个查询";
            this.gb_basic.Enter += new System.EventHandler(this.gb_basic_Enter);
            // 
            // lab_single_output
            // 
            this.lab_single_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_single_output.AutoSize = true;
            this.lab_single_output.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_single_output.ForeColor = System.Drawing.Color.Red;
            this.lab_single_output.Location = new System.Drawing.Point(77, 218);
            this.lab_single_output.Name = "lab_single_output";
            this.lab_single_output.Size = new System.Drawing.Size(19, 12);
            this.lab_single_output.TabIndex = 8;
            this.lab_single_output.Text = "  ";
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submit.Location = new System.Drawing.Point(504, 52);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(124, 128);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "确定";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "出发点:";
            // 
            // txb_city
            // 
            this.txb_city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_city.Location = new System.Drawing.Point(18, 159);
            this.txb_city.Name = "txb_city";
            this.txb_city.Size = new System.Drawing.Size(467, 21);
            this.txb_city.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "城市名:";
            // 
            // txb_origin
            // 
            this.txb_origin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_origin.Location = new System.Drawing.Point(18, 52);
            this.txb_origin.Name = "txb_origin";
            this.txb_origin.Size = new System.Drawing.Size(467, 21);
            this.txb_origin.TabIndex = 3;
            // 
            // txb_destination
            // 
            this.txb_destination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_destination.Location = new System.Drawing.Point(18, 106);
            this.txb_destination.Name = "txb_destination";
            this.txb_destination.Size = new System.Drawing.Size(467, 21);
            this.txb_destination.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "目的地:";
            // 
            // SingleInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 258);
            this.Controls.Add(this.gb_basic);
            this.Name = "SingleInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单个添加";
            this.gb_basic.ResumeLayout(false);
            this.gb_basic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_basic;
        private System.Windows.Forms.Label lab_single_output;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_origin;
        private System.Windows.Forms.TextBox txb_destination;
        private System.Windows.Forms.Label label2;
    }
}