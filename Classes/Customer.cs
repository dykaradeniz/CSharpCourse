using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        // Field  (bir alan tanımlamak)
        //public string FirstName;

        //Property (tanımlamak) // classın içinde özellik tanımlicaksak bu şekilde taımlarız
        public int Id { get; set; } // bir müşterinin özelliklerini tutmak için kullandığımız nesne
       
        string _firstName;
        public string FirstName
        {
            get
            {
                return "Mrs." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
