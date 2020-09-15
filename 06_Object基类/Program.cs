using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Object基类
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            object[] objs = new object[3];//形成数组对象

            objs[0] = 123;    //int32类型
            objs[1] = "abc"; //sting类型
            objs[2] = new DateTime(2020, 9, 15);//当前时间(类->对象)

            for (int i = 0; i < objs.Length; i++)
            {
                Console.WriteLine("object[{0}]:{1},{2},{3} \n", i, objs[i], (objs[i]).GetType(), (objs[i]).ToString());
            }

            Console.ReadKey();
        }
    }
}
