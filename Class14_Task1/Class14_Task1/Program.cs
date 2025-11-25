using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class14_T1Lib;

namespace Class14_Task1
{
    internal class Program 
    {

        public class NoIdea : Class1
        {
            public void StillNoIdea()
            {
                PrintMethod();
            }
        }
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.PrintMethod();

            NoIdea class2 = new NoIdea();
            class2.StillNoIdea();
        }
    }
}
