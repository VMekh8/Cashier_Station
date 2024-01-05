using System;


namespace Cashier_Station
{
    public class client
    {
        private int _id;
        private string _name;
        private string _surname;
        private int _ticketId;

        // Властивості для доступу до приватних полів
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int TicketId
        {
            get { return _ticketId; }
            set { _ticketId = value; }
        }

        // Конструктор класу
        public client(string name, string surname, int ticketId)
        {
            _name = name;
            _surname = surname;
            _ticketId = ticketId;
        }

        
        public client()
        {
        }
    }
}