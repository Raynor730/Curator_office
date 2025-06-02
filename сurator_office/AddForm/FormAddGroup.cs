using System.ComponentModel;

namespace сurator_office
{
    public partial class FormAddGroup : Form
    {
        public FormAddGroup()
        {
            InitializeComponent();
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, "Введите сокращенное название специальности. пример: ИС-22");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxSpecializationKode_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSpecializationKode.Text))
            {
                errorProvider.SetError(textBoxSpecializationKode, "Введите код специализации");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxSpecializationName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSpecializationName.Text))
            {
                errorProvider.SetError(textBoxSpecializationName, "Введите полное название специальности");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void numericUpDownYearOfAdmission_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDownYearOfAdmission.Value == 0)
            {
                errorProvider.SetError(numericUpDownYearOfAdmission, "Введите год поступления");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void numericUpDownYearOfGraduation_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDownYearOfGraduation.Value == 0)
            {
                errorProvider.SetError(numericUpDownYearOfGraduation, "Введите год выпуска");
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
