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

else
{
    Console.WriteLine("you failed to input the right answer please restart the code");
}

//Starting the adventure

Console.WriteLine($"{nickname}, will you travel to Farquite to search for the Ancient Gold Pot? (Yes or No)");
string travelChoice = Console.ReadLine();

if (travelChoice == "Yes")
{
    Console.WriteLine("You pack your bag with food, water and a small sword for protection.");
    Console.WriteLine("After saying bye to your sister you begin your journey to Farquite.");
    Console.WriteLine("After hours of walking you arrive at a dark forest that blocks your path.");
}
else if (travelChoice == "No")
{
    Console.WriteLine("You decide the journey is too dangerous.");
    Console.WriteLine("Without the gold, your sister's future remains rocky and unknown...");
}
else
{
    Console.WriteLine("you failed to input the right answer please restart the code");
}

//Forest choice

Console.WriteLine($"\n{nickname}, do you ENTER the forest or WALK around it? (Enter or Walk)");
string forestChoice = Console.ReadLine();

if (forestChoice == "Enter")
{
    Console.WriteLine("You step into the dark forest.");
    Console.WriteLine("The trees are tall and the path is hard to see.");
    Console.WriteLine("Suddenly you hear something moving in the bushes...");
}
else if (forestChoice == "Walk")
{
    Console.WriteLine("You choose to walk around the forest.");
    Console.WriteLine("The path is longer, but it safer.");
    Console.WriteLine("As night begins to come, you see lights in the distance.");
}
else
{
    Console.WriteLine("you failed to input the right answer please restart the code");
}

//Bush or lights decision

Console.WriteLine($"{nickname}, do you INVESTIGATE the sound or RUN away? (Investigate or Run)");
string bushChoice = Console.ReadLine();

if (bushChoice == "Investigate")
{
    Console.WriteLine("You slowly walk toward the bushes holding your sword tightly.");
    Console.WriteLine("A small injured fox jumps out. It is not dangerous.");
    Console.WriteLine("You calm down and continue deeper into the forest.");
}
else if (bushChoice == "Run")
{
    Console.WriteLine("You quickly run away from the noise.");
    Console.WriteLine("After sprinting for a while, you trip over a rock and drop some things.");
    Console.WriteLine("You get back up and continue carefully.");
}
else
{
    Console.WriteLine("you failed to input the right answer please restart the code");
}

Console.WriteLine($"{nickname}, you finally reach the edge of the forest.");
Console.WriteLine("In front of you stands a huge stone gate with strange writing.");
Console.WriteLine("This must be the entrance to Farquite.");

//Gate choice

Console.WriteLine("Do you PUSH the gate open or LOOK for another way in? (Push or Look)");
string gateChoice = Console.ReadLine();

if (gateChoice == "Push")
{
    Console.WriteLine("You push with all your strength.");
    Console.WriteLine("The gate slowly opens with a loud rumble.");
    Console.WriteLine("Inside, you see a glowing golden light in the distance...");
}
else if (gateChoice == "Look")
{
    Console.WriteLine("You search around the walls and find a hidden lever.");
    Console.WriteLine("You pull it, and the gate opens quietly.");
    Console.WriteLine("A golden glow shines from inside the ancient ruins...");
}
else
{
    Console.WriteLine("you failed to input the right answer please restart the code");
}

Console.WriteLine($"{nickname}, your heart is racing");
Console.WriteLine("At the center of the ruins, on a stone, sits The Ancient Gold Pot.");
Console.WriteLine("But standing in front of it is a large guardian.");

//Final choice

Console.WriteLine("Do you FIGHT the guardian or TRY to sneak past it? (Fight or Sneak)");
string finalChoice = Console.ReadLine();

if (finalChoice == "Fight")
{
    Console.WriteLine("You charge forward.");
    Console.WriteLine("After a long battle, you defeat the guardian.");
    Console.WriteLine("You claim The Ancient Gold Pot and secure your sister's future.");
    Console.WriteLine("You have achieved generational wealth. You Win!");
}
else if (finalChoice == "Sneak")
{
    Console.WriteLine("You carefully move in the shadows.");
    Console.WriteLine("You successfully sneak past the guardian and grab the Gold Pot.");
    Console.WriteLine("Without making a sound, you escape Farquite.");
    Console.WriteLine("Your sister will be saved. You Win!");
}
else
{
    Console.WriteLine("you failed to input the right answer please restart the code");
}
