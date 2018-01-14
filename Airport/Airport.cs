using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    // Тип рейса с точки зрения аэропорта
    enum FlightType
    {
        Depart,     // Отправка
        Arrival,    // Прибытие
        Transit     // Транзит
    };

    
    // Класс "Аэропорт"
    class Airport
    {
        private String Name;        // Название аэропорта
        private String Address;     // Адрес аэропорта

        // Конструкторы
        public Airport()
        {
            Name = "XXXX";
            Address = "XXXX";
        }
        public Airport(String Name, String Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        // Свойства
        public String AirportName
        {
            get
            {
                return Name;
            }
            set
            {
                if (value.Length > 0 && value.Length < 64)
                    Name = value;
                else
                    throw new ArgumentOutOfRangeException("Name", "Название аэропорта должно быть длиной не более 64 символов и не пустым");
            }
        }
        public String AirportAddress
        {
            get
            {
                return Address;
            }
            set
            {
                if (value.Length > 0 && value.Length < 128)
                    Address = value;
                else
                    throw new ArgumentOutOfRangeException("Address", "Адрес аэропорта должен быть длиной не более 128 символов и не пустым");
            }
        }
    }

    // Абстрактный класс "Человек"
    abstract class Human
    {
        protected String FullName;  // Полное имя  формате "Фамилия Имя Отчество"

        // Конструкторы
        public Human()
        {
            FullName = "XXXX";
        }
        public Human(String FullName)
        {
            this.FullName = FullName;
        }
        public Human(String Surname, String Name, String Patronymic)
        {
            FullName = Surname + " " + Name + " " + Patronymic;
        }

        // Свойства
        public String HumanFullName
        {
            get
            {
                return FullName;
            }
            set
            {
                if (value.Length > 0 && value.Length < 64)
                    FullName = value;
                else
                    throw new ArgumentOutOfRangeException("FullName", "Полное имя человека должно быть длиной не более 64 символов и не пустым");
            }
        }
    }

    // Абстрактный класс "Член команды"
    abstract class Crew : Human
    {
        protected String PhoneNumber;   // Контактный номер телефона
        protected String HomeAddress;   // Домашний адрес

        // Конструкторы
        public Crew() : base()
        {
            PhoneNumber = "+X-XXX-XXX-XXXX";
            HomeAddress = "XXXX";
        }
        public Crew(String FullName, String PhoneNumber, String HomeAddress) : base(FullName)
        {
            this.PhoneNumber = PhoneNumber;
            this.HomeAddress = HomeAddress;
        }
        public Crew(String Surname, String Name, String Patronymic, String PhoneNumber, String HomeAddress) : base(Surname, Name, Patronymic)
        {
            this.PhoneNumber = PhoneNumber;
            this.HomeAddress = HomeAddress;
        }

        // Свойства
        public String CrewPhoneNumber
        {
            get
            {
                return PhoneNumber;
            }
            set
            {
                if (value.Length > 0 && value.Length < 16)
                    PhoneNumber = value;
                else
                    throw new ArgumentOutOfRangeException("PhoneNumber", "Номер телефона должен быть длиной не более 16 символов и не пустым");
            }
        }
        public String CrewHomeAddress
        {
            get
            {
                return HomeAddress;
            }
            set
            {
                if (value.Length > 0 && value.Length < 128)
                    HomeAddress = value;
                else
                    throw new ArgumentOutOfRangeException("HomeAddress", "Домашний адрес должен быть длиной не более 128 символов и не пустым");
            }
        }
    }

    // Класс "Пассажир"
    class Passenger : Human
    {
        private Int32 Age;  // Возраст

        // Конструкторы
        public Passenger() : base()
        {
            Age = 199;
        }
        public Passenger(String FullName, Int32 Age) : base(FullName)
        {
            this.Age = Age;
        }
        public Passenger(String Surname, String Name, String Patronymic, Int32 Age) : base(Surname, Name, Patronymic)
        {
            this.Age = Age;
        }

        // Свойства
        public Int32 PassengerAge
        {
            get
            {
                return Age;
            }
            set
            {
                if (value >= 0 && value < 200)
                    Age = value;
                else
                    throw new ArgumentOutOfRangeException("Age", "Возраст пассажира должен быть не отрицательным и менее 200");
            }
        }
    }

    // Класс "Пилот"
    class Pilot : Crew
    {
        private String LicenseNumber;   // Номер лицензии

        // Конструкторы
        public Pilot() : base()
        {
            LicenseNumber = "XXXXXXXXXXXX";
        }
        public Pilot(String FullName, String PhoneNumber, String HomeAddress, String LicenseNumber) : base(FullName, PhoneNumber, HomeAddress)
        {
            this.LicenseNumber = LicenseNumber;
        }
        public Pilot(String Surname, String Name, String Patronymic, String PhoneNumber, String HomeAddress, String LicenseNumber) : base(Surname, Name, Patronymic, PhoneNumber, HomeAddress)
        {
            this.LicenseNumber = LicenseNumber;
        }

        // Свойства
        public String PilotLicenseNumber
        {
            get
            {
                return LicenseNumber;
            }
            set
            {
                if (value.Length > 0 && value.Length < 16)
                    LicenseNumber = value;
                else
                    throw new ArgumentOutOfRangeException("LicenseNumber", "Номер лицензии должен быть длиной не более 16 символов и не пустым");
            }
        }
    }

    // Класс "Самолет"
    class Aircraft
    {
        private Pilot СhiefPilot;       // Первый пилот
        private String Model;           // Модель самолета
        private String SerialNumber;    // Номер самолета
        private Int32 Seats;            // Количество мест в самолете

        // Конструкторы
        public Aircraft()
        {
            СhiefPilot = new Pilot();
            Model = "XXXX";
            SerialNumber = "XXXXX";
            Seats = 0;
        }
        public Aircraft(Pilot СhiefPilot, Pilot SecondPilot, String Model, String SerialNumber, Int32 Seats)
        {
            this.СhiefPilot = СhiefPilot;
            this.Model = Model;
            this.SerialNumber = SerialNumber;
            this.Seats = Seats;
        }

        // Свойства
        public Pilot AircraftСhiefPilot
        {
            get
            {
                return СhiefPilot;
            }
            set
            {
                if (value != null)
                    СhiefPilot = value;
                else
                    СhiefPilot = new Pilot();
            }
        }
        public String AircraftModel
        {
            get
            {
                return Model;
            }
            set
            {
                if (value.Length > 0 && value.Length < 16)
                    Model = value;
                else
                    throw new ArgumentOutOfRangeException("Model", "Модель самолета должна быть длиной не более 16 символов и не пустым");
            }
        }
        public String AircraftSerialNumber
        {
            get
            {
                return SerialNumber;
            }
            set
            {
                if (value.Length > 0 && value.Length < 16)
                    SerialNumber = value;
                else
                    throw new ArgumentOutOfRangeException("SerialNumber", "Номер самолета должен быть длиной не более 16 символов и не пустым");
            }
        }
        public Int32 AircraftSeats
        {
            get
            {
                return Seats;
            }
            set
            {
                if (value >= 0 && value < 1000)
                    Seats = value;
                else
                    throw new ArgumentOutOfRangeException("Seats", "Количетво мест в самолете должно быть не отрицательным и менее 1000");
            }
        }
    }

    // Класс "Билет"
    class Ticket
    {
        private Int32 Seat;     // Место
        private Double Price;   // Цена

        // Конструкторы
        Ticket()
        {
            Seat = 0;
            Price = 0.0;
        }
        Ticket(Int32 Seat, Double Price)
        {
            this.Seat = Seat;
            this.Price = Price;
        }

        // Свойства
        public Int32 TicketSeat
        {
            get
            {
                return Seat;
            }
            set
            {
                if (value >= 0 && value < 1000)
                    Seat = value;
                else
                    throw new ArgumentOutOfRangeException("Seat", "Номер места в самолете должен быть не отрицательным и менее 1000");
            }
        }
        public Double TicketPrice
        {
            get
            {
                return Price;
            }
            set
            {
                if (value >= 0.0 && value < Double.MaxValue)
                    Price = value;
                else
                    throw new ArgumentOutOfRangeException("Price", "Цена билета должна быть не отрицательной и менее " + Convert.ToString(Double.MaxValue));
            }
        }
    }

    // Класс "Рейс"
    class Flight
    {
        private FlightType Type;            // Тип рейса
        private String Number;              // Номер рейса
        private DateTime DepartureTime;     // Дата/время отправления из текущего аэропорта
        private DateTime ArrivalTime;       // Дата/время прибытия в место назначения
        private Airport ThisPoint;          // Текущий аэропорт
        private Airport DeparturePoint;     // Место отправления рейса
        private Airport ArrivalPoint;       // Место назначения рейса
        private Aircraft Plane;             // Самолет назначенный на данный рейс
        private List<Ticket> Tickets;       // Билеты на самолет
    }
}
