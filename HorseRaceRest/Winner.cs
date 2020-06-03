using Horserace.Core;
using Horserace.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HorseRaceRest
{
    [TestClass]
    public class Winner
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Horse> horses = new List<Horse>
            {
                new Horse { HorseName = "A", Odd = 0.5 },
                new Horse { HorseName = "B", Odd = 2 },
                new Horse { HorseName = "C", Odd = 3 },
                new Horse { HorseName = "D", Odd = 8 }
            };
            int A = 0, B = 0, C = 0, D = 0;
            for (int x = 0; x < 1000000; x++)
            {
                HorseRace horseRace = new HorseRace(horses, 110, 140);
                Horse horse = horseRace.Winner();
                switch (horse.HorseName)
                {
                    case "A":
                        A++;
                        break;
                    case "B":
                        B++;
                        break;
                    case "C":
                        C++;
                        break;
                    case "D":
                        D++;
                        break;
                }

            }

            Assert.IsTrue(A >= 460000 && A <= 500000);


        }
    }
}
