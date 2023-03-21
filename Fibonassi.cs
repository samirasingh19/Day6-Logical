using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Fibonassi
    {
        public static void Fibo()
        {
            int firstnumber = 0, secondnumber = 1, nextnumber, numberofelements;
            Console.WriteLine("Enter the number of elements : ");
            numberofelements = Convert.ToInt32(Console.ReadLine());
            if (numberofelements < 2)
            {
                Console.WriteLine("Please enter a value greater than two");
            }
            else
            {
                Console.WriteLine(firstnumber + "," + secondnumber);
                for (int i = 2; i < numberofelements; i++)
                {
                    nextnumber = firstnumber + secondnumber;
                    Console.WriteLine(nextnumber + " ");
                    firstnumber = secondnumber;
                    secondnumber = nextnumber;
                }
            }
        }
    }
}
