using System.ComponentModel;

namespace Assignment6
{
    enum Weekdays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    enum Season { Spring, Summer, Autumn, Winter }
    enum Colors { Red, Green, Blue }
    
    [Flags]
    enum Permissions
    { Read = 1, Write = 2, Delete = 4, Execute = 8 }

    class WeekDaysEnum
    {
        public static void PrintAllWeekDays()
        {
            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine(day);
            }
        }
    }

    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class PersonManager
    {
        private Person[] persons;

        public PersonManager()
        {
            persons = new Person[3];
            persons[0] = new Person { Name = "philo", Age = 24 };
            persons[1] = new Person { Name = "mahmoud", Age = 25 };
            persons[2] = new Person { Name = "ahmed", Age = 26 };
        }

        public void DisplayPersons()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

    class SeasonManager
    {
        private string GetSeasonMonths(Season season)
        {
            switch (season)
            {
                case Season.Spring:
                    return "March to May";
                case Season.Summer:
                    return "June to August";
                case Season.Autumn:
                    return "September to November";
                case Season.Winter:
                    return "December to February";
                default:
                    return "Wrong Input";
            }
        }

        public void DisplaySeasonMonthRange()
        {
            Console.Write("Enter season (Spring, Summer, Autumn, Winter): ");
            string? originalString = Console.ReadLine();
            if (Enum.TryParse(originalString, true, out Season season))
            {
                string months = GetSeasonMonths(season);
                Console.WriteLine($"The months for {season} are {months}");
            }
            else
            {
                Console.WriteLine("Wrong season entered");
            }
        }
    }

    class ColorManager
    {
        public void CheckPrimaryColor()
        {
            Console.Write("Enter a color name: ");
            string? input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Colors color))
            {
                if (color == Colors.Red || color == Colors.Blue || color == Colors.Green)
                {
                    Console.WriteLine($"{color} is a primary color");
                }

            }
            else
            {
                Console.WriteLine($"{input} is NOT a primary color");
            }
        }
    }

    internal class Program
    {
        #region Q1
        ////Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.
        ////Then, write a C# program that prints out all the days of the week using this enum.

        //static void Main(string[] args)
        //{
        //    WeekDaysEnum.PrintAllWeekDays();

        //}
        #endregion

        #region Q2
        //public static void Main(string[] args)
        //{
        //    PersonManager personManager = new PersonManager();
        //    personManager.DisplayPersons();

        //}
        #endregion

        #region Q3

        //static void Main(string[] args)
        //{
        //    SeasonManager seasonManager = new SeasonManager();
        //    seasonManager.DisplaySeasonMonthRange();

        //}
        #endregion

        #region Q4

        //static void Main(string[] args)
        //{
        //    Permissions permissions = Permissions.Read | Permissions.Write;

        //    permissions |= Permissions.Delete;
        //    permissions &= ~Permissions.Write;

        //    bool hasExecute = (permissions & Permissions.Execute) == Permissions.Execute;
        //    Console.WriteLine("Has Execute Permission: " + hasExecute);

        //} 
        #endregion

        #region Q5
        //static void Main(string[] args)
        //{
        //    ColorManager colorManager = new ColorManager();
        //    colorManager.CheckPrimaryColor();
        //}
        #endregion






    }
}
