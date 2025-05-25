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
    }
}
