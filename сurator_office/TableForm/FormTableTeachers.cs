using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using сurator_office.Models;
using AppContext = сurator_office.Models.AppContext;

namespace сurator_office
{
    public partial class FormTableTeachers : Form
    {
        private AppContext db;
        public FormTableTeachers()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Teachers.Load();
            this.dataGridViewTeachers.DataSource = this.db.Teachers.Local.OrderBy(o => o.Surname).ToList();

            //скрытие столбцов
            dataGridViewTeachers.Columns["Id"].Visible = false;
            dataGridViewTeachers.Columns["DisciplinesTeachers"].Visible = false;


            //Изменение название заголовков столбцов
            dataGridViewTeachers.Columns["Surname"].HeaderText = "Фалимия";
            dataGridViewTeachers.Columns["Name"].HeaderText = "Имя";
            dataGridViewTeachers.Columns["Patronymic"].HeaderText = "Отчество";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddTeacher formAddTeacher = new();
            DialogResult result = formAddTeacher.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            Teacher teacher = new Teacher();
            teacher.Surname = formAddTeacher.textBoxSurname.Text;
            teacher.Name = formAddTeacher.textBoxName.Text;
            teacher.Patronymic = formAddTeacher.textBoxPatronymic.Text;

            db.Teachers.Add(teacher);
            db.SaveChanges();

            MessageBox.Show("Новый учитель добавлен");

            this.dataGridViewTeachers.DataSource = this.db.Teachers.Local.OrderBy(o => o.Surname).ToList();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeachers.SelectedRows.Count == 0)
            {
                return;
            }
            int index = dataGridViewTeachers.SelectedRows[0].Index;

            int id = 0;

            bool converted = Int32.TryParse(dataGridViewTeachers[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }

            Teacher teacher = db.Teachers.Find(id);
            FormAddTeacher formAddTeacher = new();

            formAddTeacher.textBoxSurname.Text = teacher.Surname;
            formAddTeacher.textBoxName.Text = teacher.Name;
            formAddTeacher.textBoxPatronymic.Text = teacher.Patronymic;


            DialogResult result = formAddTeacher.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            teacher.Surname = formAddTeacher.textBoxSurname.Text;
            teacher.Name = formAddTeacher.textBoxName.Text;
            teacher.Patronymic = formAddTeacher.textBoxPatronymic.Text;

            db.Teachers.Update(teacher);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewTeachers.DataSource = this.db.Teachers.Local.OrderBy(o => o.Surname).ToList();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewTeachers.SelectedRows.Count == 0)
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

            int index = dataGridViewTeachers.SelectedRows[0].Index;

            int id = 0;

            bool converted = Int32.TryParse(dataGridViewTeachers[0, index].Value.ToString(), out id);
            if (!converted)
            {
                return;
            }

            Teacher teacher = db.Teachers.Find(id);

            db.Teachers.Remove(teacher);
            db.SaveChanges();

            MessageBox.Show("Объект удален");

            this.dataGridViewTeachers.DataSource = this.db.Teachers.Local.OrderBy(o => o.Surname).ToList();
        }
    }
}
