using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Bird //默认的访问修饰符是internal (本程序集可以访问)
    {
        public void SayHello()
        {
            Console.WriteLine("吱吱");
        }
    }
    public class Dog//访问修饰符是public(任意可以访问)
    {
        public void SayHello()
        {
            Console.WriteLine("旺旺");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Dog dog = new Dog();

            bird.SayHello();//引用internal成员
            dog.SayHello();//引用Public成员

            Console.ReadKey();
        }
    }
}
