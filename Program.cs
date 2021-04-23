using System;
using System.Linq;
using System.Collections.Generic;

namespace Plan_Your_Heist
{


    public class Criminal
    {
        public string Name;
        public int SkillLevel;
        public double CourageFactor;
    }

    public class Bank
    {
        public int Difficulty = 100;
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Criminal> criminalList = new List<Criminal>();

            Bank firstFederal = new Bank();

            while(true)
            {
                Console.WriteLine("Enter the criminal's name.");
                string nameInput = Console.ReadLine();

                if (nameInput == "")
                {
                    break;
                }

                Console.WriteLine("Enter the criminal's skill level. (0 - 100)");
                int skillInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the criminal's courage factor. (0.0 - 2.0");
                double courageInput = Convert.ToDouble(Console.ReadLine());
                if (courageInput <0.0 || courageInput >2.0)
                {
                    Console.WriteLine("Enter a valid number between 0.0 and 2.0");
                    Convert.ToDouble(Console.ReadLine());
                }


                Criminal criminal = new Criminal();
                criminal.Name = nameInput;
                criminal.SkillLevel = skillInput;
                criminal.CourageFactor = courageInput;
                
                criminalList.Add(criminal);

            };  

            Console.WriteLine("Number of Criminals in the team: " + criminalList.Count());
            int totalSkillLevelOfCrew = criminalList.Sum(crew => crew.SkillLevel);


            if (totalSkillLevelOfCrew > firstFederal.Difficulty)
            {
                Console.WriteLine("You robbed that mother fucker!");
            }
            else
            {
                Console.WriteLine("You got caught, Cabbitches!");
            }


            // Phase Two
            // List<Criminal> criminalList = new List<Criminal>();

            // while(true)
            // {
            //     Console.WriteLine("Enter the criminal's name.");
            //     string nameInput = Console.ReadLine();

            //     if (nameInput == "")
            //     {
            //         break;
            //     }

            //     Console.WriteLine("Enter the criminal's skill level.");
            //     int skillInput = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Enter the criminal's courage factor.");
            //     double courageInput = Convert.ToDouble(Console.ReadLine());


            //     Criminal criminal = new Criminal();
            //     criminal.Name = nameInput;
            //     criminal.SkillLevel = skillInput;
            //     criminal.CourageFactor = courageInput;
                
            //     criminalList.Add(criminal);

            // };  

            // Console.WriteLine("Number of Criminals: " + criminalList.Count());

        }
    
    }
            
}