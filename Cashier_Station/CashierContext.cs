using Cashier_Station.Models;
using System;
using System.Data.Entity;


namespace Cashier_Station
{
    public class CashierContext : DbContext
    {
        public CashierContext() : base("DefaultConnection") {}

        public DbSet<Client> Clients { get; set; }
        public DbSet<Cashier> Cashiers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<InterMediateRoute> InterMediateRoutes  { get; set; }
        public DbSet<Ticket> Tickets  { get; set; }
        public DbSet<Transport> Transports { get; set; }

    }
}
