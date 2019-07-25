using System;

namespace CloneTest
{
    /// <summary>
    /// 深拷贝接口
    /// </summary>
    interface IDeepCopy
    {
        object DeepCopy();
    }
    /// <summary>
    /// 浅拷贝接口
    /// </summary>
    interface IShallowCopy
    {
        object ShallowCopy();
    }

    /// <summary>
    /// 教室信息
    /// </summary>
    class ClassRoom : IDeepCopy, IShallowCopy
    {
        public int RoomID = 1;
        public string RoomName = "Room1";

        public override string ToString()
        {
            return "RoomID=" + RoomID + "\tRoomName=" + RoomName;
        }
        public object DeepCopy()
        {
            ClassRoom r = new ClassRoom();
            r.RoomID = this.RoomID;
            r.RoomName = this.RoomName;
            return r;
        }
        public object ShallowCopy()
        {
            //直接使用内置的浅拷贝方法返回
            return this.MemberwiseClone();
        }
    }

    class Student : IDeepCopy, IShallowCopy
    {
        //为了简化，使用public 字段
        public string Name;
        public int Age;
        //自定义类型，假设每个Student只拥有一个ClassRoom
        public ClassRoom Room = new ClassRoom();

        public Student()
        {
        }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public object DeepCopy()
        {
            Student s = new Student();
            s.Name = this.Name;
            s.Age = this.Age;
            s.Room = (ClassRoom)this.Room.DeepCopy();
            return s;
        }
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Name:" + Name + "\tAge:" + Age + "\t" + Room.ToString();
        }

    }
}