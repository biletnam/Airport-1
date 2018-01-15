using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    // Роль формы, добавление или изменение элемента
    public enum FormRole
    {
        Adding,     // Добавление
        Changing    // Изменение
    }

    public partial class MainForm : Form
    {
        private Airport ThisAirport;        // Текущий аэропорт

        private List<Flight> Flights;       // Рейсы
        private List<Airport> Airports;     // Аэропорты
        private List<Aircraft> Aircrafts;   // Самолеты

        // Заоголовки таблиц
        private static List<String> FlightTableHeaders = new List<String> { "Тип",
                                                                            "Номер",
                                                                            "Время отправления",
                                                                            "Время прибытия",
                                                                            "Место отправления",
                                                                            "Место прибытия",
                                                                            "Самолет" };
        private static List<String> AirportTableHeaders = new List<String> {    "Название",
                                                                                "Адрес" };
        private static List<String> AircraftTableHeaders = new List<String> {   "Модель",
                                                                                "Номер",
                                                                                "Мест",
                                                                                "Пилот"};

        public MainForm()
        {
            InitializeComponent();

            // Инициализируем поля
            ThisAirport = new Airport();
            Flights = new List<Flight>();
            Airports = new List<Airport>();
            Aircrafts = new List<Aircraft>();

            // Загружаем данные из файла
            DeserializeAll();
            // Выводим данные на таблицу
            addFlightToolStripMenuItem.Enabled = true;
            editFlightToolStripMenuItem.Enabled = false;
            removeFlightToolStripMenuItem.Enabled = false;
            addAirportToolStripMenuItem.Enabled = false;
            editAirportToolStripMenuItem.Enabled = false;
            removeAirportToolStripMenuItem.Enabled = false;
            addAircraftToolStripMenuItem.Enabled = false;
            editAircraftToolStripMenuItem.Enabled = false;
            removeAircraftToolStripMenuItem.Enabled = false;
            showDataOnDataGridView(FlightTableHeaders, 1);
        }

        // Сериализация данныx в файл
        private void SerializeAll()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream;

            // Сериализуем текущий аэропорт
            stream = new FileStream("thisairport.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, ThisAirport);
            stream.Close();

            // Сериализуем список рейсов
            stream = new FileStream("flights.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Flights);
            stream.Close();

            // Сериализуем список аэропоров
            stream = new FileStream("airports.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Airports);
            stream.Close();

            // Сериализуем список самолетов
            stream = new FileStream("aircrafts.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Aircrafts);
            stream.Close();
        }

        // Десериализация данных из файла
        private void DeserializeAll()
        {
            IFormatter formatter = new BinaryFormatter();

            // Десериализуем текущий аэропорт
            try
            {
                Stream stream = new FileStream("thisairport.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                ThisAirport = (Airport) formatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                return;
            }

            // Десериализуем список рейсов
            try
            {
                Stream stream = new FileStream("flights.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Flights = (List<Flight>) formatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                return;
            }

            // Десериализуем список аэропортов
            try
            {
                Stream stream = new FileStream("airports.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Airports = (List<Airport>) formatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                return;
            }

            // Десериализуем список самолетов
            try
            {
                Stream stream = new FileStream("aircrafts.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Aircrafts = (List<Aircraft>) formatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                return;
            }
        }

        // Очистка таблицы
        private void clearDataGridView()
        {
            dataGridView_main.Rows.Clear();
            dataGridView_main.Columns.Clear();
        }

        // Инициализация таблицы
        private void initializeDataGridView(List<String> ColumnNames)
        {
            foreach (String ColumnName in ColumnNames)
                dataGridView_main.Columns.Add(ColumnName, ColumnName);

            // Отключаем пользовательскую сортировку
            foreach (DataGridViewColumn column in dataGridView_main.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // Вывод данных на таблицу
        private void showDataOnDataGridView(List<String> ColumnNames, Int32 TableIndex)
        {
            clearDataGridView();
            initializeDataGridView(ColumnNames);

            if (TableIndex == 1)
            {
                foreach (Flight Flight in Flights)
                {
                    string[] newRow = new string[] {    (Flight.FlightType == FlightType.Depart) ? "Отправка" : ((Flight.FlightType == FlightType.Arrival) ? "Прибытие" : "Транзит"),
                                                        Flight.FlightNumber,
                                                        Convert.ToString(Flight.FlightDepartureTime),
                                                        Convert.ToString(Flight.FlightArrivalTime),
                                                        Flight.FlightDeparturePoint.AirportName + " : " + Flight.FlightDeparturePoint.AirportAddress,
                                                        Flight.FlightArrivalPoint.AirportName + " : " + Flight.FlightArrivalPoint.AirportAddress,
                                                        Flight.FlightPlane.AircraftModel };
                    dataGridView_main.Rows.Add(newRow);
                }
                if (Flights.Count == 0)
                {
                    editFlightToolStripMenuItem.Enabled = false;
                    removeFlightToolStripMenuItem.Enabled = false;
                }
                else
                {
                    editFlightToolStripMenuItem.Enabled = true;
                    removeFlightToolStripMenuItem.Enabled = true;
                }
            }
            else if (TableIndex == 2)
            {
                foreach (Airport Airport in Airports)
                {
                    string[] newRow = new string[] {    Airport.AirportName,
                                                        Airport.AirportAddress };
                    dataGridView_main.Rows.Add(newRow);
                }
                if (Airports.Count == 0)
                {
                    editAirportToolStripMenuItem.Enabled = false;
                    removeAirportToolStripMenuItem.Enabled = false;
                }
                else
                {
                    editAirportToolStripMenuItem.Enabled = true;
                    removeAirportToolStripMenuItem.Enabled = true;
                }
            }
            else if (TableIndex == 3)
            {
                foreach (Aircraft Aircraft in Aircrafts)
                {
                    string[] newRow = new string[] {    Aircraft.AircraftModel,
                                                        Aircraft.AircraftSerialNumber,
                                                        Convert.ToString(Aircraft.AircraftSeats),
                                                        Aircraft.AircraftСhiefPilot.HumanFullName};
                    dataGridView_main.Rows.Add(newRow);
                }
                if (Aircrafts.Count == 0)
                {
                    editAircraftToolStripMenuItem.Enabled = false;
                    removeAircraftToolStripMenuItem.Enabled = false;
                }
                else
                {
                    editAircraftToolStripMenuItem.Enabled = true;
                    removeAircraftToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void thisAirportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму изменения текущего аэропорта
            EditAirport NewForm = new EditAirport(ThisAirport, FormRole.Changing);
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.EditThisAirportIfNotLeft)
                ThisAirport = NewForm.EditThisAirportThisAirport;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeAll();
        }

        private void addAirportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму добавления аэропорта
            EditAirport NewForm = new EditAirport(new Airport(), FormRole.Adding);
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.EditThisAirportIfNotLeft)
                Airports.Add(NewForm.EditThisAirportThisAirport);

            showDataOnDataGridView(AirportTableHeaders, 2);
        }

        private void editAirportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму изменения выбранного аэропорта
            EditAirport NewForm = new EditAirport(Airports[dataGridView_main.CurrentRow.Index], FormRole.Changing);
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.EditThisAirportIfNotLeft)
                Airports[dataGridView_main.CurrentRow.Index] = NewForm.EditThisAirportThisAirport;

            showDataOnDataGridView(AirportTableHeaders, 2);
        }

        private void removeAirportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Airports.RemoveAt(dataGridView_main.CurrentRow.Index);

            showDataOnDataGridView(AirportTableHeaders, 2);
        }

        private void showFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFlightToolStripMenuItem.Enabled = true;
            editFlightToolStripMenuItem.Enabled = false;
            removeFlightToolStripMenuItem.Enabled = false;
            addAirportToolStripMenuItem.Enabled = false;
            editAirportToolStripMenuItem.Enabled = false;
            removeAirportToolStripMenuItem.Enabled = false;
            addAircraftToolStripMenuItem.Enabled = false;
            editAircraftToolStripMenuItem.Enabled = false;
            removeAircraftToolStripMenuItem.Enabled = false;
            showDataOnDataGridView(FlightTableHeaders, 1);
        }

        private void showAirportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFlightToolStripMenuItem.Enabled = false;
            editFlightToolStripMenuItem.Enabled = false;
            removeFlightToolStripMenuItem.Enabled = false;
            addAirportToolStripMenuItem.Enabled = true;
            editAirportToolStripMenuItem.Enabled = false;
            removeAirportToolStripMenuItem.Enabled = false;
            addAircraftToolStripMenuItem.Enabled = false;
            editAircraftToolStripMenuItem.Enabled = false;
            removeAircraftToolStripMenuItem.Enabled = false;
            showDataOnDataGridView(AirportTableHeaders, 2);
        }

        private void showAircraftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFlightToolStripMenuItem.Enabled = false;
            editFlightToolStripMenuItem.Enabled = false;
            removeFlightToolStripMenuItem.Enabled = false;
            addAirportToolStripMenuItem.Enabled = false;
            editAirportToolStripMenuItem.Enabled = false;
            removeAirportToolStripMenuItem.Enabled = false;
            addAircraftToolStripMenuItem.Enabled = true;
            editAircraftToolStripMenuItem.Enabled = false;
            removeAircraftToolStripMenuItem.Enabled = false;
            showDataOnDataGridView(AircraftTableHeaders, 3);
        }

        private void addAircraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму добавления самолета
            EditAircraft NewForm = new EditAircraft(new Aircraft(), FormRole.Adding);
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.EditThisAircraftIfNotLeft)
                Aircrafts.Add(NewForm.EditThisAircraftThisAircraft);

            showDataOnDataGridView(AircraftTableHeaders, 3);
        }

        private void editAircraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму изменения выбранного самолета
            EditAircraft NewForm = new EditAircraft(Aircrafts[dataGridView_main.CurrentRow.Index], FormRole.Changing);
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.EditThisAircraftIfNotLeft)
                Aircrafts[dataGridView_main.CurrentRow.Index] = NewForm.EditThisAircraftThisAircraft;

            showDataOnDataGridView(AircraftTableHeaders, 3);
        }

        private void removeAircraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aircrafts.RemoveAt(dataGridView_main.CurrentRow.Index);

            showDataOnDataGridView(AircraftTableHeaders, 3);
        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму добавления рейса
            EditFlight NewForm = new EditFlight((Flight) new Flight().Clone(), FormRole.Adding, ThisAirport, Airports, Aircrafts);
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.EditFlightIfNotLeft)
                Flights.Add(NewForm.EditFlightThisFlight);

            showDataOnDataGridView(FlightTableHeaders, 1);
        }

        private void editFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму изменения выбранного рейса
            EditFlight NewForm = new EditFlight((Flight) Flights[dataGridView_main.CurrentRow.Index].Clone(), FormRole.Changing, ThisAirport, Airports, Aircrafts);
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.EditFlightIfNotLeft)
                Flights[dataGridView_main.CurrentRow.Index] = NewForm.EditFlightThisFlight;

            showDataOnDataGridView(FlightTableHeaders, 1);
        }

        private void removeFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flights.RemoveAt(dataGridView_main.CurrentRow.Index);

            showDataOnDataGridView(FlightTableHeaders, 1);
        }

        private void dataGridView_main_SelectionChanged(object sender, EventArgs e)
        {
            if (addFlightToolStripMenuItem.Enabled)
            {
                if (dataGridView_main.CurrentRow.Index == -1)
                {
                    editFlightToolStripMenuItem.Enabled = false;
                    removeFlightToolStripMenuItem.Enabled = false;
                }
                else
                {
                    editFlightToolStripMenuItem.Enabled = true;
                    removeFlightToolStripMenuItem.Enabled = true;
                }
            }
            else if (addAirportToolStripMenuItem.Enabled)
            {
                if (dataGridView_main.CurrentRow.Index == -1)
                {
                    editAirportToolStripMenuItem.Enabled = false;
                    removeAirportToolStripMenuItem.Enabled = false;
                }
                else
                {
                    editAirportToolStripMenuItem.Enabled = true;
                    removeAirportToolStripMenuItem.Enabled = true;
                }
            }
            else if (addAircraftToolStripMenuItem.Enabled)
            {
                if (dataGridView_main.CurrentRow.Index == -1)
                {
                    editAircraftToolStripMenuItem.Enabled = false;
                    removeAircraftToolStripMenuItem.Enabled = false;
                }
                else
                {
                    editAircraftToolStripMenuItem.Enabled = true;
                    removeAircraftToolStripMenuItem.Enabled = true;
                }
            }
        }
    }
}
