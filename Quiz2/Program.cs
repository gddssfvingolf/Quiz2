//quiz n2
using System;
//დავალება 1
public class Program
{

    public static void Main(string[] args)
    {
        int i, limit, sumOdd = 0;
        Console.WriteLine("Enter the limit :");

        limit = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= limit; i++)
        {
            if (i % 2 != 0)
            {
                sumOdd += i;
            }
        }

        Console.WriteLine("Total sum: " + sumOdd);
    }
}

//დავალება 2

namespace palindromecheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1, rev;
            string1 = "Malayalam";
            char[] ch = string1.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + string1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + string1 + " is not a Palindrome!");
            }
            Console.Read();
        }
    }
}
//დავალება 3


//დავალება 4
public class GFG
{

    // მასივში ყველაზე ხშირად გამეორებადი ელემენეტის მოძებნა
    public static int mostFrequent(int[] arr, int n)
    {
        int maxcount = 0;
        int element_having_max_freq = 0;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }

            if (count > maxcount)
            {
                maxcount = count;
                element_having_max_freq = arr[i];
            }
        }

        return element_having_max_freq;
    }

    // Driver program
    public static void Main(String[] args)
    {
        int[] arr = { 40, 50, 30, 40, 50, 30, 30 };
        int n = arr.Length;
        Console.Write(mostFrequent(arr, n));
    }
}