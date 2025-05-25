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
    public partial class FormAddTeacher : Form
    {
        public FormAddTeacher()
        {
            InitializeComponent();
        }

        private void textBoxSurname_Validating(object sender, CancelEventArgs e)
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

        private void textBoxName_Validating(object sender, CancelEventArgs e)
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
    }
}
