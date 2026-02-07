using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part10
{
    internal class Wife
    {
        //数据成员
        private string name;//这是字段
        private int age;
        public string Name
        {//这是属性，是对字段的封装，对字段的读写方法 
            get 
            { return name; }
            set 
            {
                name = value;
            }//value是关键字，表示传入的值  
        }
        //构造函数提供了创建对象的方式，可进行初始化数据成员。若没有构造函数，编译器自动提供一个无参构造函数。
        //特点：没有返回值，与类同名,创建对象是自动调用
        public Wife(string name, int age): this()//“调用”构造函数，但是构造函数不能被调用，所以用this
        {
            this.name = name; 
        }
        public Wife() 
        {

        }
        //方法成员
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age; 
        }
    }
    
}
