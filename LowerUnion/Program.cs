using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LowerUnion
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<String> strs = new List<string>();
            args.ToList().ForEach(s => strs.Add(s.ToLower()));
            strs.Sort();
            strs.ForEach(str => Console.Write(str + " "));
            Console.WriteLine();





        }
    }
}