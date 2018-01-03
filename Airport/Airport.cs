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
        Airport()
        {
            Name = "Название не задано";
            Address = "Адрес не задан";
        }
        Airport(String Name, String Address)
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

    // Класс "Человек"
    abstract class Human
    {
        protected String FullName;

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
