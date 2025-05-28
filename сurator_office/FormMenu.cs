namespace сurator_office
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void ButtonShowStudents_Click(object sender, EventArgs e)
        {
            FormTableStudents formTableStudents = new FormTableStudents();
            formTableStudents.Show();
        }

        private void ButtonShowTeachers_Click(object sender, EventArgs e)
        {
            FormTableTeachers formTableTeachers = new FormTableTeachers();
            formTableTeachers.Show();
        }

        private void ButtonShowRolesInGroup_Click(object sender, EventArgs e)
        {
            FormTableRolesInGroup formTableRolesInGroup = new FormTableRolesInGroup();
            formTableRolesInGroup.Show();
        }

        private void ButtonShowGroups_Click(object sender, EventArgs e)
        {
            FormTableGroups formTableGroups = new FormTableGroups();
            formTableGroups.Show();
        }
    }
}
