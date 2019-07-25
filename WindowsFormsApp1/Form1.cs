using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using ReactiveUI;
using WindowsFormsApp1.ViewModel;
namespace WindowsFormsApp1
{

    public enum TestType
    {

        SA18=1,
        SA19 = 1,
        SA12=2,
        BA19 = 2

    }

    public partial class Form1 : Form, IViewFor<PersonViewModel>
    {
        TestType testType = TestType.SA12;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
        // 遍历控件，并根据资源文件替换相应属性 
        private void ApplyResource()
        {
            foreach (Control ctl in this.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
            this.ResumeLayout(false);
            this.PerformLayout();
            resources.ApplyResources(this, "$this");
        } 
        public Form1()
        {
            InitializeComponent();
            this.WhenActivated(a =>
            {
                a(this.Bind(ViewModel, vm => vm.Id, v => v.textBox1.Text));
                a(this.Bind(ViewModel, vm => vm.Name, v => v.textBox2.Text));
                a(this.Bind(ViewModel, vm => vm.Age, v => v.textBox3.Text));
                a(this.OneWayBind(ViewModel, vm => vm.Id, v => v.label1.Text));
                a(this.OneWayBind(ViewModel, vm => vm.Name, v => v.label2.Text));
                a(this.OneWayBind(ViewModel, vm => vm.Age, v => v.label3.Text));
            });
            ViewModel = new PersonViewModel();
        }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (PersonViewModel)value;
        }
        public PersonViewModel ViewModel { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = ViewModel.Age;
            ViewModel.Age = 1000;
            Thread thread = new Thread(HeatBeat);
            thread.IsBackground = true;
            thread.Start();
        }
        int i = 0;
        private void HeatBeat()
        {
            i = i + 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void TestDic(Dictionary<TestType, bool> dic)
        {
            foreach(var item in dic)
            {
                TestType i = item.Key;
            }
        }
        Dictionary<string, bool> dic = new Dictionary<string, bool>();
        List<Control> controlList = new List<Control>();
        private void GetControls1(Control fatherControl)
        {
            Control.ControlCollection sonControls = fatherControl.Controls;
            //遍历所有控件
            foreach (Control control in sonControls)
            {
                controlList.Add(control);
                if (control.Controls != null)
                {
                    GetControls1(control);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int nMutiValStatus = 0;
            char ch = (char)1;
            nMutiValStatus |= ch << 3;//关掉
            nMutiValStatus |= ch << 4;
            nMutiValStatus |= ch << 5;
            nMutiValStatus |= ch << 6;

            string s = System.Globalization.CultureInfo.InstalledUICulture.Name;
            //获取当前系统的语言 
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(s);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
            ApplyResource();
            var t = this.GetType();
            FieldInfo[] f = t.GetFields();
            foreach (var property in f)
            {
                if (!property.IsDefined(typeof(ActionMethodAttribute), false)) continue;
                var attributes = property.GetCustomAttributes();
                foreach (var attribute in attributes)
                {
                    ActionMethodAttribute columnAttr = attribute as ActionMethodAttribute;
                    var it = columnAttr.ActionTypeName;
                    if (testType == columnAttr.ActionTypeName)
                    {
                        bool visible = columnAttr.Visible;
                        dic.Add(property.Name, visible);
                    }
                }
            }
            List<string> namelist = new List<string>();
            foreach (Control control in this.Controls)
            {
                namelist.Add(control.Name);
                if (control is GroupBox)
                {
                    if (dic.ContainsKey(control.Name))
                    {
                        control.Visible = dic[control.Name];
                    }
                    else
                    {
                        foreach (Control groupContor in control.Controls)
                        {
                            if (dic.ContainsKey(groupContor.Name))
                                groupContor.Visible = dic[groupContor.Name];
                        }
                    }
                }
                else if(control is DevExpress.XtraEditors.GroupControl)
                {

                }
                else if(control is GridControl)
                {
                    GridControl gridControl = control as GridControl;
                    GridView gridView1 = gridControl.MainView as GridView;

                    foreach(GridColumn column in gridView1.Columns)
                    {
                        if (dic.ContainsKey(column.Name))
                            column.Visible = dic[column.Name];
                    }
                }
                else
                {
                    if(dic.ContainsKey(control.Name))
                        control.Visible = dic[control.Name];
                }
            }
                int i = dic.Count;
            i = namelist.Count;
            //this.SampleName.Visible = dic[SampleName.Name];
            //this.gridColumn1.Visible = dic[gridColumn2.Name];
        }
    }
}



           //modified by muwm 2018-12-4 --begin
            //switch (ControlVisibleHelp.GetShowType(currentInsMethod.m_nInsType))
            //{
            //    case InsShowType.enumShowType_Two:

            //        break;
            //    case InsShowType.enumShowType_Three:

            //        break;
            //    case InsShowType.enumShowType_Four:

            //        break;
            //    default:
            //        break;
            //}
            //modified by muwm 2018-12-4 --begin
            //modified by muwm 2018-12-4 --end