using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesAndStations
{
    class Phone
    {
        public readonly string IMEI;
        public string PhoneNumber { get; set; }
        public List<PhoneBookItem> PhoneBook { get; set; }
        public Station CurrentStation { get; set; }

        public Phone(string iMEI)
        {
            IMEI = iMEI;
            PhoneBook = new List<PhoneBookItem>();
        }        

        public void Call(string phoneNumber) => StationRequest(phoneNumber);

        public void Call(PhoneBookItem phoneBookItem) => StationRequest(phoneBookItem.PhoneNumber);

        protected void StationRequest(string phoneNumber)
        {
            if (CurrentStation is null)
                throw new Exception("Телефон не зарегистрирован на станции");
            CurrentStation.CallHandler(this, phoneNumber);
        }
    }

    class Phone3G : Phone
    {
        public bool CanCall3G = false;
        public Phone3G(string iMEI) : base(iMEI) { }
    }
}
