using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_类的字段
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(); //类的实例化形成对象
            person1.Print(); //打印
            Console.WriteLine("====================");
            Person person2 = new Person("教练",18); //实例化形成对象
            person2.Print();//打印
            Console.ReadKey();
        }
    }

    //类
    public class Person
    {
        //字段
        public string name;
        protected int age;

        //默认:构造函数
        public Person()//不带参数的构造函数
        {
            this.name = "未知";
            this.age = 0;
        }
        public Person(string name,int age)//带两个参数的构造函数
        {
            this.name = name;
            this.age = age;
        }
        public void Print()   //输出人员信息
        {
            Console.WriteLine("name={0},age={1}", this.name, this.age);
        }

    }

}
