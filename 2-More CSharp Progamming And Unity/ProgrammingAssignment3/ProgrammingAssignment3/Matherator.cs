using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment3
{
    /// <summary>
    /// Provides a variety of numeric methods
    /// </summary>
    public class Matherator
    {
        
        /// Constructor
        public Matherator()
        {
        }
        
        
        /// Prints the numbers from 1 to 10
        public void PrintOneToTen()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }


        /// Prints the numbers from m to n
        public void PrintMToN(int m, int n)
        {
            for (int i = m; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

    
        /// Returns the tenth even number, with 2 as the first even number
        public int GetTenthEvenNumber()
        {

            return GetNthEvenNumber(10);
        }

      
        /// Returns the nth even number, with 2 as the first even number
        public int GetNthEvenNumber(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            else
            {
                n = n * 2;
                return n;
            }
        }


    }
}