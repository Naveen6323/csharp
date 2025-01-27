using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice_problems;

namespace testAccessmodifiers
{
     class DifffProgram:Child
    {
        //public static int p;
        

        

    
        static void Main(string[] args)
        {
            Console.WriteLine("child class for diff project------------------");
            DifffProgram df = new DifffProgram();
            df.d();df.a();df.e();

        }
    }
    
}
