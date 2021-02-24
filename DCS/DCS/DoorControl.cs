using System;
using System.Collections.Generic;
using System.Text;

namespace DCS
{
    public class DoorControl : IDoorControl
    {
        private IDoor _door;
        private IUserValidation _userValidation;
        private IEntryNotification _entryNotification;

        public DoorControl(IDoor door, IUserValidation userValidation,
            IEntryNotification entryNotification)
        {
            _door = door;
            _userValidation = userValidation;
            _entryNotification = entryNotification;
        }
        public void RequestEntry(int id)
        {
            bool messagEntryRequest = _userValidation.ValidateEntryRequest(id);

            if (messagEntryRequest == true)
            {
                _door.Open();
                _entryNotification.NotifyEntryGranted(id);
            }
            else
            {
                Console.WriteLine("Access denied!!!");
            }
        }

        public void DoorOpened()
        {
            Console.WriteLine("Door is opend");
        }

        public void DoorClosed()
        {
            Console.WriteLine("Door is closed");
        }
    }
}
