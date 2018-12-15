using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class AccountMovement
    {
        private int iID;
        private DateTime iDate;
        private string iDescription;
        private double iAmount;

        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public DateTime Date
        {
            get { return this.iDate; }
            set { this.iDate = value}
        }

        public string Description
        {
            get { return this.iDescription; }
            set { this.iDescription = value; }
        }

        public double Amount
        {
            get { return this.iAmount; }
            set { this.iAmount = value; }
        }   
    }
}
