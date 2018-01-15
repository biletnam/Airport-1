using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class EditFlight : Form
    {
        // Флаг того, покинул ли пользователь форму не введя данные
        private bool IfNotLeft;
        // Новый самолет
        private Flight ThisFlight;

        private Airport ThisAirport;        // Текущий аэропорт
        private List<Airport> Airports;     // Аэропорты
        private List<Aircraft> Aircrafts;   // Самолеты

        // Свойства для возврата значений из формы
        public bool EditFlightIfNotLeft
        {
            get
            {
                return IfNotLeft;
            }
        }
        public Flight EditFlightThisFlight
        {
            get
            {
                return ThisFlight;
            }
        }

        public EditFlight(Flight ThisFlight, FormRole FR, Airport ThisAirport, List<Airport> Airports, List<Aircraft> Aircrafts)
        {
            InitializeComponent();

            // Устанавливаем название формы и подпись кнопки в зависимости от роли формы
            if (FR == FormRole.Adding)
            {
                Text = "Добавить самолет";
                button_edit.Text = "Добавить";
            }
            else if (FR == FormRole.Changing)
            {
                Text = "Изменить самолет";
                button_edit.Text = "Изменить";
            }

            // Заполняем форму
            comboBox_flightType.Items.Add("Отправка");
            comboBox_flightType.Items.Add("Прибытие");
            comboBox_flightType.Items.Add("Транзит");
            comboBox_flightType.SelectedIndex = (int) ThisFlight.FlightType;
            textBox_departureTime.Text = Convert.ToString(ThisFlight.FlightDepartureTime);
            textBox_arrivalTime.Text = Convert.ToString(ThisFlight.FlightArrivalTime);
            textBox_number.Text = ThisFlight.FlightNumber;
            comboBox_departurePoint.Items.Add(ThisFlight.FlightDeparturePoint.AirportName + " : " + ThisFlight.FlightDeparturePoint.AirportAddress);
            comboBox_arrivalPoint.Items.Add(ThisFlight.FlightArrivalPoint.AirportName + " : " + ThisFlight.FlightArrivalPoint.AirportAddress);
            comboBox_departurePoint.Items.Add(ThisAirport.AirportName + " : " + ThisAirport.AirportAddress);
            comboBox_arrivalPoint.Items.Add(ThisAirport.AirportName + " : " + ThisAirport.AirportAddress);
            foreach (Airport Airport in Airports)
            {
                comboBox_departurePoint.Items.Add(Airport.AirportName + " : " + Airport.AirportAddress);
                comboBox_arrivalPoint.Items.Add(Airport.AirportName + " : " + Airport.AirportAddress);
            }
            comboBox_departurePoint.SelectedIndex = 0;
            comboBox_arrivalPoint.SelectedIndex = 0;
            comboBox_plane.Items.Add(ThisFlight.FlightPlane.AircraftModel + " : " + ThisFlight.FlightPlane.AircraftSerialNumber);
            foreach (Aircraft Aircraft in Aircrafts)
            {
                comboBox_plane.Items.Add(Aircraft.AircraftModel + " : " + Aircraft.AircraftSerialNumber);
            }
            comboBox_plane.SelectedIndex = 0;

            // По умолчанию пользователь не ввел данные
            IfNotLeft = false;

            // Устанавливаем данные
            this.ThisFlight = ThisFlight;
            this.ThisAirport = ThisAirport;
            this.Airports = Airports;
            this.Aircrafts = Aircrafts;
        }

        private void button_departureTime_Click(object sender, EventArgs e)
        {
            // Открываем форму выбора даты/времени
            SelectDateTime NewForm = new SelectDateTime(ThisFlight.FlightDepartureTime);
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.SelectDateTimeIfNotLeft)
                ThisFlight.FlightDepartureTime = NewForm.SelectDateTimeThisDateTime;

            textBox_departureTime.Text = Convert.ToString(ThisFlight.FlightDepartureTime);
        }

        private void button_arrivalTime_Click(object sender, EventArgs e)
        {
            // Открываем форму выбора даты/времени
            SelectDateTime NewForm = new SelectDateTime(ThisFlight.FlightArrivalTime);
            NewForm.ShowDialog(this);
            
            // Возвращаем данные
            if (NewForm.SelectDateTimeIfNotLeft)
                ThisFlight.FlightArrivalTime = NewForm.SelectDateTimeThisDateTime;

            textBox_arrivalTime.Text = Convert.ToString(ThisFlight.FlightArrivalTime);
        }

        private void comboBox_flightType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_flightType.SelectedIndex == (int) FlightType.Depart)
            {
                comboBox_departurePoint.SelectedIndex = 1;
                comboBox_departurePoint.Enabled = false;
                comboBox_arrivalPoint.Enabled = true;
            }
            else if (comboBox_flightType.SelectedIndex == (int) FlightType.Arrival)
            {
                comboBox_departurePoint.Enabled = true;
                comboBox_arrivalPoint.SelectedIndex = 1;
                comboBox_arrivalPoint.Enabled = false;
            }
            else if (comboBox_flightType.SelectedIndex == (int) FlightType.Transit)
            {
                comboBox_departurePoint.Enabled = true;
                comboBox_arrivalPoint.Enabled = true;
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Устанавливаем данные для передачи
            IfNotLeft = true;

            Flight NewFlight = new Flight();
            NewFlight.FlightType = (FlightType) comboBox_flightType.SelectedIndex;
            NewFlight.FlightNumber = textBox_number.Text;
            NewFlight.FlightDepartureTime = ThisFlight.FlightDepartureTime;
            NewFlight.FlightArrivalTime = ThisFlight.FlightArrivalTime;
            if (comboBox_departurePoint.SelectedIndex == 0)
            {
                NewFlight.FlightDeparturePoint = ThisFlight.FlightDeparturePoint;
            }
            else if (comboBox_departurePoint.SelectedIndex == 1)
            {
                NewFlight.FlightDeparturePoint = ThisAirport;
            }
            else
            {
                NewFlight.FlightDeparturePoint = Airports[comboBox_departurePoint.SelectedIndex - 2];
            }
            if (comboBox_arrivalPoint.SelectedIndex == 0)
            {
                NewFlight.FlightArrivalPoint = ThisFlight.FlightArrivalPoint;
            }
            else if (comboBox_arrivalPoint.SelectedIndex == 1)
            {
                NewFlight.FlightArrivalPoint = ThisAirport;
            }
            else
            {
                NewFlight.FlightArrivalPoint = Airports[comboBox_departurePoint.SelectedIndex - 2];
            }
            if (comboBox_plane.SelectedIndex == 0)
            {
                NewFlight.FlightPlane = ThisFlight.FlightPlane;
            }
            else
            {
                NewFlight.FlightPlane = Aircrafts[comboBox_plane.SelectedIndex - 1];
            }
            NewFlight.FlightTickets = ThisFlight.FlightTickets;
            ThisFlight = NewFlight;

            this.Close();
        }
    }
}
