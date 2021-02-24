using System;
using System.Collections.Generic;
using System.Text;

namespace DCS
{
    class UserValidation : IUserValidation
    {
        public int ID{ get; set; }
        public bool ValidateEntryRequest(int id)
        {
            if (id == ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
