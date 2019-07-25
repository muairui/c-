using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace layout
{
    public partial class Form1 : Form
    {
        UCMain ucMain;//分析控制
        UCMain1 ucMain1;//分析控制
        public Form1()
        {
            InitializeComponent();
            if (ucMain == null)
            {
                ucMain = new UCMain();
                ucMain.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(ucMain);
            }
            //if (ucMain1 == null)
            //{
            //    ucMain1 = new UCMain1(this.Size.Width,this.Size.Height);
            //    ucMain1.Dock = DockStyle.Fill;
            //    this.panel1.Controls.Add(ucMain1);
            //}


        }
    }
}
