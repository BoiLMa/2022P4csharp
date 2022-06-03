using System;
using System.Collections.Generic;

namespace Csharp2Opdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> birds = new List<string>() {"uil", "kraai", "hond", "papegaai"};
            List<string> birds2 = new List<string>() {"meeuw", "duif"};
            birds.AddRange(birds2);
            birds.RemoveAt(birds.IndexOf("hond"));
            if (birds.Contains("kip"))
            {
                birds.RemoveAt(birds.IndexOf("kip"));
            }
            for (int i = 0; i < birds.Count; i++)
            {
                Console.WriteLine(birds[i]);
            }
            
        }
    }
}
