using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class Client
    {
        private Document iID;
        private string iFirstName;
        private string iLastName;
        private List<Account> iCuentas;

        public Client(Document pID, string pFirstName, string pLastName)
        {
            this.iID = pID;
            this.iFirstName = pFirstName;
            this.iLastName = pLastName;
        }

        public Document ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public string FirstName
        {
            get { return this.iFirstName; }
            set { this.iFirstName = value; }
        }

        public string LastName
        {
            get { return this.iFirstName; }
            set { this.iFirstName = value; }
        }



    }
}
