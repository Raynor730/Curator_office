using System.ComponentModel;

namespace сurator_office
{
    public partial class FormAddRolesInGroup : Form
    {
        public FormAddRolesInGroup()
        {
            InitializeComponent();
        }

        private void textBoxRole_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRole.Text))
            {
                errorProvider.SetError(textBoxRole, "Введите Роль");
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
