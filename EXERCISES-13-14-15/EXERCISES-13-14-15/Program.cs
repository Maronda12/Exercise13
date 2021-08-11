using System;

using System.Linq;

namespace EXERCISES_13_14_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 13


            bool goOn = true;
            while (goOn == true)
            {


                //Get number 
                Console.Write("Please enter a number: ");
                int num = int.Parse((Console.ReadLine()));
                int i;

                /*For loop number entered by user, Decrementing by 1*/
                for (i = num; i >= 1; i--)
                {
                    Console.WriteLine("\n" + i);
                }



                //Continue Loop
                while (true)
                {
                    Console.WriteLine($"Would you like to continue ? y/n");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() == "y")
                    {
                        goOn = true;
                        break;
                    }
                    else if (answer.ToLower() == "n")
                    {
                        Console.WriteLine("Good Bye!");
                        goOn = false;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Im sorry I didnt understand that lets try again");
                    }
                }


            }

        }

    }
}

 
    
    
