﻿namespace ClassesAndObjects;

internal static class DateUtil
{
    public static int YearOfBirth( int age)
    {
        return DateTime.Now.Year - age;
    }

    public static int YearOfBirth(DateTime dateofBirth)
    {
        if (dateofBirth == null)
            return 0;
        return dateofBirth.Year;
    }

    public static int Age(DateTime dateOfBirth)
    {
        if (dateOfBirth == null)
        {
            return 0;
        }
        else
        {
            return DateTime.Now.Year - dateOfBirth.Year;
        }
    }
}

