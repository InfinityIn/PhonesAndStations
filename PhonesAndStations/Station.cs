using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesAndStations
{

    class Station
    {
        public List<string> RegisteredPhones { get; set; }

        public Station() 
        {
            RegisteredPhones = new List<string>();
        }

        public virtual void RegisterPhone(Phone phone)
        {
            RegisteredPhones.Add(phone.IMEI);
            phone.CurrentStation = this;
        }

        public virtual void CallHandler(Phone phone, string phoneNumber)
        {
            if (!RegisteredPhones.Contains(phone.IMEI))
                throw new Exception("Телефон не зарегистрирован");
            if (phone is Phone3G)
                Console.WriteLine("Звонок будет осуществлён по сети 3G");
            Console.WriteLine("Осуществляется звонок по номеру " + phoneNumber);

        }
    }

    class Station3G : Station
    {
        public override void RegisterPhone(Phone phone)
        {
            if (phone is Phone3G)
                (phone as Phone3G).CanCall3G = true;
            base.RegisterPhone(phone);
        }
    }
}
