using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    // Тип рейса с точки зрения аэропорта
    public enum FlightType
    {
        Depart,     // Отправка
        Arrival,    // Прибытие
        Transit     // Транзит
    }

    // Класс мест
    public enum TravelClass
    {
        FirstClass,     // Первый класс
        BusinessClass,  // Бизнесс класс
        ComfortClass,   // Комфорт класс
        EconomyClass    // Эконом класс
    }

    // Класс "Аэропорт"
    [Serializable]
    public class Airport
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
    [Serializable]
    public abstract class Human
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
    [Serializable]
    public abstract class Crew : Human
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
    [Serializable]
    public class Passenger : Human
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
    [Serializable]
    public class Pilot : Crew
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
    [Serializable]
    public class Aircraft
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
        public Aircraft(Pilot СhiefPilot, String Model, String SerialNumber, Int32 Seats)
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
    [Serializable]
    public class Ticket
    {
        private Passenger Passenger;    // Пассажир
        private Int32 Seat;             // Место
        private Double Price;           // Цена

        // Конструкторы
        public Ticket()
        {
            Seat = 0;
            Price = 0.0;
            Passenger = new Passenger();
        }
        public Ticket(Int32 Seat, Double Price, Passenger Passenger)
        {
            this.Seat = Seat;
            this.Price = Price;
            this.Passenger = Passenger;
        }

        // Свойства
        public Passenger TicketPassenger
        {
            get
            {
                return Passenger;
            }
            set
            {
                if (value != null)
                    Passenger = value;
                else
                    Passenger = new Passenger();
            }
        }
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
    [Serializable]
    public class Flight : ICloneable
    {
        private FlightType Type;            // Тип рейса
        private String Number;              // Номер рейса
        private DateTime DepartureTime;     // Дата/время отправления из текущего аэропорта
        private DateTime ArrivalTime;       // Дата/время прибытия в место назначения
        private Airport DeparturePoint;     // Место отправления рейса
        private Airport ArrivalPoint;       // Место назначения рейса
        private Aircraft Plane;             // Самолет назначенный на данный рейс
        private List<Ticket> Tickets;       // Билеты на самолет

        // Конструкторы
        public Flight()
        {
            Type = FlightType.Transit;
            Number = "XXXX";
            DepartureTime = DateTime.Now;
            ArrivalTime = DateTime.Now;
            DeparturePoint = new Airport();
            ArrivalPoint = new Airport();
            Plane = new Aircraft();
            Tickets = new List<Ticket>();
        }

        // Свойства
        public FlightType FlightType
        {
            get
            {
                return Type;
            }
            set
            {
                Type = value;
            }
        }
        public String FlightNumber
        {
            get
            {
                return Number;
            }
            set
            {
                if (value.Length > 0 && value.Length < 16)
                    Number = value;
                else
                    throw new ArgumentOutOfRangeException("FlightNumber", "Номер рейса должен быть длиной не более 16 символов и не пустым");
            }
        }
        public DateTime FlightDepartureTime
        {
            get
            {
                return DepartureTime;
            }
            set
            {
                DepartureTime = value;
            }
        }
        public DateTime FlightArrivalTime
        {
            get
            {
                return ArrivalTime;
            }
            set
            {
                ArrivalTime = value;
            }
        }
        public Airport FlightDeparturePoint
        {
            get
            {
                return DeparturePoint;
            }
            set
            {
                if (value != null)
                    DeparturePoint = value;
                else
                    DeparturePoint = new Airport();
            }
        }
        public Airport FlightArrivalPoint
        {
            get
            {
                return ArrivalPoint;
            }
            set
            {
                if (value != null)
                    ArrivalPoint = value;
                else
                    ArrivalPoint = new Airport();
            }
        }
        public Aircraft FlightPlane
        {
            get
            {
                return Plane;
            }
            set
            {
                if (value != null)
                    Plane = value;
                else
                    Plane = new Aircraft();
            }
        }
        public List<Ticket> FlightTickets
        {
            get
            {
                return Tickets;
            }
            set
            {
                if (value != null)
                    Tickets = value;
                else
                    Tickets = new List<Ticket>();
            }
        }

        // Методы для работы с билетами
        // Посчитать цену билета в зависимости от класса места
        private Double calculatePrice(Double BasePrice, TravelClass TravelClass)
        {
            Double Price = 0.0;
            switch (TravelClass)
            {
                case TravelClass.FirstClass:
                    Price = 2 * BasePrice;
                    break;
                case TravelClass.BusinessClass:
                    Price = 1.5 * BasePrice;
                    break;
                case TravelClass.ComfortClass:
                    Price = 1.2 * BasePrice;
                    break;
                case TravelClass.EconomyClass:
                    Price = BasePrice;
                    break;
            }
            return Price;
        }
        // Добавить билет
        public void AddTicket(Int32 Seat, Double Price, Passenger Passenger, TravelClass TravelClass = TravelClass.EconomyClass)
        {
            Price = calculatePrice(Price, TravelClass);
            if (Seat > 0 && Seat <= Plane.AircraftSeats)
                Tickets.Add(new Ticket(Seat, Price, Passenger));
        }
        // Удалить билет
        public void RemoveTicket(Int32 Seat)
        {
            for (int i = 0; i < Tickets.Count; i++)
                if (Tickets[i].TicketSeat == Seat)
                {
                    Tickets.RemoveAt(i);
                    break;
                }
        }
        // Получить список свободных мест в самолете
        public List<Int32> GetFreeTickets()
        {
            List<Int32> FreeTickets = new List<Int32>();
            for (int i = 1; i <= Plane.AircraftSeats; i++)
            {
                bool IsFree = true;
                foreach (Ticket Ticket in Tickets)
                    if (Ticket.TicketSeat == i)
                    {
                        IsFree = false;
                        break;
                    }
                if (IsFree)
                    FreeTickets.Add(i);
            }
            return FreeTickets;
        }
        // Узнать, свободное ли место
        public Boolean IsFreeSeat(Int32 Seat)
        {
            bool IsFree = true;
            foreach (Ticket Ticket in Tickets)
                if (Ticket.TicketSeat == Seat)
                {
                    IsFree = false;
                    break;
                }
            return IsFree;
        }

        // Глубокое копирование
        public object Clone()
        {
            List<Ticket> newTicketsList = new List<Ticket>(this.Tickets);
            return new Flight
            {
                Type = this.Type,
                Number = this.Number,
                DepartureTime = this.DepartureTime,
                ArrivalTime = this.ArrivalTime,
                DeparturePoint = this.DeparturePoint,
                ArrivalPoint = this.ArrivalPoint,
                Plane = this.Plane,
                Tickets = newTicketsList
            };
        }
    }
}
