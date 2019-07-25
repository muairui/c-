using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace MVP
{
    public class Person : INotifyPropertyChanged
    {
        private string _id;
        public string ID
        {
            get { return _id; }
            set { _id = value; /*OnPropertyChanged("ID");*/ }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; /*OnPropertyChanged("Name"); */}
        }

        //private List<int> _Index;
        //public List<int> Index
        //{
        //    get { return _Index; }
        //    set { _Index = value; OnPropertyChanged("Index"); }
        //}
        #region INotifyPropertyChanged 成员

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
        #endregion

    }
}
