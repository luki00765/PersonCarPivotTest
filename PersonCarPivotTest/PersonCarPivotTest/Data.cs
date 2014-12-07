using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonCarPivotTest
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Car Car { get; set; }

        public Person(string name, int age, Car car)
        {
            Name = name;
            Age = age;
            Car = car;
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }
    }
}