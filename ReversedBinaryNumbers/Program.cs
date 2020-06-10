using System;
using System.Collections.Generic;
using System.Linq;

namespace ReversedBinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reversed Binary Numbers
            //  https://open.kattis.com/problems/reversebinary

            //the concept:
            // int --> binary code -->  reverse the order of the code --> int

            // 1 <= N <= 1000000000

            int numBase = 2; // binary is base 2

            var value = int.Parse(Console.ReadLine());
            
            // --* using parse routine *--
            //var value = StringToIntConverter(Console.ReadLine());


            // convert int ---> binary as string
            var binary = Convert.ToString(value, numBase);
            var revBin = Reverse(binary);


            int revNumber = Convert.ToInt32(revBin, 2);

            Console.WriteLine(revNumber);
           
        }

        private static string Reverse(string s)
        {
            var arr = s.ToCharArray();
            List<char> mylist = arr.ToList();
            mylist.Reverse();
            arr = mylist.ToArray();
            var str = char.ToString(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                str = str + arr[i];
            }
            return str;
        }
        private static int StringToIntConverter(string str)
        {
            int num = 0;

            try
            {
                num = int.Parse(str);

                if (num < 1 || num > 1000000000)
                    throw new ArgumentException();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} || {ex.GetType().FullName}");
                str = Console.ReadLine();
                num = StringToIntConverter(str);
                return num;
            }
            return num;
        }
    }
}
