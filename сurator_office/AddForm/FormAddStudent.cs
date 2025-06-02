using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сurator_office
{
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void TextBoxSurname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSurname.Text))
            {
                errorProvider.SetError(textBoxSurname, "Введите фамилию");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void TextBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, "Введите Имя");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void DateTimePickerBirthday_Validating(object sender, CancelEventArgs e)
        {
            // Получаем текущий год
            int currentYear = DateTime.Now.Year;
            // Вычисляем минимальный год рождения (текущий год минус 15)
            int minBirthYear = currentYear - 15;
            // Создаем дату 1 января этого года
            DateTime minBirthDate = new DateTime(minBirthYear, 1, 1);

            if (dateTimePickerBirthday.Value > minBirthDate)
            {
                // дата рождения равна или больше минимальной даты
                errorProvider.SetError(dateTimePickerBirthday, "Дата рождения должна быть раньше " + minBirthDate.ToShortDateString());
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void TextBoxActualAddress_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxActualAddress.Text))
            {
                errorProvider.SetError(textBoxActualAddress, "Введите фактический адресс проживания");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void NumericUpDownSubgroup_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDownSubgroup.Value == 0)
            {
                errorProvider.SetError(numericUpDownSubgroup, "Введите подгруппу");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void NumericUpDownGroup_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDownGroup.Value == 0)
            {
                errorProvider.SetError(numericUpDownGroup, "Введите группу");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void NumericUpDownRoleInGroup_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDownRoleInGroup.Value == 0)
            {
                errorProvider.SetError(numericUpDownRoleInGroup, "Введите роль в группе");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void TextBoxPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPhoneNumber.Text))
            {
                errorProvider.SetError(textBoxPhoneNumber, "Введите номер телефона");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}
