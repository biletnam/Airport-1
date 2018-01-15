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
                groupBox_tickets.Enabled = false;
            }
            else if (FR == FormRole.Changing)
            {
                Text = "Изменить самолет";
                button_edit.Text = "Изменить";
                comboBox_plane.Enabled = false;
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
            if (!(comboBox_departurePoint.Items.Count == 0 ||
                comboBox_arrivalPoint.Items.Count == 0))
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
            comboBox_plane.Items.Add(ThisFlight.FlightPlane.AircraftModel + " : " + ThisFlight.FlightPlane.AircraftSerialNumber);
            foreach (Aircraft Aircraft in Aircrafts)
            {
                comboBox_plane.Items.Add(Aircraft.AircraftModel + " : " + Aircraft.AircraftSerialNumber);
            }
            comboBox_plane.SelectedIndex = 0;
            button_removeTicket.Enabled = false;
            comboBox_travelClass.Items.Add("Первый класс");
            comboBox_travelClass.Items.Add("Бизнесс класс");
            comboBox_travelClass.Items.Add("Комфорт класс");
            comboBox_travelClass.Items.Add("Эконом класс");
            comboBox_travelClass.SelectedIndex = 3;

            // По умолчанию пользователь не ввел данные
            IfNotLeft = false;

            // Устанавливаем данные
            this.ThisFlight = ThisFlight;
            this.ThisAirport = ThisAirport;
            this.Airports = Airports;
            this.Aircrafts = Aircrafts;

            // Выводим данные на таблицу
            initializeDataGridView();
            showDataOnDataGridView();

            // Выводим свободные места
            updateComboBoxWithFreeSeats();
        }

        // Инициализация таблицы
        private void initializeDataGridView()
        {
            dataGridView_main.Columns.Add("Место", "Место");
            dataGridView_main.Columns.Add("Цена", "Цена");
            dataGridView_main.Columns.Add("Пассажир", "Пассажир");

            // Отключаем пользовательскую сортировку
            foreach (DataGridViewColumn column in dataGridView_main.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void showDataOnDataGridView()
        {
            dataGridView_main.Rows.Clear();

            foreach (Ticket Ticket in ThisFlight.FlightTickets)
            {
                string[] newRow = new string[] {    Convert.ToString(Ticket.TicketSeat),
                                                    Convert.ToString(Ticket.TicketPrice),
                                                    Ticket.TicketPassenger.HumanFullName };
                dataGridView_main.Rows.Add(newRow);
            }
        }

        private void updateComboBoxWithFreeSeats()
        {
            comboBox_seat.Items.Clear();
            List<Int32> FreeSeats = ThisFlight.GetFreeTickets();
            foreach (Int32 Seat in FreeSeats)
                comboBox_seat.Items.Add(Convert.ToString(Seat));

            if (FreeSeats.Count > 0)
            {
                comboBox_seat.Enabled = true;
                comboBox_seat.SelectedIndex = 0;
            }
            else
            {
                comboBox_seat.Enabled = false;
            }
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
            if (comboBox_departurePoint.Items.Count == 0 ||
                comboBox_arrivalPoint.Items.Count == 0)
                return;
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
            // Проверяем введенные данные
            if (textBox_number.Text.Length == 0)
            {
                MessageBox.Show(this,
                                "В номере рейса пассажира допущена ошибка: номер не может быть пустым",
                                "Номер рейса введен некорректно",
                                MessageBoxButtons.OK);
                textBox_number.Focus();
                return;
            }

            // Проверяем введенные данные
            if (ThisFlight.FlightDepartureTime > ThisFlight.FlightArrivalTime)
            {
                MessageBox.Show(this,
                                "Дата прибытия не может быть раньше даты отправки",
                                "Дата/время отправки/прибытия указаны некорректно",
                                MessageBoxButtons.OK);
                return;
            }

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

        private void button_removeTicket_Click(object sender, EventArgs e)
        {
            ThisFlight.RemoveTicket(ThisFlight.FlightTickets[dataGridView_main.CurrentRow.Index].TicketSeat);

            showDataOnDataGridView();
            updateComboBoxWithFreeSeats();

            if (ThisFlight.FlightTickets.Count == 0)
                button_removeTicket.Enabled = false;
        }

        private void button_sellTicket_Click(object sender, EventArgs e)
        {
            // Проверяем введенные данные
            if (textBox_fullName.Text.Length == 0)
            {
                MessageBox.Show(this,
                                "В полном имени пассажира допущена ошибка: полное не может быть пустым",
                                "Полное имя пассажира введено некорректно",
                                MessageBoxButtons.OK);
                textBox_fullName.Focus();
                return;
            }

            // Проверяем введенные данные
            if (ThisFlight.GetFreeTickets().Count == 0)
            {
                MessageBox.Show(this,
                                "Ошибка, нет свободных мест",
                                "Нет свободных мест",
                                MessageBoxButtons.OK);
                textBox_fullName.Focus();
                return;
            }

            ThisFlight.AddTicket(   Convert.ToInt32(comboBox_seat.Text),
                                    Convert.ToDouble(numericUpDown_price.Value),
                                    new Passenger(textBox_fullName.Text, Convert.ToInt32(numericUpDown_age.Value)),
                                    (TravelClass)comboBox_travelClass.SelectedIndex );

            button_removeTicket.Enabled = true;

            showDataOnDataGridView();
            updateComboBoxWithFreeSeats();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void textBox_fullName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                numericUpDown_age.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void numericUpDown_age_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comboBox_travelClass.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void comboBox_travelClass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comboBox_seat.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void comboBox_seat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                numericUpDown_price.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void numericUpDown_price_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_sellTicket.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void button_sellTicket_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_sellTicket.Focus();
        }

        private void dataGridView_main_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_main.CurrentRow.Index == -1)
            {
                button_removeTicket.Enabled = false;
            }
            else
            {
                button_removeTicket.Enabled = true;
            }
        }
    }
}
