using System;
using System.Text;

namespace LowerUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            Array.Sort(args);
            StringBuilder finalString = new StringBuilder();
            for (int i = 0; i < args.Length; i++)
            {
                finalString.Append(args[i].ToLower());
                if (i != args.Length -1)
                    finalString.Append("_");
            }
            Console.WriteLine(finalString);
        }
    }
}