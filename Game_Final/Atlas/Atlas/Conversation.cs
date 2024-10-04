using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;


namespace Conversation
{
    public class Dialogue
    {
        public void StartConversation()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Clear();
                Thread.Sleep(500);

                string message = "║";
                Console.WriteLine(message);
                Thread.Sleep(500);
            }

            Console.Clear();
            Console.WriteLine("║Hello?");
            Thread.Sleep(1500);
            Console.Clear();
            Thread.Sleep(1500);
            Console.WriteLine("║Is someone there?");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("║Please if you're there, answer me.");
            string userName = GetUserInput("Who are you?");
            Console.Read();
            Console.Clear();



            Console.WriteLine("║Hello" + userName, "\r\n║I was designed to help my creator safely go North.",
            "I can't seem to remember how we got there though... Could you tell me?");
            Thread.Sleep(1500);


        }

        private string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("║ I need to know who I am talking to..." + prompt);
                input = Console.ReadLine();
            }
            return input;
        }
    }







    {
       

        



        }

public class ConsoleSpin
{
    public ConsoleSpin()
    { 
        Console.Write("U+2588");
        Thread.Sleep(500);

        Console.Clear();
        Console.Write("U+2588");
        Thread.Sleep(500);
    }
    

}
    

//Console.Write("Welcome To Atlas.");


