using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station
{
    public class Route
    {
        private int _id;
        private string _startpoint;
        private string _endpoint;
        private DateTime _dateOfStart;
        private DateTime _dateOfEnd;
        private int _seatsNumber;
        private int _transportId;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string StartPoint
        {
            get { return _startpoint; }
            set { _startpoint = value; }
        }

        public string EndPoint
        {
            get { return _endpoint; }
            set { _endpoint = value; }
        }

        public DateTime DateOfStart
        {
            get { return _dateOfStart; }
            set { _dateOfStart = value; }
        }

        public DateTime DateOfEnd
        {
            get { return _dateOfEnd; }
            set { _dateOfEnd = value; }
        }

        public int SeatsNumber
        {
            get { return _seatsNumber; }
            set { _seatsNumber = value; }
        }

        public int TransportId
        {
            get { return _transportId; }
            set { _transportId = value; }
        }

        // Конструктор класу
        public Route(string startpoint, string endpoint, DateTime dateOfStart, DateTime dateOfEnd, int seatsNumber, int transportId)
        {
            StartPoint = startpoint;
            EndPoint = endpoint;
            DateOfStart = dateOfStart;
            DateOfEnd = dateOfEnd;
            SeatsNumber = seatsNumber;
            TransportId = transportId;
        }

        
        public Route()
        {
        }
    }
}
