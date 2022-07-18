// See https://aka.ms/new-console-template for more information


//Basic Assignment Operator
int num = 5;



//Arithmetic Operators
int num1 = 11;
int num2 = 12;

int adding = num1 + num2;  
int subtraction = num1 - num2;
int multiply = num1 * num2;
int division = num1 / num2;
int modulus = num1 % num2;

Console.WriteLine($"adding: {adding}");
Console.WriteLine($"subtraction: {subtraction}");
Console.WriteLine($"multiply: {multiply}");
Console.WriteLine($"division: {division}");
Console.WriteLine($"modulus: {modulus}");


//Compound Assignment Operators
num1 += 4; //equal value as (num1 = num1 + 4)
Console.WriteLine(num1);
num1 -= 4; //equal value as (num1 = num1 - 4)
Console.WriteLine(num1);
num1 *= 4; //equal value as (num1 = num1 * 4)
Console.WriteLine(num1);
num1 /= 4; //equal value as (num1 = num1 / 4)
Console.WriteLine(num1);
num1 %= 4; //equal value as (num1 = num1 % 4)
Console.WriteLine(num1);