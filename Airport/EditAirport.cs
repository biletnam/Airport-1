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
    public partial class EditAirport : Form
    {
        // Флаг того, покинул ли пользователь форму не введя данные
        private bool IfNotLeft;
        // Новый аэропорт
        private Airport ThisAirport;

        // Свойства для возврата значений из формы
        public bool EditThisAirportIfNotLeft
        {
            get
            {
                return IfNotLeft;
            }
        }
        public Airport EditThisAirportThisAirport
        {
            get
            {
                return ThisAirport;
            }
        }

        public EditAirport(Airport ThisAirport, FormRole FR)
        {
            InitializeComponent();

            // Устанавливаем название формы и подпись кнопки в зависимости от роли формы
            if (FR == FormRole.Adding)
            {
                Text = "Добавить аэропорт";
                button_edit.Text = "Добавить";
            }
            else if (FR == FormRole.Changing)
            {
                Text = "Изменить аэропорт";
                button_edit.Text = "Изменить";
            }

            // Заполняем форму
            textBox_name.Text = ThisAirport.AirportName;
            textBox_address.Text = ThisAirport.AirportAddress;

            // По умолчанию пользователь не ввел данные
            IfNotLeft = false;
            this.ThisAirport = ThisAirport;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Проверяем введенные данные
            if (textBox_name.Text.Length == 0)
            {
                MessageBox.Show(this,
                                "В названии аэропорта допущена ошибка: название не может быть пустым",
                                "Название аэропорта введено некорректно",
                                MessageBoxButtons.OK);
                textBox_name.Focus();
                return;
            }

            // Проверяем введенные данные
            if (textBox_address.Text.Length == 0)
            {
                MessageBox.Show(this,
                                "В адресе аэропорта допущена ошибка: адрес не может быть пустым",
                                "Адрес аэропорта введен некорректно",
                                MessageBoxButtons.OK);
                textBox_address.Focus();
                return;
            }

            // Устанавливаем данные для передачи
            IfNotLeft = true;
            ThisAirport = new Airport(textBox_name.Text, textBox_address.Text);

            this.Close();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void textBox_name_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_address.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void textBox_address_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_edit.Focus();
        }
    }
}
