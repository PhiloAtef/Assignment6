using System.ComponentModel;

namespace Assignment6
{

    #region Q1
    enum Weekdays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
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
    #endregion

    #region Q2 AND Q7
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

        public PersonManager(int countOfPersons)
        {
            if (countOfPersons >= 0)
            {
                persons = new Person[countOfPersons];

                //code here can be refactored into a function that returns a persons array with the logic here
                for (int i = 0; i < persons.Length; i++)
                {
                    Console.WriteLine($"Enter details for person no.{i+1}");
                    Console.Write("Name: ");
                    string? name = Console.ReadLine();
                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());
                    persons[i] = new Person { Name =  name ?? "Null", Age = age }; 
                }
            }
            else
            {
                persons = Array.Empty<Person>();
            }
        }

        public void DisplayOldestPerson()
        {
            Person oldestPerson = persons[0];

            foreach (Person person in persons)
            {
                if (person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }

            Console.WriteLine($"Oldest Person's name is {oldestPerson.Name} and age is {oldestPerson.Age}");
        }

        public void DisplayPersons()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
    #endregion

    #region Q3
    enum Season { Spring, Summer, Autumn, Winter }
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
    #endregion

    #region Q4
    [Flags]
    enum Permissions
    { Read = 1, Write = 2, Delete = 4, Execute = 8 } 
    #endregion

    #region Q5
    enum Colors { Red, Green, Blue }
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
    #endregion

    #region Q6
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class PointCalculator
    {
        public double CalculateDistance(Point point1, Point point2)
        {
            double distance = Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
            return distance;
        }

        public Point RecieveCoordinates(double pointx, double pointy)
        {
            return new Point { X = pointx, Y = pointy };
        }
    } 
    #endregion



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

        #region Q6
        //static void Main(string[] args)
        //{
        //    PointCalculator pointCalculator = new PointCalculator();

        //    Console.WriteLine("Enter first point X-coordinate: ");
        //    bool point1XParsed = double.TryParse(Console.ReadLine(), out double point1X);
        //    Console.WriteLine("Enter first point Y-coordinate: ");
        //    bool point1YParsed = double.TryParse(Console.ReadLine(), out double point1Y);

        //    Point pointX = pointCalculator.RecieveCoordinates(point1X, point1Y);

        //    Console.WriteLine("Enter second point X-coordinate: ");
        //    bool point2XParsed = double.TryParse(Console.ReadLine(), out double point2X);
        //    Console.WriteLine("Enter second point y-coordinate: ");
        //    bool point2YParsed = double.TryParse(Console.ReadLine(), out double point2Y);

        //    Point pointY = pointCalculator.RecieveCoordinates(point2X, point2Y);

        //    double distance = pointCalculator.CalculateDistance(pointX, pointY);

        //    Console.WriteLine($"Distance between point({point1X},{point1Y}) and point({point2X},{point2Y}) is: {distance}");

        //} 
        #endregion

        #region Q7
        //static void Main(string[] args)
        //{
        //    PersonManager personManager = new PersonManager(3);
        //    personManager.DisplayOldestPerson();
        //} 
        #endregion


    }
}
