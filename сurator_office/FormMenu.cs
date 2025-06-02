using сurator_office.TableForm;

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

        private void ButtonShowDisciplines_Click(object sender, EventArgs e)
        {
            FormTableDisciplines formTableDisciplines = new FormTableDisciplines();
            formTableDisciplines.Show();
        }

        private void ButtonShowDisciplinesTeachers_Click(object sender, EventArgs e)
        {
            FormTableDisciplinesTeachers formTableDisciplinesTeachers = new FormTableDisciplinesTeachers();
            formTableDisciplinesTeachers.Show();
        }

        private void ButtonShowTypesIntermediateAttestation_Click(object sender, EventArgs e)
        {
            FormTableTypesIntermediateAttestation formTableTypesIntermediateAttestation = new FormTableTypesIntermediateAttestation();
            formTableTypesIntermediateAttestation.Show();
        }

        private void buttonShowCurrentStatements_Click(object sender, EventArgs e)
        {
            FormTableInterimStatements formTableInterimStatements = new FormTableInterimStatements();
            formTableInterimStatements.Show();
        }

        private void ButtonShowInterimStatements_Click(object sender, EventArgs e)
        {
            FormTableInterimStatements formTableInterimStatements = new FormTableInterimStatements();
            formTableInterimStatements.Show();
        }

        private void buttonShowCurrentStatementsStudents_Click(object sender, EventArgs e)
        {
            FormTableCurrentStatementsStudents formTableCurrentStatementsStudents = new FormTableCurrentStatementsStudents();
            formTableCurrentStatementsStudents.Show();
        }

        private void buttonShowIntermediateAttestationStudetns_Click(object sender, EventArgs e)
        {
            FormTableIntermediateAttestationStudents formTableIntermediateAttestationStudents = new FormTableIntermediateAttestationStudents();
            formTableIntermediateAttestationStudents.Show();
        }
    }
}
