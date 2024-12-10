

//// in strings \ is an Escape character
//// \n stands for "new line"
//// \r - carriage return

//// Thread.Sleep(1000) sleeps for a second


//Console.WriteLine("Count up");
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"I is {i}");
//    Thread.Sleep(1000);
//}


//Console.WriteLine("Count down");
//for (int counter = 10; counter >0; counter--)
//{
//    Console.WriteLine($"I is {counter}");
//    Thread.Sleep(1000);
//}

//int  mondli = 0;

//while (mondli < 5)
//{
//    Console.WriteLine($"I is {mondli}");
//    Thread.Sleep(1000);
//    mondli++;
//}

//// while is best used for boolean

//bool isGood = true;
//while (isGood)
//{
//    Console.WriteLine("Life is Good");
//    isGood = false;
//}




//Console.ReadKey();

//Console.WriteLine("Welcome to the adverture game");
//Console.WriteLine("Enter your character's name");
//string playName = Console.ReadLine();
//Console.WriteLine("Choose your character type (Warrior, Wizard, Archer");
//string characterType = Console.ReadLine();

//Console.WriteLine($"You, {playName} the {characterType} find yourself at the edge of a dark forest");
//Console.WriteLine("Do you enter the forest or camp outSide(Enter/Camp)");

//string choice1 = Console.ReadLine();

//if (choice1.ToLower() == "enter")
//{
//    Console.WriteLine("You bravely enter the forest");
//}

//else
//{ 
//        Console.WriteLine("You decide to camp out and wait for daylight");
//}

//bool gameContinues = true;

//while (gameContinues)
//{
//    Console.WriteLine("You come to a fork road. Go left or right");
//    string direction = Console.ReadLine();

//    if (direction.ToLower() == "left")
//    {
//        Console.WriteLine("You find a treasure chest!");
//        gameContinues = false;
//    }

//    else 
//    {
//        Console.WriteLine("You encounter a wild beast!");
//        Console.WriteLine("Fight or flee (fight/flee)");
//        string fightChoice = Console.ReadLine();
//        if (fightChoice.ToLower() == "fight")
//        {
//            Random random = new Random();
//            int luck = random.Next(1, 11);

//            if(luck > 5)
//            {
//                Console.WriteLine("You beat the wild beast!");
//                if(luck > 8)
//                {
//                    Console.WriteLine("The wild beast dropped a treasure!");
//                }
//            }
//            else
//            {
//                Console.WriteLine("You are dead");
//                gameContinues = false;
//            }
//        }
//    }
//}


