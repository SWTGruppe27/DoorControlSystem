using System;
using System.Collections.Generic;
using System.Text;

namespace DCS
{
    class EntryNotification : IEntryNotification
    {
        public void NotifyEntryGranted(int id)
        {
            Console.WriteLine($"Notify entry with id {id}");
        }
    }
}
