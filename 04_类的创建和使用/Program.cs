using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_类的创建和使用
{
    class Program
    {
        static void Main(string[] args)
        {

            //对象实例化的方式
            //方式一:声明Person类型的变量,再赋值
            Person personA;
            personA = new Person("张三", 25);//创建并赋值
            //方式二:通过构造函数传递值
            Person personB = new Person("李四", 18);
            //方式三:对字段直接进行赋值
            Person personC = new Person();
            personC.name = "王五";
            //方式四:对属性直接进行赋值
            Person personD = new Person { Name = "王五", Age = 28 };

        }
    }

    //类
    public class Person
    {
        //字段
        public string name;
        protected int age;
        //属性 ctrl+R,E
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        //

        //默认:构造函数
        public Person()//不带参数的构造函数
        {
            this.name = "未知";
            this.age = 0;
        }
        public Person(string name, int age)//带两个参数的构造函数
        {
            this.name = name;
            this.age = age;
        }
        public void Print()   //输出人员信息
        {
            Console.WriteLine("name={0},age={1}", this.Name, this.Age);
        }

    }

}
