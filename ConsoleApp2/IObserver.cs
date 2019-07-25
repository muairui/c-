using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// 订阅者接口
    /// </summary>
    public interface IObserver
    {
        void Update(int temp);
    }

    public interface IObservable
    {
        /// <summary>
        /// 注册IObserver
        /// </summary>
        /// <param name="obj"></param>
        void Register(IObserver obj);

        /// <summary>
        /// 取消IObserver注册
        /// </summary>
        /// <param name="obj"></param>
        void Unregister(IObserver obj);
    }
    public abstract class SubjectBase:IObservable
    {
        private List<IObserver> container = new List<IObserver>();
        public void Register(IObserver obj)
        {
            container.Add(obj);
        }
        public void Unregister(IObserver obj)
        {
            container.Remove(obj);
        }

        protected virtual void Notify(int temp)
        {
            foreach(IObserver observer in container)
            {
                observer.Update(temp);
            }
        }
    }
}
