using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socketExample
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        /*程序开发说明：
         * 编写日期：2014年10月17日
         * 开发人员：孙小聪
         * 开发目的：我想自己优化一个类实现一种什么效果呢就是我下发一个数据之后 三个参数：
         * 1.步长值
         * 2.超时时间
         * 3.通讯规约
         * 数据下发之后 每隔单位时间去判断一下当前接收到的数据，然后按照指定的规约类型去判断当前返回的数据是否正确符合规约要求。
         * 若是符合规约要求返回一个True 不需要继续等待
         * 若是返回数据不符合要求继续等待。
         * 继续等待到超时时间退出进行提示
         * 若是没有超过超时时间继续等待到超时时间为止。听着很简单的一个功能真是实现的时候就会发现不是那么简单，我把这个类完善一下！ 
         * 今天下午的主要功能就是完成了。这个情况还是很复杂的，我现在手头这个程序就是用来判断是否有返回值，但是我们真正使用的情况是
         * 首先不一定一帧数据就能返回回来。而且返回来之后我们要判断完整性
         */
        #region 初始化端口
        public void InitCOM()
        {
            cmbCOM.Items.Clear();
            string[] strArr = SerialPort.GetPortNames();
            foreach (string one in strArr)
            {
                cmbCOM.Items.Add(one);
            }
            //cmbCOM.SelectedIndex = strArr.Length > 0 ? 0 : -1;
            cmbCOM.SelectedIndex = 1;
        }
        #endregion
        //接口类
        SerialPortHelper sp;
        /// <summary>
        /// 初始化信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;  //允许控件跨线程调用 当然这是不推荐的，后期使用中还是应该使用委托
            InitCOM();
            //cmbBTL.SelectedIndex = 4;
            //cmbSJW.SelectedIndex = 3;
            //cmbTZW.SelectedIndex = 0;
            //cmbXYW.SelectedIndex = 2;
        }
        #region 清空文本
        private void btnClearSend_Click(object sender, EventArgs e)
        {
            txtSend.Text = "";
        }
        private void btnClearRec_Click(object sender, EventArgs e)
        {
            txtReceive.Text = "";
        }
        #endregion
        #region 打开关闭串口
        private void btnState_Click(object sender, EventArgs e)
        {
            //if (btnState.Text == "打开串口")
            //{
            //    Parity py = cmbXYW.Text == "None" ? Parity.None :
            //        cmbXYW.Text == "Odd" ? Parity.Odd : cmbXYW.Text == "Even" ? Parity.Even :
            //        cmbXYW.Text == "Mark" ? Parity.Mark : Parity.Space;
            //    sp = new SerialPortHelper(cmbCOM.Text, int.Parse(cmbBTL.Text),
            //        int.Parse(cmbSJW.Text), cmbTZW.Text == "1" ? StopBits.One : cmbTZW.Text == "1.5" ? StopBits.OnePointFive : StopBits.Two,
            //        py, ReceMeg, 
            
            
            
           // );
            //    btnState.Text = "关闭串口";
            //}
            //else
            //{
            //    sp.Close();
            //    sp = null;
            //    btnState.Text = "打开串口";
            //}
        }
        /// <summary>
        /// 超时之后执行的操作
        /// </summary>
        /// <param name="str"></param>
        public void FunctionTimeOutAction(string str)
        {
            MessageBox.Show("数据接收超时！请准备重新发送", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        #endregion
        /// <summary>
        /// 接收的数据
        /// </summary>
        /// <param name="str"></param>
        public void ReceMeg(string str)
        {
            txtReceive.Text += str;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.btnState.Text == "打开串口")
            {
                //这个时候不能用
                MessageBox.Show("发送数据之前请先打开串口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                sp.SendData(this.txtSend.Text.Trim(), 1, 10);
            }
        }
    }
}
