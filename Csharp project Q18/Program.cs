using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q18
{
    class Program
    {
        static void Main(string[] args)
        {
            int []arr = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            int[] inc = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for(int i=0;i<9;i++)
            {
                int x = arr[i] -1;
                inc[x]++;
            }

            for(int i=0;i<10;i++)
            {
                if(inc[i]!=0)
                {
                    Console.WriteLine("{0} ->{1} times    ",i+1,inc[i]);
                }
            }

        }
    }
}
