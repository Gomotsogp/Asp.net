using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsIdentity.Model
{
    public class CustomerModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private int contactPhone;

        public int ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }

        private string contactName;

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        private string contactEmail;

        public string ContactEmail
        {
            get { return contactEmail; }
            set { contactEmail = value; }
        }

        public CustomerModel(int id, string companyName, int contactPhone, string contactName, string contactEmail)
        {
            Id = id;
            CompanyName = companyName;
            ContactPhone = contactPhone;
            ContactName = contactName;
            ContactEmail = contactName;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}