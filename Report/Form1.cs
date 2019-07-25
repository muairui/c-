using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 创建报表
            XtraReport3 report = new XtraReport3();
            // 显示预览
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 创建报表
            XtraReport3 report = new XtraReport3();
            // 打印
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 创建报表
            XtraReport3 report = new XtraReport3();
            // 显示设计视图
            ReportDesignTool tool = new ReportDesignTool(report);
            tool.ShowDesignerDialog();
        }
    }
}
