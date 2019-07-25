using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bingfaTest
{
    class TestTask
    {
        Random rand;
        private bool isBusy = false;
        public int TaskID { get; private set; }

        public TestTask(int seed)
        {
            rand = new Random(seed);
            TaskID = seed;
        }

        /// <summary>
        /// 接收数据
        /// </summary>
        /// <returns>接收到的数据，-1表示未接收</returns>
        public int ReceiveData()
        {
            if (isBusy) return -1;
            isBusy = true;
            var i = rand.Next(0, 1000);
            if (i < 990)
            {
                isBusy = false;
                return -1;
            }
            Thread.Sleep(100);
            isBusy = false;
            return i;
        }

        /// <summary>
        /// 接收数据
        /// </summary>
        /// <returns>-1表示未接收到</returns>
        public async Task<int> ReceiveDataAsync()
        {
            var task = new Task<int>(ReceiveData);
            task.Start();
            return await task;
        }
    }
}
