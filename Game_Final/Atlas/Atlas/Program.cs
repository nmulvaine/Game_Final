using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;


///Console.WriteLine("Welcome To Atlas.");
string message = "║";

for (int i = 0; i < 4; i++)
{
    Console.Clear();
    Thread.Sleep(500);

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
Console.WriteLine("║Please if you're there, answer me. Who is this?");
Thread.Sleep(2500);
Console.Clear();
Console.ReadLine();
string userName = Console.ReadLine();
Console.Write("║Hello" + userName, "\r\n║I was designed to help my creator safely go North.", 
"I can't seem to remember how we got there though... Could you tell me?");
Thread.Sleep(1500);