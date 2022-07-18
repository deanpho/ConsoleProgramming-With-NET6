// See https://aka.ms/new-console-template for more information
// in simple term, an Array is a collection of values


// Declare Fixed Size Array
int[] grades = new int[5];

// Add values to Fixed Size Array

//grades[0] = 1;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;

//grades = new int[] { 2, 3, 4, 5, 6, 7 };


// Print values in Fixed Size Array
Console.WriteLine("Enter all Grades");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("The grades you have entered are");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

// Declare Variable Sized Array
string[] studentNames = new string[] {"", "", ""};

for (int i = 0;i < studentNames.Length; i++)
{
    Console.WriteLine("This array are for the Names of students");
    studentNames[i] = Console.ReadLine();
}
// Add values to Variable Sized Array

// Print values in Variable Sized Array
