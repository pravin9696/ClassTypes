using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes
{
    class AA
    {
       virtual public void methodAA()
        {
            Console.WriteLine("method of AA ...");
        }
    }
    class BB:AA
    {
      override sealed public void methodAA() 
        {
            Console.WriteLine("method of BB ...");
        }
    }
    class CC:BB
    {
        //override public void methodAA()
        //{
        //    Console.WriteLine("method of CC ...");
        //}

    }
    sealed class classA
    {
        public void show()
        {
            Console.WriteLine("show from class A");
        }
    }
    class classB 
    {
        public void method1()
        {
            classA obj = new classA();
            obj.show();
        }
        public void show()
        {
            int sum = 100 + 200;
            Console.WriteLine("sum="+sum);
        }
    }

    internal class SealedDemo
    {
    }
}
