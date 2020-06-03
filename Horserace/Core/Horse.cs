using System;

namespace Horserace.Core
{
    public class Horse
    {
        public String HorseName { get; set; }
        public string Odds { get; set; }
        public double Odd { get; set; }
        public double Margin
        {
            get
            {
                return (100 / (Odd + 1));
            }
        }
        public double ChanceOfWinning { get; set; }

    }
}
