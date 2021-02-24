using System;
using System.Collections.Generic;
using System.Text;

namespace DCS
{
    class UserValidation : IUserValidation
    {
        public bool ValidateEntryRequest(int id)
        {
            return true;
        }
    }
}
