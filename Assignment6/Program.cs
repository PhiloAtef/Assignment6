using System.ComponentModel;

namespace Assignment6
{
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        #region Q1
        ////Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.
        ////Then, write a C# program that prints out all the days of the week using this enum.
        //enum Weekdays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        //static void Main(string[] args)
        //{
        //    foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
        //    {
        //        Console.WriteLine(day);
        //    }

        //} 
        #endregion

        #region Q2
        //public static void Main(string[] args)
        //{
        //    Person[] persons = new Person[3];

        //    persons[0] = new Person { Name = "philo", Age = 24 };
        //    persons[1] = new Person { Name = "mahmoud", Age = 25 };
        //    persons[2] = new Person { Name = "ahmed", Age = 26 };

        //    foreach (Person person in persons)
        //    {
        //        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        //    }

        //} 
        #endregion

        #region Q3
        //enum Season
        //{
        //    Spring,
        //    Summer,
        //    Autumn,
        //    Winter
        //}

        //static void Main(string[] args)
        //{
        //    Console.Write("Enter season (Spring, Summer, Autumn, Winter): ");
        //    string? originalString = Console.ReadLine();
        //    if (Enum.TryParse(originalString, true, out Season season))
        //    {
        //        string months = GetSeasonMonths(season);
        //        Console.WriteLine($"The months for {season} are {months}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Wrong season entered");
        //    }
        //}

        //static string GetSeasonMonths(Season season)
        //{
        //    switch (season)
        //    {
        //        case Season.Spring:
        //            return "March to May";
        //        case Season.Summer:
        //            return "June to August";
        //        case Season.Autumn:
        //            return "September to November";
        //        case Season.Winter:
        //            return "December to February";
        //        default:
        //            return "Wrong Input";
        //    }
        //} 
        #endregion


    }
}
