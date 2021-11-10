using System;
using Week4.Services;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {

            GlobalConfig.Instantiate();
            var input = GlobalConfig.collect;
            var print = GlobalConfig.design;
            
           
            while (true)
            {
                input.Input();
                

                Console.WriteLine("Do you want to add another course?? y/n");
                string value = Console.ReadLine();
                if (value == "n")
                    break;

            }
            
            print.Screen(input.courses);
           
        }
    }
}
