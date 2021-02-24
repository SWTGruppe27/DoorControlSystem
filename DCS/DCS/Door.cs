using System;
using System.Collections.Generic;
using System.Text;

namespace DCS
{
    class Door : IDoor
    {
        public IDoorControl DoorControl { set; get; }
        public void Open()
        {
            Console.WriteLine("Door Opened");
            DoorControl.DoorOpened();
        }
        public void Close()
        {
            Console.WriteLine("Door Closed");
            DoorControl.DoorClosed();
        }
    }
}
