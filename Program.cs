using nsp2;
using studMgt;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsp1
{
    public partial class abc1
    { }
}
namespace nsp1
{
    public  class abc
    { }
}
namespace nsp2
{
    class outerClass
    {
      public  class inner1
        {
            public void show()
            {
                Console.WriteLine("show from inner 1");
            }
            public class inner2
            {
                public class inner3
                {
                    public void Display()
                    {
                        Console.WriteLine("Display from inner 3");
                    }
                }
            }
        }
    }
}
namespace ClassTypes
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //int r1 = 11;
            //string nm = "Rajesh";
            //int[]mk=new int[5] { 34,54,23,67,56};
            //student s1 = new student(r1,nm,mk);
            //s1.CalculateResult();
            //s1.showResult();


            //outerClass.inner1 obj1 = new outerClass.inner1();
            //obj1.show();
            //outerClass.inner1.inner2.inner3 obj2 = new outerClass.inner1.inner2.inner3();
            //obj2.Display();


            //classB objB=new classB();
            //objB.method1();

            CC objC=new CC();
            objC.methodAA();
            Console.ReadKey();
        }
    }
}
