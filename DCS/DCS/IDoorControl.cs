using System;
using System.Collections.Generic;
using System.Text;

namespace DCS
{
    interface IDoorControl
    {
        void RequestEntry(int id);
        void DoorOpened();
    }
}
