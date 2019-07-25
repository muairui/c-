using System;

namespace EventTest
{

    public class AnalysisPackage 
    {
        public delegate void RecvDataHotBlockTempEventHandle(int location, float value);
        public event RecvDataHotBlockTempEventHandle RecvDataHotBlockTempEvent;//接受加热块温度事件
        private static AnalysisPackage instance;
        private static readonly object lockObj = new object();
        private AnalysisPackage()
        {

        }
        public static AnalysisPackage GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new AnalysisPackage();
                    }
                }
            }
            return instance;
        }

        public void Test()
        {
            if(RecvDataHotBlockTempEvent != null)
            {
                RecvDataHotBlockTempEvent(0, 10);
            }
        }
    }

}