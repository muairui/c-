using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnalysisPackage.GetInstance().RecvDataHotBlockTempEvent += Form1_RecvDataHotBlockTempEvent;
        }

        private void Form1_RecvDataHotBlockTempEvent(int location, float value)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                Refresh(location, value);
            }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnalysisPackage.GetInstance().Test();
        }

        private void Refresh(int loction,float value)
        {
            textBox1.Text = value.ToString();
        }
    }
}
