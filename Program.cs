using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LalitSaini_08NOV2020
{
    class Program
    {
        public string day = "";
        public string weather = "";
        public Program tProgram;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.tProgram = program;
            Console.WriteLine("Welcome To the Team Toss");
            program.Start(program);
        }

        private void Start(Program tProgram)
        {
            if (tProgram.weather == "")
            {
                tProgram.weather = GetWeather();
                int.TryParse(tProgram.weather, out int iWeather);
                if (!Enum.IsDefined(typeof(Weather), iWeather))
                {
                    Console.WriteLine("Invalid Weather Input, please Enter Again.");
                    tProgram.weather = "";
                    Start(tProgram);
                }
            }

            if (tProgram.day == "")
            {
                tProgram.day = GetTossDay();
                int.TryParse(tProgram.day, out int iDay);

                if (!Enum.IsDefined(typeof(TossDay), iDay))
                {
                    Console.WriteLine("Invalid Day Input, please Enter Again.");
                    tProgram.day = "";
                    Start(tProgram);
                }
            }

            Toss toss = new Toss
            {
                day = (TossDay)Enum.Parse(typeof(TossDay), tProgram.day),
                weather = (Weather)Enum.Parse(typeof(Weather), tProgram.weather)
            };

            toss.GetResult();
            Console.ReadLine();

        }

        static string GetWeather()
        {
            Console.WriteLine("Please enter  weather Condition \n" +
                                 "1 for Clear Day \n" +
                                 "2 for  Cloudy Day");
            return Convert.ToString(Console.ReadLine());
        }

        static string GetTossDay()
        {
            Console.WriteLine("Please enter Day/Night \n" +
                                "1 for Day \n" +
                                "2 for Night");

            return Convert.ToString(Console.ReadLine());
        }

        
    }


}
