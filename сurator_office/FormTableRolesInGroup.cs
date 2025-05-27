using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using сurator_office.Models;
using AppContext = сurator_office.Models.AppContext;

namespace сurator_office
{
    public partial class FormTableRolesInGroup : Form
    {
        private AppContext db;
        public FormTableRolesInGroup()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.RolesInGroups.Load();
            this.dataGridViewRolesInGroup.DataSource = this.db.RolesInGroups.Local.OrderBy(o => o.Role).ToList();

            //скрытие столбцов
            dataGridViewRolesInGroup.Columns["Id"].Visible = false;
            dataGridViewRolesInGroup.Columns["Students"].Visible = false;

            //Изменение название заголовков столбцов
            dataGridViewRolesInGroup.Columns["Role"].HeaderText = "Роль";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddRolesInGroup formAddRolesInGroup = new();
            DialogResult result = formAddRolesInGroup.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            RolesInGroup rolesInGroup = new RolesInGroup();
            rolesInGroup.Role = formAddRolesInGroup.textBoxRole.Text;

            db.RolesInGroups.Add(rolesInGroup);
            db.SaveChanges();

            MessageBox.Show("Новая роль добавлена");
            this.dataGridViewRolesInGroup.DataSource = this.db.RolesInGroups.Local.OrderBy(o => o.Role).ToList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewRolesInGroup.SelectedRows.Count == 0)
            {
                return;
            }
            int index = dataGridViewRolesInGroup.SelectedRows[0].Index;

            short id = 0;

            bool converted = short.TryParse(dataGridViewRolesInGroup[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }

            RolesInGroup rolesInGroup = db.RolesInGroups.Find(id);
            FormAddRolesInGroup formAddRolesInGroups = new();

            formAddRolesInGroups.textBoxRole.Text = rolesInGroup.Role;



            DialogResult result = formAddRolesInGroups.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            rolesInGroup.Role = formAddRolesInGroups.textBoxRole.Text;


            db.RolesInGroups.Update(rolesInGroup);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewRolesInGroup.DataSource = this.db.RolesInGroups.Local.OrderBy(o => o.Role).ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRolesInGroup.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
            {
                return;
            }

            int index = dataGridViewRolesInGroup.SelectedRows[0].Index;

            short id = 0;

            bool converted = short.TryParse(dataGridViewRolesInGroup[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }

            RolesInGroup rolesInGroup = db.RolesInGroups.Find(id);

            db.RolesInGroups.Remove(rolesInGroup);
            db.SaveChanges();

            MessageBox.Show("Роль удалена");

            this.dataGridViewRolesInGroup.DataSource = this.db.RolesInGroups.Local.OrderBy(o => o.Role).ToList();
        }
    }
}
