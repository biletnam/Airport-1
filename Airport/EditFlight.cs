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
        // Время отправления/прибытия рейса
        private DateTime DepartureTime;
        private DateTime ArrivalTime;

        public EditFlight()
        {
            InitializeComponent();

            DepartureTime = ArrivalTime = DateTime.Now;
            textBox_departureTime.Text = Convert.ToString(DepartureTime);
            textBox_arrivalTime.Text = Convert.ToString(ArrivalTime);
        }

        private void button_departureTime_Click(object sender, EventArgs e)
        {
            // Открываем форму выбора даты/времени
            SelectDateTime NewForm = new SelectDateTime();
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.SelectDateTimeIfNotLeft)
                DepartureTime = NewForm.SelectDateTimeThisDateTime;

            textBox_departureTime.Text = Convert.ToString(DepartureTime);
        }

        private void button_arrivalTime_Click(object sender, EventArgs e)
        {
            // Открываем форму выбора даты/времени
            SelectDateTime NewForm = new SelectDateTime();
            NewForm.ShowDialog(this);

            // Возвращаем данные
            if (NewForm.SelectDateTimeIfNotLeft)
                ArrivalTime = NewForm.SelectDateTimeThisDateTime;

            textBox_arrivalTime.Text = Convert.ToString(ArrivalTime);
        }
    }
}
