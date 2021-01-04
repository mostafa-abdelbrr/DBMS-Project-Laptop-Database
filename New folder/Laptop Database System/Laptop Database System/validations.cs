using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database_System
{
    public class validations
    {
       public  validations()
        {

        }
        public bool email(string email)
        {
            if (!(email.Contains('@') && email.Contains('.') && email.IndexOf('@') < email.IndexOf('.', email.IndexOf('@'))))
            {
                return false;
            }
            return true;
        }

        public bool phoneNumber(long number)
        {
            if(number.ToString().Length < 7 || number.ToString().Length>  15)
            {
                return false;
            }
            return true;
        }

    }
}
