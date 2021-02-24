using System;
using System.Collections.Generic;
using System.Text;

namespace DCS
{
    interface IEntryNotification
    {
        void NotifyEntryGranted(int id);
    }
}
