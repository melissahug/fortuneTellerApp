using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to your future. Continue at your own risk.\n\n\n\n");

            Console.WriteLine("What is your FIRST NAME?\nOr type 'q' to quit");
            string firstName = (Console.ReadLine());
            
                    if (firstName == "q")
                    {
                        Console.WriteLine("NO ONE LIKES A QUITTER!!");
                        Environment.Exit(0);
                    }
            
            Console.WriteLine("What is your LAST NAME?\nOr type 'q' to quit");
            string lastName = (Console.ReadLine());

                    if (lastName == "q")
                    {
                            Console.WriteLine("NO ONE LIKES A QUITTER!!");
                            Environment.Exit(0);
                    }

            Console.WriteLine("What is your AGE?\nOr type '99' to quit");
            int userAge = int.Parse(Console.ReadLine());
            int divisor = 2;
            
                    if (userAge == 99)
                    {
                        Console.WriteLine("NO ONE LIKES A QUITTER!!");
                        Environment.Exit(0);
                    }
                    else if (userAge % divisor == 0)

                            {
                                userAge = 2;
                            }
                            else
                            {
                                userAge = 99;
                            }
            
            Console.WriteLine("What is your birth month? Please put a 2 digit month (01 - 12). \nOr type '99' to quit");
            int birthMonth = int.Parse(Console.ReadLine());

                        if (birthMonth == 99)
                        {
                            Console.WriteLine("NO ONE LIKES A QUITTER!!");
                            Environment.Exit(0);

                        }
                        else if (birthMonth == 01 || birthMonth == 02 || birthMonth == 03 || birthMonth == 04)
                        {
                            birthMonth = 25;
                        }
                        else if (birthMonth == 05 || birthMonth == 06 || birthMonth == 07 || birthMonth == 08)
                        {
                            birthMonth = 75000000;
                        }
                        else if (birthMonth == 09 || birthMonth == 10 || birthMonth == 11 || birthMonth == 12)
                        {
                            birthMonth = 19000;
                        }
                        else
                        {
                            birthMonth = 0;
                        }

                Console.WriteLine("What is your favorite ROYGBIV color (Please type the entire word)?\n*Don't know what \"ROYGBIV\" is? Just type \"HELP\" for a list.*\nOr type '99' to quit");
                string userFavColor = (Console.ReadLine());
                            if (userFavColor.Equals("help", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.WriteLine("Please type the entire word:\n red\n orange\n yellow\n green\n blue\n indigo\n violet\n\n\nWhat is your favorite ROYGBIV color?\nOr type '99' to quit\n");
                                Console.ReadLine();
                            }

                            else if (userFavColor.Equals("q", StringComparison.CurrentCulture))
                            {
                                Console.WriteLine("NO ONE LIKES A QUITTER!!");
                                Environment.Exit(0);
                            }

                            else if (userFavColor.Equals("red", StringComparison.CurrentCultureIgnoreCase))
                            {
                                userFavColor = "Corvette";
                            }
                            else if (userFavColor.Equals("orange", StringComparison.CurrentCultureIgnoreCase))
                            {
                                userFavColor = "Megabus voucher (restrictions apply)";
                            }
                            else if (userFavColor.Equals("yellow", StringComparison.CurrentCultureIgnoreCase))
                            {
                                userFavColor = "school bus";
                            }
                            else if (userFavColor.Equals("green", StringComparison.CurrentCultureIgnoreCase))
                            {
                                userFavColor = "Prius";
                            }
                            else if (userFavColor.Equals("blue", StringComparison.CurrentCultureIgnoreCase))
                            {
                                userFavColor = "personal jet (you absorb fuel costs)";
                            }
                            else if (userFavColor.Equals("indigo", StringComparison.CurrentCultureIgnoreCase))
                            {
                                userFavColor = "a pair of flying unicorns and unlimited glitter";
                            }
                            else if (userFavColor.Equals("violet", StringComparison.CurrentCultureIgnoreCase))
                            {
                                userFavColor = "Harley (pleather coat included)";
                            }
                            else
                            {
                                userFavColor = "...since you didn't put a requested color, you must walk forever. FOREVER!";
                            }


            Console.WriteLine("How many siblings do you have?\nOr type '99' to quit");
            int userSiblingAmt = Convert.ToInt32(Console.ReadLine());
            string retireLocation = " ";
                    
                            if (userSiblingAmt == 99)
                    {
                        Console.WriteLine("NO ONE LIKES A QUITTER");
                        Environment.Exit(0);
                    }       
                    
                            else if (userSiblingAmt == 0)
                            {
                                retireLocation = "Fiji";
                            }

                            else if (userSiblingAmt == 1)
                            {
                                retireLocation = "Montreal";
                            }

                            else if (userSiblingAmt == 2)
                            {
                                retireLocation = "Miami";
                            }
                            else if (userSiblingAmt == 3)
                            {
                                retireLocation = "Paris";
                            }

                            else if (userSiblingAmt > 3)
                            {
                                retireLocation = "Maui";
                            }

                            else if (userSiblingAmt < 0)

                            {
                                retireLocation = "High school for life";
                            }
         Console.WriteLine("{0} {1} will retire in {2} years with ${3}.00 in the bank, a vaction home in {4} and {5}.", firstName, lastName, userAge, birthMonth, retireLocation, userFavColor);
                }

            }

        }
