using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Practice5
{
    internal class SortByMileage:IComparer<Car>
    {
        // Перевизначаю стандартний метод для порівняння за пробігом
        public int Compare(Car car1, Car car2)
        {
            if (car1.Mileage < car2.Mileage) return -1;
            if (car1.Mileage > car2.Mileage) return 1;
            return 0;
        }
    }
}