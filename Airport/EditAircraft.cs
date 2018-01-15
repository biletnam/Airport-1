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
            textBox_name.Text = ThisAirport.AirportName;
            textBox_address.Text = ThisAirport.AirportAddress;

            // По умолчанию пользователь не ввел данные
            IfNotLeft = false;
            this.ThisAirport = ThisAirport;
        }
    }
}
