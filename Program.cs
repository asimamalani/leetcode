using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = ValidParentheses.Run("{}()[({(})]");
            System.Console.WriteLine(result);
        }
    }
}
