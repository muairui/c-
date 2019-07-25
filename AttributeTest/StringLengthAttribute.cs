using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AttributeTest
{
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

    public class People
    {
        [StringLength(8)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Description { get; set; }
    }
    public class ValidationModel
    {

        public void Validate(object obj)
        {
            var t = obj.GetType();

            //由于我们只在Property设置了Attibute,所以先获取Property
            var properties = t.GetProperties();
            foreach (var property in properties)
            {

                //这里只做一个stringlength的验证，这里如果要做很多验证，需要好好设计一下,千万不要用if elseif去链接
                //会非常难于维护，类似这样的开源项目很多，有兴趣可以去看源码。
                if (!property.IsDefined(typeof(StringLengthAttribute), false)) continue;

                var attributes = property.GetCustomAttributes();
                foreach (var attribute in attributes)
                {
                    //这里的MaximumLength 最好用常量去做
                    var maxinumLength = (int)attribute.GetType().
                      GetProperty("MaximumLength").
                      GetValue(attribute);

                    //获取属性的值
                    var propertyValue = property.GetValue(obj) as string;
                    if (propertyValue == null)
                        throw new Exception("exception info");//这里可以自定义，也可以用具体系统异常类

                    if (propertyValue.Length > maxinumLength)
                        throw new Exception(string.Format("属性{0}的值{1}的长度超过了{2}", property.Name, propertyValue, maxinumLength));
                }
            }

        }
    }
}