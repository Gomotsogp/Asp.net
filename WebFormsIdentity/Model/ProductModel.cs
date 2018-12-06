using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsIdentity.Model
{
    public class ProductModel
    {

        private int id;

        public ProductModel(int id, string productName, double annualCost)
        {
            ID = id;
            ProductName = productName;
            AnnualCost = annualCost;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private double annualCost;

        public double AnnualCost
        {
            get { return annualCost; }
            set { annualCost = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public ProductModel()
        {

        }
    }
}