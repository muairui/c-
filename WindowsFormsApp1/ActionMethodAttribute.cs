using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class ActionMethodAttribute : Attribute
    {
        public TestType ActionTypeName;
        public bool Visible;
        public ActionMethodAttribute(TestType typeName,bool visible)
        {
            ActionTypeName = typeName;
            Visible = visible;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class StringLengthAttribute : Attribute
    {
        private int _maximumLength;
        public StringLengthAttribute(int maximumLength)
        {
            _maximumLength = maximumLength;
        }

        public int MaximumLength
        {
            get { return _maximumLength; }
        }
    }
    public class ValidationModel
    {

        public void Validate(object obj)
        {
            List<string> nameList = new List<string>();
            Form1 frm = obj as Form1;
            var t = obj.GetType();
            FieldInfo[] f = t.GetFields();
            foreach (var property in f)
            {
                if (!property.IsDefined(typeof(ActionMethodAttribute), false)) continue;

                var attributes = property.GetCustomAttributes();
                nameList.Add(property.Name);
  
            }

            foreach(Control control in frm.Controls)
            {
                foreach(string name in nameList)
                {
                    if(name == control.Name)
                    {
                        control.Visible = false;
                    }
                }
            }
        }
    }
}
