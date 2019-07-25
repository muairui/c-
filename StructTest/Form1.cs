using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodInfoStruct methodInfoStruct = new MethodInfoStruct();
            methodInfoStruct.MethodName = CodeBytes("方法1", BatchInfoLength.MethodNameMaxLength);
            methodInfoStruct.BottleMaterial = CodeBytes("聚丙烯", BatchInfoLength.BottleMaterialMaxLength);
            methodInfoStruct.SampleVolume = 100;
            methodInfoStruct.StepCount = 6;

            MethodInfoClass methodInfoClass = new MethodInfoClass();
            methodInfoClass.MethodName = CodeBytes("方法1", BatchInfoLength.MethodNameMaxLength);
            methodInfoClass.BottleMaterial = CodeBytes("聚丙烯", BatchInfoLength.BottleMaterialMaxLength);
            methodInfoClass.SampleVolume = 100;
            methodInfoClass.StepCount = 6;
            float[] data = new float[10];
            //methodInfoClass.data = new float[10];
            methodInfoClass.data = data;
            int sturctSize = Marshal.SizeOf(methodInfoStruct);
            int classSize = Marshal.SizeOf(methodInfoClass);


            byte[] structBytes = Struct2Bytes(methodInfoStruct);

            byte[] classBytes = Struct2Bytes(methodInfoClass);


            byte[] srcArray = new byte[] { 0x01, 0x02, 0x03, 0x04 };
            byte[] dstArray = new byte[srcArray.Length-1];
            Buffer.BlockCopy(srcArray, 1, dstArray, 0, srcArray.Length-1);

            byte[] mergeArray = new byte[srcArray.Length + 2];
            mergeArray[0] = 0x00;
            mergeArray[1] = 0x01;
            Buffer.BlockCopy(srcArray, 0, mergeArray, 2, srcArray.Length);

        }
        public  byte[] Object2Bytes(object obj)
        {
            byte[] buff;
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter iFormatter = new BinaryFormatter();
                iFormatter.Serialize(ms, obj);
                buff = ms.GetBuffer();
            }
            return buff;
        }
        public  byte[] Struct2Bytes<T>(T obj)
        {
            int size = Marshal.SizeOf(obj);
            byte[] bytes = new byte[size];
            IntPtr arrPtr = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);
            Marshal.StructureToPtr(obj, arrPtr, true);
            return bytes;
        }
        private  byte _fillChar = 0;      //the fill character
        public  byte[] CodeBytes(string str, int len)
        {
            if (string.IsNullOrEmpty(str))
            {
                str = string.Empty;
            }

            byte[] result = new byte[len];
            byte[] strBytes = Encoding.Default.GetBytes(str);

            //copy the array converted into result, and fill the remaining bytes with 0
            for (int i = 0; i < len; i++)
                result[i] = ((i < strBytes.Length) ? strBytes[i] : _fillChar);

            return result;
        }
    }
    public static class BatchInfoLength  //define some constant
    {
        public const int BatchNameMaxLength = 50;
        public const int MethodNameMaxLength = 50;
        public const int SampleBottleMaxLength = 20;
        public const int BottleMaterialMaxLength = 20;
        public const int StepDescriptionMaxLength = 50;

    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MethodInfoStruct
    {
        //方法名字
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = BatchInfoLength.MethodNameMaxLength)]
        public byte[] MethodName;
        //瓶材料
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = BatchInfoLength.BottleMaterialMaxLength)]
        public byte[] BottleMaterial;
        //样品量
        public double SampleVolume;
        //步骤数量
        public UInt32 StepCount;

        
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class MethodInfoClass
    {
        //方法名字
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = BatchInfoLength.MethodNameMaxLength)]
        public byte[] MethodName;
        //瓶材料
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = BatchInfoLength.BottleMaterialMaxLength)]
        public byte[] BottleMaterial;
        //样品量
        public double SampleVolume;
        //步骤数量
        public UInt32 StepCount;
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public float[] data;
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct ScheduleFile
    {
        public Int32 schedule_id;
        public byte[] basic_schedule_name;
        public Int32 table_count;//服务个数（表个数）
        public Table[] table_list;//服务列表
        DateTime t;
    }
    //结构体Table
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct Table
    {
        public Int32 table_id;
        public Int32 trip_cnt;
        public Trip[] trip_list;
    }
    //结构体Trip
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct Trip//单程
    {
        public byte[] local_sub_id;
        public byte[] global_sub_id;
        public ushort trip_flag;
        public ushort route_id;
        public ushort loop_id;
        public byte[] destination_code;
        public ushort record_cnt;
        public Record[] record_list;
    }
    //结构体Record
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct Record//记录
    {
        public ushort station_id;
        public ushort platform_id;
        public DateTime arrival_time;
        public DateTime departure_time;
        public Int32 performance_level;
        public ushort record_flag;
    }
}
