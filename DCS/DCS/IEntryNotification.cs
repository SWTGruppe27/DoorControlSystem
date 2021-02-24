using System;
using System.Collections.Generic;
using System.Text;

namespace DCS
{
    public interface IEntryNotification
    {
        void NotifyEntryGranted(int id);
    }
}
