using System;

namespace DojoDachi.Models
{
    public class Jordan
    {
        public int Happiness;
        public int Fullness;
        public int Energy;
        public int Meals;
        public string ImgUrl;
        public bool didWin
        {
            get
            {
                return Happiness >= 100 && Fullness >= 100 && Energy >= 100;
            }
        }
        public bool didLose
        {
            get
            {
                return Happiness <= 0 || Fullness <= 0;
            }
        }


        public Jordan()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
        }

        public string Play()
        {
            ResetMike();
            if (Energy == 0)
            {
                return "Jordan is tired from carrying the team.";
            }
            else if (Energy < 5)
            {
                Energy = 0;
            }
            else if (TwentyFiveChance())
            {
                Energy -= 5;
                return $"Jordan isnt happy with you performance.";
            }
            else
            {
                Energy -= 5;
            }
            Random rand = new Random();
            int hap = rand.Next(5, 11);
            Happiness += hap;
            return $"You passed the ball to Jordan and gained {hap}";
        }

        public string Feed()
        {
            ResetMike();
            if (Meals == 0)
            {
                return "Jordan needs Food.";
            }
            else if (TwentyFiveChance())
            {
                Meals--;
                return $"You gave Jordan a snack but he spit it out.";

            }
            Random rand = new Random();

            Meals--;
            int full = rand.Next(5, 11);
            Fullness += full;
            return $"Jordan ate a whole pizza, gaining {full} Fullness.";
        }

        public string Work()
        {
            ResetMike();

            if (Energy == 0)
            {
                return "Jordan is exhausted. Let him get some sleep";
            }
            else if (Energy < 5)
            {
                Energy = 0;
            }
            else
            {
                Energy -= 5;
            }
            Random rand = new Random();
            int work = rand.Next(1, 4);
            Meals += work;
            return $"Jordan went to get some work in and gained {work} meals";
        }

        public string Sleep()
        {
            ResetMike();
            Happiness -= 5;
            Fullness -= 5;
            Energy += 15;
            return $"Jordan took a nap and gained 15 energy.";
        }

        static bool TwentyFiveChance()
        {
            Random rand = new Random();
            return rand.Next(0, 101) <= 25;
        }
        public void ResetMike()
        {
            ImgUrl = "jordan.jpg";
        }
    }
}