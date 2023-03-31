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

            StringBuilder finalString = new StringBuilder();
            for (int i = 0; i < strs.Count; i++)
            {
                finalString.Append(strs[i]);
                if (i == strs.Count -1)
                    continue;
                finalString.Append("_");
            }

            Console.WriteLine(finalString);

        }
    }
}