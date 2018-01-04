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
            Name = "Название не задано";
            Address = "Адрес не задан";
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
            FullName = "Полное имя не задано";
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
            PhoneNumber = "Номер телефона не задан";
            HomeAddress = "Домашний адрес не задан";
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



    // Класс "Самолет"
    class Aircraft
    {
        private Pilot СhiefPilot;
        private Pilot SecondPilot;
        private String Model;
        private String SerialNumber;

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
