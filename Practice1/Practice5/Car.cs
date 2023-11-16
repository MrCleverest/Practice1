using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1.Practice5
{
    public class Car:IComparable
    {
        string brand; // Марка автомобіля
        string owner; // Прізвище власника
        int year; // Рік придбання
        int mileage; // Пробіг автобілю
        public string Brand { get { return brand; } set { brand = value; }}
        public string Owner { get { return owner; } set { owner = value; } }
        public int Year { get { return year; } set { year = value; } }
        public int Mileage { get { return mileage; } set { mileage = value; } }
        public Car()
        {
            brand = "Chevrolet";
            owner = "Базаров";
            year = 2023;
            mileage = 1000;
        }
        public Car(string brand, string owner, int year, int mileage)
        {
            this.brand = brand;
            this.owner = owner;
            this.year = year;
            this.mileage = mileage;
        }
        public int CompareTo(object obj)
        {
            Car c = obj as Car;
            return mileage.CompareTo(c.mileage);
        }
    }
}