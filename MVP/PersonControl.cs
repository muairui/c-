using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVP
{
    public class PersonControl
    {
        public PersonForm View;

        public Person Model;

        public PersonControl(PersonForm view)
        {
            //初始化了一个Model
            if (Model == null)
                Model = new Person();
            Model.ID = "1";
            Model.Name = "mwm";

            //通过构造函数将View注入到Controllor中
            this.View = view;

            //建立起View 和Controllor的关联
            //这时候View中能使用它所对应的Controllor进行业务逻辑的操作,Model也能和VIEW UI控件进行双向绑定
            this.View.Controllor = this;


        }


        /// <summary>
        /// 执行一个业务逻辑
        /// </summary>
        public void UpdatePerson()
        {
            UpdateToDataBase(Model);
        }

        private void UpdateToDataBase(Person p)
        {
            //do some thing
            //执行将数据插入到数据库的操作
            System.Windows.Forms.MessageBox.Show("ID:" + p.ID + " Name:" + p.Name);

        }
    }
}
