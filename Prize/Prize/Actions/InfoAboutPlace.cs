using System;
using System.Collections.Generic;
namespace Prize.Actions
{
    public class InfoAboutPlace: Interfaces.IInfoAboutPlace
    {
        public string Win { get; set; }

        Models.Prize prize = new Models.Prize();

        public virtual void WinPlace(string place)
        {
            if (place == "1")
            {
                Console.WriteLine($"Sum of your prize is up to {prize.SumPriz[0]}");
            }
            else if (place == "2")
            {
                Console.WriteLine($"Sum of your prize is up to {prize.SumPriz[1]}");
            }
            else if (place == "3")
            {
                Console.WriteLine($"Sum of your prize is up to {prize.SumPriz[2]}");
            }
        }
    }
}
