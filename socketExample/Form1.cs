using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace socketExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient tcpClient;
        bool IsConnected = false;
        NetworkStream networkStream;
        private void Form1_Load(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            tcpClient.BeginConnect("127.0.0.1", 10001, new AsyncCallback(AsynConnect), tcpClient);
        }
        public  void AsynConnect(IAsyncResult iar)
        {
            try
            {
                //连接成功
                tcpClient.EndConnect(iar);
                //连接成功标志
                IsConnected = true;
                networkStream = tcpClient.GetStream();
                byte[] TempBytes = new byte[1024];
                //开始异步读取返回数据
                networkStream.BeginRead(TempBytes, 0, TempBytes.Length, new AsyncCallback(AsynReceiveData), TempBytes);
            }
            catch (Exception ex)
            {
            }
        }
        public  void AsynReceiveData(IAsyncResult iar)
        {
            byte[] CurrentBytes = (byte[])iar.AsyncState;
            try
            {
                //结束了本次数据接收
                int num = networkStream.EndRead(iar);
                //这里展示结果为InfoModel的CurrBytes属性，将返回的数据添加至返回数据容器中
                //ResponseBytes.Add(CurrentBytes);
                //处理结果后马上启动数据异步读取【目前我每条接收的字节数据长度不会超过1024】
                byte[] NewBytes = new byte[24];
                networkStream.BeginRead(NewBytes, 0, NewBytes.Length, new AsyncCallback(AsynReceiveData), NewBytes);

                string str = System.Text.Encoding.Default.GetString(NewBytes);
            }
            catch (Exception ex)
            {
            }
        }
        public  void SendData(byte[] SendBytes)
        {
            try
            {
                if (networkStream.CanWrite && SendBytes != null && SendBytes.Length > 0)
                {
                    //发送数据
                    networkStream.Write(SendBytes, 0, SendBytes.Length);
                    networkStream.Flush();
                }
            }
            catch (Exception ex)
            {
                if (tcpClient != null)
                {
                    tcpClient.Close();
                    //关闭连接后马上更新连接状态标志
                    IsConnected = false;
                }
            }
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            string send = richTextBox1.Text;
            SendData(System.Text.Encoding.Default.GetBytes(send));
        }
        private AutoResetEvent recvDataResetEvent = new AutoResetEvent(false);
        private void button1_Click(object sender, EventArgs e)
        {
            recvDataResetEvent.Set();
        }
        int n = 0;
        private void CheckFeedback()
        {
            while (recvDataResetEvent.WaitOne(3000) == false)
            {
                n++;
                if(n == 3)
                {
                    MessageBox.Show("chaoguo 3ci" + n.ToString());
                    n = 0;
                    return;
                }
            }

            bool ret = recvDataResetEvent.WaitOne(30000);
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //recvDataResetEvent.Reset();
            //send 数据 
            recvDataResetEvent = new AutoResetEvent(false);
            //然后开启线程
            Task.Factory.StartNew(() => CheckFeedback());
            //CheckFeedback();
        }
    }
}
