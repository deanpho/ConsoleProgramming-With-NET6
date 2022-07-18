// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, You!");

string firstName = "Nguyen";
string lastName = "Pho";
DateTime date = DateTime.Now;


// Print to screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed");

// Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + lastName + " " + firstName);
Console.WriteLine($"My full name is {lastName}, {firstName}");
Console.WriteLine("My full name is {0}, {1}", lastName, firstName);

// String length
int mylenght = firstName.Length;
Console.WriteLine("Your name is {0} letters long", mylenght);

// Resplace string parts
string newName1 = firstName.Replace('N', 'D');
Console.WriteLine("Your new firstName is " + newName1);

string newName2 = lastName.Replace('P', 'N');
Console.WriteLine("Your new lastName is " + newName2);


// Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine("Your full name is " + fullName);

// Split string
string[] splitName = fullName.Split('n');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

string nullString = null; //set as null
string emptyString = ""; //set as empty (same as (string abcd = string.Empty)
string whiteSpaceString = " ";

// Compare strings
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if (firstName == lastName)
{
    Console.WriteLine("Name is equal");
}

if (firstName != lastName)
{
    Console.WriteLine("Name is equal");
}

int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}

// Convert to String
int num = 123;
string a = "";

a = num.ToString();
a = 1243535.ToString();