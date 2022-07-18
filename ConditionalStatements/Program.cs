// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter number of apples: ");
int numofApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numofOranges = Convert.ToInt32(Console.ReadLine());


//if Statement (<, >, ==, !=, <=, >=)
if (numofApples > numofOranges)
{
    Console.WriteLine("You have more apples");
}
else if (numofApples < numofOranges)
{
    Console.WriteLine("You have more oranges");
}
else if (numofApples == numofOranges)
{
    Console.WriteLine("You have the same amount of apples and oranges");
}
else
{
    Console.WriteLine("Invalid entry!");
}

//--------------------------------------------------------------------------------
Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
//switch Statement
switch (grade)
{
    case int n when (n >= 0 && n < 60):
        Console.WriteLine("You failed");
        break;
    case int n when (n >= 60 && n <=100):
        Console.WriteLine("You passed");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}

//Ternary Operator
var message = numofApples > numofOranges ? "You have more Apples" : "You have more Oranges";
Console.WriteLine(message);