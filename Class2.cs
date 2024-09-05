using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace studMgt
{
    public partial class student
    {
        private int [] marks;
        public student()
        {
            
        }
        public student(int r,string nm,int[]mk )
        {
            roll = r;
            name = nm;
            marks = mk;
        }
        public void showResult()
        {
            Console.WriteLine("Roll=" +roll); 
            Console.WriteLine("Name="+name);
            Console.WriteLine("Total Marks="+total);
            Console.WriteLine("Per="+per);
            
        }
    }
}
namespace ClassTypes
{
    internal class Class2
    {
    }
}
