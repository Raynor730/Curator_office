using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using сurator_office.Models;
using AppContext = сurator_office.Models.AppContext;

namespace сurator_office
{
    public partial class FormTableGroups : Form
    {
        private AppContext db;
        public FormTableGroups()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Groups.Load();
            this.dataGridViewGroups.DataSource = this.db.Groups.Local.OrderBy(o => o.Name).ToList();

            //скрытие столбцов
            dataGridViewGroups.Columns["Id"].Visible = false;
            dataGridViewGroups.Columns["Students"].Visible = false;

            //Изменение название заголовков столбцов
            dataGridViewGroups.Columns["Name"].HeaderText = "Сокращенное название";
            dataGridViewGroups.Columns["SpecializationKode"].HeaderText = "Код специальности";
            dataGridViewGroups.Columns["SpecializationName"].HeaderText = "Полное название специальности";
            dataGridViewGroups.Columns["YearOfAdmission"].HeaderText = "Год поступления";
            dataGridViewGroups.Columns["YearOfGraduation"].HeaderText = "Год выпуска";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddGroup formAddGroup = new();
            DialogResult result = formAddGroup.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            Group group = new();
            group.Name = formAddGroup.textBoxName.Text;
            group.SpecializationKode = formAddGroup.textBoxSpecializationKode.Text;
            group.SpecializationName = formAddGroup.textBoxSpecializationName.Text;
            group.YearOfAdmission = (short)formAddGroup.numericUpDownYearOfAdmission.Value;
            group.YearOfGraduation = (short)formAddGroup.numericUpDownYearOfGraduation.Value;

            db.Groups.Add(group);
            db.SaveChanges();

            MessageBox.Show("Новая группа добавлена");

            this.dataGridViewGroups.DataSource = this.db.Groups.Local.OrderBy(o => o.Name).ToList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 0)
            {
                return;
            }
            int index = dataGridViewGroups.SelectedRows[0].Index;

            int id = 0;

            bool converted = Int32.TryParse(dataGridViewGroups[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }

            Group group = db.Groups.Find(id);
            FormAddGroup formAddGroup = new FormAddGroup();

            formAddGroup.textBoxName.Text = group.Name;
            formAddGroup.textBoxSpecializationKode.Text = group.SpecializationKode;
            formAddGroup.textBoxSpecializationName.Text = group.SpecializationName;
            formAddGroup.numericUpDownYearOfAdmission.Value = group.YearOfAdmission;
            formAddGroup.numericUpDownYearOfGraduation.Value = group.YearOfGraduation;

            DialogResult result = formAddGroup.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            group.Name = formAddGroup.textBoxName.Text;
            group.SpecializationKode = formAddGroup.textBoxSpecializationKode.Text;
            group.SpecializationName = formAddGroup.textBoxSpecializationName.Text;
            group.YearOfAdmission = (short)formAddGroup.numericUpDownYearOfAdmission.Value;
            group.YearOfGraduation = (short)formAddGroup.numericUpDownYearOfGraduation.Value;

            db.Groups.Update(group);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewGroups.DataSource = this.db.Groups.Local.OrderBy(o => o.Name).ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 0)
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

            int index = dataGridViewGroups.SelectedRows[0].Index;

            int id = 0;

            bool converted = Int32.TryParse(dataGridViewGroups[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }

            Group group = db.Groups.Find(id);

            db.Groups.Remove(group);
            db.SaveChanges();

            MessageBox.Show("Объект удален");

            this.dataGridViewGroups.DataSource = this.db.Groups.Local.OrderBy(o => o.Name).ToList();
        }
    }
}
