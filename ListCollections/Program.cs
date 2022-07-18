// See https://aka.ms/new-console-template for more information

// Declare
List<string> names = new List<string>();
string name = "";

// Add values to list
names.Add("Nguyen");

Console.WriteLine("Enter Names: ");
//while (name != "-1")
//while (name.Equals("-1") == false)
while (!name.Equals("-1"))
{
    Console.Write("Enter Name: ");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.Write($"the name: {name} is added sucessfully");
        
    }
    
}

// Print values in list
Console.WriteLine("printing names via for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names via foreach loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}