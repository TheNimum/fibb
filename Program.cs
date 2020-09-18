using System;
using System.Collections.Generic;

namespace fibb
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fibnum = new List<int> {1, 1};
                while(Fibnum.Count < 20)
                {
                    var prev = Fibnum[Fibnum.Count -1];
                    var prev2 = Fibnum[Fibnum.Count -2];
                    Fibnum.Add(prev + prev2);
                }
            
                    foreach (var item in Fibnum)
                    {
                        Console.WriteLine(item);
                    }

        }
    }
}
