using System;

namespace Cashier_Station
{
    public class Ticket
    {

        private int _id;
        private int _routeId;
        private decimal _price;
        private DateTime _dateBuy;
        private bool _isActive;

        // Властивості для доступу до полів ззовні класу
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int RouteId
        {
            get { return _routeId; }
            set { _routeId = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public DateTime DateBuy
        {
            get { return _dateBuy; }
            set { _dateBuy = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        // Конструктор класу
        public Ticket(int id, int routeId, decimal price, DateTime dateBuy, bool isActive)
        {
            _id = id;
            _routeId = routeId;
            _price = price;
            _dateBuy = dateBuy;
            _isActive = isActive;
        }

        // Інший конструктор, який не вимагає вказання значень для полів при створенні об'єкта
        public Ticket()
        {
        }
    }
}