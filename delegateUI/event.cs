using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateUI
{
    public class Myevent
    {
        public delegate void StopRunEvent();
        /// <summary>
        /// 通信失败后，序列停止运行
        /// </summary>
        public event StopRunEvent StopRun;  //2017.11.28 zk 添加

        public void Stop()
        {
            if (StopRun != null)
                StopRun();
        }
    }
}
