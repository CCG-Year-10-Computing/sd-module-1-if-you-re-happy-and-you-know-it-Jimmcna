// Program Name:adventure to the gold pot 
// Created on: Visual Studio
// Author: Jim McNamara test

// Variables
string dayResponse;

Console.WriteLine("Welcome adventurer.\r\n\r\nYour younger sister has fallen very sick, and you don’t have enough money to pay for the treatment she needs. You’ve tried working small, lowpaying jobs, but nothing earns money fast enough. Every day, you feel more stressed and helpless.\r\n\r\nOne evening, you overhear some travellers talking about something called The Ancient Gold Pot. They say whoever finds it will gain enough gold to become rich for generations. \r\n\r\nYou quickly ask them where it is. They tell you its hidden in a faraway place called Farquite.\r\n\r\nAs soon as you hear that, you run home, pack your bag, and prepare to leave. This is your only chance to save your sister. Your journey to Farquite begins now.");


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

 