using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingSession
{
    internal class Application
    {
        public void Run()
        {
            var lastDepth = -1;
            var numberOfDepthIncreases = 0;

            foreach (var line in File.ReadLines("C:\\Users\\chris\\OneDrive\\Bilder\\Downloaded\\day1input.txt"))
            {
                var currentDepth = int.Parse(line.Trim());
                if (lastDepth != -1 && currentDepth > lastDepth)
                {
                    numberOfDepthIncreases++;
                }
                lastDepth = currentDepth;
            }

            Console.WriteLine($"Antal: {numberOfDepthIncreases}");
        }
    }
}
