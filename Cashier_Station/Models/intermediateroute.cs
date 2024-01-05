using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station
{
    public class intermediateroute
    {
        private int _id;
        private int _routeId;
        private string _namestation;
        private double _distanceFromStart;
        private double _distanceToend;
        private DateTime _arrivalTime;

        // Властивості для доступу до приватних полів
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public int RouteId
        {
            get { return _routeId; }
            set { _routeId = value; }
        }

        public string NameStation
        {
            get { return _namestation; }
            set { _namestation = value; }
        }

        public double DistanceFromStart
        {
            get { return _distanceFromStart; }
            set { _distanceFromStart = value; }
        }

        public double DistanceToEnd
        {
            get { return _distanceToend; }
            set { _distanceToend = value; }
        }

        public DateTime ArrivalTime
        {
            get { return _arrivalTime; }
            set { _arrivalTime = value; }
        }

        // Конструктор класу
        public intermediateroute(int routeId, string namestation, double distanceFromStart, double distanceToend, DateTime arrivalTime)
        {
            _routeId = routeId;
            _namestation = namestation;
            _distanceFromStart = distanceFromStart;
            _distanceToend = distanceToend;
            _arrivalTime = arrivalTime;
        }

        
        public intermediateroute()
        {
        }
    }
}
