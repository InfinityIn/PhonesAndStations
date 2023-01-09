using PhonesAndStations;

var phone = new Phone("123");
var phone3G = new Phone3G("123");

var station = new Station();
var station3G = new Station3G();

//station.RegisterPhone(phone);
//station.RegisterPhone(phone3G);

station3G.RegisterPhone(phone);
station3G.RegisterPhone(phone3G);

phone.Call("333");
phone3G.Call("333");