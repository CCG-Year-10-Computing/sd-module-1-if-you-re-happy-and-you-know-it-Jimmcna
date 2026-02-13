// Program Name:adventure to the gold pot 
// Created on: Visual Studio
// Author: Jim McNamara test

// Variables
string dayResponse;


Console.Write("Enter your nickname: ");
string nickname = Console.ReadLine();

//Day going good, Bad and or alright
Console.WriteLine($"Hello, {nickname}, hows your day going? (Good, Bad or Alright)");
dayResponse = Console.ReadLine();

if (dayResponse == "Good")
{
    Console.WriteLine("Thats Great, but I have something that can make your day even better!");
}

else if (dayResponse == "bad")
{
    Console.WriteLine("Thats sad, but I have something that can make your frown go upsidown!) ");
}

else if (dayResponse == "alright")
{
    Console.WriteLine("Thats Good, but I have something that can make your day turn from alright to amazing!!");
}

else
{
    Console.WriteLine("you failed to input the right answer please restart the code");
}
//telling player about the gold pot

string AncientGoldPotyn;
Console.WriteLine($"{nickname}, have you heard of the ancient Gold pot (Yes or No)");
AncientGoldPotyn = Console.ReadLine();

if (AncientGoldPotyn == "Yes")
{
    Console.WriteLine("Well Thats great, but ill give you a quick rundown, The ancient gold pot or better known as the AGP is a legendary pot that contains enough riches to set you up for life ");
}

else if (AncientGoldPotyn == "No")
{
    Console.WriteLine("Well... The Ancient Gold Pot or the AGP for short is a well know legend know by the locals, the AGP contanins enough money to set you up for life! ");
}
a