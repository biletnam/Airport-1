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
    public partial class EditAircraft : Form
    {
        // Флаг того, покинул ли пользователь форму не введя данные
        private bool IfNotLeft;
        // Новый самолет
        private Aircraft ThisAircraft;

        // Свойства для возврата значений из формы
        public bool EditThisAircraftIfNotLeft
        {
            get
            {
                return IfNotLeft;
            }
        }
        public Aircraft EditThisAircraftThisAircraft
        {
            get
            {
                return ThisAircraft;
            }
        }

        public EditAircraft(Aircraft ThisAircraft, FormRole FR)
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
            textBox_aircraftModel.Text = ThisAircraft.AircraftModel;
            textBox_aircraftSerialNumber.Text = ThisAircraft.AircraftSerialNumber;
            numericUpDown_aircraftSeats.Value = Convert.ToDecimal(ThisAircraft.AircraftSeats);
            textBox_pilotFullName.Text = ThisAircraft.AircraftСhiefPilot.HumanFullName;
            textBox_pilotPhoneNumber.Text = ThisAircraft.AircraftСhiefPilot.CrewPhoneNumber;
            textBox_pilotHomeAddress.Text = ThisAircraft.AircraftСhiefPilot.CrewHomeAddress;
            textBox_pilotLicenseNumber.Text = ThisAircraft.AircraftСhiefPilot.PilotLicenseNumber;

            // По умолчанию пользователь не ввел данные
            IfNotLeft = false;
            this.ThisAircraft = ThisAircraft;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Проверяем введенные данные
            if (textBox_aircraftModel.Text.Length == 0)
            {
                MessageBox.Show(this,
                                "В модели самолета допущена ошибка: модель самолета не может быть пустой",
                                "Модель самолета введена некорректно",
                                MessageBoxButtons.OK);
                textBox_aircraftModel.Focus();
                return;
            }

            // Проверяем введенные данные
            if (textBox_aircraftSerialNumber.Text.Length == 0)
            {
                MessageBox.Show(this,
                                "В серийном номере самолета допущена ошибка: серийный номер не может быть пустым",
                                "Серийный номер самолета введен некорректно",
                                MessageBoxButtons.OK);
                textBox_aircraftSerialNumber.Focus();
                return;
            }

            // Проверяем введенные данные
            if (textBox_pilotFullName.Text.Length == 0)
            {
                MessageBox.Show(this,
                                "В полном имени пилота допущена ошибка: полное имя не может быть пустым",
                                "Полное имя пилота введено некорректно",
                                MessageBoxButtons.OK);
                textBox_pilotFullName.Focus();
                return;
            }

            // Проверяем введенные данные
            if (textBox_pilotPhoneNumber.Text.Length == 0)
            {
                MessageBox.Show(this,
                                "В телефонном номере пилота допущена ошибка: телефонный номер не может быть пустым",
                                "Телефонный номер пилота введен некорректно",
                                MessageBoxButtons.OK);
                textBox_pilotPhoneNumber.Focus();
                return;
            }

            // Проверяем введенные данные
            if (textBox_pilotHomeAddress.Text.Length == 0)
            {
                MessageBox.Show(this,
                                "В домашнем адресе пилота допущена ошибка: домашний адрес не может быть пустым",
                                "Домашний адрес пилота введен некорректно",
                                MessageBoxButtons.OK);
                textBox_pilotHomeAddress.Focus();
                return;
            }

            // Проверяем введенные данные
            if (textBox_pilotLicenseNumber.Text.Length == 0)
            {
                MessageBox.Show(this,
                                "В номере лицензии пилота допущена ошибка: номер лицензии не может быть пустым",
                                "Номер лицензии пилота введен некорректно",
                                MessageBoxButtons.OK);
                textBox_pilotLicenseNumber.Focus();
                return;
            }

            // Устанавливаем данные для передачи
            IfNotLeft = true;
            ThisAircraft = new Aircraft( new Pilot( textBox_pilotFullName.Text,
                                                    textBox_pilotPhoneNumber.Text,
                                                    textBox_pilotHomeAddress.Text,
                                                    textBox_pilotLicenseNumber.Text ),
                                         textBox_aircraftModel.Text,
                                         textBox_aircraftSerialNumber.Text,
                                         Convert.ToInt32(numericUpDown_aircraftSeats.Value) );

            this.Close();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void textBox_aircraftModel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_aircraftSerialNumber.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void textBox_aircraftSerialNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                numericUpDown_aircraftSeats.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void numericUpDown_aircraftSeats_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_pilotFullName.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void textBox_pilotFullName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_pilotPhoneNumber.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void textBox_pilotPhoneNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_pilotHomeAddress.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void textBox_pilotHomeAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_pilotLicenseNumber.Focus();
        }

        // Автопереход на следующий элемент формы на нажатию enter
        private void textBox_pilotLicenseNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_edit.Focus();
        }
    }
}
