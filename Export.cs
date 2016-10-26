using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace map
{
    class Export
    {
        private DataGridView _DataGridView;
        private string _FileName = "";

        public void SetDataGridView(DataGridView g)
        {
            _DataGridView = g;
        }

        public Export(DataGridView g)
        {
            _DataGridView = g;
        }

        public void ExportToTxt()
        {
            System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt文件|*.txt";
            sfd.Title = "导出文本文件";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                if (fileName != "")
                {
                    try
                    {
                        //实例化一个文件流--->与写入文件相关联
                        FileStream fs = new FileStream(fileName, FileMode.Create);
                        //实例化一个StreamWriter-->与fs相关联
                        StreamWriter sw = new StreamWriter(fs);
                        //开始写入
                        //写表头
                        foreach (DataGridViewColumn dgvc in this._DataGridView.Columns)
                        {
                            sw.Write(dgvc.HeaderText + "\t");
                        }
                        sw.WriteLine();
                        //写内容
                        int nRows = this._DataGridView.RowCount;
                        int nCols = this._DataGridView.ColumnCount;
                        for (int i = 0; i < nRows; i++)
                        {
                            for (int j = 0; j < nCols; j++)
                            {
                                sw.Write(this._DataGridView[j, i].Value.ToString() + "\t");
                            }
                            sw.WriteLine();
                        }

                        //清空缓冲区 
                        sw.Flush();
                        //关闭流
                        sw.Close();
                        fs.Close();
                        this.OpenFile(fileName);
                    }
                    catch (System.Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 导出到Excel
        /// </summary>
        /// <param name="pfileName">文件名,不需要带扩展名</param>
        public void ExportToExcel(string pfileName)
        {
            _FileName = pfileName == null ? "未命名" : pfileName.Trim();

            System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Microsoft Excel|*.xls";
            sfd.Title = "Microsoft Excel Document";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                if (fileName != "")
                {
                    try
                    {
                        ExportTo(fileName);
                        OpenFile(fileName);
                    }
                    catch (System.Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 导出到
        /// </summary>
        /// <param name="fileName">文件名</param>
        private void ExportTo(string fileName)
        {

            //
            //获取指定文件是否存在
            bool isExist = System.IO.File.Exists(fileName);
            //定义一个缺少的object对象            
            object oMis = System.Reflection.Missing.Value;
            //
            //定义一个Excel区域对象,用于保存选择的区域
            Microsoft.Office.Interop.Excel.Range selectRange;
            //
            //声明一Excel Application 对象
            Microsoft.Office.Interop.Excel.Application App = null;
            //
            //声明一Excel Workbook 对象
            Microsoft.Office.Interop.Excel.Workbook wb = null;
            //
            //声明一Excel Worksheet 对象
            Microsoft.Office.Interop.Excel.Worksheet ws = null;
            //
            //将当前水标状态保存到临时变量中后将光标置为忙状态
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                App = new Microsoft.Office.Interop.Excel.Application();

                //
                //判断指定的文件是否存在
                if (isExist)
                {
                    //
                    //打开已存在的工作薄 Workbook
                    wb = App.Workbooks.Open(fileName, oMis, oMis, oMis, oMis, oMis, oMis, oMis, oMis, oMis, oMis, oMis, oMis, oMis, oMis);
                    //新建工作表
                    ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets.Add(oMis, oMis, 1, oMis);
                    //指定工作表名
                    ws.Name = DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + wb.Sheets.Count; //加 wb.Sheets.Count 防止重名
                }
                else
                {
                    //
                    //增加一工作薄 Workbook
                    wb = App.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                    //新建工作薄后默认有一个工作表,取得第一个工作表
                    ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets[1];
                    //指定工作表名
                    ws.Name = DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                }

                //
                //增加一工作表 Worksheet      

                //
                //声明两个变量记录Excle当前操作的行号与列号
                int rown = 0;
                int coln = 0;

                //
                //声明一变量用于记录当前DatagridView的总行数
                int colCount = _DataGridView.Columns.Count;

                _DataGridView.SuspendLayout();

                //
                //将DataGirdView列头写入Excel中
                foreach (DataGridViewColumn dgvc in _DataGridView.Columns)
                {
                    selectRange = ws.get_Range(ws.Cells[rown + 1, ++coln], ws.Cells[rown + 1, coln]);
                    selectRange.Columns.ColumnWidth = dgvc.Width / 10;
                    selectRange.Interior.ColorIndex = 16;
                    selectRange.Interior.Pattern = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    selectRange.Font.ColorIndex = 2;
                    selectRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                    selectRange.VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                    selectRange.set_Item(1, 1, dgvc.HeaderText);
                }

                //
                //行号增加一
                rown++;

                //
                //将DataGridView中所有的行数写入Excel中
                foreach (DataGridViewRow dgvr in _DataGridView.Rows)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        selectRange = ws.get_Range(ws.Cells[rown + 1, i + 1], ws.Cells[rown + 1, i + 1]);
                        selectRange.set_Item(1, 1, dgvr.Cells[i].Value);
                    }
                    rown++;
                }

                //
                //写入完成后将有数据的范围内设置其边框与内部线条
                ws.UsedRange.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].Weight = 3;
                ws.UsedRange.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].Weight = 3;
                ws.UsedRange.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].Weight = 3;
                ws.UsedRange.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].Weight = 3;
                ws.UsedRange.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal].Weight = 2;
                ws.UsedRange.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].Weight = 2;

                //
                //设置Wookbook为已保存状态
                wb.Saved = true;

                if (isExist)
                {
                    wb.Save();
                }
                else
                {
                    //
                    //将当前工作薄保存为指定的文件名
                    wb.SaveCopyAs(fileName);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                _DataGridView.ResumeLayout();

                wb.Close(false, null, null);
                //
                //退出Excel程序
                App.Quit();

                //
                //将当前光标更改回原来的状态
                Cursor.Current = currentCursor;
            }

        }

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="fileName">文件名</param>
        private void OpenFile(string fileName)
        {
            if (MessageBox.Show("你想打开这个文件吗?", "导出到...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = fileName;
                    process.StartInfo.Verb = "Open";
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    process.Start();
                }
                catch
                {
                    MessageBox.Show("你的计算机中未安装相关程序,不能打开该文档!", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
