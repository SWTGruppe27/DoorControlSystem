using System;

namespace DCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UserValidation userValidation = new UserValidation();
            Door door = new Door();

            userValidation.ID = 5;
            
            DoorControl doorControl = new DoorControl(door, userValidation, new EntryNotification());

            door.DoorControl = doorControl;

            doorControl.RequestEntry(5);
        }
    }
}
