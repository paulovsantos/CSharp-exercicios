﻿using System.Globalization;
using System.Collections.Generic;

namespace ExercicioFixacaoLista
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; } //Encapsulamento

        public Employee(int id, string name, double salary) //Método construtor
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncresaSalary(double percentage)
        {
            Salary += (Salary * percentage / 100.0);
        }
       
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + "$ "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}