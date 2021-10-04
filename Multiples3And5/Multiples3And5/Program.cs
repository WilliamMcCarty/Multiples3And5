using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Variable int total to store the total
            int total = 0;

            //Loop from 1 to 1000
            for (int i = 1; i < 1000; i++)
            {
                //If multiple of 3 or 5 add to the total
                if (i % 3 == 0 || i % 5 == 0)
                {
                    //Add to the total
                    total += i;
                }
            }

            //Display the total
            Console.WriteLine(total);
        }//End Main
    }// End Class
 }// End Name Space
