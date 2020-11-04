using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> electionData = new Dictionary<string, int>();

            Console.WriteLine("Enter the file adress: ");
            string path = Console.ReadLine();

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] nameAndVotes = line.Split(',');
                string name = nameAndVotes[0];
                int votes = int.Parse(nameAndVotes[1]);
                if (electionData.ContainsKey(name))
                    electionData[name] = electionData[name] + votes;
                else
                    electionData.Add(name, votes);
            }
            foreach(var candidt in electionData)
            {
                Console.WriteLine(candidt.Key +": "+ candidt.Value);
            }
        }
    }
}
