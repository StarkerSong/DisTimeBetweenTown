using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisTimeBetweenTown
{
    public partial class SingleInputForm : Form
    {
        string origin = "";
        string destination = "";
        string city = "";

        public SingleInputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 单个查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            origin = txb_origin.Text.Trim().ToString();
            destination = txb_destination.Text.Trim().ToString();
            city = txb_city.Text.Trim().ToString();

            lab_single_output.Text = LinkAPI.Output(origin, destination, city);   
        }

        private void gb_basic_Enter(object sender, EventArgs e)
        {

        }
    }
}
