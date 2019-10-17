using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 0;
            int guess = 0;

            while (true)  //loop
            {
                string input_str = Console.ReadLine();
                input = int.Parse(input_str);
                //離開條件
                if (input == guess)
                {
                    Console.WriteLine("度的度度");
                    break;
                }
                Console.WriteLine("NONONONONO");


            }
        }
    }
}

/* for(int i =0; i<10; i++)
 {
     if (i % 2 == 0) ;
     {
         continue;
     }
     Console.WriteLine(i);
 }
 Console.WriteLine("pizza");
 Console.ReadKey();
}
}
}*/
