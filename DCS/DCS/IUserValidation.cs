using System;
using System.Collections.Generic;
using System.Text;

namespace DCS
{
    public interface IUserValidation
    {
        bool ValidateEntryRequest(int id);
    }
}
