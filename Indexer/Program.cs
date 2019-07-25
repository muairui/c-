using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{

    /// <summary>
    ///什么是索引指示器？
    ///实现索引指示器（indexer）的类可以象数组那样使用其实例后的对象，但与数组不同的是索引指示器的参数类型不仅限于int
    ///简单来说，其本质就是一个含参数属性
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Point[] tmpPoints = new Point[10];
            for (int i = 0; i < tmpPoints.Length; i++)
            {
                tmpPoints[i] = new Point(i, Math.Sin(i));
            }
            Points tmpObj = new Points(tmpPoints);
            for (int i = 0; i < tmpObj.PointNumber; i++)
            {

                Console.WriteLine(tmpObj[i]);

            }
        }
    }
    public class Point
    {
        private double x, y;
        public Point(double X, double Y)
        {
            x = X;
            y = Y;
        }
        //重写ToString方法方便输出
        public override string ToString()
        {
            return String.Format("X: {0} , Y: {1}", x, y);
        }
    }

    public class Points
    {
        Point[] points;
        public Points(Point[] Points)
        {
            points = Points;
        }

        public int PointNumber
        {
            get
            {
                return points.Length;
            }
        }
        //实现索引访问器

        public Point this[int Index]
        {
            get
            {
                return points[Index];
            }
        }
    }
}
