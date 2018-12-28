using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2018
{
    class Day1
    {
        public int RunPart1()
        {
            int count = CalculateFrequency();

            return count; 
        }

        public int RunPart2()
        {
            int count = FindFirstDuplicateFrequency();

            return count;
        }

        //Solves Part 1
        private int CalculateFrequency()
        {
            int count = 0;
            List<string> input = GetInput();

            foreach (string item in input) {
                char op = item[0];
                int.TryParse(item.Substring(1), out int number);

                if (op == '+') {
                    count += number;
                }
                else if(op == '-')
                {
                    count -= number;
                }
            }

            return count;
        }

        //Solves Part 2
        private int FindFirstDuplicateFrequency() {
            var list = GetInput();
            HashSet<int> frequencies = new HashSet<int>();
            int i = 0;
            var frequency = 0;
            while (true)
            {
                int.TryParse(list[i % list.Count], out int number);
                frequency += number;
                if (frequencies.Contains(frequency))
                {
                    return frequency;
                }
                frequencies.Add(frequency);
                i++;
            }
        }

        private List<string> GetInput()
        {
            string line;
            List<string> input = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader(@".\Day1\Day1Input.txt");
            while ((line = file.ReadLine()) != null)
            {
                input.Add(line);
            }

            return input;
        }
    }
}
