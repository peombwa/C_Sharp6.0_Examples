using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CreatingTypes_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Income = 10000;
            emp.YearsOfService = 5;
            emp.SetRating(Employee.Rating.excellent);
            emp.CalculateRaise();

            Console.WriteLine($"Income : {emp.Income}");
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public enum Rating
        {
            poor,
            good,
            excellent
        }

        private Rating rating;
        public double Income { get; set; }
        public int YearsOfService { get; set; }

        public void SetRating(Rating rating)
        {
            this.rating = rating;
        }

        public void CalculateRaise()
        {
            double baseRaise = Income * .05;
            double bonus = YearsOfService * 1000;
            Income += baseRaise + bonus;

            switch (rating)
            {
                case Rating.poor:
                    Income = Income * 2000;
                    break;
                case Rating.good:
                    break;
                case Rating.excellent:
                    Income = Income * 500;
                    break;
                default:
                    break;
            }
        }
    }
}
