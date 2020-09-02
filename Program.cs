using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyggegummiMaskine_project
{
    class Program
    {
        public static int choice = 0;
        public static bool subscription_fee;
        static void Main(string[] args)
        {
            //add manager and call add gums method from dispenser
            Manager man = new Manager();
            man.Addgums();

            //run propgram loop
            while (true)
            {
                //write a welcome text
                string welcometext = "GummyDispenser 3000.";
                Console.WriteLine(string.Format(String.Format("{0," + ((Console.WindowWidth / 2) + (welcometext.Length / 2)) + "}", welcometext)));

                Console.WriteLine(new string('=', Console.WindowWidth));
                Console.WriteLine($"dispenser has been filled with gums. {man.disp.Number_of_gums} remaining");
                Console.WriteLine(new string('=', Console.WindowWidth));

                Console.WriteLine("type 1 to pull a gum from the dispenser\ntype 2 to walk away from the dispenser");
              
                choice = int.Parse(Console.ReadLine());

                // pull a gum from the dispenser
                if (choice == 1)
                {
                    //check if there are any gums left
                    if(man.disp.Number_of_gums > 0)
                    {
                        Console.WriteLine($"you have gotten a gum with {man.RemoveGum()} flavor");
                    }
                    else
                    {
                        string subscription = "";
                        Console.WriteLine("there are no more gums left in the dispenser");
                        
                        //check if there is an subscription
                        if(!subscription_fee)
                        {
                            Console.WriteLine("would you like to buy an subscription to refill the dispenser each month ?");
                            Console.Write("y/n: ");
                            subscription = Console.ReadLine();

                            //answer if the user wants an sucscription
                            if (subscription == "y")
                            {
                                Console.Clear();

                                Console.WriteLine("thank you!\nyour dispenser will be refilled when empty");
                                subscription_fee = true;
                                Console.WriteLine("would you like to refill your dispenser now ?");
                                Console.Write("y/n ");
                                string refill = Console.ReadLine();

                                //ask if user wants to refill
                                if(refill == "y")
                                {
                                    //dispenser is refilled. and spare gums are put aside
                                    man.AddAditionalgums();
                                }

                            }
                        }
                        else
                        {
                            //dispenser is refilled. and spare gums are put aside
                            man.AddAditionalgums();
                        }
                    }
                    
                    
                }
                else
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();
                Console.WriteLine(new string('=', Console.WindowWidth));
                Console.Clear();
            }
            
        }

    }
}
