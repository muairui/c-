using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                mainEntities1 entities = new mainEntities1();

                //Method method = entities.Method.FirstOrDefault();
                MethodStepConfig config = new MethodStepConfig();
                config.StepID = 1;
                config.Key = "test";
                config.Value = "0";
                config.ID = 1;
                entities.Database.Connection.ConnectionString = "datasource = F:\\muwm\\Work\\前处理产品线\\Titan.Phoenix\\Titan.Phoenix\\bin\\Debug\\Methods\\212132123.mtd;Pooling=True";
                entities.MethodStepConfig.Add(config);
                entities.SaveChanges();




                Method method = new Method();
                method.ID = 10;
                method.Name = "test";
                entities.Method.Add(method);
                entities.SaveChanges();
            }
            catch (Exception ex)
            {
            }

        }
    }
}
