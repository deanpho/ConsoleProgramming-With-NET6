// See https://aka.ms/new-console-template for more information
using System.Globalization;

// Empty DateTime
DateTime date = new DateTime(); 


// Create a DateTime from date and time
DateTime dob = new DateTime(1982,05,15,8,1,35);
Console.WriteLine("My Dob is " + dob);
Console.WriteLine("My Dob is " + dob.Date);


// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The time now is " + now);

Console.WriteLine("Day of day " + dob.Day);
Console.WriteLine("Day of week " + dob.DayOfWeek);
Console.WriteLine("Day of Year " + dob.DayOfYear);
Console.WriteLine("Time of day " + dob.TimeOfDay);
Console.WriteLine("Ticks " + dob.Ticks);
Console.WriteLine("Kind " + dob.Kind); //local time zone | universal time zone

// Create a DateTime from a string
DateTime datefromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The date from string is " + datefromString);

// Add Additional Time
Console.WriteLine("One hour from now is " + now.AddHours(1));
Console.WriteLine("One day from now is " + now.AddDays(1));

// Ticks from DateTime
Console.WriteLine("Time as a numeral " + now.Ticks);

// Date Only
DateOnly dateonlyOfBirth = DateOnly.FromDateTime(dob);
Console.WriteLine("Date only " + dateonlyOfBirth);

// Time only
TimeOnly timeOnly = TimeOnly.FromDateTime(dob);
Console.WriteLine("Time only " + timeOnly);