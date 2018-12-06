using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsIdentity.Model
{
    public class RateModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string  year;

        public string  Year
        {
            get { return year; }
            set { year = value; }
        }

        private string  rateType;

        public string  RateType
        {
            get { return rateType; }
            set { rateType = value; }
        }

        private string  rate;

        public string  Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public RateModel(int id, string year, string rateType, string rate)
        {
            Id = id;
            Year = Year;
            rateType = RateType;
            rate = Rate;
        
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}