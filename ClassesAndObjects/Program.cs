// See https://aka.ms/new-console-template for more information

// primitive datatypes (int, string, char, bool)

// Object Oriented Programming - Creating your own datatype
// class - blueprint of an object

// Single responsibility Principle

using ClassesAndObjects;

Person person = new();
string middleName = String.Empty;


Console.WriteLine("Enter Your First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Your Middle Name: ");
middleName = Console.ReadLine();

Console.WriteLine("Enter Your Last Name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Your Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Your Salary: ");
int salary = Convert.ToInt32(Console.ReadLine());


if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Your Full Name is: " + person.getFullName());
}
else
{
    Console.WriteLine("Your Full Name is: " + person.getFullName(middleName));
}

//person.setAge(age);

person.setSalary(salary);

//Console.WriteLine ("Your Age is: " + person.getAge());

Console.WriteLine("Your Age is: " + DateUtil.YearOfBirth(person.Age));
Console.WriteLine("Your Salary is: " + person.getSalary());


















//Person person = new();

//Console.WriteLine("Enter First Name");
//person.FirstName = Console.ReadLine();

//Console.WriteLine("Enter Last Name");
//person.LastName = Console.ReadLine();

//Console.WriteLine("Enter Person Age");
//person.Age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Person Salary");
//int salary = Convert.ToInt32(Console.ReadLine());



//person.getSalary(salary);

//Console.WriteLine("First Name is: " + person.FirstName);
//Console.WriteLine("Last Name is: " + person.LastName);
//Console.WriteLine("Your full name is: " + person.getFullName());
//Console.WriteLine("Person age is: " + person.Age);
//Console.WriteLine("Person Salary is: " + person.setSalary());

