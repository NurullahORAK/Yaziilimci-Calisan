using System;

namespace InheritanceUgulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to worker app ");


            while (true)
            {
                Console.WriteLine("Please select an action...");
                Console.WriteLine("1- Software developer operations");
                Console.WriteLine("2- admin operations");
                Console.WriteLine("press q to exit");

                string select = Console.ReadLine();
                if (select == "q")
                {
                    Console.WriteLine("Exiting the application...");
                    break;
                }
                else if (select == "1")
                {

                    while (true)
                    {
                        Programmer programmer = new Programmer(1, "Nurullah", "ORAK", "C#,C,JAVA");
                        Console.WriteLine("Select an software developer operations");
                        Console.WriteLine("1-Formatting");
                        Console.WriteLine("2-Show developer information");
                        Console.WriteLine("press q to exit");
                        string selectOperations = Console.ReadLine();
                        if (selectOperations == "1")
                        {
                            Console.WriteLine("Enter the operating system.");
                            string operatingSystem= Console.ReadLine();
                            programmer.Formatting(operatingSystem);
                        }
                        else if (selectOperations == "2")
                        {
                            programmer.BilgileriGoster();
                        }
                        else if (selectOperations == "q")
                        {
                            Console.WriteLine("Exiting the application...");
                            break;
                        }
                    }
                }
                else if (select == "2")
                {
                    while (true)
                    {
                        Admin admin = new Admin(0, "Mehmet Sıddık", "ORAK", 2);
                        Console.WriteLine("Select an admin operations");
                        Console.WriteLine("1-Get a raise");
                        Console.WriteLine("2-Show admin informations");
                        Console.WriteLine("press q to exit");
                        string adminOperationsSelect = Console.ReadLine();
                        if (adminOperationsSelect == "1")
                        {
                            Console.WriteLine("Enter the raise amount");
                            int raise=Convert.ToInt32(Console.ReadLine());
                            admin.zamYap(raise);
                        }
                        else if (adminOperationsSelect == "2")
                        {
                            admin.BilgileriGoster();
                        }
                        else if(adminOperationsSelect == "q") 
                        {
                            Console.WriteLine("Exiting the appllication...");
                            break;
                        }
                    }
                }

            }


        }
    }
}
