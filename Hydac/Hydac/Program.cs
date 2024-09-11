using System.Runtime.CompilerServices;

namespace Objects_and_domains
{
    internal class Program
    {
        static void pass()
        {
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                    Console.Write("Username: ");
                    string bruger = Console.ReadLine();
                    Console.Write("Password: ");
                    string passkey = Console.ReadLine();

                    if (bruger == "Archie" && passkey == "1234")
                    {
                        Console.WriteLine("Logged in :)");
                        home();
                    }
                    else
                    {
                        fail();
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }

        static void home()
        {

        }

        static void fail()
        {
            Console.Clear();
            Console.WriteLine("Log in invalid or non existant\nPlease select retry or exit to continue:");
            string ask = Console.ReadLine();
            if (ask == "retry")
                pass();
            else if (ask == "exit")
            {

            }


        }

        static void Main(string[] args)
        {

            Console.WriteLine("super sej menu");
            Console.WriteLine("\n1. log in \n2. Opret en bruger");

            string logRequest = Console.ReadLine();

            if (logRequest == "1")
            {
                pass();
            }
            else if (logRequest == "2")
            {

            }
        }
    }
}
