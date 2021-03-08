using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempString;
            while (true)
            {
                Console.WriteLine("Write something:");
                tempString = Console.ReadLine();
                char[] charArray = tempString.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(new string(charArray));
            }
        }
    }
}
