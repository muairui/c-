using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
namespace WindowsFormsApp1.ViewModel
{
    //ViewModel需要继承自ReactiveObject
    public class PersonViewModel : ReactiveObject
    {
        private int _id;
        private string _name;
        private int _age;

        public PersonViewModel()
        {
            Id = 1;
            Name = "张三";
            Age = 18;
        }

        public int Id
        {
            get => _id;
            set => this.RaiseAndSetIfChanged(ref _id, value);
        }

        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }

        public int Age
        {
            get => _age;
            set => this.RaiseAndSetIfChanged(ref _age, value);
        }
    }
}
