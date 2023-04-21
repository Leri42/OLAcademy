using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int AreaOrVolume(int length, int heigth)
        {
            return length * heigth;
        }

        public static int AreaOrVolume(int length, int heigth, int width)
        {
            return length * width * heigth;
        }



        public static string ToBinary()
        {
            Console.WriteLine("Please Enter Number");
            string userInput = Console.ReadLine();
            int num;

            int reminder = 0;
            string numberInStrin = "";
            bool converInputToInt = int.TryParse(userInput, out num);
            while (!converInputToInt)
            {
                Console.WriteLine("You entered wrong value");
                userInput = Console.ReadLine();
                converInputToInt = int.TryParse(userInput, out num);
            }


            while (num > 0)
            {
                reminder = num % 2;
                num /= 2;
                numberInStrin = reminder.ToString() + numberInStrin;

            }


            return numberInStrin;
        }

        public static void UserRegistrationAndLogin()
        {
            Console.WriteLine("For Registration Please Enter User Name");
            string userName = Console.ReadLine();
            Console.WriteLine("For Registration Please Enter User Password");
            string password = Console.ReadLine();
            int count = 0;

            while (count <= 5)
            {
                Console.WriteLine("For Login Please Enter User Name");
                string userNameLogin = Console.ReadLine();
                Console.WriteLine("For Login Please Enter User Password");
                string userNamePassword = Console.ReadLine();
                if (userName == userNameLogin && password == userNamePassword)
                {
                    Console.WriteLine("Succes");
                    break;
                }
                else if (count == 5)
                {
                    Console.WriteLine("Login Failed");
                }
                else
                {
                    Console.WriteLine("User Name Or password is incorect please try again");
                }


                count++;
            }
        }
    }
}
