using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesInPraxis
{
    public delegate bool MyDelegate(Employee employee);
    // Action -> void
    // Predicate -> bool
    // Func

    class Program
    {
        static void Main(string[] args)
        {

            var employees = GetData();

            //MyDelegate del = new MyDelegate(Bedingung);
            //Func<Employee, bool> del = new Func<Employee, bool>(Bedingung);

            //var del = new Func<Employee, bool>(Bedingung);

            //Func<Employee, bool> del = Bedingung;
            //var query = Abfrage(employees, del);

            //var query = Abfrage(employees, Bedingung);

            //var query = Abfrage(employees, delegate (Employee e)
            //{
            //    return e.Experience > 5;
            //});

            //var query = Abfrage(employees, (Employee e) =>
            //{
            //    return e.Experience > 5;
            //});

            //var query = Abfrage(employees, (e) =>
            //{
            //    return e.Experience > 5;
            //});

            //var query = Abfrage(employees, (e) => e.Experience > 5);
            var linqQuery = employees.Where(e => e.Experience > 5);

            foreach (var e in linqQuery)
            {
                Console.WriteLine($"Id: {e.Id} - {e.Name, 10} - {e.Experience}");
            }
           
            Console.ReadKey();
        }

        private static bool Bedingung(Employee e)
        {
            return e.Name.Contains("A");
        }

        private static IEnumerable<Employee> Abfrage(
            IEnumerable<Employee> employees, 
            Func<Employee, bool> predicate)
        {
            var query = new List<Employee>();

            foreach (var e in employees)
            {
                if (predicate(e))
                    query.Add(e);
            }

            return query;
        }

        private static IEnumerable<Employee> GetData()
        {
            return new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Sepp", Experience = 6 },
                new Employee() { Id = 2, Name = "Maria", Experience = 5 },
                new Employee() { Id = 3, Name = "Thomas", Experience = 10 },
                new Employee() { Id = 4, Name = "Stanislaus", Experience = 14 },
                new Employee() { Id = 5, Name = "Lisa", Experience = 6 },
                new Employee() { Id = 6, Name = "Anton", Experience = 1 },
                new Employee() { Id = 7, Name = "Alexandra", Experience = 3 },
                new Employee() { Id = 8, Name = "Mario", Experience = 18 },
                new Employee() { Id = 9, Name = "Paula", Experience = 3 },
            };
        }
    }
}
