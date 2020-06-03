using Horserace.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Horserace.Helper
{
   public class HorseRace
    {
        public List<Horse> _horses { get; }
        const int MinHorsesNeededForRace = 4;
        const int MaxHorsesCouldBeRaced = 16;
        private readonly double _minMargin;
        private readonly double _maxMargin;
        double margin;
        public HorseRace(List<Horse> horses, double minMargin, double maxMargin)
        {
            _horses = horses;
            _minMargin = minMargin;
            _maxMargin = maxMargin;

            margin = _horses.Sum(f => f.Margin);
            foreach (var horse in horses)
            {
                horse.ChanceOfWinning = (horse.Margin / margin);
            }
        }
        private bool IsValidHorseCount()
        {
            return (_horses.Count >= MinHorsesNeededForRace && _horses.Count <= MaxHorsesCouldBeRaced);
        }
        private bool IsValidMargin()
        {
            return (margin >= _minMargin && margin <= _maxMargin);
        }
        public bool IsValidRace()
        {
            return IsValidHorseCount() && IsValidMargin();
        }
        public Horse Winner()
        {
            Random r = new Random();
            Horse winner = new Horse();
            double diceRoll = r.NextDouble();
            double cumulative = 0.0;
            for (int i = 0; i < _horses.Count; i++)
            {
                cumulative += _horses[i].ChanceOfWinning;
                if (diceRoll <= cumulative)
                {
                    winner = _horses[i];
                    break;
                }
            }
            return winner;
        }
    }
}
