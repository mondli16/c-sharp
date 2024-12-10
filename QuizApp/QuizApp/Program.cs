// See https://aka.ms/new-console-template for more information

string question1 = "What is the capital of Germany";
string answer1 = "Berlin";

string question2 = "What is 2+2";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow";
string answer3 = "Green";

int score = 0;

Console.WriteLine(question1);
string userAnser1 = Console.ReadLine();
if (userAnser1 == answer1)
{
    Console.WriteLine("Correct");
    score++;
}

Console.WriteLine(question2);
string userAnser2 = Console.ReadLine();
if (userAnser2 == answer2)
{
    Console.WriteLine("Correct");
    score++;
}

Console.WriteLine(question3);
string userAnser3 = Console.ReadLine();
if (userAnser3 == answer3)
{ 
    Console.WriteLine("Correct");
    score++;
}

Console.WriteLine("Your score is "+ score);
Console.ReadKey();