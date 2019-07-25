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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataBind();
        }
        public class BlogNew
        {
            public int BlogID { get; set; }
            public string BlogTitle { get; set; }
        }
        public List<BlogNew> blogNews { get; set; }  //应用于第四种方式


        public List<int> index { get; set; }
        public void DataBind()
        {
            blogNews = new List<BlogNew>();
            blogNews.Add(new BlogNew { BlogID = 1, BlogTitle = "人生若只如初见" });
            blogNews.Add(new BlogNew { BlogID = 2, BlogTitle = "何事秋风悲画扇" });
            blogNews.Add(new BlogNew { BlogID = 3, BlogTitle = "最喜欢纳兰性德" });

            dataGridView1.DataBindings.Add("DataSource", this, "blogNews", false, DataSourceUpdateMode.OnPropertyChanged);
            index = new List<int>();
            index.Add(1);
            index.Add(2);
            listBox1.DataBindings.Add("DataSource", this, "index", false, DataSourceUpdateMode.OnPropertyChanged);


        }
    }
    public class BlogNew
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
    }
}
