// See https://aka.ms/new-console-template for more information

/*
    Declare Variable
        - Data Types
            -string     words/numbers (Name, License plate number) - "abc"
            -int        whole numbers | double/float - decimal
            -char       One Character ('A', '9' '%')
*/

string firstName = "Jackson"; //CamelCase
string LastName = "Smith"; //PascalCase

/*
Allow user input and store in variable
*/
Console.WriteLine($"Good Day Mr {LastName}! \r\nPlease enter your first name");
firstName = Console.ReadLine();

/*
Print contents of variable/user's input
*/
if (firstName == "Jackson")
{
    Console.WriteLine($"Thank you for the verification Mr {LastName + " " +firstName}, welcome to this world!");
}
else
{
    Console.WriteLine("You are not known!");
}


