using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Class Person
    /// </summary>
    [Serializable]
    public class Person
    {
        /// <summary>
        /// Gets or sets the person job.
        /// </summary>
        /// <value>The person job.</value>
        public Job PersonJob
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>The age.</value>
        public int Age
        {
            get;
            set;
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>System.Object.</returns>
        public object Clone()
        {
            BinaryFormatter formatter = new BinaryFormatter(null, new System.Runtime.Serialization.StreamingContext(System.Runtime.Serialization.StreamingContextStates.Clone));
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            object clonedObj = formatter.Deserialize(stream);
            stream.Close();
            return clonedObj;
        }
    }

    /// <summary>
    /// Class Job
    /// </summary>
    [Serializable]
    public class Job
    {
        /// <summary>
        /// Gets or sets the name of the job.
        /// </summary>
        /// <value>The name of the job.</value>
        public string JobName
        {
            get;
            set;
        }
    }
    public partial class MethodStepConfig
    {
        public long ID { get; set; }
        public Nullable<long> StepID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public struct StructConfig
    {
        public long ID { get; set; }
        public Nullable<long> StepID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
    class Program
    {
        static void ThreadMethod()
        {
            Console.WriteLine("线程开始" + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("线程结束" + Thread.CurrentThread.ManagedThreadId);

        }
        public static List<T> Clone<T>(object List)
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, List);
                objectStream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(objectStream) as List<T>;
            }
        }
        private static void HeartBeatAS90F(object paras)
        {
            int i = 0;
        }
        static void Main(string[] args)
        {
            Task t = new Task(ThreadMethod);
            Task t1 = new Task(ThreadMethod);
            var task2 = new Task(() =>
            {
                Console.WriteLine("Task 2 Begin");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Task 2 Finish");
            });
            t.Start();
            t1.Start();
            task2.Start();
            Task.WaitAny(t, t1,task2);
            Console.WriteLine("All task finished!");
            //ThreadPool.QueueUserWorkItem(ThreadMethod);线程池
            //ThreadPool.QueueUserWorkItem(ThreadMethod);
            //ThreadPool.QueueUserWorkItem(ThreadMethod);
            //ThreadPool.QueueUserWorkItem(ThreadMethod);
            //Task t = new Task(ThreadMethod);
            //t.Start();
            //MethodStepConfig config = new MethodStepConfig();
            //StructConfig config1 = new StructConfig();
            //List<MethodStepConfig> list = new List<MethodStepConfig>();
            //List<StructConfig> list2 = new List<StructConfig>();
            //for (int i = 0;i <10;i++)
            //{
            //    config.ID = i;
            //    config.Key = i.ToString();
            //    config.Value = i.ToString();
            //    config.StepID = i;
            //    list.Add(config);
            //    config1.ID = i;
            //    config1.Key = i.ToString();
            //    config1.Value = i.ToString();
            //    config1.StepID = i;
            //    list2.Add(config1);
            //}
            //int count = list.Count;
            //int num = list2.Count;
            List<Person> originalList = new List<Person>();
            Person person = new Person();
            person.Name = "zhangsan";
            person.Age = 90;
            Job job = new Job();
            job.JobName = "开发工程师";
            person.PersonJob = job;
            originalList.Add(person);

            person = new Person();
            person.Name = "lisi2";
            job = new Job();
            job.JobName = "开发工程师";
            person.PersonJob = job;
            originalList.Add(person);

            person = new Person();
            person.Name = "3";
            job = new Job();
            job.JobName = "测试工程师";
            person.PersonJob = job;
            originalList.Add(person);

            Console.WriteLine("原数据如下：");
            for (int i = 0; i < originalList.Count; i++)
            {
                Console.WriteLine("Name:" + originalList[i].Name + ",JobName:" + originalList[i].PersonJob.JobName);
            }

            Console.WriteLine("--------------List深复制------------------");
            List<Person> deepCopyList = Clone<Person>(originalList);
            deepCopyList[1].Name = "lisi";
            for (int i = 0; i < originalList.Count; i++)
            {
                Console.WriteLine("原数据：Name:" + originalList[i].Name + ",JobName:" + originalList[i].PersonJob.JobName);
                Console.WriteLine("深复制后：Name:" + deepCopyList[i].Name + ",JobName:" + deepCopyList[i].PersonJob.JobName);
            }

            Console.WriteLine("----------------List赋值----------------");
            List<Person> shallowCopyList = originalList;
            shallowCopyList[2].Name = "amy";
            shallowCopyList[2].PersonJob.JobName = "产品工程师";
            Job modifyJob = new Job();
            modifyJob.JobName = "UNKNOWN";
            shallowCopyList[1].PersonJob = modifyJob;
            for (int i = 0; i < originalList.Count; i++)
            {
                Console.WriteLine("原数据：Name:" + originalList[i].Name + ",JobName:" + originalList[i].PersonJob.JobName);
                Console.WriteLine("浅复制：Name:" + shallowCopyList[i].Name + ",JobName:" + shallowCopyList[i].PersonJob.JobName);
            }



            ParameterizedThreadStart paraStart = new ParameterizedThreadStart(HeartBeatAS90F);
            Thread threadAS90F = new Thread(paraStart);
            threadAS90F.IsBackground = true;
            threadAS90F.Start(shallowCopyList);

            Console.Read();
            Console.ReadKey();
        }
    }
}
