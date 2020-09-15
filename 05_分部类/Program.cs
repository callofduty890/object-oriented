using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_分部类
{
    public partial class PartialTest//分部类
    {
        protected string age;//类中的字段
        public void F2() { }//类中的方法
    }


    public class TEST//等同于ParitalTest类
    {
        protected string name;//类中的字段
        protected string age;//类中的字段

        public void F1() { }//类中的方法
        public void F2() { }//类中的方法

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
