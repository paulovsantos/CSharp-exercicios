﻿using ExercicioResolvido1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioResolvido1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 3; i++)
            {
                Console.Write($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)?");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'y')
                {

                    Console.Write("Addtional charge: ");
                    double addtionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsorcedEmployee(name, hours, valuePerHour, addtionalCharge));

                   
                } else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
