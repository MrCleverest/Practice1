using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practice1.Practice5
{
    internal class Automobiles
    {
        public List<Car> cars = new List<Car>(); 
        // Серіалізатор для запису у файл
        XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
        public void add(Car car)
        {
            cars.Add(car);
        }
        public void remove(int i)
        {
            cars.RemoveAt(i);
        }
        public void sort()
        {
            SortByMileage sm = new SortByMileage();
            cars.Sort(sm);
        }
        public void writeFile(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.Create,
                FileAccess.Write, FileShare.None);
            serializer.Serialize(fstream, cars);
            fstream.Close();
        }
        public void readFile(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.Open,
                FileAccess.Read, FileShare.None);
            cars=serializer.Deserialize(fstream) as List<Car>;
            fstream.Close();
        }
    }
}