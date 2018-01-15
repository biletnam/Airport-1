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
    public partial class SelectDateTime : Form
    {
        // Флаг того, покинул ли пользователь форму не введя данные
        private bool IfNotLeft;
        // Выбранное время
        private DateTime ThisDateTime;

        // Свойства для возврата значений из формы
        public bool SelectDateTimeIfNotLeft
        {
            get
            {
                return IfNotLeft;
            }
        }
        public DateTime SelectDateTimeThisDateTime
        {
            get
            {
                return ThisDateTime;
            }
        }

        public SelectDateTime(DateTime CurrentTime)
        {
            InitializeComponent();

            // По умолчанию пользователь не ввел данные
            IfNotLeft = false;
            ThisDateTime = CurrentTime;

            // Заполняем форму
            dateTimePicker_date.Value = ThisDateTime;
            dateTimePicker_time.Value = ThisDateTime;
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            // Устанавливаем данные для передачи
            IfNotLeft = true;
            ThisDateTime = dateTimePicker_date.Value.Date + dateTimePicker_time.Value.TimeOfDay;

            this.Close();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void dateTimePicker_date_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dateTimePicker_time.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void dateTimePicker_time_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_select.Focus();
        }
    }
}
