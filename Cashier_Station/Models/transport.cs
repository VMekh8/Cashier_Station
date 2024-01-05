using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station
{
    public class Transport
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Конструктор класу
        public Transport(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Інший конструктор, який не вимагає вказання значень для полів при створенні об'єкта
        public Transport()
        {
        }
    }
}
