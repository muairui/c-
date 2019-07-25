using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public IEnumerable<Friend> friends;

        private void button1_Click(object sender, EventArgs e)
        {
            Friends friendcollection = new Friends();
            foreach (Friend f in friendcollection)
            {
                string name = f.Name;
            }

            friends = friendcollection as IEnumerable<Friend>;


            int min = 0;
            int max = 1000000000;
            int mid = (min + max) / 2;
            int mid1 = min + ((max - min) >> 1);//右移一位相当于除以2
        }
    }

    public class Friend
    {
        private string name;
         public string Name
         {
             get { return name; }
             set { name = value; }
         }
         public Friend(string name)
         {
             this.name = name;
         }
    }
    public class Friends : IEnumerable //迭代器必须实现IEnumerator接口
    {
        private Friend[] friendArray;
        public Friends()
        {
            friendArray = new Friend[]
            {
                new Friend("1"),
                new Friend("2"),
                new Friend("3"),
            };
        }
        public Friend this[int index]
        {
            get { return friendArray[index]; }
        }
        public int Count
        {
            get { return friendArray.Length; }
        }
        public IEnumerator GetEnumerator()
        {
            for(int index = 0;index<friendArray.Length;index++ )
            {
                // 这样就不需要额外定义一个FriendIterator迭代器来实现IEnumerator
                // 在C# 2.0中只需要使用下面语句就可以实现一个迭代器
                yield return friendArray[index];
            }
          
        }
    }
}
