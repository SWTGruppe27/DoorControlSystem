using System;
using System.Collections.Generic;
using System.Text;

namespace DCS
{
    interface IUserValidation
    {
        bool ValidateEntryRequest(int id);
    }
}
