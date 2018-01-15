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
            foreach (Airport Airport in Airports)
            {
                comboBox_departurePoint.Items.Add(Airport.AirportName + " : " + Airport.AirportAddress);
                comboBox_arrivalPoint.Items.Add(Airport.AirportName + " : " + Airport.AirportAddress);
            }
            comboBox_departurePoint.SelectedIndex = 0;
            comboBox_arrivalPoint.SelectedIndex = 0;
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
            SelectDateTime NewForm = new SelectDateTime();
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.SelectDateTimeIfNotLeft)
                ThisFlight.FlightDepartureTime = NewForm.SelectDateTimeThisDateTime;

            textBox_departureTime.Text = Convert.ToString(ThisFlight.FlightDepartureTime);
        }

        private void button_arrivalTime_Click(object sender, EventArgs e)
        {
            // Открываем форму выбора даты/времени
            SelectDateTime NewForm = new SelectDateTime();
            NewForm.ShowDialog(this);
            
            // Возвращаем данные
            if (NewForm.SelectDateTimeIfNotLeft)
                ThisFlight.FlightArrivalTime = NewForm.SelectDateTimeThisDateTime;

            textBox_arrivalTime.Text = Convert.ToString(ThisFlight.FlightArrivalTime);
        }
    }
}
