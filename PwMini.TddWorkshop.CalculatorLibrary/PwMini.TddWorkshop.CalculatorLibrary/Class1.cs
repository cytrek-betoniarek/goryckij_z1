using System;

namespace PwMini.TddWorkshop.CalculatorLibrary
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers.Contains(','))
            {
                string[] args = numbers.Split(',');
                if (args[1].Contains('\n'))
                {
                    string[] subargs = args[1].Split('\n');
                    return int.Parse(subargs[0]) + int.Parse(subargs[1]) + int.Parse(subargs[1]);
                }
                else return int.Parse(args[0]) + int.Parse(args[1]);
            }
            return 0;
        }

        public int MyAdd(int a, int b)
        {
            return a + b;
        }
    }
}
