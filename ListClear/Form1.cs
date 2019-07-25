using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListClear
{
    public partial class Form1 : Form
    {
        [Serializable]
        public class Part
        {
            public string PartName { get; set; }
            public double PartId { get; set; }
            public override string ToString()
            {
                return "ID: " + PartId + "   Name: " + PartName;
            }

            public List<int> list;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Part> parts = new List<Part>();

            int capacity = parts.Capacity;
            int count = parts.Count;
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });

            capacity = parts.Capacity;
            count = parts.Count;



            parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            capacity = parts.Capacity;
            parts.Add(new Part() { PartName = "seat", PartId = 1434 });
            capacity = parts.Capacity;
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            capacity = parts.Capacity;
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

            capacity = parts.Capacity;
            count = parts.Count;
            parts.TrimExcess();

            capacity = parts.Capacity;
            count = parts.Count;

            parts.Clear();

            capacity = parts.Capacity;
            count = parts.Count;
        }
        /// <summary>
        /// huishou
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            GC.Collect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<float> list = new List<float>();

            for(int i = 0;i< 10000000; i++)
            {
                list.Add(i);
            }
            MessageBox.Show(list.Capacity.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<float> list = new List<float>();

            for (int i = 0; i < 10000000; i++)
            {
                list.Add(i);
            }
            list.TrimExcess();
            GC.Collect();
            MessageBox.Show(list.Capacity.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                List<float> list = new List<float>();

                for (int i = 0; i < 200000000; i++)
                {
                    list.Add(i);
                }
            }
        }
        List<float> glist = new List<float>();
        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000000; i++)
            {
                glist.Add(i);
            }
            MessageBox.Show(glist.Capacity.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            glist.TrimExcess();
            MessageBox.Show(glist.Capacity.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(glist != null)
            {
                glist.Clear();
                glist = null;
            }

            GC.Collect();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //GC.Collect();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Part part = new Part();
            part.PartId = 1;
            part.PartName = "test";
            part.list = new List<int>();

            for (int i = 0; i < 10000000; i++)
            {
                part.list.Add(i);
            }
            byte[] buffer = SerializeToBinary(part);


            Part partD = new Part();

            partD = (Part)DeserializeWithBinary(buffer);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Part part = new Part();
            part.PartId = 1;
            part.PartName = "test";
            part.list = new List<int>();
            part.list.Add(1);
            part.list.Add(2);
            part.list.Add(3);
            part.list.Add(4);
            part.list.Add(5);
            part.list.TrimExcess();
            byte[] buffer = SerializeToBinary(part);
            Part partD = new Part();

            partD = (Part)DeserializeWithBinary(buffer);
        }
        public  byte[] SerializeToBinary(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, obj);

            byte[] data = stream.ToArray();
            stream.Close();
            return data;
        }
        /// <summary>
        /// 将二进制数据反序列化
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public  object DeserializeWithBinary(byte[] data)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(data, 0, data.Length);
            stream.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(stream);

            stream.Close();

            return obj;
        }


    }
}
