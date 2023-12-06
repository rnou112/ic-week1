using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev_Week1.Classes
{
    internal class LoopExample
    { 
        public List<int> Numbers { get; set; }

        public LoopExample()
        {
            Numbers = new List<int>();
        }

        public void AddNumbersWithForLoop(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Numbers.Add(i);
            }
            DisplayNumbers();
        }

        public void AddNumbersDoWhile(int count)
        {
            int i = 0;
            do
            {
                Numbers.Add(i);
                i++;
            } while (i < count);
        }

        private void DisplayNumbers()
        {
            foreach(int i in Numbers)
            {
                Console.WriteLine("Number at " + i + " is " + Numbers[i]);
            }     
        }
    }
}
