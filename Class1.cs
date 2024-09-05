using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studMgt
{
    public partial class student
    {
        private int roll;
        private string name;
        float per;
        int total = 0;
        public student(int r,string nm)
        {
            roll = r;
            name = nm;
        }
        public void CalculateResult()
        {
            
            for (int i = 0; i < marks.Length; i++)
            {
                total+= marks[i];   //total=total+marks[i];
            }
            per = total / marks.Length;
        }
    }


}
namespace ClassTypes
{
    internal class Class1
    {
    }
}
