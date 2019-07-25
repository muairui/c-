using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServiceTestLocal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        mwmWebServiceTest.WebService1SoapClient myWebService = null;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = myWebService.HelloWorld();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = myWebService.GetStr(textBox3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myWebService = new mwmWebServiceTest.WebService1SoapClient("WebService1Soap");
        }
    }
}
