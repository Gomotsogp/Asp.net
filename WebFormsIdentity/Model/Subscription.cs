using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsIdentity.Model
{
    public class Subscription
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int numberUsers;

        public int NumberUsers
        {
            get { return numberUsers; }
            set { numberUsers = value; }
        }

        private DateTime subscriptionStart;

        public DateTime SubscriptionStart
        {
            get { return subscriptionStart; }
            set { subscriptionStart = value; }
        }
        private DateTime annual;

        public DateTime Annual
        {
            get { return annual; }
            set { annual = value; }
        }

        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private int salesRep;

        public int SalesRep
        {
            get { return salesRep; }
            set { salesRep = value; }
        }

        public Subscription(int id, int numberUsers, DateTime subscriptionStart, DateTime annual, double cost, int salesRep)
        {
            Id = id;
            NumberUsers = numberUsers;
            SubscriptionStart = subscriptionStart;
            Annual = annual;
            Cost = cost;
            SalesRep = salesRep;

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}