using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DisTimeBetweenTown
{
    public partial class MainForm : Form
    {
        string fileName = "";

        string origin = "";
        string destination = "";
        string city = "";

        string originHead = "";
        string destinationHead = "";
        string cityHead = "";

        string duration = "";
        string distance = "";

        int undo_data_count = 0;//未处理数据 

        ArrayList arrayList = new ArrayList();
        DataTable dt;

        Thread objThread;//多线程
        public delegate void UpdateText(string msg);
        public UpdateText updateText;

        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//计时器
        TimeSpan ts;
        string currentCostTime = "";//当前花费时间

        public void updateTextMethod(string msg)
        {
            txb_output.AppendText(msg + "\r\n");
            txb_output.ScrollToCaret();
            lbl_deal_data_count.Text = (pbar.Value<pbar.Maximum?pbar.Value++:pbar.Maximum).ToString();
        }


        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 导入文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_File_Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txb_filename.Text = openFileDialog1.FileName;
                fileName = txb_filename.Text.ToString();
                dt = LoadData.FromExcel(fileName).Tables[0];
                dgv_errorData.DataSource = dt;
                dgv_errorData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_errorData.Show();

                for (int i = 0; i < dt.Columns.Count; ++i)
                {
                    cmb_origin.Items.Add(dt.Columns[i].ColumnName);
                    cmb_destination.Items.Add(dt.Columns[i].ColumnName);
                    cmb_city.Items.Add(dt.Columns[i].ColumnName);
                }

            }
        }
         
        private void function()
        {
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    origin = dt.Rows[i][originHead].ToString() + txb_zone.Text.ToString();
                    destination = dt.Rows[i][destinationHead].ToString() + txb_zone.Text.ToString();
                    city = dt.Rows[i][cityHead].ToString() + txb_zone.Text.ToString();
                    string ori_tmp = origin;
                    string des_tmp = destination;

                    #region deal data
                    try
                    {           
                        var json = LinkAPI.RequestApi(origin, city, destination, city);
                        JObject jo = JObject.Parse(json);
                        while (jo["result"] != null && jo["result"]["routes"] == null)
                        {
                            origin = jo["result"]["origin"]["content"][0]["name"].ToString();
                            destination = jo["result"]["destionation"]["content"][0]["name"].ToString();
                            json = LinkAPI.RequestApi(origin, city, destination, city);
                            jo = JObject.Parse(json);
                        }

                        duration = jo["result"]["routes"][0]["duration"].ToString();
                        distance = jo["result"]["routes"][0]["distance"].ToString();
                        if (this.IsHandleCreated)
                        {
                            this.BeginInvoke(updateText, "序号：" + i + " " + city + " " + ori_tmp + " " + des_tmp + " " +/*origin+" " + destination+*/" 时间：" + duration + " 距离：" + distance);
                            //Thread.Sleep(20);
                        }
                    }
                     catch
                    {
                        undo_data_count++;
                        if (this.IsHandleCreated)
                        {
                            this.BeginInvoke(updateText, "序号：" + i + " " + city + " " + ori_tmp + " " + des_tmp);
                        }
                    }
                        #endregion
                }
                if (this.IsHandleCreated)
                    this.BeginInvoke(updateText, "数据处理结束");
            }
        }

        private void cmb_origin_SelectedIndexChanged(object sender, EventArgs e)
        {
            originHead = cmb_origin.Text.ToString();
        }

        private void cmb_destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinationHead = cmb_destination.Text.ToString();
        }

        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityHead = cmb_city.Text.ToString();
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 开始按钮，启动查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool btnStatus = false;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            //时间计时器            
            sw.Start();
            timer_deal_data.Start();

            //显示进度条
            pbar.Visible = true;
            pbar.Minimum = 0;//设置精度条最小值
            pbar.Maximum = dt.Rows.Count;//设置精度条最大值

            //信息显示
            lbl_all_data__count.Text = dt.Rows.Count.ToString();


            //多线程处理数据
            objThread = new Thread(function);
            objThread.Start();

            btn_start.Enabled = false;
        }

        /// <summary>
        /// 计时器显示时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_deal_data_Tick(object sender, EventArgs e)
        {
            ts = sw.Elapsed;//获取当前测量的总运行时间
            currentCostTime = string.Format(
                "{0}天{1}时{2}分{3}秒{4}毫秒",
                ts.Days,
                ts.Hours,
                ts.Minutes,
                ts.Seconds,
                ts.Milliseconds
                );
            lbl_cost_time.Text = currentCostTime;
        }

        /// <summary>
        /// 暂停处理，挂起线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            sw.Stop();
            lbl_cost_time.Text = currentCostTime;
            if (objThread.ThreadState == ThreadState.Running)
                objThread.Suspend();//挂起线程
        }

        /// <summary>
        /// 执行线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_resume_Click(object sender, EventArgs e)
        {
            if (objThread.ThreadState == ThreadState.Suspended)
                objThread.Resume();//重新执行线程
            sw.Start();
        }

        /// <summary>
        /// 取消开始执行的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            dt.Clear();
            txb_output.Text = "";
            sw.Reset();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateText = new UpdateText(updateTextMethod);
        }
    }
}
