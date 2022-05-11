using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioFixacaoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                list.Remove(new Employee(id, name, salary));
                Console.WriteLine("__________________");
                
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            double searchId = double.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncresaSalary(percentage);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("__________________");
            Console.WriteLine("Updated list of employees: ");

            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("__________________");
            Console.Write("Do you want to delete an employee? S/N: ");
            char op = char.Parse(Console.ReadLine());

            if (op == 'S' || op == 's')
            {
                Console.Write("Enter the ID: ");
                int removeId = int.Parse(Console.ReadLine());
                list.RemoveAll(x => x.Id == removeId);

                Console.WriteLine("Employee delete!");
                Console.WriteLine("__________________");
            } else
            {
                Console.WriteLine("ID Invalid!");
            }

            Console.WriteLine("__________________");
            Console.WriteLine("Updated list of employees after deletion: ");

            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
