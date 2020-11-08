using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LalitSaini_08NOV2020
{
    enum TossDay
    {
        day = 1,
        night = 2
    }

    enum Weather
    {
        clearday = 1,
        cloudyDay = 2
    }

    class Toss
    {
        public TossDay day { get; set; }
        public Weather weather { get; set; }

        public void GetResult()
        {
            string tResult = "";
            switch (day)
            {
                case TossDay.day:
                    if (weather == Weather.clearday)
                        Console.WriteLine("Lengaburu wins toss and bats \n" +
                                           "Enchai win toss and bowls");
                    else
                        Console.WriteLine("Lengaburu wins toss and Bowls \n" +
                                           "Enchai win toss and Bats");//Not Clear
                    break;
                case TossDay.night:
                    if (weather == Weather.clearday)
                        Console.WriteLine("Lengaburu wins toss and bats \n" +
                                           "Enchai win toss and bowls");//Not Clear
                    else
                        Console.WriteLine("Lengaburu wins toss and Bowls \n" +
                                           "Enchai win toss and Bats");
                    break;
            }

        }

    }
}
