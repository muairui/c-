using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVP
{
    public partial class PersonForm : Form
    {
        private PersonControl _controllor;

        public PersonControl Controllor
        {
            get { return _controllor; }
            set
            {
                this._controllor = value;
                //绑定一定只能写在给Controllor赋值以后而不能写在PersonForm的构造函数中(此时Controllor还未被实例化)
                //因为我们这里采用的是Controllor-First而不是View-First，不然Controllor.Model为null会异常
                //将View通过构造函数注入到Controllor中的属于Controllor-First,这时候Controllor先创建
                //将Controllor通过构造函数注入到View中的属于View-First,这时候View先创建
                this.textBox1.DataBindings.Add("Text", Controllor.Model, "ID");
                this.textBox2.DataBindings.Add("Text", Controllor.Model, "Name");


                

                //this.dataGridView1.DataBindings.Add(Controllor.Model.Name);
                //if (Controllor.Model.Index != null)
                //this.listBox1.DataBindings.Add("DataSource", Controllor.Model.Index, "Index");
            }
        }

        public PersonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "2";
            this.textBox2.Text = "jacky";
            Controllor.UpdatePerson();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controllor.Model.ID = "21";
            Controllor.Model.Name = "jacky1";

            Controllor.UpdatePerson();
        }
    }
}
