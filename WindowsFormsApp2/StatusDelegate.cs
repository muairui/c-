using System;


namespace WindowsFormsApp2
{

    public class StatusDelegate 
    {
        public delegate void ShowDel();
        public event ShowDel ShowEvent;

        public delegate void ShowDel1();
        public event ShowDel1 ShowEvent1;

        public delegate void ShowDel2();
        public event ShowDel2 ShowEvent2;


        public void CallShow()
        {
            if(ShowEvent != null)
            {
                ShowEvent();
            }
        }
        public void CallShow1()
        {
            if (ShowEvent1 != null)
            {
                ShowEvent1();
            }
        }
        public void CallShow2()
        {
            if (ShowEvent2 != null)
            {
                ShowEvent2();
            }
        }

    }

}